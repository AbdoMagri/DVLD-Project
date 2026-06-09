namespace DVLD
{
    partial class frmScheduleTest
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpTest = new System.Windows.Forms.GroupBox();
            this.lblAppointmentIsLocked = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.PictureBox();
            this.lblDClass = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblTrial = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDLAppID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ds = new System.Windows.Forms.Label();
            this.lblDLAppIDValue = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.lblDClassValue = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.Trial = new System.Windows.Forms.Label();
            this.lblTrialValue = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.Fees = new System.Windows.Forms.Label();
            this.lblFeesValue = new System.Windows.Forms.Label();
            this.grpRetake = new System.Windows.Forms.GroupBox();
            this.lblRTestAppID = new System.Windows.Forms.Label();
            this.lblRAppFees = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.RAppFees = new System.Windows.Forms.Label();
            this.lblRAppFeesValue = new System.Windows.Forms.Label();
            this.TotalFees = new System.Windows.Forms.Label();
            this.lblTotalFeesValue = new System.Windows.Forms.Label();
            this.RTestAppID = new System.Windows.Forms.Label();
            this.lblRTestAppIDValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.grpRetake.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTest
            // 
            this.grpTest.Controls.Add(this.lblAppointmentIsLocked);
            this.grpTest.Controls.Add(this.panel1);
            this.grpTest.Controls.Add(this.lblDClass);
            this.grpTest.Controls.Add(this.lblFees);
            this.grpTest.Controls.Add(this.lblTrial);
            this.grpTest.Controls.Add(this.lblName);
            this.grpTest.Controls.Add(this.lblDLAppID);
            this.grpTest.Controls.Add(this.btnSave);
            this.grpTest.Controls.Add(this.lblTitle);
            this.grpTest.Controls.Add(this.ds);
            this.grpTest.Controls.Add(this.lblDLAppIDValue);
            this.grpTest.Controls.Add(this.Class);
            this.grpTest.Controls.Add(this.lblDClassValue);
            this.grpTest.Controls.Add(this.Name);
            this.grpTest.Controls.Add(this.lblNameValue);
            this.grpTest.Controls.Add(this.Trial);
            this.grpTest.Controls.Add(this.lblTrialValue);
            this.grpTest.Controls.Add(this.lblDate);
            this.grpTest.Controls.Add(this.dtpDate);
            this.grpTest.Controls.Add(this.Fees);
            this.grpTest.Controls.Add(this.lblFeesValue);
            this.grpTest.Controls.Add(this.grpRetake);
            this.grpTest.Location = new System.Drawing.Point(12, 12);
            this.grpTest.Name = "grpTest";
            this.grpTest.Size = new System.Drawing.Size(520, 572);
            this.grpTest.TabIndex = 0;
            this.grpTest.TabStop = false;
            this.grpTest.Text = "Vision Test";
            // 
            // lblAppointmentIsLocked
            // 
            this.lblAppointmentIsLocked.AutoSize = true;
            this.lblAppointmentIsLocked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentIsLocked.ForeColor = System.Drawing.Color.Red;
            this.lblAppointmentIsLocked.Location = new System.Drawing.Point(98, 135);
            this.lblAppointmentIsLocked.Name = "lblAppointmentIsLocked";
            this.lblAppointmentIsLocked.Size = new System.Drawing.Size(342, 16);
            this.lblAppointmentIsLocked.TabIndex = 50;
            this.lblAppointmentIsLocked.Text = "Person already sat for the test, appontment locked";
            this.lblAppointmentIsLocked.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Image = global::DVLD.Properties.Resources.Vision_512;
            this.panel1.ImageLocation = "";
            this.panel1.Location = new System.Drawing.Point(220, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 84);
            this.panel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panel1.TabIndex = 49;
            this.panel1.TabStop = false;
            // 
            // lblDClass
            // 
            this.lblDClass.AutoSize = true;
            this.lblDClass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDClass.Location = new System.Drawing.Point(174, 196);
            this.lblDClass.Name = "lblDClass";
            this.lblDClass.Size = new System.Drawing.Size(40, 16);
            this.lblDClass.TabIndex = 48;
            this.lblDClass.Text = "[???]";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(174, 354);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(40, 16);
            this.lblFees.TabIndex = 48;
            this.lblFees.Text = "[???]";
            // 
            // lblTrial
            // 
            this.lblTrial.AutoSize = true;
            this.lblTrial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrial.Location = new System.Drawing.Point(174, 274);
            this.lblTrial.Name = "lblTrial";
            this.lblTrial.Size = new System.Drawing.Size(15, 16);
            this.lblTrial.TabIndex = 48;
            this.lblTrial.Text = "0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(174, 234);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 16);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "[???]";
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.AutoSize = true;
            this.lblDLAppID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAppID.Location = new System.Drawing.Point(174, 154);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(40, 16);
            this.lblDLAppID.TabIndex = 46;
            this.lblDLAppID.Text = "[???]";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::DVLD.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(396, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 36);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(180, 106);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Schedule Test";
            // 
            // ds
            // 
            this.ds.AutoSize = true;
            this.ds.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds.Location = new System.Drawing.Point(27, 156);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(80, 16);
            this.ds.TabIndex = 1;
            this.ds.Text = "D.L.App.ID:";
            // 
            // lblDLAppIDValue
            // 
            this.lblDLAppIDValue.AutoSize = true;
            this.lblDLAppIDValue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblDLAppIDValue.Location = new System.Drawing.Point(177, 156);
            this.lblDLAppIDValue.Name = "lblDLAppIDValue";
            this.lblDLAppIDValue.Size = new System.Drawing.Size(0, 14);
            this.lblDLAppIDValue.TabIndex = 2;
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(27, 196);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(62, 16);
            this.Class.TabIndex = 3;
            this.Class.Text = "D. Class:";
            // 
            // lblDClassValue
            // 
            this.lblDClassValue.AutoSize = true;
            this.lblDClassValue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblDClassValue.Location = new System.Drawing.Point(177, 196);
            this.lblDClassValue.Name = "lblDClassValue";
            this.lblDClassValue.Size = new System.Drawing.Size(0, 14);
            this.lblDClassValue.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(27, 236);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(47, 16);
            this.Name.TabIndex = 5;
            this.Name.Text = "Name:";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNameValue.Location = new System.Drawing.Point(177, 236);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(0, 14);
            this.lblNameValue.TabIndex = 6;
            // 
            // Trial
            // 
            this.Trial.AutoSize = true;
            this.Trial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trial.Location = new System.Drawing.Point(27, 276);
            this.Trial.Name = "Trial";
            this.Trial.Size = new System.Drawing.Size(39, 16);
            this.Trial.TabIndex = 7;
            this.Trial.Text = "Trial:";
            // 
            // lblTrialValue
            // 
            this.lblTrialValue.AutoSize = true;
            this.lblTrialValue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTrialValue.Location = new System.Drawing.Point(177, 276);
            this.lblTrialValue.Name = "lblTrialValue";
            this.lblTrialValue.Size = new System.Drawing.Size(0, 14);
            this.lblTrialValue.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(27, 316);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 16);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(174, 313);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(160, 22);
            this.dtpDate.TabIndex = 10;
            // 
            // Fees
            // 
            this.Fees.AutoSize = true;
            this.Fees.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fees.Location = new System.Drawing.Point(27, 356);
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(41, 16);
            this.Fees.TabIndex = 11;
            this.Fees.Text = "Fees:";
            // 
            // lblFeesValue
            // 
            this.lblFeesValue.AutoSize = true;
            this.lblFeesValue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblFeesValue.Location = new System.Drawing.Point(177, 356);
            this.lblFeesValue.Name = "lblFeesValue";
            this.lblFeesValue.Size = new System.Drawing.Size(0, 14);
            this.lblFeesValue.TabIndex = 12;
            // 
            // grpRetake
            // 
            this.grpRetake.Controls.Add(this.lblRTestAppID);
            this.grpRetake.Controls.Add(this.lblRAppFees);
            this.grpRetake.Controls.Add(this.lblTotalFees);
            this.grpRetake.Controls.Add(this.RAppFees);
            this.grpRetake.Controls.Add(this.lblRAppFeesValue);
            this.grpRetake.Controls.Add(this.TotalFees);
            this.grpRetake.Controls.Add(this.lblTotalFeesValue);
            this.grpRetake.Controls.Add(this.RTestAppID);
            this.grpRetake.Controls.Add(this.lblRTestAppIDValue);
            this.grpRetake.Enabled = false;
            this.grpRetake.ForeColor = System.Drawing.Color.Black;
            this.grpRetake.Location = new System.Drawing.Point(27, 396);
            this.grpRetake.Name = "grpRetake";
            this.grpRetake.Size = new System.Drawing.Size(480, 90);
            this.grpRetake.TabIndex = 13;
            this.grpRetake.TabStop = false;
            this.grpRetake.Text = "Retake Test Info";
            // 
            // lblRTestAppID
            // 
            this.lblRTestAppID.AutoSize = true;
            this.lblRTestAppID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTestAppID.Location = new System.Drawing.Point(144, 60);
            this.lblRTestAppID.Name = "lblRTestAppID";
            this.lblRTestAppID.Size = new System.Drawing.Size(33, 16);
            this.lblRTestAppID.TabIndex = 51;
            this.lblRTestAppID.Text = "N/A";
            // 
            // lblRAppFees
            // 
            this.lblRAppFees.AutoSize = true;
            this.lblRAppFees.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAppFees.Location = new System.Drawing.Point(144, 28);
            this.lblRAppFees.Name = "lblRAppFees";
            this.lblRAppFees.Size = new System.Drawing.Size(15, 16);
            this.lblRAppFees.TabIndex = 50;
            this.lblRAppFees.Text = "0";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.Location = new System.Drawing.Point(366, 28);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(40, 16);
            this.lblTotalFees.TabIndex = 49;
            this.lblTotalFees.Text = "[???]";
            // 
            // RAppFees
            // 
            this.RAppFees.AutoSize = true;
            this.RAppFees.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAppFees.Location = new System.Drawing.Point(10, 28);
            this.RAppFees.Name = "RAppFees";
            this.RAppFees.Size = new System.Drawing.Size(84, 16);
            this.RAppFees.TabIndex = 0;
            this.RAppFees.Text = "R.App.Fees:";
            // 
            // lblRAppFeesValue
            // 
            this.lblRAppFeesValue.AutoSize = true;
            this.lblRAppFeesValue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblRAppFeesValue.Location = new System.Drawing.Point(150, 28);
            this.lblRAppFeesValue.Name = "lblRAppFeesValue";
            this.lblRAppFeesValue.Size = new System.Drawing.Size(0, 14);
            this.lblRAppFeesValue.TabIndex = 1;
            // 
            // TotalFees
            // 
            this.TotalFees.AutoSize = true;
            this.TotalFees.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFees.Location = new System.Drawing.Point(270, 28);
            this.TotalFees.Name = "TotalFees";
            this.TotalFees.Size = new System.Drawing.Size(77, 16);
            this.TotalFees.TabIndex = 2;
            this.TotalFees.Text = "Total Fees:";
            // 
            // lblTotalFeesValue
            // 
            this.lblTotalFeesValue.AutoSize = true;
            this.lblTotalFeesValue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTotalFeesValue.Location = new System.Drawing.Point(390, 28);
            this.lblTotalFeesValue.Name = "lblTotalFeesValue";
            this.lblTotalFeesValue.Size = new System.Drawing.Size(0, 14);
            this.lblTotalFeesValue.TabIndex = 3;
            // 
            // RTestAppID
            // 
            this.RTestAppID.AutoSize = true;
            this.RTestAppID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTestAppID.Location = new System.Drawing.Point(10, 60);
            this.RTestAppID.Name = "RTestAppID";
            this.RTestAppID.Size = new System.Drawing.Size(101, 16);
            this.RTestAppID.TabIndex = 4;
            this.RTestAppID.Text = "R.Test.App.ID:";
            // 
            // lblRTestAppIDValue
            // 
            this.lblRTestAppIDValue.AutoSize = true;
            this.lblRTestAppIDValue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblRTestAppIDValue.Location = new System.Drawing.Point(150, 60);
            this.lblRTestAppIDValue.Name = "lblRTestAppIDValue";
            this.lblRTestAppIDValue.Size = new System.Drawing.Size(0, 14);
            this.lblRTestAppIDValue.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::DVLD.Properties.Resources.circle_x;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(217, 614);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 36);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 662);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Schedule Test";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.grpTest.ResumeLayout(false);
            this.grpTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.grpRetake.ResumeLayout(false);
            this.grpRetake.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTest;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label ds;
        private System.Windows.Forms.Label lblDLAppIDValue;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label lblDClassValue;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label Trial;
        private System.Windows.Forms.Label lblTrialValue;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label Fees;
        private System.Windows.Forms.Label lblFeesValue;
        private System.Windows.Forms.GroupBox grpRetake;
        private System.Windows.Forms.Label RAppFees;
        private System.Windows.Forms.Label lblRAppFeesValue;
        private System.Windows.Forms.Label TotalFees;
        private System.Windows.Forms.Label lblTotalFeesValue;
        private System.Windows.Forms.Label RTestAppID;
        private System.Windows.Forms.Label lblRTestAppIDValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDClass;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblTrial;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.Label lblRTestAppID;
        private System.Windows.Forms.Label lblRAppFees;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.PictureBox panel1;
        private System.Windows.Forms.Label lblAppointmentIsLocked;
    }
}