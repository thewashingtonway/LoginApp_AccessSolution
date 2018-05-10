namespace LoginApp_Access
{
    partial class frmAddNewOutreach
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
            this.lblNewOutreach = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.coBoxType = new System.Windows.Forms.ComboBox();
            this.coBoxTopic = new System.Windows.Forms.ComboBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewOutreach
            // 
            this.lblNewOutreach.AutoSize = true;
            this.lblNewOutreach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOutreach.Location = new System.Drawing.Point(59, 49);
            this.lblNewOutreach.Name = "lblNewOutreach";
            this.lblNewOutreach.Size = new System.Drawing.Size(566, 63);
            this.lblNewOutreach.TabIndex = 0;
            this.lblNewOutreach.Text = "Create New Outreach";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(113, 195);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(124, 25);
            this.lblStaffName.TabIndex = 1;
            this.lblStaffName.Text = "Staff Name:";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(79, 271);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(158, 25);
            this.lblMemberName.TabIndex = 2;
            this.lblMemberName.Text = "Member Name:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(56, 347);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(181, 25);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date of Outreach:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(53, 423);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(184, 25);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type of Outreach:";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(65, 499);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(172, 25);
            this.lblTopic.TabIndex = 5;
            this.lblTopic.Text = "Topic of Interest:";
            // 
            // coBoxType
            // 
            this.coBoxType.FormattingEnabled = true;
            this.coBoxType.Items.AddRange(new object[] {
            "Phone Call",
            "Email",
            "In Person"});
            this.coBoxType.Location = new System.Drawing.Point(244, 423);
            this.coBoxType.Name = "coBoxType";
            this.coBoxType.Size = new System.Drawing.Size(292, 33);
            this.coBoxType.TabIndex = 10;
            // 
            // coBoxTopic
            // 
            this.coBoxTopic.FormattingEnabled = true;
            this.coBoxTopic.Items.AddRange(new object[] {
            "Social",
            "Work Order Day (WOD)",
            "Advocacy",
            "Personal",
            "Employment",
            "Education",
            "Other"});
            this.coBoxTopic.Location = new System.Drawing.Point(244, 499);
            this.coBoxTopic.Name = "coBoxTopic";
            this.coBoxTopic.Size = new System.Drawing.Size(292, 33);
            this.coBoxTopic.TabIndex = 11;
            // 
            // txtStaffName
            // 
            this.txtStaffName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtStaffName.Location = new System.Drawing.Point(244, 195);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(509, 31);
            this.txtStaffName.TabIndex = 7;
            this.txtStaffName.Text = "Full Name";
            this.txtStaffName.Enter += new System.EventHandler(this.txtStaffName_Enter);
            this.txtStaffName.Leave += new System.EventHandler(this.txtStaffName_Leave);
            // 
            // txtMemberName
            // 
            this.txtMemberName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMemberName.Location = new System.Drawing.Point(244, 271);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(509, 31);
            this.txtMemberName.TabIndex = 8;
            this.txtMemberName.Text = "Full Name";
            this.txtMemberName.Enter += new System.EventHandler(this.txtMemberName_Enter);
            this.txtMemberName.Leave += new System.EventHandler(this.txtMemberName_Leave);
            // 
            // txtDate
            // 
            this.txtDate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDate.Location = new System.Drawing.Point(244, 347);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(509, 31);
            this.txtDate.TabIndex = 9;
            this.txtDate.Text = "MM/DD/YYYY";
            this.txtDate.Enter += new System.EventHandler(this.txtDate_Enter);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(58, 575);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(179, 25);
            this.lblOther.TabIndex = 6;
            this.lblOther.Text = "Other Comments:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(244, 575);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(509, 342);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "Enter any comments about the outreach";
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            this.richTextBox1.Leave += new System.EventHandler(this.richTextBox1_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(181, 983);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(224, 58);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(484, 983);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(224, 58);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddNewOutreach
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(911, 1129);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.coBoxTopic);
            this.Controls.Add(this.coBoxType);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.lblNewOutreach);
            this.Name = "frmAddNewOutreach";
            this.Text = "frmAddNewOutreach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewOutreach;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.ComboBox coBoxType;
        private System.Windows.Forms.ComboBox coBoxTopic;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}