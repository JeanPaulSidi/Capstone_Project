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
        //Instance Variables
        private FormParent _frmParent;
        private Combination combination;
        private int _distributionCount = 0;

        //Constructor
        public FormUnConstrainedDistributionSolution(FormParent FrmParent)
        {
            InitializeComponent();
            _frmParent = FrmParent;
        }

        // Properties

        // Methods
        private void AddObjectControls(int ObjectCount, FlowLayoutPanel Fpnl)
        {
            int startX = 10; // Initial X position
            int pictureBoxWidth = 50, pictureBoxHeight = 80;
            int spacing = 3;

            for (int i = 0; i < ObjectCount; i++)
            {
                // Create PictureBox
                PictureBox pictureBox = new PictureBox
                {
                    Name = "picturebox" + (i+1),
                    Size = new Size(pictureBoxWidth, pictureBoxHeight),
                    Location = new Point(startX, 60),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightGray,
                    Image = Properties.Resources.Bille,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                Fpnl.Controls.Add(pictureBox);
                startX += pictureBoxWidth + spacing;

            }

        }

        private void HighlightSelectedObjects(int[] Array, FlowLayoutPanel Fpnl) 
        {
            foreach (int value in Array) 
            {
                Control control = Fpnl.Controls["picturebox" + value];

                if (control is PictureBox picturebox) 
                {
                    picturebox.Image.Dispose();
                    picturebox.Image = null;
                    picturebox.BackColor = Color.Red;
                }
            }
        }

        private void TransformSelectedbjectsToBars(int[] Array, FlowLayoutPanel Fpnl) 
        {
            int textBoxWidth = 10, textBoxHeight = 120;
        }

        private string DisplaySolution()
        {
            int CombinationCount = combination.CombinationCount;
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

            CombinationSet.Add((_frmParent.FrmIntro.ObjectCount + _frmParent.FrmIntro.DrawerCount - 1) + 1);

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
            AddObjectControls(_frmParent.FrmIntro.ObjectCount + _frmParent.FrmIntro.DrawerCount - 1, Fpnl1);
            AddObjectControls(_frmParent.FrmIntro.ObjectCount + _frmParent.FrmIntro.DrawerCount - 1, Fpnl2);
            Fpnl2.Visible = false;
            combination = new Combination(_frmParent.FrmIntro.ObjectCount + _frmParent.FrmIntro.DrawerCount - 1, _frmParent.FrmIntro.DrawerCount - 1);
            LblSolution.Text = DisplaySolution();
        }

        private void BtnVisualisation_Click(object sender, EventArgs e)
        {
            var randomCombination = combination.GetCombination();

            if (randomCombination != null)
            {
                Fpnl2.Visible = false;
                HighlightSelectedObjects(randomCombination, Fpnl1);
                TransformSelectedbjectsToBars(randomCombination, Fpnl2);
                Fpnl2.Visible = true;
                _distributionCount++;
                LblDistributionCounter.Text = _distributionCount.ToString();
                List<int> Distribution = GetDistribution(randomCombination.ToList());
                DisplayDistribution(Distribution, LblDristributionDetails);
            }
        }
    }
}
