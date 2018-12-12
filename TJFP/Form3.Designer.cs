namespace TJFP
{
    partial class Form3
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rrCustInfoClearButton = new System.Windows.Forms.Button();
            this.rrSaveCustButton = new System.Windows.Forms.Button();
            this.custProvinceList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.custPhoneBox = new System.Windows.Forms.TextBox();
            this.el5 = new System.Windows.Forms.Label();
            this.custPostalBox = new System.Windows.Forms.TextBox();
            this.custNameBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.custCityBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.custAddressBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.repairClearButton = new System.Windows.Forms.Button();
            this.repairInfo = new System.Windows.Forms.TextBox();
            this.repairSaveButton = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rrCustInfoClearButton);
            this.groupBox3.Controls.Add(this.rrSaveCustButton);
            this.groupBox3.Controls.Add(this.custProvinceList);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.custPhoneBox);
            this.groupBox3.Controls.Add(this.el5);
            this.groupBox3.Controls.Add(this.custPostalBox);
            this.groupBox3.Controls.Add(this.custNameBox);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.custCityBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.custAddressBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 163);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Information";
            // 
            // rrCustInfoClearButton
            // 
            this.rrCustInfoClearButton.Location = new System.Drawing.Point(221, 130);
            this.rrCustInfoClearButton.Name = "rrCustInfoClearButton";
            this.rrCustInfoClearButton.Size = new System.Drawing.Size(75, 23);
            this.rrCustInfoClearButton.TabIndex = 25;
            this.rrCustInfoClearButton.Text = "Clear";
            this.rrCustInfoClearButton.UseVisualStyleBackColor = true;
            this.rrCustInfoClearButton.Click += new System.EventHandler(this.RrCustInfoClearButton_Click);
            // 
            // rrSaveCustButton
            // 
            this.rrSaveCustButton.Location = new System.Drawing.Point(302, 130);
            this.rrSaveCustButton.Name = "rrSaveCustButton";
            this.rrSaveCustButton.Size = new System.Drawing.Size(75, 23);
            this.rrSaveCustButton.TabIndex = 21;
            this.rrSaveCustButton.Text = "Save";
            this.rrSaveCustButton.UseVisualStyleBackColor = true;
            this.rrSaveCustButton.Click += new System.EventHandler(this.RrSaveCustButton_Click);
            // 
            // custProvinceList
            // 
            this.custProvinceList.FormattingEnabled = true;
            this.custProvinceList.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NS",
            "NT",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.custProvinceList.Location = new System.Drawing.Point(321, 68);
            this.custProvinceList.Name = "custProvinceList";
            this.custProvinceList.Size = new System.Drawing.Size(56, 21);
            this.custProvinceList.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Postal Code:";
            // 
            // custPhoneBox
            // 
            this.custPhoneBox.BackColor = System.Drawing.SystemColors.Window;
            this.custPhoneBox.Location = new System.Drawing.Point(242, 95);
            this.custPhoneBox.Name = "custPhoneBox";
            this.custPhoneBox.Size = new System.Drawing.Size(134, 20);
            this.custPhoneBox.TabIndex = 20;
            // 
            // el5
            // 
            this.el5.AutoSize = true;
            this.el5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.el5.Location = new System.Drawing.Point(190, 98);
            this.el5.Name = "el5";
            this.el5.Size = new System.Drawing.Size(47, 13);
            this.el5.TabIndex = 19;
            this.el5.Text = "Phone:";
            // 
            // custPostalBox
            // 
            this.custPostalBox.BackColor = System.Drawing.SystemColors.Window;
            this.custPostalBox.Location = new System.Drawing.Point(95, 95);
            this.custPostalBox.Name = "custPostalBox";
            this.custPostalBox.Size = new System.Drawing.Size(82, 20);
            this.custPostalBox.TabIndex = 18;
            // 
            // custNameBox
            // 
            this.custNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.custNameBox.Location = new System.Drawing.Point(95, 19);
            this.custNameBox.Name = "custNameBox";
            this.custNameBox.Size = new System.Drawing.Size(281, 20);
            this.custNameBox.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(10, 45);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Address:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(10, 71);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "City:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(254, 71);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "Province:";
            // 
            // custCityBox
            // 
            this.custCityBox.BackColor = System.Drawing.SystemColors.Window;
            this.custCityBox.Location = new System.Drawing.Point(95, 68);
            this.custCityBox.Name = "custCityBox";
            this.custCityBox.Size = new System.Drawing.Size(153, 20);
            this.custCityBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // custAddressBox
            // 
            this.custAddressBox.BackColor = System.Drawing.SystemColors.Window;
            this.custAddressBox.Location = new System.Drawing.Point(95, 42);
            this.custAddressBox.Name = "custAddressBox";
            this.custAddressBox.Size = new System.Drawing.Size(281, 20);
            this.custAddressBox.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.repairClearButton);
            this.groupBox1.Controls.Add(this.repairInfo);
            this.groupBox1.Controls.Add(this.repairSaveButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 183);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repair Information";
            // 
            // repairClearButton
            // 
            this.repairClearButton.Location = new System.Drawing.Point(222, 151);
            this.repairClearButton.Name = "repairClearButton";
            this.repairClearButton.Size = new System.Drawing.Size(75, 23);
            this.repairClearButton.TabIndex = 24;
            this.repairClearButton.Text = "Clear";
            this.repairClearButton.UseVisualStyleBackColor = true;
            this.repairClearButton.Click += new System.EventHandler(this.RepairButtonClear_Click);
            // 
            // repairInfo
            // 
            this.repairInfo.AcceptsReturn = true;
            this.repairInfo.AcceptsTab = true;
            this.repairInfo.BackColor = System.Drawing.SystemColors.Window;
            this.repairInfo.Location = new System.Drawing.Point(9, 22);
            this.repairInfo.Multiline = true;
            this.repairInfo.Name = "repairInfo";
            this.repairInfo.Size = new System.Drawing.Size(368, 123);
            this.repairInfo.TabIndex = 23;
            // 
            // repairSaveButton
            // 
            this.repairSaveButton.Location = new System.Drawing.Point(302, 151);
            this.repairSaveButton.Name = "repairSaveButton";
            this.repairSaveButton.Size = new System.Drawing.Size(75, 23);
            this.repairSaveButton.TabIndex = 21;
            this.repairSaveButton.Text = "Save";
            this.repairSaveButton.UseVisualStyleBackColor = true;
            this.repairSaveButton.Click += new System.EventHandler(this.RepairButtonSave_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.Text = "TJFP - New Repair Request";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button rrSaveCustButton;
        private System.Windows.Forms.ComboBox custProvinceList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox custPhoneBox;
        private System.Windows.Forms.Label el5;
        private System.Windows.Forms.TextBox custPostalBox;
        private System.Windows.Forms.TextBox custNameBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox custCityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox custAddressBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button repairClearButton;
        private System.Windows.Forms.TextBox repairInfo;
        private System.Windows.Forms.Button repairSaveButton;
        private System.Windows.Forms.Button rrCustInfoClearButton;
    }
}