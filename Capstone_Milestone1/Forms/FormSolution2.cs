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
    public partial class FormSolution2 : Form
    {
        // Instance Variables
        private FormParent _frmParent;

        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private List<int> distribution = new List<int>();
        private PTupleGenerator _pTuple;
        private Timer distributionTimer;
        private List<Image> _images = new List<Image>();

        private int _objectCount;
        private int _drawerCount;

        //private const int PictureBoxCount = 9;
        private const int PictureBoxStartY = 50;
        private const int DrawerSpacing = 200; // Space between PictureBox row and Drawers
        private int currentIndex = 0;

        private int _distributionCounter = 0;


        public FormSolution2(FormParent frmParent)
        {
            InitializeComponent();
            CreateImageList();
            DisplayInitialPictureBoxes();
            _frmParent = frmParent;
        }

        private void CreateImageList()
        {
            _images.Clear();
            _images.Add(Properties.Resources._1);
            _images.Add(Properties.Resources._2);
            _images.Add(Properties.Resources._3);
            _images.Add(Properties.Resources._4);
            _images.Add(Properties.Resources._5);
            _images.Add(Properties.Resources._6);
            _images.Add(Properties.Resources._7);
            _images.Add(Properties.Resources._8);
            _images.Add(Properties.Resources._9);
        }

        private void CreateDrawers()
        {
            int drawerStartY = PictureBoxStartY + DrawerSpacing;

            for (int i = 1; i <= _drawerCount; i++)
            {
                int panelX = 30 + (i - 1) * 300; // Match panel's X coordinate

                Label drawerLabel = new Label
                {
                    Text = $"Drawer {i}",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(panelX + 80, drawerStartY - 30) // Align with panel
                };
                Controls.Add(drawerLabel);

                FlowLayoutPanel flowPanel = new FlowLayoutPanel
                {
                    Name = $"flow{i}",
                    Size = new Size(250, 250),
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10),
                    Location = new Point(panelX, drawerStartY) // Reference same X as label
                };
                Controls.Add(flowPanel);
            }
        }

        private void DisplayInitialPictureBoxes()
        {
            int pictureBoxWidth = 70; // Initial width
            int pictureBoxHeight = 70; // Initial height
            int startX = 100;
            int spacing = 90;
            int startY = 100;

            for (int i = 0; i < _objectCount; i++)
            {
                PictureBox picBox = new PictureBox
                {
                    Name = $"pictureBox{i + 1}",
                    Size = new Size(pictureBoxWidth, pictureBoxHeight),
                    Margin = new Padding(5),
                    Image = _images[i],
                    BackColor = Color.Transparent,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(startX + i * spacing, startY),
                    BorderStyle = BorderStyle.FixedSingle
                };
                pictureBoxes.Add(picBox);
                Controls.Add(picBox);
            }
        }

        private void StartDistribution()
        {
            distributionTimer = new Timer { Interval = 1000 };
            distributionTimer.Tick += OnDistributionTick;
            distributionTimer.Start();
        }

        private void OnDistributionTick(object sender, EventArgs e)
        {
            if (distribution.Count == 0 || pictureBoxes.Count == 0 || distributionTimer == null)
                return;

            if (distribution.Count > currentIndex)
            {
                int panelIndex = distribution[currentIndex];
                FlowLayoutPanel targetPanel = null;

                foreach (Control control in Controls)
                {
                    if (control is FlowLayoutPanel flowPanel && flowPanel.Name == $"flow{panelIndex}")
                    {
                        targetPanel = flowPanel;
                        break;
                    }
                }

                if (targetPanel != null)
                {
                    targetPanel.Controls.Add(pictureBoxes[currentIndex]);
                    currentIndex++;
                }
            }
            else
            {
                distributionTimer.Stop();
            }
        }

        private void ResetPictureBoxesAndPanels()
        {
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is PictureBox || Controls[i] is FlowLayoutPanel)
                {
                    Controls.RemoveAt(i);
                }
            }

            pictureBoxes.Clear();
            distribution.Clear();
            currentIndex = 0;
        }


        private void BtnClickToVisualize_Click(object sender, EventArgs e)
        {
            ResetPictureBoxesAndPanels();
            var randomTuple = _pTuple.GetTuple();
            if (randomTuple != null)
            {
                distribution = randomTuple.ToList();
                //distribution = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1,1 };
                DisplayInitialPictureBoxes();
                CreateDrawers();
                StartDistribution();
                _distributionCounter++;
                lblCounter.Text = _distributionCounter.ToString();
            }
            else 
            {
                MessageBox.Show("No more possible distribution");
            }

        }

        private void FormSolution2_Load(object sender, EventArgs e)
        {

            //int DrawerCount = 3;
            //int ObjectCount = PictureBoxCount;
            _objectCount = _frmParent.FrmIntroduction2.ObjectCount;
            _drawerCount = _frmParent.FrmIntroduction2.DrawerCount;
            _pTuple = new PTupleGenerator(_drawerCount, _objectCount);
            LblSolution.Text = _pTuple.GetSetCount().ToString();
        }
    }
}
