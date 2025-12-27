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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
       public static SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-D1L8A90\SQLEXPRESS; Initial Catalog=KxP_hr; Integrated Security=false; User ID=ali; Password=ali;");

        private void buttonX1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter cmd;
            DataTable dt=new DataTable();
            try
            {
                
                cn.Open();
                cmd = new SqlDataAdapter("select * from users where username ='" + txtUname.Text + "' and password ='" + txtPassword.Text + "'", cn);
                cmd.Fill(dt);
                int count=dt.Rows.Count;
                if ( count > 0)
                {
                    MessageBox.Show("مرحبا بكم ", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain fm = new frmMain();
                    fm.Show();
                    
                   
                }
                else
                {
                    txtUname.Clear();
                    txtPassword.Clear();
                    MessageBox.Show("إسم المستخدم او كلمة المرور غير صحيحة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {

                cn.Close();
            }
        }

        private void labelX4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        
    }
}
