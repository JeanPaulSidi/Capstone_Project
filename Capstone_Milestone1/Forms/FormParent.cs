using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Milestone1.Forms
{
    public partial class FormParent : Form
    {
        //Instance Variables

        private FormIntroduction _frmIntro;
        private FormConstrainedDistributionAnalysis _frmConsDistAnalysis;
        private FormConstrainedDistributionSolution _frmConsDistSolution;
        private FormUnConstrainedDistributionAnalysis _frmUnConsDistAnalysis;
        private FormUnConstrainedDistributionSolution _frmUnConsDistSolution;
        private Panel _panel;

        private FormIntroduction2 _frmIntroduction2;
        private FormAnalysis2 _frmAnalysis2;
        private FormSolution2 _frmSolution2;
        private FormHome _frmHome;

        //Contructor
        public FormParent()
        {
            InitializeComponent();
            InitializeInstanceVariables();

        }

        //Properties (Getters/Setters)
        public FormIntroduction FrmIntro 
        {
            get { return _frmIntro; }
        }
        public FormConstrainedDistributionAnalysis FrmConsDistAnalysis 
        {
            get { return _frmConsDistAnalysis; }
        }
        public FormConstrainedDistributionSolution FrmConsDistSolution 
        {
            get { return _frmConsDistSolution;}
        }
        public FormUnConstrainedDistributionAnalysis FrmUnConsDistAnalysis 
        {
            get { return _frmUnConsDistAnalysis;}
        }
        public FormUnConstrainedDistributionSolution FrmUnConsDistSolution 
        {
            get { return _frmUnConsDistSolution;}
        }

        //
        public FormHome FrmHome 
        {
            get { return _frmHome; }
        }
        public FormIntroduction2 FrmIntroduction2 
        {
            get { return _frmIntroduction2; }
        }
        public FormAnalysis2 FrmAnalysis2 
        {
            get { return _frmAnalysis2; }
        }
        public FormSolution2 FrmSolution2 
        {
            get { return _frmSolution2; }
        }

        public Panel Pnl 
        {
            get { return _panel; }
        }

        //Methods
        private void InitializeInstanceVariables() 
        {
            _frmIntro = new FormIntroduction(this);
            _frmConsDistAnalysis = new FormConstrainedDistributionAnalysis(this);
            _frmConsDistSolution = new FormConstrainedDistributionSolution(this);
            _frmUnConsDistAnalysis = new FormUnConstrainedDistributionAnalysis(this);
            _frmUnConsDistSolution = new FormUnConstrainedDistributionSolution(this);

            _frmIntroduction2 = new FormIntroduction2(this);
            _frmAnalysis2 = new FormAnalysis2(this);
            _frmSolution2 = new FormSolution2(this);
            _frmHome = new FormHome(this);

            _panel = Panel;
        }

        public void DisplayForm(Form frm)
        {
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            _panel.Controls.Clear();
            _panel.Controls.Add(frm);
            frm.Show();
        }

        private void FormParent_Load(object sender, EventArgs e)
        {
            //DisplayForm(_frmIntro);
            DisplayForm(_frmHome);
        }
    }
}
