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
    public partial class FormSolution3 : Form
    {
        // Instance Variables
        private FormParent _frmParent;

        private Panel mainPanel = new Panel();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private List<PictureBox> preAssignedBoxes = new List<PictureBox>();
        private List<PictureBox> remainingBoxes = new List<PictureBox>();
        private List<Image> _images = new List<Image>();

        private Timer assignmentTimer;
        private Timer distributionTimer;
        private int assignmentIndex = 0;
        private int distributionIndex = 0;

        private int PictureBoxCount = 9;
        private int DistributionCounter = 0;

        private List<int> preAssignedIndices = new List<int> { 6, 2, 1 };
        private List<int> distributionList = new List<int>();
        private List<int> distributionIndices = new List<int>(); // Current drawer mapping


        public FormSolution3(FormParent frmParent)
        {
            InitializeComponent();
            SetupMainPanel();
            CreateImageList();
            DisplayPictureBoxes();
            CreateDrawers();
            _frmParent = frmParent;

            assignmentTimer = new Timer { Interval = 1000 };
            assignmentTimer.Tick += OnAssignmentTick;

            distributionTimer = new Timer { Interval = 700 };
            distributionTimer.Tick += OnDistributionTick;

        }

        private void SetupMainPanel()
        {
            mainPanel.Size = new Size(600, 200);
            mainPanel.Location = new Point(50, 50);
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(mainPanel);
        }

        private void CreateImageList()
        {
            _images.Clear();
            _images.AddRange(new Image[]
            {
                Properties.Resources._1, Properties.Resources._2, Properties.Resources._3,
                Properties.Resources._4, Properties.Resources._5, Properties.Resources._6,
                Properties.Resources._7, Properties.Resources._8, Properties.Resources._9
            });
        }

        private void CreateDrawers()
        {
            int drawerStartY = mainPanel.Bottom + 50;
            for (int i = 1; i <= 3; i++)
            {
                Label drawerLabel = new Label
                {
                    Text = $"Drawer {i}",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(50 + (i - 1) * 200, drawerStartY - 30)
                };
                Controls.Add(drawerLabel);

                FlowLayoutPanel drawerPanel = new FlowLayoutPanel
                {
                    Name = $"drawer{i}",
                    Size = new Size(180, 180),
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(50 + (i - 1) * 200, drawerStartY)
                };
                Controls.Add(drawerPanel);
            }
        }

        private void DisplayPictureBoxes()
        {
            int spacing = 60;
            for (int i = 0; i < PictureBoxCount; i++)
            {
                PictureBox picBox = new PictureBox
                {
                    Name = $"pictureBox{i + 1}",
                    Size = new Size(50, 50),
                    Margin = new Padding(5),
                    Image = _images[i],
                    BackColor = Color.Transparent,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(10 + i * spacing, 10)
                };
                pictureBoxes.Add(picBox);
                mainPanel.Controls.Add(picBox);
            }
        }

        private void StartAssignmentAndDistribution()
        {
            assignmentIndex = 0;
            distributionIndex = 0;
            preAssignedBoxes.Clear();
            remainingBoxes.Clear();

            foreach (int index in preAssignedIndices)
                preAssignedBoxes.Add(pictureBoxes[index]);

            for (int i = 0; i < PictureBoxCount; i++)
                if (!preAssignedIndices.Contains(i))
                    remainingBoxes.Add(pictureBoxes[i]);

            distributionIndices = new List<int>(distributionList);

            assignmentTimer.Start();
        }

        private void OnAssignmentTick(object sender, EventArgs e)
        {
            if (assignmentIndex < preAssignedBoxes.Count)
            {
                PictureBox picBox = preAssignedBoxes[assignmentIndex];
                FlowLayoutPanel targetPanel = FindDrawerPanel(assignmentIndex + 1);
                targetPanel?.Controls.Add(picBox);
                assignmentIndex++;
            }
            else
            {
                assignmentTimer.Stop();
                distributionTimer.Start();
            }
        }

        private void OnDistributionTick(object sender, EventArgs e)
        {
            if (distributionIndex < remainingBoxes.Count)
            {
                PictureBox picBox = remainingBoxes[distributionIndex];
                int targetDrawer = distributionIndices[distributionIndex];
                FlowLayoutPanel targetPanel = FindDrawerPanel(targetDrawer);
                targetPanel?.Controls.Add(picBox);
                distributionIndex++;
            }
            else
            {
                distributionTimer.Stop();
                BtnVisualize.Enabled = true;
            }
        }

        private FlowLayoutPanel FindDrawerPanel(int drawerNumber)
        {
            foreach (Control control in Controls)
            {
                if (control is FlowLayoutPanel flowPanel && flowPanel.Name == $"drawer{drawerNumber}")
                    return flowPanel;
            }
            return null;
        }

        private void ResetPictureBoxesAndPanels()
        {
            foreach (Control control in Controls)
            {
                if (control is FlowLayoutPanel flowPanel)
                    flowPanel.Controls.Clear();
            }

            mainPanel.Controls.Clear();
            pictureBoxes.Clear();
            DisplayPictureBoxes();
        }

        private void BtnVisualize_Click(object sender, EventArgs e)
        {
            BtnVisualize.Enabled = false;

            ResetPictureBoxesAndPanels();

            if (DistributionCounter == 2)
            {
                preAssignedIndices.Clear();
                preAssignedIndices.AddRange(new List<int> { 1, 3, 5 });
            }

            distributionList.Clear();
            switch (DistributionCounter % 3)
            {
                case 0:
                    distributionList.AddRange(new List<int> { 1, 1, 1, 1, 2, 2 });
                    break;
                case 1:
                    distributionList.AddRange(new List<int> { 2, 2, 3, 3, 1, 1 });
                    break;
                case 2:
                    distributionList.AddRange(new List<int> { 1, 2, 3, 1, 2, 3 });
                    break;
            }

            DistributionCounter++;
            StartAssignmentAndDistribution();
        }

        private void FormSolution3_Load(object sender, EventArgs e)
        {
            LblTitle.Text += ("Distributing 9 distinct objects into 3 drawers.");
            LblTitle.Text += (" drawers cannot be empty. ");
            LblTitle.Text += ($"Result: (9 X 8 X 7) X (3^6)  = ");
            LblTitle.Text += ($" ({9 * 8 * 7}) X ({3 * 3 * 3 * 3 * 3 * 3})");
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmSolution2);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmHome);
        }
    }
}

