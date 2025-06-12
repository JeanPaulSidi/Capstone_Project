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
    public partial class FormIntroduction : Form
    {
        //Instance Variables
        private FormParent _frmParent;
        private const int _objectCountMax = 10;
        private const int _objectCountMin = 3;
        private const int _drawerCountMin = 2;
        
        private int _objectCount = 0;
        private int _drawerCount = 0;

        //Constructor
        public FormIntroduction(FormParent FrmParent)
        {
            InitializeComponent();
            _frmParent = FrmParent;
        }

        //Properties
        public int ObjectCount 
        {
            get { return _objectCount; }
        }
        public int DrawerCount 
        {
            get { return _drawerCount; }
        }

        //Methods
        private List<int> PopulateComboBox(int Min, int Max) 
        {
            List<int> list = new List<int>();

            for (int  i = Min; i <= Max; i++) 
            {
                list.Add(i);
            }
            return list;
        }

        private void FormIntroduction_Load(object sender, EventArgs e)
        {
            BtnClickToStart.Visible = false;
            BtnReset.Visible = false;
            BtnNext.Visible = false;
            BtnReset.Enabled = false;

            CboObjectCount.DataSource = PopulateComboBox(_objectCountMin, _objectCountMax);
            CboObjectCount.Text = string.Empty;
            CboDrawerCount.DataSource = null;
        }

        private void CboObjectCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboObjectCount.SelectedItem != null)
            {
                _objectCount = (int)CboObjectCount.SelectedItem;
                CboDrawerCount.DataSource = PopulateComboBox(_drawerCountMin, _objectCount - 1);

                // Force no initial selection to prevent auto-triggering the event
                CboDrawerCount.SelectedIndex = -1;
                BtnClickToStart.Visible = false; // Ensure it's hidden again after changing ObjectCount

            }

            

        }

        private void CboDrawerCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Make the button visible only when the user actually selects an item
            BtnClickToStart.Visible = CboDrawerCount.SelectedIndex != -1;

            if (CboDrawerCount.SelectedItem != null) 
            {
                _drawerCount = (int)CboDrawerCount.SelectedItem;
                BtnReset.Enabled = true;
            }
            else 
            {
                BtnReset.Enabled = false;
            }

        }

        private void BtnClickToStart_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmConsDistAnalysis);
            BtnClickToStart.Visible = false;
            BtnNext.Visible = true;
            BtnReset.Visible = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmConsDistAnalysis);
        }
    }
}
