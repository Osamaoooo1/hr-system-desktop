namespace HR_ManagmentSystem
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUname
            // 
            // 
            // 
            // 
            this.txtUname.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUname.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUname.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUname.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUname.Border.Class = "TextBoxBorder";
            this.txtUname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUname.Border.PaddingBottom = 8;
            this.txtUname.Border.PaddingLeft = 8;
            this.txtUname.Border.PaddingRight = 8;
            this.txtUname.Border.PaddingTop = 8;
            this.txtUname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUname.Location = new System.Drawing.Point(48, 254);
            this.txtUname.Name = "txtUname";
            this.txtUname.PreventEnterBeep = true;
            this.txtUname.Size = new System.Drawing.Size(295, 39);
            this.txtUname.TabIndex = 2;
            this.txtUname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUname.WatermarkText = "إسم المستخدم";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtPassword.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtPassword.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtPassword.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.Border.PaddingBottom = 8;
            this.txtPassword.Border.PaddingLeft = 8;
            this.txtPassword.Border.PaddingRight = 8;
            this.txtPassword.Border.PaddingTop = 8;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword.Location = new System.Drawing.Point(48, 318);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.Size = new System.Drawing.Size(295, 39);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WatermarkText = "كلمة المرور";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(48, 382);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(295, 48);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Text = "تسجيل الدخول";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Red;
            this.labelX4.Image = global::HR_ManagmentSystem.Properties.Resources.Action_Cancel;
            this.labelX4.Location = new System.Drawing.Point(12, 12);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(23, 20);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX4.TabIndex = 9;
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Image = global::HR_ManagmentSystem.Properties.Resources.key_solid;
            this.labelX2.Location = new System.Drawing.Point(349, 318);
            this.labelX2.Name = "labelX2";
            this.labelX2.PaddingBottom = 10;
            this.labelX2.PaddingLeft = 10;
            this.labelX2.PaddingRight = 10;
            this.labelX2.PaddingTop = 10;
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(47, 39);
            this.labelX2.TabIndex = 6;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Image = global::HR_ManagmentSystem.Properties.Resources.user;
            this.labelX1.Location = new System.Drawing.Point(349, 254);
            this.labelX1.Name = "labelX1";
            this.labelX1.PaddingBottom = 10;
            this.labelX1.PaddingLeft = 10;
            this.labelX1.PaddingRight = 10;
            this.labelX1.PaddingTop = 10;
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(47, 39);
            this.labelX1.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(361, 39);
            this.label16.TabIndex = 10;
            this.label16.Text = " Human Resource Management";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Image = global::HR_ManagmentSystem.Properties.Resources.desk;
            this.label17.Location = new System.Drawing.Point(121, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 102);
            this.label17.TabIndex = 26;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.buttonX1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(419, 514);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUname);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtUname;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

