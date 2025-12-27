using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HR_ManagmentSystem
{
    public partial class frmReportAtten : Form
    {
        public frmReportAtten()
        {
            InitializeComponent();
        }
        int searchtype = 0;
       // SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-D1L8A90\SQLEXPRESS;Initial Catalog=KxP_hr;Integrated Security=True");
        SqlDataAdapter da;
       
        DataTable dtAtten = new DataTable();
        DataTable dtEmp = new DataTable();

        private void frmReportAtten_Load(object sender, EventArgs e)
        {
            
           
            // query to fill datagridview 
            da = new SqlDataAdapter("select * from AttenEmpView", frmLogin.cn);
            da.Fill(dtAtten);
            dataGridViewX1.DataSource = dtAtten;

            //query to fill combobox employees data

            da = new SqlDataAdapter("select employee_id,first_name+'_'+last_name as fullname from employees", frmLogin.cn);
            da.Fill(dtEmp);
            cbEmpID.DataSource = dtEmp;
            cbEmpID.DisplayMember = "fullname";
            
        }

        //button to search as employee name and attendance date
        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            searchtype = 1;
            try
            {
                char[] c = { '-', '0', '1' };
                // MessageBox.Show(dtAttenDate.Text.TrimEnd(c));
                da = new SqlDataAdapter("select * from AttenEmpView where first_name+'_'+last_name like '%" + cbEmpID.Text + "%' and Date like '" + dtAttenDate.Text.TrimEnd(c) + "%'", frmLogin.cn);
                dtAtten.Clear();
                da.Fill(dtAtten);
                dataGridViewX1.DataSource = dtAtten;
            }
            catch
            {
                return;
            }
        }

        //button to search as employee name only
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            searchtype = 2;
            try
            {
                da = new SqlDataAdapter("select * from AttenEmpView where first_name+'_'+last_name like '%" + cbEmpID.Text + "%'", frmLogin.cn);
                dtAtten.Clear();
                da.Fill(dtAtten);
                dataGridViewX1.DataSource = dtAtten;
            }
            catch
            {
                return;
            }
        }

        //button to search attendance date only
        private void buttonItem2_Click(object sender, EventArgs e)
        {
            searchtype = 3;
            try
            {
                char[] c = { '-', '0', '1' };
                // MessageBox.Show(dtAttenDate.Text.TrimEnd(c));
                da = new SqlDataAdapter("select * from AttenEmpView where Date like '" + dtAttenDate.Text.TrimEnd(c) + "%'", frmLogin.cn);
                dtAtten.Clear();
                da.Fill(dtAtten);
                dataGridViewX1.DataSource = dtAtten;
            }
            catch
            {
                return;
            }
        }

        //button to close the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //button to print search result
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            frmReport2 frmreport2= new frmReport2();
            if (searchtype == 1)
            {
                try
                {
                    char[] c = { '-', '0', '1' };
                    // MessageBox.Show(dtAttenDate.Text.TrimEnd(c));
                    da = new SqlDataAdapter("select * from AttenEmpView where first_name+'_'+last_name like '%" + cbEmpID.Text + "%' and Date like '" + dtAttenDate.Text.TrimEnd(c) + "%'", frmLogin.cn);
                    da.Fill(frmreport2.KxP_hrDataSetView.AttenEmpView);
                    frmreport2.reportViewer1.RefreshReport();
                    frmreport2.ShowDialog();
                }
                catch
                {
                    return;
                }
            }
            else if (searchtype == 2)
            {
                try
                {
                    da = new SqlDataAdapter("select * from AttenEmpView where first_name+'_'+last_name like '%" + cbEmpID.Text + "%'", frmLogin.cn);
                    da.Fill(frmreport2.KxP_hrDataSetView.AttenEmpView);
                    frmreport2.reportViewer1.RefreshReport();
                    frmreport2.ShowDialog();
                }
                catch
                {
                    return;
                }
            }
            else if (searchtype == 3)
            {
                char[] c = { '-', '0', '1' };
                da = new SqlDataAdapter("select * from AttenEmpView where Date like '" + dtAttenDate.Text.TrimEnd(c) + "%'", frmLogin.cn);
                da.Fill(frmreport2.KxP_hrDataSetView.AttenEmpView);
                frmreport2.reportViewer1.RefreshReport();
                frmreport2.ShowDialog();
            }
            else
            {
                return;
            }
            
            
        }
        
    }
}
