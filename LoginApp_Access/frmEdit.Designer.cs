namespace LoginApp_Access
{
    partial class frmEdit
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
            this.coBoxState = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.coBoxMinor = new System.Windows.Forms.ComboBox();
            this.coBoxShared = new System.Windows.Forms.ComboBox();
            this.coBoxIndependent = new System.Windows.Forms.ComboBox();
            this.coBoxHousing = new System.Windows.Forms.ComboBox();
            this.coBoxMilitary = new System.Windows.Forms.ComboBox();
            this.coBoxGender = new System.Windows.Forms.ComboBox();
            this.coBocHomeless = new System.Windows.Forms.ComboBox();
            this.coBoxImmigrant = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.coBoxDisabled = new System.Windows.Forms.ComboBox();
            this.txtEnrollmentDate = new System.Windows.Forms.TextBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.txtRace = new System.Windows.Forms.TextBox();
            this.txtEthnicity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMinor = new System.Windows.Forms.Label();
            this.lblShared = new System.Windows.Forms.Label();
            this.lblIndependent = new System.Windows.Forms.Label();
            this.lblHousing = new System.Windows.Forms.Label();
            this.lblMilitaryStatus = new System.Windows.Forms.Label();
            this.lblImmigrant = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblHomeless = new System.Windows.Forms.Label();
            this.lblDisabled = new System.Windows.Forms.Label();
            this.lblEnrollmentDate = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblEthnicity = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblzipcode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coBoxState
            // 
            this.coBoxState.FormattingEnabled = true;
            this.coBoxState.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.coBoxState.Location = new System.Drawing.Point(1011, 293);
            this.coBoxState.Name = "coBoxState";
            this.coBoxState.Size = new System.Drawing.Size(331, 33);
            this.coBoxState.TabIndex = 106;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(889, 1216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(215, 49);
            this.btnCancel.TabIndex = 105;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // coBoxMinor
            // 
            this.coBoxMinor.FormattingEnabled = true;
            this.coBoxMinor.Items.AddRange(new object[] {
            "With non-relatives",
            "With relatives",
            "Single parent male",
            "Single parent female",
            "Two parents"});
            this.coBoxMinor.Location = new System.Drawing.Point(533, 1122);
            this.coBoxMinor.Name = "coBoxMinor";
            this.coBoxMinor.Size = new System.Drawing.Size(330, 33);
            this.coBoxMinor.TabIndex = 104;
            // 
            // coBoxShared
            // 
            this.coBoxShared.FormattingEnabled = true;
            this.coBoxShared.Items.AddRange(new object[] {
            "With minors",
            "Without minors",
            "With non-relatives",
            "With relatives",
            "With spouse",
            "Other "});
            this.coBoxShared.Location = new System.Drawing.Point(532, 1063);
            this.coBoxShared.Name = "coBoxShared";
            this.coBoxShared.Size = new System.Drawing.Size(330, 33);
            this.coBoxShared.TabIndex = 103;
            // 
            // coBoxIndependent
            // 
            this.coBoxIndependent.FormattingEnabled = true;
            this.coBoxIndependent.Items.AddRange(new object[] {
            "Male on own",
            "Female on own"});
            this.coBoxIndependent.Location = new System.Drawing.Point(532, 1004);
            this.coBoxIndependent.Name = "coBoxIndependent";
            this.coBoxIndependent.Size = new System.Drawing.Size(330, 33);
            this.coBoxIndependent.TabIndex = 102;
            // 
            // coBoxHousing
            // 
            this.coBoxHousing.FormattingEnabled = true;
            this.coBoxHousing.Items.AddRange(new object[] {
            "Independent",
            "Dependent on family",
            "Boarding/Group home",
            "Without adequate housing",
            ""});
            this.coBoxHousing.Location = new System.Drawing.Point(532, 945);
            this.coBoxHousing.Name = "coBoxHousing";
            this.coBoxHousing.Size = new System.Drawing.Size(330, 33);
            this.coBoxHousing.TabIndex = 101;
            // 
            // coBoxMilitary
            // 
            this.coBoxMilitary.FormattingEnabled = true;
            this.coBoxMilitary.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Dependent on spouse"});
            this.coBoxMilitary.Location = new System.Drawing.Point(532, 886);
            this.coBoxMilitary.Name = "coBoxMilitary";
            this.coBoxMilitary.Size = new System.Drawing.Size(330, 33);
            this.coBoxMilitary.TabIndex = 100;
            // 
            // coBoxGender
            // 
            this.coBoxGender.FormattingEnabled = true;
            this.coBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Transgender",
            "Unknown",
            "Other"});
            this.coBoxGender.Location = new System.Drawing.Point(533, 830);
            this.coBoxGender.Name = "coBoxGender";
            this.coBoxGender.Size = new System.Drawing.Size(189, 33);
            this.coBoxGender.TabIndex = 99;
            // 
            // coBocHomeless
            // 
            this.coBocHomeless.FormattingEnabled = true;
            this.coBocHomeless.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.coBocHomeless.Location = new System.Drawing.Point(930, 768);
            this.coBocHomeless.Name = "coBocHomeless";
            this.coBocHomeless.Size = new System.Drawing.Size(149, 33);
            this.coBocHomeless.TabIndex = 98;
            // 
            // coBoxImmigrant
            // 
            this.coBoxImmigrant.FormattingEnabled = true;
            this.coBoxImmigrant.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.coBoxImmigrant.Location = new System.Drawing.Point(1028, 830);
            this.coBoxImmigrant.Name = "coBoxImmigrant";
            this.coBoxImmigrant.Size = new System.Drawing.Size(149, 33);
            this.coBoxImmigrant.TabIndex = 97;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(444, 1216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(215, 49);
            this.btnSave.TabIndex = 96;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // coBoxDisabled
            // 
            this.coBoxDisabled.FormattingEnabled = true;
            this.coBoxDisabled.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.coBoxDisabled.Location = new System.Drawing.Point(533, 768);
            this.coBoxDisabled.Name = "coBoxDisabled";
            this.coBoxDisabled.Size = new System.Drawing.Size(189, 33);
            this.coBoxDisabled.TabIndex = 95;
            // 
            // txtEnrollmentDate
            // 
            this.txtEnrollmentDate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEnrollmentDate.Location = new System.Drawing.Point(532, 709);
            this.txtEnrollmentDate.Name = "txtEnrollmentDate";
            this.txtEnrollmentDate.Size = new System.Drawing.Size(330, 31);
            this.txtEnrollmentDate.TabIndex = 94;
            this.txtEnrollmentDate.Text = "MM/DD/YYYY";
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(532, 650);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(810, 31);
            this.txtIncome.TabIndex = 93;
            // 
            // txtRace
            // 
            this.txtRace.Location = new System.Drawing.Point(532, 591);
            this.txtRace.Name = "txtRace";
            this.txtRace.Size = new System.Drawing.Size(810, 31);
            this.txtRace.TabIndex = 92;
            // 
            // txtEthnicity
            // 
            this.txtEthnicity.Location = new System.Drawing.Point(532, 532);
            this.txtEthnicity.Name = "txtEthnicity";
            this.txtEthnicity.Size = new System.Drawing.Size(810, 31);
            this.txtEthnicity.TabIndex = 91;
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPhone.Location = new System.Drawing.Point(532, 473);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(399, 31);
            this.txtPhone.TabIndex = 90;
            this.txtPhone.Text = "(XXX) XXX-XXXX";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmail.Location = new System.Drawing.Point(532, 414);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(810, 31);
            this.txtEmail.TabIndex = 89;
            this.txtEmail.Text = "youremailhere@email.com";
            // 
            // txtDOB
            // 
            this.txtDOB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDOB.Location = new System.Drawing.Point(942, 354);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(269, 31);
            this.txtDOB.TabIndex = 88;
            this.txtDOB.Text = "MM/DD/YYYY";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(532, 354);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(256, 31);
            this.txtZipcode.TabIndex = 87;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(532, 293);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(399, 31);
            this.txtCity.TabIndex = 86;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(532, 234);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(810, 31);
            this.txtAddress2.TabIndex = 85;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(532, 175);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(810, 31);
            this.txtAddress1.TabIndex = 84;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(1011, 117);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(331, 31);
            this.txtLastName.TabIndex = 83;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(532, 117);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(311, 31);
            this.txtFirstName.TabIndex = 82;
            // 
            // lblMinor
            // 
            this.lblMinor.AutoSize = true;
            this.lblMinor.Location = new System.Drawing.Point(329, 1122);
            this.lblMinor.Name = "lblMinor";
            this.lblMinor.Size = new System.Drawing.Size(197, 25);
            this.lblMinor.TabIndex = 81;
            this.lblMinor.Text = "Minor Composition:";
            // 
            // lblShared
            // 
            this.lblShared.AutoSize = true;
            this.lblShared.Location = new System.Drawing.Point(314, 1063);
            this.lblShared.Name = "lblShared";
            this.lblShared.Size = new System.Drawing.Size(212, 25);
            this.lblShared.TabIndex = 80;
            this.lblShared.Text = "Shared Composition:";
            // 
            // lblIndependent
            // 
            this.lblIndependent.AutoSize = true;
            this.lblIndependent.Location = new System.Drawing.Point(264, 1004);
            this.lblIndependent.Name = "lblIndependent";
            this.lblIndependent.Size = new System.Drawing.Size(262, 25);
            this.lblIndependent.TabIndex = 79;
            this.lblIndependent.Text = "Independent Composition:";
            // 
            // lblHousing
            // 
            this.lblHousing.AutoSize = true;
            this.lblHousing.Location = new System.Drawing.Point(362, 945);
            this.lblHousing.Name = "lblHousing";
            this.lblHousing.Size = new System.Drawing.Size(164, 25);
            this.lblHousing.TabIndex = 78;
            this.lblHousing.Text = "Housing Status:";
            // 
            // lblMilitaryStatus
            // 
            this.lblMilitaryStatus.AutoSize = true;
            this.lblMilitaryStatus.Location = new System.Drawing.Point(372, 886);
            this.lblMilitaryStatus.Name = "lblMilitaryStatus";
            this.lblMilitaryStatus.Size = new System.Drawing.Size(154, 25);
            this.lblMilitaryStatus.TabIndex = 77;
            this.lblMilitaryStatus.Text = "Military Status:";
            // 
            // lblImmigrant
            // 
            this.lblImmigrant.AutoSize = true;
            this.lblImmigrant.Location = new System.Drawing.Point(728, 830);
            this.lblImmigrant.Name = "lblImmigrant";
            this.lblImmigrant.Size = new System.Drawing.Size(294, 25);
            this.lblImmigrant.TabIndex = 76;
            this.lblImmigrant.Text = "Are you a refugee immigrant?";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(437, 830);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(89, 25);
            this.lblGender.TabIndex = 75;
            this.lblGender.Text = "Gender:";
            // 
            // lblHomeless
            // 
            this.lblHomeless.AutoSize = true;
            this.lblHomeless.Location = new System.Drawing.Point(728, 768);
            this.lblHomeless.Name = "lblHomeless";
            this.lblHomeless.Size = new System.Drawing.Size(196, 25);
            this.lblHomeless.TabIndex = 74;
            this.lblHomeless.Text = "Are you homeless?";
            // 
            // lblDisabled
            // 
            this.lblDisabled.AutoSize = true;
            this.lblDisabled.Location = new System.Drawing.Point(240, 768);
            this.lblDisabled.Name = "lblDisabled";
            this.lblDisabled.Size = new System.Drawing.Size(286, 25);
            this.lblDisabled.TabIndex = 73;
            this.lblDisabled.Text = "Are you physically disabled?";
            // 
            // lblEnrollmentDate
            // 
            this.lblEnrollmentDate.AutoSize = true;
            this.lblEnrollmentDate.Location = new System.Drawing.Point(355, 709);
            this.lblEnrollmentDate.Name = "lblEnrollmentDate";
            this.lblEnrollmentDate.Size = new System.Drawing.Size(171, 25);
            this.lblEnrollmentDate.TabIndex = 72;
            this.lblEnrollmentDate.Text = "Enrollment Date:";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(439, 650);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(87, 25);
            this.lblIncome.TabIndex = 71;
            this.lblIncome.Text = "Income:";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(458, 591);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(68, 25);
            this.lblRace.TabIndex = 70;
            this.lblRace.Text = "Race:";
            // 
            // lblEthnicity
            // 
            this.lblEthnicity.AutoSize = true;
            this.lblEthnicity.Location = new System.Drawing.Point(426, 532);
            this.lblEthnicity.Name = "lblEthnicity";
            this.lblEthnicity.Size = new System.Drawing.Size(100, 25);
            this.lblEthnicity.TabIndex = 69;
            this.lblEthnicity.Text = "Ethnicity:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(365, 473);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(161, 25);
            this.lblPhone.TabIndex = 68;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(455, 414);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 25);
            this.lblEmail.TabIndex = 67;
            this.lblEmail.Text = "Email:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(794, 357);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(137, 25);
            this.lblDOB.TabIndex = 66;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblzipcode
            // 
            this.lblzipcode.AutoSize = true;
            this.lblzipcode.Location = new System.Drawing.Point(421, 357);
            this.lblzipcode.Name = "lblzipcode";
            this.lblzipcode.Size = new System.Drawing.Size(105, 25);
            this.lblzipcode.TabIndex = 65;
            this.lblzipcode.Text = "Zip Code:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(937, 296);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(68, 25);
            this.lblState.TabIndex = 64;
            this.lblState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(471, 296);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(55, 25);
            this.lblCity.TabIndex = 63;
            this.lblCity.Text = "City:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(364, 237);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(162, 25);
            this.lblAddress2.TabIndex = 62;
            this.lblAddress2.Text = "Address Line 2:";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(364, 178);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(162, 25);
            this.lblAddress1.TabIndex = 61;
            this.lblAddress1.Text = "Address Line 1:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(884, 120);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(121, 25);
            this.lblLastName.TabIndex = 60;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(404, 120);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(122, 25);
            this.lblFirstName.TabIndex = 59;
            this.lblFirstName.Text = "First Name:";
            // 
            // frmEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1582, 1382);
            this.Controls.Add(this.coBoxState);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.coBoxMinor);
            this.Controls.Add(this.coBoxShared);
            this.Controls.Add(this.coBoxIndependent);
            this.Controls.Add(this.coBoxHousing);
            this.Controls.Add(this.coBoxMilitary);
            this.Controls.Add(this.coBoxGender);
            this.Controls.Add(this.coBocHomeless);
            this.Controls.Add(this.coBoxImmigrant);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.coBoxDisabled);
            this.Controls.Add(this.txtEnrollmentDate);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.txtRace);
            this.Controls.Add(this.txtEthnicity);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtZipcode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblMinor);
            this.Controls.Add(this.lblShared);
            this.Controls.Add(this.lblIndependent);
            this.Controls.Add(this.lblHousing);
            this.Controls.Add(this.lblMilitaryStatus);
            this.Controls.Add(this.lblImmigrant);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblHomeless);
            this.Controls.Add(this.lblDisabled);
            this.Controls.Add(this.lblEnrollmentDate);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblEthnicity);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblzipcode);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Member";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox coBoxState;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox coBoxMinor;
        private System.Windows.Forms.ComboBox coBoxShared;
        private System.Windows.Forms.ComboBox coBoxIndependent;
        private System.Windows.Forms.ComboBox coBoxHousing;
        private System.Windows.Forms.ComboBox coBoxMilitary;
        private System.Windows.Forms.ComboBox coBoxGender;
        private System.Windows.Forms.ComboBox coBocHomeless;
        private System.Windows.Forms.ComboBox coBoxImmigrant;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox coBoxDisabled;
        private System.Windows.Forms.TextBox txtEnrollmentDate;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.TextBox txtRace;
        private System.Windows.Forms.TextBox txtEthnicity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMinor;
        private System.Windows.Forms.Label lblShared;
        private System.Windows.Forms.Label lblIndependent;
        private System.Windows.Forms.Label lblHousing;
        private System.Windows.Forms.Label lblMilitaryStatus;
        private System.Windows.Forms.Label lblImmigrant;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblHomeless;
        private System.Windows.Forms.Label lblDisabled;
        private System.Windows.Forms.Label lblEnrollmentDate;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblEthnicity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblzipcode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
    }
}