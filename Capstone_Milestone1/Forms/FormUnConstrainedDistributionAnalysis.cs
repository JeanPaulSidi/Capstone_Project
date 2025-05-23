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
    public partial class FormUnConstrainedDistributionAnalysis : Form
    {
        //Instance Variables

       
        private FormParent _frmParent;
        private List<string> _lines = new List<string>();
        private int _currentLineIndex = 0;
        private int _currentStep = 1;

        // Constructor
        public FormUnConstrainedDistributionAnalysis(FormParent FrmParent)
        {
            InitializeComponent();
            _frmParent = FrmParent;
        }

        // Properties

        // Methods
        private void CreateStepLines(int ObjectCount, int DrawerCount) 
        {
            string Line1 = ("Let's separate the bar(s) from the objects");
            string Line2 = ("Let's turn the bar(s) into objects");
            string Line3 = ($"To achieve such a distribution, we have to choose {DrawerCount - 1} objects from the {ObjectCount + DrawerCount - 1}, then turn them back into bars.");

            _lines.Add(Line1);
            _lines.Add(Line2);
            _lines.Add(Line3);

        }
        private void GroupPictureBoxes(int ObjectCount) 
        {
            int pictureBoxWidth = 50, pictureBoxHeight = 80;

            for (int i = 0; i < ObjectCount; i++)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(pictureBoxWidth, pictureBoxHeight),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightGray,
                    Image = Properties.Resources.Bille,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                Fpnl.Controls.Add(pictureBox);
            }
        }

        private void GroupTextBoxes(int DrawerCount)
        {
            int textBoxWidth = 10, textBoxHeight = 120;

            for (int i = 0; i < DrawerCount - 1; i++)
            {
                TextBox textBox = new TextBox
                {
                    Size = new Size(textBoxWidth, textBoxHeight),
                    Multiline = true,
                    BackColor = Color.Red
                };

                Fpnl.Controls.Add(textBox);
            }
        }

        private void AddSpace() 
        {
            int groupSpacing = 50;

            Label spacer = new Label
            {
                Size = new Size(groupSpacing, 0),
                BackColor = Color.Transparent // Invisible, just for spacing
            };

            Fpnl.Controls.Add(spacer);
        }

        private void ReplaceTextBoxesByPictureBoxes() 
        {
            foreach (Control control in Fpnl.Controls.OfType<TextBox>().ToList())
            {
                // Create a new PictureBox using the TextBox's properties
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(50, 80), // Keep same size
                    Location = control.Location, // Maintain position
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightGray,
                    Image = Properties.Resources.Bille, // Ensure resource exists
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // Remove the existing TextBox and add the PictureBox
                Fpnl.Controls.Remove(control);
                Fpnl.Controls.Add(pictureBox);
            }
        }

        private void FormUnConstrainedDistributionAnalysis_Load(object sender, EventArgs e)
        {
            LblTitle.Text = ($"Distribution of {_frmParent.FrmIntro.ObjectCount} objects into {_frmParent.FrmIntro.DrawerCount} drawers.");
            CreateStepLines(_frmParent.FrmIntro.ObjectCount, _frmParent.FrmIntro.DrawerCount);
            Fpnl.Controls.Add(_frmParent.FrmConsDistSolution.Fpnl);
            BtnGoToSolution.Visible = false;
        }

        private void BtnNextStep_Click(object sender, EventArgs e)
        {

            switch (_currentStep) 
            {
                case 1:
                    Fpnl.Controls.Clear();
                    GroupPictureBoxes(_frmParent.FrmIntro.ObjectCount);
                    AddSpace();
                    GroupTextBoxes(_frmParent.FrmIntro.DrawerCount);
                    LblSteps.Text += ($"* {_lines[0]} \n\n");
                    _currentStep++;
                    break;
                case 2:
                    ReplaceTextBoxesByPictureBoxes();
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

        
    }
}
