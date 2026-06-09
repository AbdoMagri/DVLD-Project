namespace DVLD
{
    partial class ctrlFilterPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPersonInfo = new System.Windows.Forms.GroupBox();
            this.ctrlPersonInfo1 = new DVLD.ctrlPersonInfo();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPersonInfo.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersonInfo
            // 
            this.gbPersonInfo.Controls.Add(this.ctrlPersonInfo1);
            this.gbPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonInfo.Location = new System.Drawing.Point(3, 75);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Size = new System.Drawing.Size(903, 284);
            this.gbPersonInfo.TabIndex = 1;
            this.gbPersonInfo.TabStop = false;
            this.gbPersonInfo.Text = "Person Informations";
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(12, 20);
            this.ctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(884, 250);
            this.ctrlPersonInfo1.TabIndex = 1;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.button2);
            this.gbFilter.Controls.Add(this.button1);
            this.gbFilter.Controls.Add(this.textBox1);
            this.gbFilter.Controls.Add(this.comboBox1);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(903, 66);
            this.gbFilter.TabIndex = 2;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // button2
            // 
            this.button2.Image = global::DVLD.Properties.Resources.user__2_;
            this.button2.Location = new System.Drawing.Point(836, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 42);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::DVLD.Properties.Resources.user__1_;
            this.button1.Location = new System.Drawing.Point(781, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 42);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "National No",
            "Person ID"});
            this.comboBox1.Location = new System.Drawing.Point(87, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By:";
            // 
            // ctrlFilterPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.gbPersonInfo);
            this.Name = "ctrlFilterPerson";
            this.Size = new System.Drawing.Size(911, 364);
            this.Load += new System.EventHandler(this.ctrlFilterPerson_Load);
            this.gbPersonInfo.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonInfo;
        private ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
