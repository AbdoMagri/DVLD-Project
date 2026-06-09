namespace DVLD
{
    partial class frmLocalDrivingLicenseApplictions
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
            this.lblRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLocalDrivingLicenses = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCancelApp = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMScheduleWriteTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(228, 581);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(15, 16);
            this.lblRecords.TabIndex = 16;
            this.lblRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 581);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "# Records:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "User ID",
            "UserName",
            "Person ID",
            "Full Name",
            "Is Active"});
            this.comboBox1.Location = new System.Drawing.Point(209, 234);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filter By: ";
            // 
            // dgvLocalDrivingLicenses
            // 
            this.dgvLocalDrivingLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalDrivingLicenses.Location = new System.Drawing.Point(134, 272);
            this.dgvLocalDrivingLicenses.Name = "dgvLocalDrivingLicenses";
            this.dgvLocalDrivingLicenses.Size = new System.Drawing.Size(970, 273);
            this.dgvLocalDrivingLicenses.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCancelApp,
            this.editApplicationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem2,
            this.toolStripSeparator2,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripSeparator3,
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator4,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(247, 204);
            // 
            // tsmCancelApp
            // 
            this.tsmCancelApp.Image = global::DVLD.Properties.Resources.cross_32;
            this.tsmCancelApp.Name = "tsmCancelApp";
            this.tsmCancelApp.Size = new System.Drawing.Size(246, 22);
            this.tsmCancelApp.Text = "Cancel Application";
            this.tsmCancelApp.Click += new System.EventHandler(this.tsmCancelApp_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::DVLD.Properties.Resources.Delete_32_2;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(246, 22);
            this.toolStripMenuItem1.Text = "Delete Application";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMScheduleVisionTest,
            this.TSMScheduleWriteTest,
            this.TSMScheduleStreetTest});
            this.toolStripMenuItem2.Image = global::DVLD.Properties.Resources.Schedule_Test_32;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(246, 22);
            this.toolStripMenuItem2.Text = "Schedule Tests";
            // 
            // TSMScheduleVisionTest
            // 
            this.TSMScheduleVisionTest.Image = global::DVLD.Properties.Resources.Vision_Test_32;
            this.TSMScheduleVisionTest.Name = "TSMScheduleVisionTest";
            this.TSMScheduleVisionTest.Size = new System.Drawing.Size(181, 22);
            this.TSMScheduleVisionTest.Text = "Schedule Vision Test";
            this.TSMScheduleVisionTest.Click += new System.EventHandler(this.TSMScheduleVisionTest_Click);
            // 
            // TSMScheduleWriteTest
            // 
            this.TSMScheduleWriteTest.Image = global::DVLD.Properties.Resources.Written_Test_32;
            this.TSMScheduleWriteTest.Name = "TSMScheduleWriteTest";
            this.TSMScheduleWriteTest.Size = new System.Drawing.Size(181, 22);
            this.TSMScheduleWriteTest.Text = "Schedule Write Test";
            this.TSMScheduleWriteTest.Click += new System.EventHandler(this.TSMScheduleWriteTest_Click);
            // 
            // TSMScheduleStreetTest
            // 
            this.TSMScheduleStreetTest.Image = global::DVLD.Properties.Resources.Street_Test_32;
            this.TSMScheduleStreetTest.Name = "TSMScheduleStreetTest";
            this.TSMScheduleStreetTest.Size = new System.Drawing.Size(181, 22);
            this.TSMScheduleStreetTest.Text = "Schedule Street Test";
            this.TSMScheduleStreetTest.Click += new System.EventHandler(this.TSMScheduleStreetTest_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(243, 6);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_32;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(243, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(243, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(445, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Local Driving License Applications";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Image = global::DVLD.Properties.Resources.New_Application_64;
            this.btnAddNewUser.Location = new System.Drawing.Point(1022, 190);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(82, 76);
            this.btnAddNewUser.TabIndex = 17;
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.circle_x;
            this.btnClose.Location = new System.Drawing.Point(1001, 568);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 38);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "  Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Applications;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(534, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmLocalDrivingLicenseApplictions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 615);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLocalDrivingLicenses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLocalDrivingLicenseApplictions";
            this.Text = "frmLocalDrivingLicenseApplictions";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplictions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelApp;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem TSMScheduleWriteTest;
        private System.Windows.Forms.ToolStripMenuItem TSMScheduleStreetTest;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}