﻿using System;
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
    public partial class FormHome : Form
    {
        // Instance Variables
        private FormParent _frmParent;

        public FormHome(FormParent FrmParent)
        {
            InitializeComponent();
            _frmParent = FrmParent;
        }

        private void BtnSelectIndistinguishable_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmIntro);
        }

        private void BtnSelectDistinguishable_Click(object sender, EventArgs e)
        {
            _frmParent.DisplayForm(_frmParent.FrmIntroduction2);
        }
    }
}
