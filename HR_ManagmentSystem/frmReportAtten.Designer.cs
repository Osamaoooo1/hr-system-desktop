namespace HR_ManagmentSystem
{
    partial class frmReportAtten
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportAtten));
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cbEmpID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dtAttenDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.listBoxItem1 = new DevComponents.DotNetBar.ListBoxItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintReport = new DevComponents.DotNetBar.ButtonX();
            this.btnSearchEmp = new DevComponents.DotNetBar.ButtonX();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAttenDate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(24, 194);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(127, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "نتائج البحث   :  ";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(24, 223);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(875, 365);
            this.dataGridViewX1.TabIndex = 4;
            // 
            // cbEmpID
            // 
            this.cbEmpID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEmpID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpID.FormattingEnabled = true;
            this.cbEmpID.ItemHeight = 21;
            this.cbEmpID.Location = new System.Drawing.Point(179, 57);
            this.cbEmpID.Name = "cbEmpID";
            this.cbEmpID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbEmpID.Size = new System.Drawing.Size(248, 27);
            this.cbEmpID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEmpID.TabIndex = 18;
            // 
            // dtAttenDate
            // 
            // 
            // 
            // 
            this.dtAttenDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtAttenDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAttenDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtAttenDate.ButtonDropDown.Visible = true;
            this.dtAttenDate.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dtAttenDate.IsPopupCalendarOpen = false;
            this.dtAttenDate.Location = new System.Drawing.Point(179, 105);
            this.dtAttenDate.MaxDate = new System.DateTime(2025, 12, 1, 0, 0, 0, 0);
            this.dtAttenDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtAttenDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAttenDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtAttenDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtAttenDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtAttenDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtAttenDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtAttenDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtAttenDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtAttenDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtAttenDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAttenDate.MonthCalendar.DisplayMonth = new System.DateTime(2024, 7, 1, 0, 0, 0, 0);
            this.dtAttenDate.MonthCalendar.MonthSelectionMode = true;
            // 
            // 
            // 
            this.dtAttenDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtAttenDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtAttenDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtAttenDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAttenDate.MonthCalendar.TodayButtonVisible = true;
            this.dtAttenDate.Name = "dtAttenDate";
            this.dtAttenDate.Size = new System.Drawing.Size(248, 25);
            this.dtAttenDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtAttenDate.TabIndex = 20;
            this.dtAttenDate.TimeSelectorType = DevComponents.Editors.DateTimeAdv.eTimeSelectorType.TouchStyle;
            // 
            // listBoxItem1
            // 
            this.listBoxItem1.Name = "listBoxItem1";
            this.listBoxItem1.Text = "Item 1";
            // 
            // btnExit
            // 
            this.btnExit.AutoEllipsis = true;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExit.Image = global::HR_ManagmentSystem.Properties.Resources.Action_Cancel;
            this.btnExit.Location = new System.Drawing.Point(530, 608);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 47);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "رجوع               ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintReport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Image = global::HR_ManagmentSystem.Properties.Resources.Action_Printing_Print_32x32;
            this.btnPrintReport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnPrintReport.Location = new System.Drawing.Point(206, 608);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(244, 47);
            this.btnPrintReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrintReport.TabIndex = 25;
            this.btnPrintReport.Text = "طباعة نتائج البحث";
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchEmp.AutoExpandOnClick = true;
            this.btnSearchEmp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchEmp.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnSearchEmp.Image = global::HR_ManagmentSystem.Properties.Resources.Action_Search;
            this.btnSearchEmp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnSearchEmp.Location = new System.Drawing.Point(179, 147);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(13);
            this.btnSearchEmp.Size = new System.Drawing.Size(248, 40);
            this.btnSearchEmp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchEmp.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem2});
            this.btnSearchEmp.TabIndex = 24;
            this.btnSearchEmp.Text = "بحث";
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.GlobalItem = false;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "بحث بإسم الموضف";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.GlobalItem = false;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "بحث بالتاريخ الشهري";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelX3.Image = global::HR_ManagmentSystem.Properties.Resources.Calendar;
            this.labelX3.Location = new System.Drawing.Point(24, 103);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(127, 27);
            this.labelX3.TabIndex = 21;
            this.labelX3.Text = "التاريخ بالشهر  :";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelX1.Image = global::HR_ManagmentSystem.Properties.Resources.user;
            this.labelX1.Location = new System.Drawing.Point(24, 49);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(127, 35);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "إسم الموضف  :";
            // 
            // frmReportAtten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 686);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.dtAttenDate);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbEmpID);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dataGridViewX1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportAtten";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "بحث وتقارير الحضور";
            this.Load += new System.EventHandler(this.frmReportAtten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAttenDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbEmpID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtAttenDate;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ListBoxItem listBoxItem1;
        private DevComponents.DotNetBar.ButtonX btnSearchEmp;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonX btnPrintReport;
        private System.Windows.Forms.Button btnExit;
    }
}