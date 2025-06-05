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
    public partial class FormUnConstrainedDistributionSolution : Form
    {
        private const string Emoji = "🟣";
        private Queue<TextBox> textBoxQueue = new Queue<TextBox>(); // Queue to control sequential animation
        private Timer animationTimer;
        private int currentEmojiCount = 0;
        private TextBox currentTextBox;

        //Instance Variables
        private FormParent _frmParent;
        private Combination _combination;
        private int _distributionCount = 0;

        //Constructor
        public FormUnConstrainedDistributionSolution(FormParent FrmParent)
        {
            InitializeComponent();
            _frmParent = FrmParent;
        }

        // Properties

        // Methods
        private void AddObjectControls(int Count)
        {
            int PictureboxWidth = 80;
            int PictureboxHeight = 100;
            for (int i = 1; i <= Count; i++)
            {
                int Spacing = (i - 1) * 90;
                int StartXPosition = 10;
                int StartYPosition = 100;

                PictureBox pictureBox = new PictureBox
                {
                    Name = "pictureBox" + i,
                    Size = new System.Drawing.Size(PictureboxWidth, PictureboxHeight),
                    //Location = new System.Drawing.Point(50 + ((i - 1) * 120), 50),
                    Location = new System.Drawing.Point(StartXPosition + Spacing, StartYPosition),
                    BorderStyle = BorderStyle.FixedSingle,
                    Image = Properties.Resources.Bille,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                this.Controls.Add(pictureBox);
            }

        }

        private void ReplaceSelectedObjectControls(int[] Array)
        {
            int TextboxWidth = 30;
            int TextboxHeight = 150;

            foreach (int value in Array)
            {
                Control pictureBox = this.Controls["pictureBox" + value];
                if (pictureBox != null)
                {
                    //this.Controls.Remove(pictureBox);
                    pictureBox.Visible = false;

                    TextBox textBox = new TextBox
                    {
                        Size = new System.Drawing.Size(TextboxWidth, TextboxHeight),
                        Multiline = true,
                        //Location = pictureBox.Location,
                        Location = new Point(pictureBox.Location.X + 30, pictureBox.Location.Y),
                        BackColor = Color.Red,

                    };
                    this.Controls.Add(textBox);
                }
            }
        }

        private void ResetObjectControls() 
        {
            foreach (Control control in this.Controls) 
            {
                if (control is PictureBox pictureBox) 
                {
                   control.Visible = true;
                }
            }

            foreach (Control control in this.Controls) 
            {
                if (control is TextBox textBox) 
                {
                    textBox.Visible = false;
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

            CombinationSet.Add((_frmParent.FrmIntro.ObjectCount + _frmParent.FrmIntro.DrawerCount - 1) + 1 );

            for (int i = 0; i < CombinationSet.Count; i++)
            {
                if (i == 0)
                {
                    Distribution.Add(CombinationSet[i] - 1);
                }
                else
                {
                    Distribution.Add(CombinationSet[i] - CombinationSet[i - 1] - 1);
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

        private void FormUnConstrainedDistributionSolution_Load(object sender, EventArgs e)
        {
            AddObjectControls(_frmParent.FrmIntro.ObjectCount + _frmParent.FrmIntro.DrawerCount - 1);
            _combination = new Combination(_frmParent.FrmIntro.ObjectCount + _frmParent.FrmIntro.DrawerCount - 1, _frmParent.FrmIntro.DrawerCount - 1);
            LblSolution.Text = DisplaySolution();
        }

        private void BtnVisualisation_Click(object sender, EventArgs e)
        {
            BtnVisualisation.Enabled = false;
            ResetObjectControls();

            var randomCombination = _combination.GetCombination();

            if (randomCombination != null)
            {
                ReplaceSelectedObjectControls(randomCombination);
                _distributionCount++;
                LblDistributionCount.Text = _distributionCount.ToString();
                List<int> Distribution = GetDistribution(randomCombination.ToList());
                DisplayDistribution(Distribution, LblDistributionDetails);
                //

                flowLayoutPanel1.Controls.Clear();
                CreateDrawers(Distribution, flowLayoutPanel1);
            }
            else
            {
                MessageBox.Show("No more possible distribution");
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
    }
}
