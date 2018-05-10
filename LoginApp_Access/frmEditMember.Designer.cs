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
            this.lblNewMember = new System.Windows.Forms.Label();
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
            this.coBoxState.Location = new System.Drawing.Point(858, 360);
            this.coBoxState.Name = "coBoxState";
            this.coBoxState.Size = new System.Drawing.Size(331, 33);
            this.coBoxState.TabIndex = 31;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(736, 1283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(215, 49);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            this.coBoxMinor.Location = new System.Drawing.Point(380, 1189);
            this.coBoxMinor.Name = "coBoxMinor";
            this.coBoxMinor.Size = new System.Drawing.Size(330, 33);
            this.coBoxMinor.TabIndex = 48;
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
            this.coBoxShared.Location = new System.Drawing.Point(379, 1130);
            this.coBoxShared.Name = "coBoxShared";
            this.coBoxShared.Size = new System.Drawing.Size(330, 33);
            this.coBoxShared.TabIndex = 47;
            // 
            // coBoxIndependent
            // 
            this.coBoxIndependent.FormattingEnabled = true;
            this.coBoxIndependent.Items.AddRange(new object[] {
            "Male on own",
            "Female on own"});
            this.coBoxIndependent.Location = new System.Drawing.Point(379, 1071);
            this.coBoxIndependent.Name = "coBoxIndependent";
            this.coBoxIndependent.Size = new System.Drawing.Size(330, 33);
            this.coBoxIndependent.TabIndex = 46;
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
            this.coBoxHousing.Location = new System.Drawing.Point(379, 1012);
            this.coBoxHousing.Name = "coBoxHousing";
            this.coBoxHousing.Size = new System.Drawing.Size(330, 33);
            this.coBoxHousing.TabIndex = 45;
            // 
            // coBoxMilitary
            // 
            this.coBoxMilitary.FormattingEnabled = true;
            this.coBoxMilitary.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Dependent on spouse"});
            this.coBoxMilitary.Location = new System.Drawing.Point(379, 953);
            this.coBoxMilitary.Name = "coBoxMilitary";
            this.coBoxMilitary.Size = new System.Drawing.Size(330, 33);
            this.coBoxMilitary.TabIndex = 44;
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
            this.coBoxGender.Location = new System.Drawing.Point(380, 897);
            this.coBoxGender.Name = "coBoxGender";
            this.coBoxGender.Size = new System.Drawing.Size(189, 33);
            this.coBoxGender.TabIndex = 42;
            // 
            // coBocHomeless
            // 
            this.coBocHomeless.FormattingEnabled = true;
            this.coBocHomeless.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.coBocHomeless.Location = new System.Drawing.Point(777, 835);
            this.coBocHomeless.Name = "coBocHomeless";
            this.coBocHomeless.Size = new System.Drawing.Size(149, 33);
            this.coBocHomeless.TabIndex = 41;
            // 
            // coBoxImmigrant
            // 
            this.coBoxImmigrant.FormattingEnabled = true;
            this.coBoxImmigrant.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.coBoxImmigrant.Location = new System.Drawing.Point(875, 897);
            this.coBoxImmigrant.Name = "coBoxImmigrant";
            this.coBoxImmigrant.Size = new System.Drawing.Size(149, 33);
            this.coBoxImmigrant.TabIndex = 43;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(291, 1283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(215, 49);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // coBoxDisabled
            // 
            this.coBoxDisabled.FormattingEnabled = true;
            this.coBoxDisabled.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.coBoxDisabled.Location = new System.Drawing.Point(380, 835);
            this.coBoxDisabled.Name = "coBoxDisabled";
            this.coBoxDisabled.Size = new System.Drawing.Size(189, 33);
            this.coBoxDisabled.TabIndex = 40;
            // 
            // txtEnrollmentDate
            // 
            this.txtEnrollmentDate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEnrollmentDate.Location = new System.Drawing.Point(379, 776);
            this.txtEnrollmentDate.Name = "txtEnrollmentDate";
            this.txtEnrollmentDate.Size = new System.Drawing.Size(330, 31);
            this.txtEnrollmentDate.TabIndex = 39;
            this.txtEnrollmentDate.Text = "MM/DD/YYYY";
            this.txtEnrollmentDate.Enter += new System.EventHandler(this.txtEnrollmentDate_Enter);
            this.txtEnrollmentDate.Leave += new System.EventHandler(this.txtEnrollmentDate_Leave);
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(379, 717);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(810, 31);
            this.txtIncome.TabIndex = 38;
            // 
            // txtRace
            // 
            this.txtRace.Location = new System.Drawing.Point(379, 658);
            this.txtRace.Name = "txtRace";
            this.txtRace.Size = new System.Drawing.Size(810, 31);
            this.txtRace.TabIndex = 37;
            // 
            // txtEthnicity
            // 
            this.txtEthnicity.Location = new System.Drawing.Point(379, 599);
            this.txtEthnicity.Name = "txtEthnicity";
            this.txtEthnicity.Size = new System.Drawing.Size(810, 31);
            this.txtEthnicity.TabIndex = 36;
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPhone.Location = new System.Drawing.Point(379, 540);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(399, 31);
            this.txtPhone.TabIndex = 35;
            this.txtPhone.Text = "(XXX) XXX-XXXX";
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmail.Location = new System.Drawing.Point(379, 481);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(810, 31);
            this.txtEmail.TabIndex = 34;
            this.txtEmail.Text = "example@someone.com";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtDOB
            // 
            this.txtDOB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDOB.Location = new System.Drawing.Point(789, 421);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(269, 31);
            this.txtDOB.TabIndex = 33;
            this.txtDOB.Text = "MM/DD/YYYY";
            this.txtDOB.Enter += new System.EventHandler(this.txtDOB_Enter);
            this.txtDOB.Leave += new System.EventHandler(this.txtDOB_Leave);
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(379, 421);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(256, 31);
            this.txtZipcode.TabIndex = 32;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(379, 360);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(399, 31);
            this.txtCity.TabIndex = 30;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(379, 301);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(810, 31);
            this.txtAddress2.TabIndex = 29;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(379, 242);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(810, 31);
            this.txtAddress1.TabIndex = 28;
            // 
            // txtLastName
            // 
            this.txtLastName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLastName.Location = new System.Drawing.Point(858, 184);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(331, 31);
            this.txtLastName.TabIndex = 26;
            this.txtLastName.Text = "Doe";
            this.txtLastName.Enter += new System.EventHandler(this.txtLastName_Enter);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFirstName.Location = new System.Drawing.Point(379, 184);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(311, 31);
            this.txtFirstName.TabIndex = 25;
            this.txtFirstName.Text = "Jane";
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // lblMinor
            // 
            this.lblMinor.AutoSize = true;
            this.lblMinor.Location = new System.Drawing.Point(176, 1189);
            this.lblMinor.Name = "lblMinor";
            this.lblMinor.Size = new System.Drawing.Size(197, 25);
            this.lblMinor.TabIndex = 24;
            this.lblMinor.Text = "Minor Composition:";
            // 
            // lblShared
            // 
            this.lblShared.AutoSize = true;
            this.lblShared.Location = new System.Drawing.Point(161, 1130);
            this.lblShared.Name = "lblShared";
            this.lblShared.Size = new System.Drawing.Size(212, 25);
            this.lblShared.TabIndex = 23;
            this.lblShared.Text = "Shared Composition:";
            // 
            // lblIndependent
            // 
            this.lblIndependent.AutoSize = true;
            this.lblIndependent.Location = new System.Drawing.Point(111, 1071);
            this.lblIndependent.Name = "lblIndependent";
            this.lblIndependent.Size = new System.Drawing.Size(262, 25);
            this.lblIndependent.TabIndex = 22;
            this.lblIndependent.Text = "Independent Composition:";
            // 
            // lblHousing
            // 
            this.lblHousing.AutoSize = true;
            this.lblHousing.Location = new System.Drawing.Point(209, 1012);
            this.lblHousing.Name = "lblHousing";
            this.lblHousing.Size = new System.Drawing.Size(164, 25);
            this.lblHousing.TabIndex = 20;
            this.lblHousing.Text = "Housing Status:";
            // 
            // lblMilitaryStatus
            // 
            this.lblMilitaryStatus.AutoSize = true;
            this.lblMilitaryStatus.Location = new System.Drawing.Point(219, 953);
            this.lblMilitaryStatus.Name = "lblMilitaryStatus";
            this.lblMilitaryStatus.Size = new System.Drawing.Size(154, 25);
            this.lblMilitaryStatus.TabIndex = 19;
            this.lblMilitaryStatus.Text = "Military Status:";
            // 
            // lblImmigrant
            // 
            this.lblImmigrant.AutoSize = true;
            this.lblImmigrant.Location = new System.Drawing.Point(575, 897);
            this.lblImmigrant.Name = "lblImmigrant";
            this.lblImmigrant.Size = new System.Drawing.Size(294, 25);
            this.lblImmigrant.TabIndex = 18;
            this.lblImmigrant.Text = "Are you a refugee immigrant?";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(284, 897);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(89, 25);
            this.lblGender.TabIndex = 17;
            this.lblGender.Text = "Gender:";
            // 
            // lblHomeless
            // 
            this.lblHomeless.AutoSize = true;
            this.lblHomeless.Location = new System.Drawing.Point(575, 835);
            this.lblHomeless.Name = "lblHomeless";
            this.lblHomeless.Size = new System.Drawing.Size(196, 25);
            this.lblHomeless.TabIndex = 16;
            this.lblHomeless.Text = "Are you homeless?";
            // 
            // lblDisabled
            // 
            this.lblDisabled.AutoSize = true;
            this.lblDisabled.Location = new System.Drawing.Point(87, 835);
            this.lblDisabled.Name = "lblDisabled";
            this.lblDisabled.Size = new System.Drawing.Size(286, 25);
            this.lblDisabled.TabIndex = 15;
            this.lblDisabled.Text = "Are you physically disabled?";
            // 
            // lblEnrollmentDate
            // 
            this.lblEnrollmentDate.AutoSize = true;
            this.lblEnrollmentDate.Location = new System.Drawing.Point(202, 776);
            this.lblEnrollmentDate.Name = "lblEnrollmentDate";
            this.lblEnrollmentDate.Size = new System.Drawing.Size(171, 25);
            this.lblEnrollmentDate.TabIndex = 14;
            this.lblEnrollmentDate.Text = "Enrollment Date:";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(286, 717);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(87, 25);
            this.lblIncome.TabIndex = 13;
            this.lblIncome.Text = "Income:";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(305, 658);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(68, 25);
            this.lblRace.TabIndex = 12;
            this.lblRace.Text = "Race:";
            // 
            // lblEthnicity
            // 
            this.lblEthnicity.AutoSize = true;
            this.lblEthnicity.Location = new System.Drawing.Point(273, 599);
            this.lblEthnicity.Name = "lblEthnicity";
            this.lblEthnicity.Size = new System.Drawing.Size(100, 25);
            this.lblEthnicity.TabIndex = 11;
            this.lblEthnicity.Text = "Ethnicity:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(212, 540);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(161, 25);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(302, 481);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 25);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(641, 424);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(137, 25);
            this.lblDOB.TabIndex = 8;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblzipcode
            // 
            this.lblzipcode.AutoSize = true;
            this.lblzipcode.Location = new System.Drawing.Point(268, 424);
            this.lblzipcode.Name = "lblzipcode";
            this.lblzipcode.Size = new System.Drawing.Size(105, 25);
            this.lblzipcode.TabIndex = 7;
            this.lblzipcode.Text = "Zip Code:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(784, 363);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(68, 25);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(318, 363);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(55, 25);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(211, 304);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(162, 25);
            this.lblAddress2.TabIndex = 4;
            this.lblAddress2.Text = "Address Line 2:";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(211, 245);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(162, 25);
            this.lblAddress1.TabIndex = 3;
            this.lblAddress1.Text = "Address Line 1:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(731, 187);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(121, 25);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(251, 187);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(122, 25);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblNewMember
            // 
            this.lblNewMember.AutoSize = true;
            this.lblNewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewMember.Location = new System.Drawing.Point(146, 79);
            this.lblNewMember.Name = "lblNewMember";
            this.lblNewMember.Size = new System.Drawing.Size(344, 63);
            this.lblNewMember.TabIndex = 0;
            this.lblNewMember.Text = "Edit Member";
            // 
            // frmEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1328, 1443);
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
            this.Controls.Add(this.lblNewMember);
            this.Name = "frmEdit";
            this.Text = "frmEditMember";
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
        private System.Windows.Forms.Label lblNewMember;
    }
}