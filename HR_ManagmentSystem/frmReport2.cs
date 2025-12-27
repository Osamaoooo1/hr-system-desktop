using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HR_ManagmentSystem
{
    public partial class frmReport2 : Form
    {
        public frmReport2()
        {
            InitializeComponent();
        }

        private void frmReport2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KxP_hrDataSetView.AttenEmpView' table. You can move, or remove it, as needed.
           // this.AttenEmpViewTableAdapter.Fill(this.KxP_hrDataSetView.AttenEmpView);

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
