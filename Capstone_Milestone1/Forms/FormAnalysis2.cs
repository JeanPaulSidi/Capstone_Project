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
    public partial class FormAnalysis2 : Form
    {
        // Instance Variables
        private FormParent _frmParent;
        private List<string> _lines = new List<string>();
        private List<Image> _images = new List<Image>();

        private int _objectCount;
        private int _drawerCount;

        private int _currentLineIndex = 0;
        private int _currentStep = 1;

        public FormAnalysis2(FormParent frmParent)
        {
            InitializeComponent();
            CreateImageList();
            _frmParent = frmParent;
        }

        // Properties


        //Methods
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

        private void CreateStepLines(int ObjectCount, int DrawerCount)
        {
            string Line1 = ($"Let's consider the {ObjectCount} objects");
            string Line2 = ($"Let's consider the {ObjectCount - 1} separation bar(s) between the objects");
            string Line3 = ($"To achieve such a distribution, we have to choose {DrawerCount - 1} bar(s) from the {ObjectCount - 1} separation bar(s).");

            _lines.Add(Line1);
            _lines.Add(Line2);
            _lines.Add(Line3);
        }

        private void AddObjectControls(int ObjectCount, FlowLayoutPanel Fpnl)
        {
            int startX = 10; // Initial X position
            int pictureBoxWidth = 50, pictureBoxHeight = 80;
            int spacing = 5;

            for (int i = 0; i < ObjectCount; i++)
            {
                // Create PictureBox
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(pictureBoxWidth, pictureBoxHeight),
                    Location = new Point(startX, 60),
                    BorderStyle = BorderStyle.FixedSingle,
                    //BackColor = Color.LightGray,
                    Image = _images[i],
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Margin = new Padding(10) //Adds spacing around each PictureBox

                };
                Fpnl.Controls.Add(pictureBox);
                startX += pictureBoxWidth + spacing;
            }

        }

        private void AddDrawerControls(int DrawerCount, FlowLayoutPanel Fpnl)
        {
            Fpnl.Controls.Clear(); // Clear previous controls
            int startX = 10; // Initial X position
            int spacing = 50;
            int panelWidth = 120; // Width for each wrapperPanel

            for (int i = 0; i < DrawerCount; i++)
            {
                // Create Label
                Label drawerLabel = new Label
                {
                    Text = $"Drawer {i + 1}",
                    Size = new Size(panelWidth, 20),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Create TextBox
                TextBox drawerTextbox = new TextBox
                {
                    Name = $"drawer{i + 1}",
                    Size = new Size(panelWidth, 60),
                    TextAlign = HorizontalAlignment.Center,
                    BackColor = Color.LightBlue,
                    ReadOnly = true,
                    Multiline = true
                };

                // Wrap in a Panel for horizontal alignment control
                Panel wrapperPanel = new Panel
                {
                    Size = new Size(panelWidth, 90),
                    Location = new Point(startX, 0), // Manual X position
                    Margin = new Padding(spacing)
                };

                wrapperPanel.Controls.Add(drawerLabel);
                wrapperPanel.Controls.Add(drawerTextbox);

                Fpnl.Controls.Add(wrapperPanel);
                startX += panelWidth + spacing; // Move the next drawer to the right
            }
        }

        private void FormAnalysis2_Load(object sender, EventArgs e)
        {
            BtnNext.Visible = false;
            BtnGoToSolution.Visible = false;
            _objectCount = _frmParent.FrmIntroduction2.ObjectCount;
            _drawerCount = _frmParent.FrmIntroduction2.DrawerCount;
            LblTitle.Text = ($"Distribution of {_objectCount} objects into {_drawerCount} drawers");
            CreateStepLines(_objectCount, _drawerCount);

        }

        private void BtnNextStep_Click(object sender, EventArgs e)
        {
            switch (_currentStep)
            {
                case 1:
                    AddObjectControls(_objectCount, Fpnl1);
                    LblSteps.Text += ($"* {_lines[0]} \n\n");
                    _currentStep++;
                    break;
                case 2:
                    AddDrawerControls(_drawerCount, Fpnl2);
                    LblSteps.Text += ($"* {_lines[1]} \n\n");
                    _currentStep++;
                    break;
                case 3:
                    LblSteps.Text += ($"* {_lines[2]} \n\n");
                    _currentStep++;
                    BtnNextStep.Enabled = false;
                    BtnGoToSolution.Visible = true;
                    break;
            }

        }

        private void BtnGoToSolution_Click(object sender, EventArgs e)
        {
            BtnGoToSolution.Visible = false;
            _frmParent.DisplayForm(_frmParent.FrmSolution2);
            BtnNext.Visible = true;
        }

        private void BtnGoToSetup_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmIntroduction2);
        }

        private void BtnGoHome_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmHome);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmSolution2);
        }
    }
}

