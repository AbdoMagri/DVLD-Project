namespace DVLD
{
    partial class frmLicenseHistory
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
            this.ctrlFilterPerson1 = new DVLD.ctrlFilterPerson();
            this.dgvLocalDrivingLicenses = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlFilterPerson1
            // 
            this.ctrlFilterPerson1.Location = new System.Drawing.Point(14, 21);
            this.ctrlFilterPerson1.Name = "ctrlFilterPerson1";
            this.ctrlFilterPerson1.Size = new System.Drawing.Size(911, 364);
            this.ctrlFilterPerson1.TabIndex = 0;
            // 
            // dgvLocalDrivingLicenses
            // 
            this.dgvLocalDrivingLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingLicenses.Location = new System.Drawing.Point(14, 391);
            this.dgvLocalDrivingLicenses.Name = "dgvLocalDrivingLicenses";
            this.dgvLocalDrivingLicenses.Size = new System.Drawing.Size(911, 215);
            this.dgvLocalDrivingLicenses.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.circle_x;
            this.btnClose.Location = new System.Drawing.Point(822, 620);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 38);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "  Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 670);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvLocalDrivingLicenses);
            this.Controls.Add(this.ctrlFilterPerson1);
            this.Name = "frmLicenseHistory";
            this.Text = "frmLicenseHistory";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlFilterPerson ctrlFilterPerson1;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicenses;
        private System.Windows.Forms.Button btnClose;
    }
}