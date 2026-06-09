namespace DVLD
{
    partial class frmTakeTest
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
            this.btnClose = new System.Windows.Forms.Button();
            this.grpTest = new System.Windows.Forms.GroupBox();
            this.lblTestID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pannel1 = new System.Windows.Forms.PictureBox();
            this.lblDClass = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblTrial = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDLAppID = new System.Windows.Forms.Label();
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rpPass = new System.Windows.Forms.RadioButton();
            this.rpFail = new System.Windows.Forms.RadioButton();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.grpTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pannel1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::DVLD.Properties.Resources.circle_x;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(287, 610);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 36);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // grpTest
            // 
            this.grpTest.Controls.Add(this.lblTestID);
            this.grpTest.Controls.Add(this.label4);
            this.grpTest.Controls.Add(this.label5);
            this.grpTest.Controls.Add(this.pannel1);
            this.grpTest.Controls.Add(this.lblDClass);
            this.grpTest.Controls.Add(this.lblFees);
            this.grpTest.Controls.Add(this.lblTrial);
            this.grpTest.Controls.Add(this.lblName);
            this.grpTest.Controls.Add(this.lblDLAppID);
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
            this.grpTest.Location = new System.Drawing.Point(7, 8);
            this.grpTest.Name = "grpTest";
            this.grpTest.Size = new System.Drawing.Size(520, 418);
            this.grpTest.TabIndex = 46;
            this.grpTest.TabStop = false;
            this.grpTest.Text = "Vision Test";
            // 
            // lblTestID
            // 
            this.lblTestID.AutoSize = true;
            this.lblTestID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestID.Location = new System.Drawing.Point(174, 389);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(98, 16);
            this.lblTestID.TabIndex = 52;
            this.lblTestID.Text = "Not Taken Yet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Test ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(177, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 51;
            // 
            // pannel1
            // 
            this.pannel1.Image = global::DVLD.Properties.Resources.Vision_512;
            this.pannel1.ImageLocation = "";
            this.pannel1.Location = new System.Drawing.Point(220, 19);
            this.pannel1.Name = "pannel1";
            this.pannel1.Size = new System.Drawing.Size(99, 84);
            this.pannel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pannel1.TabIndex = 49;
            this.pannel1.TabStop = false;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(172, 106);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Scheduled Test";
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
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::DVLD.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(416, 610);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 36);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Result:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Note:";
            // 
            // rpPass
            // 
            this.rpPass.AutoSize = true;
            this.rpPass.Checked = true;
            this.rpPass.Location = new System.Drawing.Point(111, 432);
            this.rpPass.Name = "rpPass";
            this.rpPass.Size = new System.Drawing.Size(48, 17);
            this.rpPass.TabIndex = 50;
            this.rpPass.TabStop = true;
            this.rpPass.Text = "Pass";
            this.rpPass.UseVisualStyleBackColor = true;
            // 
            // rpFail
            // 
            this.rpFail.AutoSize = true;
            this.rpFail.Location = new System.Drawing.Point(165, 432);
            this.rpFail.Name = "rpFail";
            this.rpFail.Size = new System.Drawing.Size(41, 17);
            this.rpFail.TabIndex = 51;
            this.rpFail.Text = "Fail";
            this.rpFail.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(111, 479);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(416, 111);
            this.txtNote.TabIndex = 52;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 658);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.rpFail);
            this.Controls.Add(this.rpPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpTest);
            this.Controls.Add(this.btnSave);
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.grpTest.ResumeLayout(false);
            this.grpTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pannel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpTest;
        private System.Windows.Forms.PictureBox pannel1;
        private System.Windows.Forms.Label lblDClass;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblTrial;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.Button btnSave;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rpPass;
        private System.Windows.Forms.RadioButton rpFail;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblTestID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}