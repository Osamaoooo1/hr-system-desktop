namespace HR_ManagmentSystem
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmpNum = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSearchEmp = new DevComponents.DotNetBar.ButtonX();
            this.btnAddEmp = new DevComponents.DotNetBar.ButtonX();
            this.btnSaveChangesEmp = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdateEmp = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteEmp = new DevComponents.DotNetBar.ButtonX();
            this.cbOffice = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.officesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kxP_hrDataSet = new HR_ManagmentSystem.KxP_hrDataSet();
            this.cbReport = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.fkemployeesmanagersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJob = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalary = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBoxEmpImage = new System.Windows.Forms.PictureBox();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportstoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageempDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.cbStausAtten = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNoteAtten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAttenNum = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSearchAtten = new DevComponents.DotNetBar.ButtonX();
            this.btnAddAtten = new DevComponents.DotNetBar.ButtonX();
            this.btnSaveChangesAtten = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdateAtten = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteAtten = new DevComponents.DotNetBar.ButtonX();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpAttenDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cbEmpID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtAttenID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewX3 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.attendaceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSaveChangesOffice = new DevComponents.DotNetBar.ButtonX();
            this.btnAddOffice = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdateOffice = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteOffice = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOfficeNum = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOfficeState = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOfficeCity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.txtOfficeAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOfficeId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewX2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.officeidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.employeesTableAdapter = new HR_ManagmentSystem.KxP_hrDataSetTableAdapters.employeesTableAdapter();
            this.tableAdapterManager = new HR_ManagmentSystem.KxP_hrDataSetTableAdapters.TableAdapterManager();
            this.officesTableAdapter = new HR_ManagmentSystem.KxP_hrDataSetTableAdapters.officesTableAdapter();
            this.openImageEmp = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.attendanceTableAdapter = new HR_ManagmentSystem.KxP_hrDataSetTableAdapters.AttendanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kxP_hrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkemployeesmanagersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.tabControlPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            this.tabControlPanel2.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Location = new System.Drawing.Point(0, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1034, 533);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.tabControlPanel1.Controls.Add(this.label21);
            this.tabControlPanel1.Controls.Add(this.txtEmployeeId);
            this.tabControlPanel1.Controls.Add(this.panel1);
            this.tabControlPanel1.Controls.Add(this.groupPanel1);
            this.tabControlPanel1.Controls.Add(this.cbOffice);
            this.tabControlPanel1.Controls.Add(this.cbReport);
            this.tabControlPanel1.Controls.Add(this.label7);
            this.tabControlPanel1.Controls.Add(this.label6);
            this.tabControlPanel1.Controls.Add(this.label5);
            this.tabControlPanel1.Controls.Add(this.txtJob);
            this.tabControlPanel1.Controls.Add(this.label4);
            this.tabControlPanel1.Controls.Add(this.txtSalary);
            this.tabControlPanel1.Controls.Add(this.label3);
            this.tabControlPanel1.Controls.Add(this.txtLname);
            this.tabControlPanel1.Controls.Add(this.label2);
            this.tabControlPanel1.Controls.Add(this.label1);
            this.tabControlPanel1.Controls.Add(this.txtFname);
            this.tabControlPanel1.Controls.Add(this.pictureBoxEmpImage);
            this.tabControlPanel1.Controls.Add(this.dataGridViewX1);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 42);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlPanel1.Size = new System.Drawing.Size(1034, 491);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(942, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 25);
            this.label21.TabIndex = 25;
            this.label21.Text = ": رقم الموضف";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmployeeId
            // 
            // 
            // 
            // 
            this.txtEmployeeId.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtEmployeeId.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtEmployeeId.Border.BorderLeftWidth = 1;
            this.txtEmployeeId.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtEmployeeId.Border.BorderRightWidth = 1;
            this.txtEmployeeId.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtEmployeeId.Border.BorderTopWidth = 1;
            this.txtEmployeeId.Border.Class = "TextBoxBorder";
            this.txtEmployeeId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmployeeId.Border.PaddingBottom = 3;
            this.txtEmployeeId.Border.PaddingLeft = 3;
            this.txtEmployeeId.Border.PaddingRight = 3;
            this.txtEmployeeId.Border.PaddingTop = 3;
            this.txtEmployeeId.Border.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.txtEmployeeId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.Location = new System.Drawing.Point(650, 61);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.PreventEnterBeep = true;
            this.txtEmployeeId.ReadOnly = true;
            this.txtEmployeeId.Size = new System.Drawing.Size(287, 25);
            this.txtEmployeeId.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblEmpNum);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(648, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 35);
            this.panel1.TabIndex = 23;
            // 
            // lblEmpNum
            // 
            this.lblEmpNum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNum.Location = new System.Drawing.Point(143, 3);
            this.lblEmpNum.Name = "lblEmpNum";
            this.lblEmpNum.Size = new System.Drawing.Size(87, 29);
            this.lblEmpNum.TabIndex = 24;
            this.lblEmpNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Image = global::HR_ManagmentSystem.Properties.Resources.Next_16x16;
            this.button4.Location = new System.Drawing.Point(250, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 29);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::HR_ManagmentSystem.Properties.Resources.DoubleFirst_32x32;
            this.button3.Location = new System.Drawing.Point(13, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 29);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::HR_ManagmentSystem.Properties.Resources.Prev_16x16;
            this.button2.Location = new System.Drawing.Point(74, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 29);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::HR_ManagmentSystem.Properties.Resources.DoubleLast_32x32;
            this.button1.Location = new System.Drawing.Point(306, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 29);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnSearchEmp);
            this.groupPanel1.Controls.Add(this.btnAddEmp);
            this.groupPanel1.Controls.Add(this.btnSaveChangesEmp);
            this.groupPanel1.Controls.Add(this.btnUpdateEmp);
            this.groupPanel1.Controls.Add(this.btnDeleteEmp);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(648, 338);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupPanel1.Size = new System.Drawing.Size(378, 141);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 22;
            this.groupPanel1.Text = "الإجراءات";
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchEmp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchEmp.Image = global::HR_ManagmentSystem.Properties.Resources.table_tab_search;
            this.btnSearchEmp.Location = new System.Drawing.Point(200, 62);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(158, 45);
            this.btnSearchEmp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchEmp.TabIndex = 25;
            this.btnSearchEmp.Text = "بحث";
            this.btnSearchEmp.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddEmp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddEmp.Image = global::HR_ManagmentSystem.Properties.Resources.add;
            this.btnAddEmp.Location = new System.Drawing.Point(10, 62);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(179, 45);
            this.btnAddEmp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddEmp.TabIndex = 24;
            this.btnAddEmp.Text = "سجل جديد";
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnSaveChangesEmp
            // 
            this.btnSaveChangesEmp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveChangesEmp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveChangesEmp.Image = global::HR_ManagmentSystem.Properties.Resources.disk;
            this.btnSaveChangesEmp.Location = new System.Drawing.Point(10, 7);
            this.btnSaveChangesEmp.Name = "btnSaveChangesEmp";
            this.btnSaveChangesEmp.Size = new System.Drawing.Size(111, 43);
            this.btnSaveChangesEmp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveChangesEmp.TabIndex = 2;
            this.btnSaveChangesEmp.Text = "حفظ";
            this.btnSaveChangesEmp.Click += new System.EventHandler(this.btnSaveChangesEmp_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdateEmp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdateEmp.Image = global::HR_ManagmentSystem.Properties.Resources.gear_in;
            this.btnUpdateEmp.Location = new System.Drawing.Point(130, 7);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(108, 43);
            this.btnUpdateEmp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdateEmp.TabIndex = 1;
            this.btnUpdateEmp.Text = "تعديل";
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteEmp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteEmp.Image = global::HR_ManagmentSystem.Properties.Resources.delete;
            this.btnDeleteEmp.Location = new System.Drawing.Point(247, 7);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(111, 43);
            this.btnDeleteEmp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteEmp.TabIndex = 0;
            this.btnDeleteEmp.Text = "حذف";
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // cbOffice
            // 
            this.cbOffice.DataSource = this.officesBindingSource;
            this.cbOffice.DisplayMember = "office_id";
            this.cbOffice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOffice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOffice.FormattingEnabled = true;
            this.cbOffice.ItemHeight = 18;
            this.cbOffice.Location = new System.Drawing.Point(648, 258);
            this.cbOffice.Name = "cbOffice";
            this.cbOffice.Size = new System.Drawing.Size(98, 24);
            this.cbOffice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbOffice.TabIndex = 17;
            // 
            // officesBindingSource
            // 
            this.officesBindingSource.DataMember = "offices";
            this.officesBindingSource.DataSource = this.kxP_hrDataSet;
            // 
            // kxP_hrDataSet
            // 
            this.kxP_hrDataSet.DataSetName = "KxP_hrDataSet";
            this.kxP_hrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbReport
            // 
            this.cbReport.DataSource = this.fkemployeesmanagersBindingSource;
            this.cbReport.DisplayMember = "employee_id";
            this.cbReport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbReport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReport.FormattingEnabled = true;
            this.cbReport.ItemHeight = 18;
            this.cbReport.Location = new System.Drawing.Point(839, 259);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(97, 24);
            this.cbReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbReport.TabIndex = 16;
            // 
            // fkemployeesmanagersBindingSource
            // 
            this.fkemployeesmanagersBindingSource.DataMember = "fk_employees_managers";
            this.fkemployeesmanagersBindingSource.DataSource = this.employeesBindingSource;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.kxP_hrDataSet;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(752, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = ":      القسم";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(942, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = ": رقم المدير";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(942, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = " :      الوضيفة";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtJob
            // 
            // 
            // 
            // 
            this.txtJob.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtJob.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtJob.Border.BorderLeftWidth = 1;
            this.txtJob.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtJob.Border.BorderRightWidth = 1;
            this.txtJob.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtJob.Border.BorderTopWidth = 1;
            this.txtJob.Border.Class = "TextBoxBorder";
            this.txtJob.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtJob.Border.PaddingBottom = 3;
            this.txtJob.Border.PaddingLeft = 3;
            this.txtJob.Border.PaddingRight = 3;
            this.txtJob.Border.PaddingTop = 3;
            this.txtJob.Border.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.txtJob.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.Location = new System.Drawing.Point(649, 222);
            this.txtJob.Name = "txtJob";
            this.txtJob.PreventEnterBeep = true;
            this.txtJob.Size = new System.Drawing.Size(288, 25);
            this.txtJob.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(943, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = " :         الراتب";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSalary
            // 
            // 
            // 
            // 
            this.txtSalary.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSalary.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSalary.Border.BorderLeftWidth = 1;
            this.txtSalary.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSalary.Border.BorderRightWidth = 1;
            this.txtSalary.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSalary.Border.BorderTopWidth = 1;
            this.txtSalary.Border.Class = "TextBoxBorder";
            this.txtSalary.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSalary.Border.PaddingBottom = 3;
            this.txtSalary.Border.PaddingLeft = 3;
            this.txtSalary.Border.PaddingRight = 3;
            this.txtSalary.Border.PaddingTop = 3;
            this.txtSalary.Border.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.txtSalary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(782, 183);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PreventEnterBeep = true;
            this.txtSalary.Size = new System.Drawing.Size(155, 25);
            this.txtSalary.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(942, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = ":الإسم الثاني";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLname
            // 
            // 
            // 
            // 
            this.txtLname.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtLname.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtLname.Border.BorderLeftWidth = 1;
            this.txtLname.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtLname.Border.BorderRightWidth = 1;
            this.txtLname.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtLname.Border.BorderTopWidth = 1;
            this.txtLname.Border.Class = "TextBoxBorder";
            this.txtLname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLname.Border.PaddingBottom = 3;
            this.txtLname.Border.PaddingLeft = 3;
            this.txtLname.Border.PaddingRight = 3;
            this.txtLname.Border.PaddingTop = 3;
            this.txtLname.Border.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.txtLname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(782, 141);
            this.txtLname.Name = "txtLname";
            this.txtLname.PreventEnterBeep = true;
            this.txtLname.Size = new System.Drawing.Size(155, 25);
            this.txtLname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(943, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = " : الإسم الأول";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(734, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "سجلات الموضفين";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFname
            // 
            // 
            // 
            // 
            this.txtFname.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtFname.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtFname.Border.BorderLeftWidth = 1;
            this.txtFname.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtFname.Border.BorderRightWidth = 1;
            this.txtFname.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtFname.Border.BorderTopWidth = 1;
            this.txtFname.Border.Class = "TextBoxBorder";
            this.txtFname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFname.Border.PaddingBottom = 3;
            this.txtFname.Border.PaddingLeft = 3;
            this.txtFname.Border.PaddingRight = 3;
            this.txtFname.Border.PaddingTop = 3;
            this.txtFname.Border.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.txtFname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(782, 97);
            this.txtFname.Name = "txtFname";
            this.txtFname.PreventEnterBeep = true;
            this.txtFname.Size = new System.Drawing.Size(155, 25);
            this.txtFname.TabIndex = 3;
            // 
            // pictureBoxEmpImage
            // 
            this.pictureBoxEmpImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.employeesBindingSource, "image_emp", true));
            this.pictureBoxEmpImage.Location = new System.Drawing.Point(648, 97);
            this.pictureBoxEmpImage.Name = "pictureBoxEmpImage";
            this.pictureBoxEmpImage.Size = new System.Drawing.Size(127, 112);
            this.pictureBoxEmpImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmpImage.TabIndex = 2;
            this.pictureBoxEmpImage.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxEmpImage, "أنقر لإضافة صورة");
            this.pictureBoxEmpImage.Click += new System.EventHandler(this.pictureBoxEmpImage_Click);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.ColumnHeadersHeight = 29;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.jobtitleDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.reportstoDataGridViewTextBoxColumn,
            this.officeidDataGridViewTextBoxColumn,
            this.imageempDataGridViewImageColumn});
            this.dataGridViewX1.DataSource = this.employeesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(644, 489);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // jobtitleDataGridViewTextBoxColumn
            // 
            this.jobtitleDataGridViewTextBoxColumn.DataPropertyName = "job_title";
            this.jobtitleDataGridViewTextBoxColumn.HeaderText = "job_title";
            this.jobtitleDataGridViewTextBoxColumn.Name = "jobtitleDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // reportstoDataGridViewTextBoxColumn
            // 
            this.reportstoDataGridViewTextBoxColumn.DataPropertyName = "reports_to";
            this.reportstoDataGridViewTextBoxColumn.HeaderText = "reports_to";
            this.reportstoDataGridViewTextBoxColumn.Name = "reportstoDataGridViewTextBoxColumn";
            // 
            // officeidDataGridViewTextBoxColumn
            // 
            this.officeidDataGridViewTextBoxColumn.DataPropertyName = "office_id";
            this.officeidDataGridViewTextBoxColumn.HeaderText = "office_id";
            this.officeidDataGridViewTextBoxColumn.Name = "officeidDataGridViewTextBoxColumn";
            // 
            // imageempDataGridViewImageColumn
            // 
            this.imageempDataGridViewImageColumn.DataPropertyName = "image_emp";
            this.imageempDataGridViewImageColumn.HeaderText = "image_emp";
            this.imageempDataGridViewImageColumn.Name = "imageempDataGridViewImageColumn";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Image = global::HR_ManagmentSystem.Properties.Resources.BO_Customer_32x32;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "الموظفين";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.label20);
            this.tabControlPanel3.Controls.Add(this.cbStausAtten);
            this.tabControlPanel3.Controls.Add(this.label19);
            this.tabControlPanel3.Controls.Add(this.txtNoteAtten);
            this.tabControlPanel3.Controls.Add(this.panel3);
            this.tabControlPanel3.Controls.Add(this.groupPanel3);
            this.tabControlPanel3.Controls.Add(this.label15);
            this.tabControlPanel3.Controls.Add(this.dtpAttenDate);
            this.tabControlPanel3.Controls.Add(this.label14);
            this.tabControlPanel3.Controls.Add(this.cbEmpID);
            this.tabControlPanel3.Controls.Add(this.txtAttenID);
            this.tabControlPanel3.Controls.Add(this.label13);
            this.tabControlPanel3.Controls.Add(this.dataGridViewX3);
            this.tabControlPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 42);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(1034, 491);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 9;
            this.tabControlPanel3.TabItem = this.tabItem3;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(886, 154);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 27);
            this.label20.TabIndex = 31;
            this.label20.Text = " الحالة        :   ";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbStausAtten
            // 
            this.cbStausAtten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbStausAtten.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStausAtten.FormattingEnabled = true;
            this.cbStausAtten.Items.AddRange(new object[] {
            "حاضر",
            "غائب",
            "إجازة"});
            this.cbStausAtten.Location = new System.Drawing.Point(886, 193);
            this.cbStausAtten.Name = "cbStausAtten";
            this.cbStausAtten.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbStausAtten.Size = new System.Drawing.Size(124, 24);
            this.cbStausAtten.TabIndex = 30;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(736, 1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(183, 37);
            this.label19.TabIndex = 29;
            this.label19.Text = "التحضير";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNoteAtten
            // 
            // 
            // 
            // 
            this.txtNoteAtten.Border.Class = "TextBoxBorder";
            this.txtNoteAtten.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNoteAtten.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteAtten.Location = new System.Drawing.Point(626, 154);
            this.txtNoteAtten.Multiline = true;
            this.txtNoteAtten.Name = "txtNoteAtten";
            this.txtNoteAtten.PreventEnterBeep = true;
            this.txtNoteAtten.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNoteAtten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoteAtten.Size = new System.Drawing.Size(240, 63);
            this.txtNoteAtten.TabIndex = 28;
            this.txtNoteAtten.WatermarkFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteAtten.WatermarkText = "ملاحضات";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.lblAttenNum);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Location = new System.Drawing.Point(626, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 35);
            this.panel3.TabIndex = 27;
            // 
            // lblAttenNum
            // 
            this.lblAttenNum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttenNum.Location = new System.Drawing.Point(153, 3);
            this.lblAttenNum.Name = "lblAttenNum";
            this.lblAttenNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAttenNum.Size = new System.Drawing.Size(87, 29);
            this.lblAttenNum.TabIndex = 24;
            this.lblAttenNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button9
            // 
            this.button9.Image = global::HR_ManagmentSystem.Properties.Resources.Next_16x16;
            this.button9.Location = new System.Drawing.Point(250, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 29);
            this.button9.TabIndex = 3;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Image = global::HR_ManagmentSystem.Properties.Resources.DoubleFirst_32x32;
            this.button10.Location = new System.Drawing.Point(13, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 29);
            this.button10.TabIndex = 2;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Image = global::HR_ManagmentSystem.Properties.Resources.Prev_16x16;
            this.button11.Location = new System.Drawing.Point(74, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 29);
            this.button11.TabIndex = 1;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Image = global::HR_ManagmentSystem.Properties.Resources.DoubleLast_32x32;
            this.button12.Location = new System.Drawing.Point(306, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 29);
            this.button12.TabIndex = 0;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.btnSearchAtten);
            this.groupPanel3.Controls.Add(this.btnAddAtten);
            this.groupPanel3.Controls.Add(this.btnSaveChangesAtten);
            this.groupPanel3.Controls.Add(this.btnUpdateAtten);
            this.groupPanel3.Controls.Add(this.btnDeleteAtten);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel3.Location = new System.Drawing.Point(626, 273);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(384, 135);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 26;
            this.groupPanel3.Text = "الإجراءات";
            // 
            // btnSearchAtten
            // 
            this.btnSearchAtten.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchAtten.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchAtten.Image = global::HR_ManagmentSystem.Properties.Resources.table_tab_search;
            this.btnSearchAtten.Location = new System.Drawing.Point(200, 56);
            this.btnSearchAtten.Name = "btnSearchAtten";
            this.btnSearchAtten.Size = new System.Drawing.Size(158, 45);
            this.btnSearchAtten.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchAtten.TabIndex = 28;
            this.btnSearchAtten.Text = "بحث";
            this.btnSearchAtten.Click += new System.EventHandler(this.btnSearchAtten_Click);
            // 
            // btnAddAtten
            // 
            this.btnAddAtten.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddAtten.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddAtten.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAtten.Image = global::HR_ManagmentSystem.Properties.Resources.add;
            this.btnAddAtten.Location = new System.Drawing.Point(10, 56);
            this.btnAddAtten.Name = "btnAddAtten";
            this.btnAddAtten.Size = new System.Drawing.Size(184, 45);
            this.btnAddAtten.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddAtten.TabIndex = 27;
            this.btnAddAtten.Text = "سجل جديد";
            this.btnAddAtten.Click += new System.EventHandler(this.btnAddAtten_Click);
            // 
            // btnSaveChangesAtten
            // 
            this.btnSaveChangesAtten.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveChangesAtten.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveChangesAtten.Image = global::HR_ManagmentSystem.Properties.Resources.disk;
            this.btnSaveChangesAtten.Location = new System.Drawing.Point(10, 7);
            this.btnSaveChangesAtten.Name = "btnSaveChangesAtten";
            this.btnSaveChangesAtten.Size = new System.Drawing.Size(111, 43);
            this.btnSaveChangesAtten.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveChangesAtten.TabIndex = 2;
            this.btnSaveChangesAtten.Text = "حفظ";
            this.btnSaveChangesAtten.Click += new System.EventHandler(this.btnSaveChangesAtten_Click);
            // 
            // btnUpdateAtten
            // 
            this.btnUpdateAtten.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdateAtten.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdateAtten.Image = global::HR_ManagmentSystem.Properties.Resources.gear_in;
            this.btnUpdateAtten.Location = new System.Drawing.Point(130, 7);
            this.btnUpdateAtten.Name = "btnUpdateAtten";
            this.btnUpdateAtten.Size = new System.Drawing.Size(108, 43);
            this.btnUpdateAtten.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdateAtten.TabIndex = 1;
            this.btnUpdateAtten.Text = "تعديل";
            this.btnUpdateAtten.Click += new System.EventHandler(this.btnUpdateAtten_Click);
            // 
            // btnDeleteAtten
            // 
            this.btnDeleteAtten.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteAtten.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteAtten.Image = global::HR_ManagmentSystem.Properties.Resources.delete;
            this.btnDeleteAtten.Location = new System.Drawing.Point(247, 7);
            this.btnDeleteAtten.Name = "btnDeleteAtten";
            this.btnDeleteAtten.Size = new System.Drawing.Size(111, 43);
            this.btnDeleteAtten.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteAtten.TabIndex = 0;
            this.btnDeleteAtten.Text = "حذف";
            this.btnDeleteAtten.Click += new System.EventHandler(this.btnDeleteAtten_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(922, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 27);
            this.label15.TabIndex = 20;
            this.label15.Text = "التاريخ اليومي:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpAttenDate
            // 
            this.dtpAttenDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAttenDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAttenDate.Location = new System.Drawing.Point(626, 115);
            this.dtpAttenDate.Name = "dtpAttenDate";
            this.dtpAttenDate.Size = new System.Drawing.Size(290, 26);
            this.dtpAttenDate.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(736, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 26);
            this.label14.TabIndex = 18;
            this.label14.Text = "الموضف   :  ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbEmpID
            // 
            this.cbEmpID.DataSource = this.employeesBindingSource;
            this.cbEmpID.DisplayMember = "employee_id";
            this.cbEmpID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEmpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpID.FormattingEnabled = true;
            this.cbEmpID.ItemHeight = 21;
            this.cbEmpID.Location = new System.Drawing.Point(625, 73);
            this.cbEmpID.Name = "cbEmpID";
            this.cbEmpID.Size = new System.Drawing.Size(105, 27);
            this.cbEmpID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEmpID.TabIndex = 17;
            // 
            // txtAttenID
            // 
            // 
            // 
            // 
            this.txtAttenID.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAttenID.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAttenID.Border.BorderLeftWidth = 1;
            this.txtAttenID.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAttenID.Border.BorderRightWidth = 1;
            this.txtAttenID.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAttenID.Border.BorderTopWidth = 1;
            this.txtAttenID.Border.Class = "TextBoxBorder";
            this.txtAttenID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAttenID.Border.PaddingBottom = 3;
            this.txtAttenID.Border.PaddingLeft = 3;
            this.txtAttenID.Border.PaddingRight = 3;
            this.txtAttenID.Border.PaddingTop = 3;
            this.txtAttenID.Border.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.txtAttenID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttenID.Location = new System.Drawing.Point(817, 73);
            this.txtAttenID.Name = "txtAttenID";
            this.txtAttenID.PreventEnterBeep = true;
            this.txtAttenID.ReadOnly = true;
            this.txtAttenID.Size = new System.Drawing.Size(98, 28);
            this.txtAttenID.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(921, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 24);
            this.label13.TabIndex = 8;
            this.label13.Text = "معرف الحضور : ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewX3
            // 
            this.dataGridViewX3.AutoGenerateColumns = false;
            this.dataGridViewX3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX3.ColumnHeadersHeight = 29;
            this.dataGridViewX3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewX3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendaceIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridViewX3.DataSource = this.attendanceBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX3.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewX3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX3.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewX3.Name = "dataGridViewX3";
            this.dataGridViewX3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewX3.RowHeadersWidth = 40;
            this.dataGridViewX3.Size = new System.Drawing.Size(616, 489);
            this.dataGridViewX3.TabIndex = 2;
            // 
            // attendaceIDDataGridViewTextBoxColumn
            // 
            this.attendaceIDDataGridViewTextBoxColumn.DataPropertyName = "attendaceID";
            this.attendaceIDDataGridViewTextBoxColumn.HeaderText = "attendaceID";
            this.attendaceIDDataGridViewTextBoxColumn.Name = "attendaceIDDataGridViewTextBoxColumn";
            this.attendaceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn1
            // 
            this.employeeIDDataGridViewTextBoxColumn1.DataPropertyName = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn1.HeaderText = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn1.Name = "employeeIDDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.kxP_hrDataSet;
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Image = global::HR_ManagmentSystem.Properties.Resources.date_task;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "الحضور";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.label12);
            this.tabControlPanel2.Controls.Add(this.groupPanel2);
            this.tabControlPanel2.Controls.Add(this.panel2);
            this.tabControlPanel2.Controls.Add(this.label11);
            this.tabControlPanel2.Controls.Add(this.txtOfficeState);
            this.tabControlPanel2.Controls.Add(this.label10);
            this.tabControlPanel2.Controls.Add(this.txtOfficeCity);
            this.tabControlPanel2.Controls.Add(this.line1);
            this.tabControlPanel2.Controls.Add(this.txtOfficeAddress);
            this.tabControlPanel2.Controls.Add(this.label9);
            this.tabControlPanel2.Controls.Add(this.txtOfficeId);
            this.tabControlPanel2.Controls.Add(this.label8);
            this.tabControlPanel2.Controls.Add(this.dataGridViewX2);
            this.tabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 42);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(1034, 491);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 16;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(733, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 37);
            this.label12.TabIndex = 27;
            this.label12.Text = "بيانات الأقسام";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnSaveChangesOffice);
            this.groupPanel2.Controls.Add(this.btnAddOffice);
            this.groupPanel2.Controls.Add(this.btnUpdateOffice);
            this.groupPanel2.Controls.Add(this.btnDeleteOffice);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(610, 225);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(384, 135);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 25;
            this.groupPanel2.Text = "الإجراءات";
            // 
            // btnSaveChangesOffice
            // 
            this.btnSaveChangesOffice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveChangesOffice.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveChangesOffice.Image = global::HR_ManagmentSystem.Properties.Resources.disk;
            this.btnSaveChangesOffice.Location = new System.Drawing.Point(10, 7);
            this.btnSaveChangesOffice.Name = "btnSaveChangesOffice";
            this.btnSaveChangesOffice.Size = new System.Drawing.Size(111, 43);
            this.btnSaveChangesOffice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveChangesOffice.TabIndex = 2;
            this.btnSaveChangesOffice.Text = "حفظ";
            this.btnSaveChangesOffice.Click += new System.EventHandler(this.btnSaveChangesOffice_Click);
            // 
            // btnAddOffice
            // 
            this.btnAddOffice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddOffice.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddOffice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOffice.Image = global::HR_ManagmentSystem.Properties.Resources.add;
            this.btnAddOffice.Location = new System.Drawing.Point(10, 64);
            this.btnAddOffice.Name = "btnAddOffice";
            this.btnAddOffice.Size = new System.Drawing.Size(348, 45);
            this.btnAddOffice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddOffice.TabIndex = 26;
            this.btnAddOffice.Text = "سجل جديد";
            this.btnAddOffice.Click += new System.EventHandler(this.btnAddOffice_Click);
            // 
            // btnUpdateOffice
            // 
            this.btnUpdateOffice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdateOffice.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdateOffice.Image = global::HR_ManagmentSystem.Properties.Resources.gear_in;
            this.btnUpdateOffice.Location = new System.Drawing.Point(130, 7);
            this.btnUpdateOffice.Name = "btnUpdateOffice";
            this.btnUpdateOffice.Size = new System.Drawing.Size(108, 43);
            this.btnUpdateOffice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdateOffice.TabIndex = 1;
            this.btnUpdateOffice.Text = "تعديل";
            this.btnUpdateOffice.Click += new System.EventHandler(this.btnUpdateOffice_Click);
            // 
            // btnDeleteOffice
            // 
            this.btnDeleteOffice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteOffice.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteOffice.Image = global::HR_ManagmentSystem.Properties.Resources.delete;
            this.btnDeleteOffice.Location = new System.Drawing.Point(247, 7);
            this.btnDeleteOffice.Name = "btnDeleteOffice";
            this.btnDeleteOffice.Size = new System.Drawing.Size(111, 43);
            this.btnDeleteOffice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteOffice.TabIndex = 0;
            this.btnDeleteOffice.Text = "حذف";
            this.btnDeleteOffice.Click += new System.EventHandler(this.btnDeleteOffice_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblOfficeNum);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Location = new System.Drawing.Point(610, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 35);
            this.panel2.TabIndex = 24;
            // 
            // lblOfficeNum
            // 
            this.lblOfficeNum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfficeNum.Location = new System.Drawing.Point(143, 3);
            this.lblOfficeNum.Name = "lblOfficeNum";
            this.lblOfficeNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOfficeNum.Size = new System.Drawing.Size(87, 29);
            this.lblOfficeNum.TabIndex = 24;
            this.lblOfficeNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Image = global::HR_ManagmentSystem.Properties.Resources.Next_16x16;
            this.button5.Location = new System.Drawing.Point(250, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 29);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Image = global::HR_ManagmentSystem.Properties.Resources.DoubleFirst_32x32;
            this.button6.Location = new System.Drawing.Point(13, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 29);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Image = global::HR_ManagmentSystem.Properties.Resources.Prev_16x16;
            this.button7.Location = new System.Drawing.Point(74, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 29);
            this.button7.TabIndex = 1;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Image = global::HR_ManagmentSystem.Properties.Resources.DoubleLast_32x32;
            this.button8.Location = new System.Drawing.Point(306, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 29);
            this.button8.TabIndex = 0;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(750, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "الولاية : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOfficeState
            // 
            // 
            // 
            // 
            this.txtOfficeState.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeState.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeState.Border.BorderLeftWidth = 1;
            this.txtOfficeState.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeState.Border.BorderRightWidth = 1;
            this.txtOfficeState.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeState.Border.BorderTopWidth = 1;
            this.txtOfficeState.Border.Class = "TextBoxBorder";
            this.txtOfficeState.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOfficeState.Border.PaddingBottom = 3;
            this.txtOfficeState.Border.PaddingLeft = 3;
            this.txtOfficeState.Border.PaddingRight = 3;
            this.txtOfficeState.Border.PaddingTop = 3;
            this.txtOfficeState.Border.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.txtOfficeState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfficeState.Location = new System.Drawing.Point(610, 63);
            this.txtOfficeState.Name = "txtOfficeState";
            this.txtOfficeState.PreventEnterBeep = true;
            this.txtOfficeState.Size = new System.Drawing.Size(134, 25);
            this.txtOfficeState.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(907, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "المدينة      : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOfficeCity
            // 
            // 
            // 
            // 
            this.txtOfficeCity.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeCity.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeCity.Border.BorderLeftWidth = 1;
            this.txtOfficeCity.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeCity.Border.BorderRightWidth = 1;
            this.txtOfficeCity.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeCity.Border.BorderTopWidth = 1;
            this.txtOfficeCity.Border.Class = "TextBoxBorder";
            this.txtOfficeCity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOfficeCity.Border.PaddingBottom = 3;
            this.txtOfficeCity.Border.PaddingLeft = 3;
            this.txtOfficeCity.Border.PaddingRight = 3;
            this.txtOfficeCity.Border.PaddingTop = 3;
            this.txtOfficeCity.Border.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.txtOfficeCity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfficeCity.Location = new System.Drawing.Point(610, 143);
            this.txtOfficeCity.Name = "txtOfficeCity";
            this.txtOfficeCity.PreventEnterBeep = true;
            this.txtOfficeCity.Size = new System.Drawing.Size(291, 25);
            this.txtOfficeCity.TabIndex = 11;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.line1.Location = new System.Drawing.Point(558, -1);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 502);
            this.line1.TabIndex = 10;
            this.line1.Text = "line1";
            this.line1.VerticalLine = true;
            // 
            // txtOfficeAddress
            // 
            // 
            // 
            // 
            this.txtOfficeAddress.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeAddress.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeAddress.Border.BorderLeftWidth = 1;
            this.txtOfficeAddress.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeAddress.Border.BorderRightWidth = 1;
            this.txtOfficeAddress.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeAddress.Border.BorderTopWidth = 1;
            this.txtOfficeAddress.Border.Class = "TextBoxBorder";
            this.txtOfficeAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOfficeAddress.Border.PaddingBottom = 3;
            this.txtOfficeAddress.Border.PaddingLeft = 3;
            this.txtOfficeAddress.Border.PaddingRight = 3;
            this.txtOfficeAddress.Border.PaddingTop = 3;
            this.txtOfficeAddress.Border.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.txtOfficeAddress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfficeAddress.Location = new System.Drawing.Point(610, 102);
            this.txtOfficeAddress.Name = "txtOfficeAddress";
            this.txtOfficeAddress.PreventEnterBeep = true;
            this.txtOfficeAddress.Size = new System.Drawing.Size(291, 25);
            this.txtOfficeAddress.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(907, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "إسم القسم : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOfficeId
            // 
            // 
            // 
            // 
            this.txtOfficeId.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeId.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeId.Border.BorderLeftWidth = 1;
            this.txtOfficeId.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeId.Border.BorderRightWidth = 1;
            this.txtOfficeId.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOfficeId.Border.BorderTopWidth = 1;
            this.txtOfficeId.Border.Class = "TextBoxBorder";
            this.txtOfficeId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOfficeId.Border.PaddingBottom = 3;
            this.txtOfficeId.Border.PaddingLeft = 3;
            this.txtOfficeId.Border.PaddingRight = 3;
            this.txtOfficeId.Border.PaddingTop = 3;
            this.txtOfficeId.Border.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.txtOfficeId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfficeId.Location = new System.Drawing.Point(807, 63);
            this.txtOfficeId.Name = "txtOfficeId";
            this.txtOfficeId.PreventEnterBeep = true;
            this.txtOfficeId.ReadOnly = true;
            this.txtOfficeId.Size = new System.Drawing.Size(94, 25);
            this.txtOfficeId.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(907, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "رقم القسم   :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewX2
            // 
            this.dataGridViewX2.AutoGenerateColumns = false;
            this.dataGridViewX2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX2.ColumnHeadersHeight = 29;
            this.dataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewX2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.officeidDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.dataGridViewX2.DataSource = this.officesBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewX2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewX2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX2.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewX2.Name = "dataGridViewX2";
            this.dataGridViewX2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewX2.RowHeadersWidth = 40;
            this.dataGridViewX2.Size = new System.Drawing.Size(551, 489);
            this.dataGridViewX2.TabIndex = 1;
            // 
            // officeidDataGridViewTextBoxColumn1
            // 
            this.officeidDataGridViewTextBoxColumn1.DataPropertyName = "office_id";
            this.officeidDataGridViewTextBoxColumn1.HeaderText = "office_id";
            this.officeidDataGridViewTextBoxColumn1.Name = "officeidDataGridViewTextBoxColumn1";
            this.officeidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Image = global::HR_ManagmentSystem.Properties.Resources.building;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "الأقسام";
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.officesTableAdapter = this.officesTableAdapter;
            this.tableAdapterManager.UpdateOrder = HR_ManagmentSystem.KxP_hrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // officesTableAdapter
            // 
            this.officesTableAdapter.ClearBeforeFill = true;
            // 
            // openImageEmp
            // 
            this.openImageEmp.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Image = global::HR_ManagmentSystem.Properties.Resources.Action_Cancel;
            this.label18.Location = new System.Drawing.Point(12, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 35);
            this.label18.TabIndex = 26;
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label18, "تسجيل الخروج");
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(408, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(361, 43);
            this.label16.TabIndex = 6;
            this.label16.Text = " Human Resource Management";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Image = global::HR_ManagmentSystem.Properties.Resources.desk__1_;
            this.label17.Location = new System.Drawing.Point(361, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 43);
            this.label17.TabIndex = 25;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 597);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج إدارة الموارد البشرية";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kxP_hrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkemployeesmanagersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.tabControlPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            this.tabControlPanel2.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private KxP_hrDataSet kxP_hrDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private KxP_hrDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportstoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageempDataGridViewImageColumn;
        private System.Windows.Forms.PictureBox pictureBoxEmpImage;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFname;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtJob;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbOffice;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbReport;
        private KxP_hrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private KxP_hrDataSetTableAdapters.officesTableAdapter officesTableAdapter;
        private System.Windows.Forms.BindingSource officesBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblEmpNum;
        private DevComponents.DotNetBar.ButtonX btnDeleteEmp;
        private DevComponents.DotNetBar.ButtonX btnUpdateEmp;
        private DevComponents.DotNetBar.ButtonX btnAddEmp;
        private DevComponents.DotNetBar.ButtonX btnSaveChangesEmp;
        private System.Windows.Forms.BindingSource fkemployeesmanagersBindingSource;
        private System.Windows.Forms.OpenFileDialog openImageEmp;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOfficeAddress;
        private System.Windows.Forms.Label label9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOfficeId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOfficeState;
        private System.Windows.Forms.Label label10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOfficeCity;
        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOfficeNum;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private DevComponents.DotNetBar.ButtonX btnAddOffice;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnSaveChangesOffice;
        private DevComponents.DotNetBar.ButtonX btnUpdateOffice;
        private DevComponents.DotNetBar.ButtonX btnDeleteOffice;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpAttenDate;
        private System.Windows.Forms.Label label14;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbEmpID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAttenID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX btnSaveChangesAtten;
        private DevComponents.DotNetBar.ButtonX btnUpdateAtten;
        private DevComponents.DotNetBar.ButtonX btnDeleteAtten;
        private DevComponents.DotNetBar.ButtonX btnAddAtten;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAttenNum;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNoteAtten;
     //   private System.Windows.Forms.DataGridViewTextBoxColumn attendanceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbStausAtten;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private KxP_hrDataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendaceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ButtonX btnSearchEmp;
        private DevComponents.DotNetBar.ButtonX btnSearchAtten;
        private System.Windows.Forms.Label label21;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmployeeId;

    }
}