namespace DVLD
{
    partial class frmVisonTestAppointments
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlDrivingLicenseApplicationInfo1 = new DVLD.ctrlDrivingLicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(378, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vistion Test Appointments";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToOrderColumns = true;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAppointments.Location = new System.Drawing.Point(12, 545);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.Size = new System.Drawing.Size(994, 174);
            this.dgvAppointments.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEdit,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Image = global::DVLD.Properties.Resources.edit_32;
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(122, 22);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.TestType_32;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Appointments:";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::DVLD.Properties.Resources.circle_x;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(895, 740);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 36);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Image = global::DVLD.Properties.Resources.AddAppointment_32;
            this.btnAddNewUser.Location = new System.Drawing.Point(962, 499);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(44, 37);
            this.btnAddNewUser.TabIndex = 9;
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DVLD.Properties.Resources.Vision_512;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(456, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 100);
            this.panel1.TabIndex = 2;
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(12, 183);
            this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(994, 310);
            this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 4;
            // 
            // frmVisonTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 788);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmVisonTestAppointments";
            this.Text = "Vison Test Appointments";
            this.Load += new System.EventHandler(this.frmVisonTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}