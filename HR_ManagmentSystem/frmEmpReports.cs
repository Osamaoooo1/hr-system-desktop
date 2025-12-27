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
    public partial class frmEmpReports : Form
    {
        public frmEmpReports()
        {
            InitializeComponent();
        }
       // SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-D1L8A90\SQLEXPRESS;Initial Catalog=KxP_hr;Integrated Security=True");
        SqlDataAdapter daEmp;
        DataTable dtEmp=new DataTable();

        private void frmEmpReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kxP_hrDataSet.employees' table. You can move, or remove it, as needed.
            
            daEmp=new SqlDataAdapter("select * from employees",frmLogin.cn);
           
            daEmp.Fill(dtEmp);
            this.dataGridViewX1.DataSource = dtEmp;
           
        }
        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            dtEmp.Clear();
            daEmp = new SqlDataAdapter("select * from employees where convert(nvarchar,employee_id)+first_name+last_name+job_title+convert(varchar,salary)+convert(varchar,reports_to)+convert(varchar,office_id) like '%" + textBoxX1.Text + "%'", frmLogin.cn);
           
            daEmp.Fill(dtEmp);
            this.dataGridViewX1.DataSource = dtEmp;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            frmReport rfrm = new frmReport();
            rfrm.ShowDialog();
        }

        


    }
}
