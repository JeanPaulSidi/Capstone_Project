using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Milestone1.Forms
{
    public partial class FormConstrainedDistributionSolution : Form
    {
        private const string Emoji = "🟣";
        private Queue<TextBox> textBoxQueue = new Queue<TextBox>(); // Queue to control sequential animation
        private Timer animationTimer;
        private int currentEmojiCount = 0;
        private TextBox currentTextBox;

        //Instance Variables
        private FormParent _frmParent;
        private Panel _fpnl;
        private Combination _combination;
        private int _distributionCount = 0;

        //Constructor
        public FormConstrainedDistributionSolution(FormParent FrmParent)
        {
            InitializeComponent();
            _frmParent = FrmParent;
            //_fpnl = Fpnl2;
        }

        //Properties
        public Panel Fpnl 
        {
            get { return _fpnl; }
        }

        //Methods
        private void AddObjectControls(int ObjectCount, FlowLayoutPanel Fpnl)
        {
            int startX = 10; // Initial X position
            int pictureBoxWidth = 50, pictureBoxHeight = 80;
            int textBoxWidth = 10, textBoxHeight = 120;
            int spacing = 3;

            for (int i = 0; i < ObjectCount; i++)
            {
                // Create PictureBox
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(pictureBoxWidth, pictureBoxHeight),
                    Location = new Point(startX, 60),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightGray,
                    Image = Properties.Resources.Bille,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                Fpnl.Controls.Add(pictureBox);
                startX += pictureBoxWidth + spacing;


                if (i < ObjectCount - 1) // Add TextBoxes between PictureBoxes
                {
                    TextBox textBox = new TextBox
                    {
                        Name = "textbox" + (i+1),
                        Size = new Size(textBoxWidth, textBoxHeight), // Adjusted width & height
                        Location = new Point(startX, 50),
                        Multiline = true, // Allows taller textbox to display properly
                        BackColor = Color.Black
                    };

                    //TextBoxes.Add(textBox);
                    Fpnl.Controls.Add(textBox);
                    startX += textBoxWidth + spacing;
                }
            }

        }

        private void HideTextboxes(FlowLayoutPanel Fpnl)
        {
            foreach (TextBox textBox in Fpnl.Controls.OfType<TextBox>())
            {
                textBox.Visible = false;
            }
        }

        private void ShowSelectedTextboxes(int[] Array, FlowLayoutPanel Fpnl)
        {
            foreach (int value in Array)
            {
                Control textbox = Fpnl.Controls["textbox" + value];

                if (textbox != null)
                {
                    textbox.BackColor = Color.Red;
                    textbox.Visible = true;
                }
            }
        }

        private string DisplaySolution() 
        {
            int CombinationCount = _combination.CombinationCount;
            int ObjectCount = _frmParent.FrmIntro.ObjectCount;
            int DrawerCount = _frmParent.FrmIntro.DrawerCount;

            if (CombinationCount == 1) 
            {
                return ($"There is {CombinationCount} way to distribute {ObjectCount} objects into {DrawerCount} drawers.");
            }
            return ($"There are {CombinationCount} ways to distribute {ObjectCount} objects into {DrawerCount} drawers.");
        }

        private List<int> GetDistribution(List<int> CombinationSet)
        {
            List<int> Distribution = new List<int>();

            CombinationSet.Add(_frmParent.FrmIntro.ObjectCount);

            for (int i = 0; i < CombinationSet.Count; i++)
            {
                if (i == 0)
                {
                    Distribution.Add(CombinationSet[i]);
                }
                else
                {
                    Distribution.Add(CombinationSet[i] - CombinationSet[i - 1]);
                }
            }
            return Distribution;
        }

        private void DisplayDistribution(List<int> Distribution, Label Lbl)
        {
            Lbl.Text = string.Empty;

            for (int i = 0; i < Distribution.Count; i++)
            {
                if ((i != 0) && (i % 5 == 0)) 
                { 
                    Lbl.Text += "\n\n"; 
                }
                Lbl.Text += ($"Drawer{i + 1}: {Distribution[i]} object(s)    ");
                
            }
        }

        private void CreateDrawers(List<int> distribution, FlowLayoutPanel panel)
        {
            panel.Controls.Clear(); // Clear previous controls

            for (int i = 0; i < distribution.Count; i++)
            {
                // Create Label
                Label drawerLabel = new Label
                {
                    Text = $"Drawer {i + 1}",
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Create TextBox
                TextBox drawerTextbox = new TextBox
                {
                    Name = $"drawer{i + 1}",
                    Size = new Size(100, 60),
                    TextAlign = HorizontalAlignment.Center,
                    BackColor = Color.LightBlue,
                    ReadOnly = true,
                    Font = new Font("Segoe UI Emoji", 10),
                    Multiline = true,
                    Tag = distribution[i] // Store emoji count in Tag
                };

                // Wrap in a FlowLayoutPanel for vertical stacking
                FlowLayoutPanel wrapperPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    AutoSize = true,
                    Margin = new Padding(10)
                };

                wrapperPanel.Controls.Add(drawerLabel);
                wrapperPanel.Controls.Add(drawerTextbox);
                panel.Controls.Add(wrapperPanel);

                // Add to queue for sequential animation
                textBoxQueue.Enqueue(drawerTextbox);
            }

            // Start sequential animation
            AnimateNextTextBox();
        }

        private void AnimateNextTextBox()
        {
            if (textBoxQueue.Count > 0)
            {
                currentTextBox = textBoxQueue.Dequeue();
                currentEmojiCount = 0;

                animationTimer = new Timer
                {
                    Interval = 300 // Adjust speed (milliseconds)
                };

                animationTimer.Tick += AnimationTick;
                animationTimer.Start();
            }
            else
            {
                BtnVisualisation.Enabled = true;
            }
        }

        private void AnimationTick(object sender, EventArgs e)
        {
            if (currentTextBox != null)
            {
                int emojiLimit = Convert.ToInt32(currentTextBox.Tag);

                if (currentEmojiCount < emojiLimit)
                {
                    currentTextBox.AppendText($"{Emoji} "); // Append emoji dynamically
                    currentEmojiCount++;
                }
                else
                {
                    animationTimer.Stop();
                    animationTimer.Dispose();

                    // Start animation for the next TextBox
                    AnimateNextTextBox();
                }
            }
        }

        private void FormConstrainedDistributionSolution_Load(object sender, EventArgs e)
        {
            AddObjectControls(_frmParent.FrmIntro.ObjectCount, Fpnl1);
            //AddObjectControls(_frmParent.FrmIntro.ObjectCount, Fpnl2);
            //HideTextboxes(Fpnl2);
            _combination = new Combination(_frmParent.FrmIntro.ObjectCount - 1, _frmParent.FrmIntro.DrawerCount - 1);
            LblSolution.Text = DisplaySolution();

        }

        private void BtnVisualisation_Click(object sender, EventArgs e)
        {
           BtnVisualisation.Enabled = false;

            var randomCombination = _combination.GetCombination();

            if (randomCombination != null) 
            {
                HideTextboxes(Fpnl1);
                ShowSelectedTextboxes(randomCombination, Fpnl1);
                _distributionCount++;
                LblDistributionCounter.Text = _distributionCount.ToString();
                List<int> Distribution = GetDistribution(randomCombination.ToList());
                DisplayDistribution(Distribution, LblDristributionDetails);

                //
                Fpnl2.Controls.Clear();
                CreateDrawers(Distribution, Fpnl2);
            }
            else 
            {
                MessageBox.Show("No more possible distribution");
            } 
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmUnConsDistAnalysis);
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmConsDistAnalysis);
        }
    }
}
