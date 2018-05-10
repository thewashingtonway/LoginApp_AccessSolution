namespace LoginApp_Access
{
    partial class frmChoice
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
            this.lblChoices = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOutreach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChoices
            // 
            this.lblChoices.AutoSize = true;
            this.lblChoices.Location = new System.Drawing.Point(293, 73);
            this.lblChoices.Name = "lblChoices";
            this.lblChoices.Size = new System.Drawing.Size(195, 25);
            this.lblChoices.TabIndex = 3;
            this.lblChoices.Text = "Would you like to...";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(541, 78);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add a new member";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(120, 253);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(541, 78);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit a current members info";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnOutreach
            // 
            this.btnOutreach.Location = new System.Drawing.Point(120, 373);
            this.btnOutreach.Name = "btnOutreach";
            this.btnOutreach.Size = new System.Drawing.Size(541, 78);
            this.btnOutreach.TabIndex = 2;
            this.btnOutreach.Text = "Create new Outreach Instance";
            this.btnOutreach.UseVisualStyleBackColor = true;
            this.btnOutreach.Click += new System.EventHandler(this.btnOutreach_Click);
            // 
            // frmChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 564);
            this.Controls.Add(this.btnOutreach);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblChoices);
            this.Name = "frmChoice";
            this.Text = "Action Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoices;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnOutreach;
    }
}