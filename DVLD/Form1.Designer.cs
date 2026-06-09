namespace DVLD
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccountSettings = new System.Windows.Forms.Button();
            this.cmsAccountSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCurrntUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnApplications = new System.Windows.Forms.Button();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDrivingLicensesServices = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementForLostOrDamagedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDetainLiceses = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.cmsAccountSettings.SuspendLayout();
            this.cmsApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAccountSettings);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnDrivers);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnApplications);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1668, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnAccountSettings
            // 
            this.btnAccountSettings.BackgroundImage = global::DVLD.Properties.Resources.Icojam_Blue_Bits_User_settings_48;
            this.btnAccountSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccountSettings.ContextMenuStrip = this.cmsAccountSettings;
            this.btnAccountSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAccountSettings.FlatAppearance.BorderSize = 0;
            this.btnAccountSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSettings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountSettings.Location = new System.Drawing.Point(599, 3);
            this.btnAccountSettings.Name = "btnAccountSettings";
            this.btnAccountSettings.Size = new System.Drawing.Size(172, 53);
            this.btnAccountSettings.TabIndex = 4;
            this.btnAccountSettings.Text = "Accont Settings";
            this.btnAccountSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccountSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccountSettings.UseVisualStyleBackColor = true;
            this.btnAccountSettings.Click += new System.EventHandler(this.btnAccountSettings_Click);
            // 
            // cmsAccountSettings
            // 
            this.cmsAccountSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCurrntUserInfo,
            this.tsmChangePassword,
            this.toolStripSeparator1,
            this.tsmSignOut});
            this.cmsAccountSettings.Name = "cmsAccountSettings";
            this.cmsAccountSettings.Size = new System.Drawing.Size(200, 124);
            // 
            // tsmCurrntUserInfo
            // 
            this.tsmCurrntUserInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmCurrntUserInfo.Image = global::DVLD.Properties.Resources.information;
            this.tsmCurrntUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmCurrntUserInfo.Name = "tsmCurrntUserInfo";
            this.tsmCurrntUserInfo.Size = new System.Drawing.Size(199, 38);
            this.tsmCurrntUserInfo.Text = "Current User Info";
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmChangePassword.Image = global::DVLD.Properties.Resources.password;
            this.tsmChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(199, 38);
            this.tsmChangePassword.Text = "Change Password";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // tsmSignOut
            // 
            this.tsmSignOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSignOut.Image = global::DVLD.Properties.Resources.logout__1_;
            this.tsmSignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmSignOut.Name = "tsmSignOut";
            this.tsmSignOut.Size = new System.Drawing.Size(199, 38);
            this.tsmSignOut.Text = "Sign Out";
            this.tsmSignOut.Click += new System.EventHandler(this.tsmSignOut_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackgroundImage = global::DVLD.Properties.Resources.Aha_Soft_Free_Large_Boss_Admin_48;
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(461, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(132, 53);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackgroundImage = global::DVLD.Properties.Resources.Icons8_Windows_8_Transport_Driver_48;
            this.btnDrivers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDrivers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivers.Location = new System.Drawing.Point(313, 3);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(142, 53);
            this.btnDrivers.TabIndex = 2;
            this.btnDrivers.Text = "Drivers";
            this.btnDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDrivers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DVLD.Properties.Resources.Hopstarter_Sleek_Xp_Basic_User_Group_48;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(179, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "People";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnApplications
            // 
            this.btnApplications.BackgroundImage = global::DVLD.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Applications_Cascade_48;
            this.btnApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApplications.ContextMenuStrip = this.cmsApplications;
            this.btnApplications.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnApplications.FlatAppearance.BorderSize = 0;
            this.btnApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplications.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplications.Location = new System.Drawing.Point(3, 3);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(173, 53);
            this.btnApplications.TabIndex = 0;
            this.btnApplications.Text = "Applications";
            this.btnApplications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplications.UseVisualStyleBackColor = true;
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // cmsApplications
            // 
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManageApplicationTypes,
            this.tsmManageTestTypes,
            this.toolStripSeparator2,
            this.tsmDrivingLicensesServices,
            this.toolStripSeparator3,
            this.tsmManageApplications,
            this.toolStripSeparator4,
            this.tsmDetainLiceses});
            this.cmsApplications.Name = "cmsApplications";
            this.cmsApplications.Size = new System.Drawing.Size(215, 154);
            // 
            // tsmManageApplicationTypes
            // 
            this.tsmManageApplicationTypes.Name = "tsmManageApplicationTypes";
            this.tsmManageApplicationTypes.Size = new System.Drawing.Size(214, 22);
            this.tsmManageApplicationTypes.Text = "Manage Application Types";
            this.tsmManageApplicationTypes.Click += new System.EventHandler(this.tsmManageApplicationTypes_Click);
            // 
            // tsmManageTestTypes
            // 
            this.tsmManageTestTypes.Name = "tsmManageTestTypes";
            this.tsmManageTestTypes.Size = new System.Drawing.Size(214, 22);
            this.tsmManageTestTypes.Text = "Manage Test Types";
            this.tsmManageTestTypes.Click += new System.EventHandler(this.tsmManageTestTypes_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // tsmDrivingLicensesServices
            // 
            this.tsmDrivingLicensesServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replacementForLostOrDamagedLicenseToolStripMenuItem,
            this.releaseDetainedDrivingLicenseToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.tsmDrivingLicensesServices.Name = "tsmDrivingLicensesServices";
            this.tsmDrivingLicensesServices.Size = new System.Drawing.Size(214, 22);
            this.tsmDrivingLicensesServices.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            // 
            // replacementForLostOrDamagedLicenseToolStripMenuItem
            // 
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Name = "replacementForLostOrDamagedLicenseToolStripMenuItem";
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Text = "Replacement for Lost or Damaged License";
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(211, 6);
            // 
            // tsmManageApplications
            // 
            this.tsmManageApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationsToolStripMenuItem,
            this.internationalLicenseApplicationsToolStripMenuItem});
            this.tsmManageApplications.Name = "tsmManageApplications";
            this.tsmManageApplications.Size = new System.Drawing.Size(214, 22);
            this.tsmManageApplications.Text = "Manage Applictions";
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // internationalLicenseApplicationsToolStripMenuItem
            // 
            this.internationalLicenseApplicationsToolStripMenuItem.Name = "internationalLicenseApplicationsToolStripMenuItem";
            this.internationalLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.internationalLicenseApplicationsToolStripMenuItem.Text = "International License Applications";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(211, 6);
            // 
            // tsmDetainLiceses
            // 
            this.tsmDetainLiceses.Name = "tsmDetainLiceses";
            this.tsmDetainLiceses.Size = new System.Drawing.Size(214, 22);
            this.tsmDetainLiceses.Text = "Detain Licenses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1638, 735);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.cmsAccountSettings.ResumeLayout(false);
            this.cmsApplications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApplications;
        private System.Windows.Forms.Button btnAccountSettings;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip cmsAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmCurrntUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmSignOut;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmManageTestTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmDrivingLicensesServices;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmManageApplications;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmDetainLiceses;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamagedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseApplicationsToolStripMenuItem;
    }
}

