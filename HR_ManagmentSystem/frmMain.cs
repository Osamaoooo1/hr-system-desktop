using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace HR_ManagmentSystem
{
    public partial class frmMain : Form
    {
      
       // SqlConnection cn = new SqlConnection(@"Server=desktop-d1l8a90\sqlexpress;Database=KxP_hr;Integrated Security=true;");
        byte[] _imageEmpBinary;
        public frmMain()
        {
            InitializeComponent();
        }

        public void databindingEmployees()
        {
            txtEmployeeId.DataBindings.Add("text", this.kxP_hrDataSet.employees, "employee_id");
            txtFname.DataBindings.Add("text", this.kxP_hrDataSet.employees, "first_name");
            txtLname.DataBindings.Add("text", this.kxP_hrDataSet.employees, "last_name");
            txtSalary.DataBindings.Add("text", this.kxP_hrDataSet.employees, "salary");
            txtJob.DataBindings.Add("text", this.kxP_hrDataSet.employees, "job_title");
            cbOffice.DataBindings.Add("text", this.kxP_hrDataSet.employees, "office_id");
            cbReport.DataBindings.Add("text", this.kxP_hrDataSet.employees, "reports_to");
            //pictureBoxEmpImage.DataBindings.Add("Image", this.kxP_hrDataSet.employees, "image_emp");
        }
        public void databindingOffices()
        {
            txtOfficeId.DataBindings.Add("text", this.kxP_hrDataSet.offices, "office_id");
            txtOfficeAddress.DataBindings.Add("text", this.kxP_hrDataSet.offices, "address");
            txtOfficeCity.DataBindings.Add("text", this.kxP_hrDataSet.offices, "city");
            txtOfficeState.DataBindings.Add("text", this.kxP_hrDataSet.offices, "state");
        }
        public void databindingAttendance()
        {
            txtAttenID.DataBindings.Add("text", this.kxP_hrDataSet.Attendance, "attendaceID");
            cbEmpID.DataBindings.Add("text", this.kxP_hrDataSet.Attendance, "employeeID");
            dtpAttenDate.DataBindings.Add("text", this.kxP_hrDataSet.Attendance, "Date");
            cbStausAtten.DataBindings.Add("text", this.kxP_hrDataSet.Attendance, "Status");
            txtNoteAtten.DataBindings.Add("text", this.kxP_hrDataSet.Attendance, "Note");
            
            
        }

        BindingManagerBase bmb; // bindingManager for Employees Table
        BindingManagerBase bmbOffices; // bindingManager for Offices Table
        CurrencyManager bmbAttendance; //bindingManager for Attendance Table
        SqlCommandBuilder cmdb;
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'kxP_hrDataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.kxP_hrDataSet.Attendance);
            databindingAttendance();
            bmbAttendance = (CurrencyManager) this.BindingContext[this.kxP_hrDataSet.Attendance];
            lblAttenNum.Text = (bmbAttendance.Position + 1) + " / " + this.kxP_hrDataSet.Attendance.Rows.Count;
            

            // TODO: This line of code loads data into the 'kxP_hrDataSet.offices' table. You can move, or remove it, as needed.
            this.officesTableAdapter.Fill(this.kxP_hrDataSet.offices);
            databindingOffices();
            bmbOffices = this.BindingContext[this.kxP_hrDataSet.offices];
            lblOfficeNum.Text = (bmbOffices.Position + 1) + " / " + (this.kxP_hrDataSet.offices.Rows.Count);

            // TODO: This line of code loads data into the 'kxP_hrDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.kxP_hrDataSet.employees);
            databindingEmployees();
            bmb = this.BindingContext[this.kxP_hrDataSet.employees];
            lblEmpNum.Text = (bmb.Position + 1) + " / " + this.kxP_hrDataSet.employees.Rows.Count;

            
        }

        #region EmployeesOpiretion
        //button to ADD New Employee record to saved it
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                bmb.AddNew();
                txtFname.Focus();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        //button to save New Employee record 
        private void btnSaveChangesEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حقاً حفظ التغييرات ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bmb.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(this.employeesTableAdapter.Adapter);
                    this.employeesTableAdapter.Adapter.Update(this.kxP_hrDataSet.employees);
                    MessageBox.Show(": تمت إضافة سجل الموضف :" + txtFname.Text + " " + txtLname.Text + " بنجاح ", "إضافة موضف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblEmpNum.Text = (bmb.Position + 1) + " / " + this.kxP_hrDataSet.employees.Rows.Count;
                }
            }
            catch(SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        //button to Edit Employee record
        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (MessageBox.Show("هل تريد حقاً التعديل ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bmb.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(this.employeesTableAdapter.Adapter);
                    // this.kxP_hrDataSet.employees["image_emp"]= _imageEmpBinary;
                    this.employeesTableAdapter.Adapter.Update(this.kxP_hrDataSet.employees);
                    MessageBox.Show(": تم تعديل سجل الموضف :" + txtFname.Text + " " + txtLname.Text, "تعديل موضف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblEmpNum.Text = (bmb.Position + 1) + " / " + this.kxP_hrDataSet.employees.Rows.Count;
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        //button to Delete Employee record
        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حقاً الحذف ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bmb.RemoveAt(bmb.Position);
                    bmb.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(this.employeesTableAdapter.Adapter);
                    this.employeesTableAdapter.Adapter.Update(this.kxP_hrDataSet.employees);
                    bmbAttendance.Refresh();
                    MessageBox.Show(": تم حذف سجل الموضف :" + txtFname.Text + " " + txtLname.Text, "حذف موضف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblEmpNum.Text = (bmb.Position + 1) + " / " + this.kxP_hrDataSet.employees.Rows.Count;
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
           
        }

        private void pictureBoxEmpImage_Click(object sender, EventArgs e)
        {
            openImageEmp.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (openImageEmp.ShowDialog() == DialogResult.OK)
            {
                pictureBoxEmpImage.Image = Image.FromFile(openImageEmp.FileName);
            }
            MemoryStream ms = new MemoryStream();
            pictureBoxEmpImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            _imageEmpBinary = ms.ToArray();
        }
        #endregion
        #region OfficesOpiretion
        //button to save New Office record 
        private void btnSaveChangesOffice_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حقاً حفظ التغييرات ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bmbOffices.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(this.officesTableAdapter.Adapter);
                    this.officesTableAdapter.Adapter.Update(this.kxP_hrDataSet.offices);
                    MessageBox.Show(": تمت إضافة سجل القسم :" + txtOfficeId.Text + " بنجاح ", "إضافة قسم ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblOfficeNum.Text = (bmbOffices.Position + 1) + " / " + (this.kxP_hrDataSet.offices.Rows.Count);
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
            
        }
        //button to ADD New Office record to saved it
        private void btnAddOffice_Click(object sender, EventArgs e)
        {
            bmbOffices.AddNew();
            txtOfficeAddress.Focus();
        }
        //button to Edit Office record
        private void btnUpdateOffice_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حقاً التعديل ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bmbOffices.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(this.officesTableAdapter.Adapter);
                    this.officesTableAdapter.Adapter.Update(this.kxP_hrDataSet.offices);
                    MessageBox.Show(" : تم تعديل سجل القسم :" + txtOfficeId.Text, "تعديل قسم ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblOfficeNum.Text = (bmbOffices.Position + 1) + " / " + (this.kxP_hrDataSet.offices.Rows.Count);
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }

        }
        //button to Delete Employee record
        private void btnDeleteOffice_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حقاً الحذف ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bmbOffices.RemoveAt(bmbOffices.Position);
                    bmbOffices.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(this.officesTableAdapter.Adapter);
                    this.officesTableAdapter.Adapter.Update(this.kxP_hrDataSet.offices);
                    MessageBox.Show(" : تم حذف سجل القسم :" + txtOfficeId.Text, "حذف قسم ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblOfficeNum.Text = (bmbOffices.Position + 1) + " / " + (this.kxP_hrDataSet.offices.Rows.Count);
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }
        #endregion
        #region AttendanceOpirations
        //button to  Add attendance record 
        private void btnAddAtten_Click(object sender, EventArgs e)
        {
            try
            {
                bmbAttendance.AddNew();
                dtpAttenDate.Text = DateTime.Today.ToString();
                cbEmpID.Focus();
               
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }


        }

        //Button to save record that added
        private void btnSaveChangesAtten_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حقاً حفظ التغييرات ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bmbAttendance.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(this.attendanceTableAdapter.Adapter);
                    this.attendanceTableAdapter.Adapter.Update(this.kxP_hrDataSet.Attendance);
                    MessageBox.Show(": تمت الإضافة :" + " بنجاح ", "إضافة حضور ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblAttenNum.Text = (bmbAttendance.Position + 1) + " / " + this.kxP_hrDataSet.Attendance.Rows.Count;
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        //button to Update attendance record
        private void btnUpdateAtten_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حقاًالتعديل ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bmbAttendance.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(this.attendanceTableAdapter.Adapter);
                    this.attendanceTableAdapter.Adapter.Update(this.kxP_hrDataSet.Attendance);
                    MessageBox.Show(":  تم التعديل على الحضور :" + txtAttenID.Text, "تعديل حضور ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblAttenNum.Text = (bmbAttendance.Position + 1) + " / " + this.kxP_hrDataSet.Attendance.Rows.Count;
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }

        }

        //button to Delete attendance record
        private void btnDeleteAtten_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حقاً الحذف ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bmbAttendance.RemoveAt(bmbAttendance.Position);
                    bmbAttendance.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(this.attendanceTableAdapter.Adapter);
                    this.attendanceTableAdapter.Adapter.Update(this.kxP_hrDataSet.Attendance);
                    bmbAttendance.Refresh();
                    MessageBox.Show(": تم حذف الحضور " + txtAttenID.Text, "حذف حضور ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblAttenNum.Text = (bmbAttendance.Position + 1) + " / " + this.kxP_hrDataSet.Attendance.Rows.Count;
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnSearchAtten_Click(object sender, EventArgs e)
        {
            frmReportAtten frma = new frmReportAtten();
            frma.ShowDialog();
        }

        #endregion

       

        #region arrowsEmployees
        // |<< buuton
        private void button3_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblEmpNum.Text = (bmb.Position + 1) + " / " + this.kxP_hrDataSet.employees.Rows.Count;
        }
        // << button
        private void button2_Click(object sender, EventArgs e)
        {
            bmb.Position--;
            lblEmpNum.Text = (bmb.Position + 1) + " / " + this.kxP_hrDataSet.employees.Rows.Count;
        }
        // >> button
        private void button4_Click(object sender, EventArgs e)
        {
            bmb.Position++;
            lblEmpNum.Text = (bmb.Position + 1) + " / " + this.kxP_hrDataSet.employees.Rows.Count;
        }
        // >>| button
        private void button1_Click(object sender, EventArgs e)
        {
            bmb.Position = this.kxP_hrDataSet.employees.Rows.Count - 1;
            lblEmpNum.Text = (bmb.Position + 1) + " / " + (this.kxP_hrDataSet.employees.Rows.Count);
        }
        #endregion
        #region arrowsOffices
        // >> button
        private void button5_Click(object sender, EventArgs e)
        {
            bmbOffices.Position++;
            lblOfficeNum.Text = (bmbOffices.Position + 1) + " / " + this.kxP_hrDataSet.offices.Rows.Count;
        }
        // |<< button
        private void button6_Click(object sender, EventArgs e)
        {
            bmbOffices.Position = 0;
            lblOfficeNum.Text = (bmbOffices.Position + 1) + " / " + this.kxP_hrDataSet.offices.Rows.Count;

        }
        // << button
        private void button7_Click(object sender, EventArgs e)
        {
            bmbOffices.Position--;
            lblOfficeNum.Text = (bmbOffices.Position + 1) + " / " + this.kxP_hrDataSet.offices.Rows.Count;
        }
        // >>| button
        private void button8_Click(object sender, EventArgs e)
        {
            bmbOffices.Position = this.kxP_hrDataSet.offices.Rows.Count - 1;
            lblOfficeNum.Text = (bmbOffices.Position + 1) + " / " + this.kxP_hrDataSet.offices.Rows.Count;
        }
        #endregion
        #region arrowsAttendance
        // >>| button
        private void button12_Click(object sender, EventArgs e)
        {
            bmbAttendance.Position = this.kxP_hrDataSet.Attendance.Rows.Count - 1;
            lblAttenNum.Text = (bmbAttendance.Position + 1) + " / " + this.kxP_hrDataSet.Attendance.Rows.Count;
        }
        // >> button 
        private void button9_Click(object sender, EventArgs e)
        {
            bmbAttendance.Position++;
            lblAttenNum.Text = (bmbAttendance.Position + 1) + " / " + this.kxP_hrDataSet.Attendance.Rows.Count;
        }
        // << button
        private void button11_Click(object sender, EventArgs e)
        {
            bmbAttendance.Position--;
            lblAttenNum.Text = (bmbAttendance.Position + 1) + " / " + this.kxP_hrDataSet.Attendance.Rows.Count;
        }
        // |<< button
        private void button10_Click(object sender, EventArgs e)
        {
            bmbAttendance.Position = 0;
            lblAttenNum.Text = (bmbAttendance.Position + 1) + " / " + this.kxP_hrDataSet.Attendance.Rows.Count;
        }

        #endregion
        

        private void label18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           
            frmEmpReports frmr = new frmEmpReports();
            frmr.ShowDialog();
        }





    }
}
