using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Capstone_Milestone1.Forms
{
    public partial class FormConstrainedDistributionAnalysis : Form
    {
        //Instance Variables
        private FormParent _frmParent;
        private List<string> _lines = new List<string>();
        private int _currentLineIndex = 0;
        private int _currentStep = 1;

        //Contructor
        public FormConstrainedDistributionAnalysis(FormParent FrmParent)
        {
            InitializeComponent();
            _frmParent = FrmParent;
        }

        //Properties


        //Methods
        private void CreateStepLines(int ObjectCount, int DrawerCount) 
        {
            string Line1 = ($"Let's consider the {ObjectCount} objects");
            string Line2 = ($"Let's consider the {ObjectCount - 1} separation bar(s) between the objects");
            string Line3 = ($"To achieve such a distribution, we have to choose {DrawerCount - 1} bar(s) from the {ObjectCount - 1} separation bar(s).");

            _lines.Add( Line1 );
            _lines.Add( Line2 );
            _lines.Add( Line3 );
        }

        private void AddObjectControls(int ObjectCount) 
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

        private void HideTextboxes() 
        {
            foreach (TextBox textBox in Fpnl.Controls.OfType<TextBox>()) 
            {
                textBox.Visible = false;
            }
        }

        private void ShowTextboxes() 
        {
            foreach (TextBox textBox in Fpnl.Controls.OfType<TextBox>()) 
            {
                textBox.Visible = true;
            }
        }

        private void FormConstrainedDistributionAnalysis_Load(object sender, EventArgs e)
        {
            BtnNext.Visible = false;
            LblTitle.Text = ($"Distribution of {_frmParent.FrmIntro.ObjectCount} objects into {_frmParent.FrmIntro.DrawerCount} drawers.");
            Fpnl.Visible = false;
            AddObjectControls(_frmParent.FrmIntro.ObjectCount);
            CreateStepLines(_frmParent.FrmIntro.ObjectCount, _frmParent.FrmIntro.DrawerCount);
            BtnGoToSolution.Visible = false;
        }

        private void BtnNextStep_Click(object sender, EventArgs e)
        {
            switch (_currentStep) 
            {
                case 1:
                    HideTextboxes();
                    Fpnl.Visible = true;
                    LblSteps.Text += ($"* {_lines[0]} \n\n");
                    _currentStep++;
                    break;
                case 2:
                    ShowTextboxes();
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

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmIntro);
        }

        private void BtnGoToSolution_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmConsDistSolution);
            BtnNext.Visible = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmConsDistSolution);
        }

        private void BtnGoToSetup_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmIntro);
        }
    }
}
