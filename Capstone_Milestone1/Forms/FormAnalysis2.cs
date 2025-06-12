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

        public FormAnalysis2(FormParent frmParent)
        {
            InitializeComponent();
            _frmParent = frmParent;
        }
    }
}
