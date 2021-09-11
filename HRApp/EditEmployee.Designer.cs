
namespace HRApp
{
    partial class EditEmployee
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
            this.lblEditEmployee = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.btnQualifications = new System.Windows.Forms.Button();
            this.tabEmployees = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.chkLeaver = new System.Windows.Forms.CheckBox();
            this.lblLeaver = new System.Windows.Forms.Label();
            this.dtDateStarted = new System.Windows.Forms.DateTimePicker();
            this.dtDateLeft = new System.Windows.Forms.DateTimePicker();
            this.lblDateStarted = new System.Windows.Forms.Label();
            this.lblDateLeft = new System.Windows.Forms.Label();
            this.tbNINO = new System.Windows.Forms.TextBox();
            this.lblNino = new System.Windows.Forms.Label();
            this.cbReportsTo = new System.Windows.Forms.ComboBox();
            this.lblReportsTo = new System.Windows.Forms.Label();
            this.tbExtensionNumber = new System.Windows.Forms.TextBox();
            this.lblExtensionNumber = new System.Windows.Forms.Label();
            this.cbOfficeLocation = new System.Windows.Forms.ComboBox();
            this.lblOfficeLocation = new System.Windows.Forms.Label();
            this.cbTypeOfEmployee = new System.Windows.Forms.ComboBox();
            this.lblTypeOfEmployee = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.tbJobTitle = new System.Windows.Forms.TextBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.cbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.tbAddress3 = new System.Windows.Forms.TextBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbAddress4 = new System.Windows.Forms.TextBox();
            this.tbAddress1 = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.lblKnownAs = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbKnownAs = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.tbForename = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tabHolidays = new System.Windows.Forms.TabPage();
            this.btnEditHoliday = new System.Windows.Forms.Button();
            this.btnDeleteHoliday = new System.Windows.Forms.Button();
            this.gvEmployeeHolidays = new System.Windows.Forms.DataGridView();
            this.gbRequestHoliday = new System.Windows.Forms.GroupBox();
            this.chApproved = new System.Windows.Forms.CheckBox();
            this.lblApproved = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnSubmitHoliday = new System.Windows.Forms.Button();
            this.tbNumberOfHolidays = new System.Windows.Forms.TextBox();
            this.dtHolidayEnd = new System.Windows.Forms.DateTimePicker();
            this.dtHolidayStart = new System.Windows.Forms.DateTimePicker();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.gbHolidays = new System.Windows.Forms.GroupBox();
            this.btnResetHoliday = new System.Windows.Forms.Button();
            this.tbHolidaysLeft = new System.Windows.Forms.TextBox();
            this.tbHolidaysTaken = new System.Windows.Forms.TextBox();
            this.tbTotalHolidays = new System.Windows.Forms.TextBox();
            this.lblHolidaysLeft = new System.Windows.Forms.Label();
            this.lblHolidaysTaken = new System.Windows.Forms.Label();
            this.lblTotalHolidays = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tabEmployees.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.gbAddress.SuspendLayout();
            this.gbName.SuspendLayout();
            this.tabHolidays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeHolidays)).BeginInit();
            this.gbRequestHoliday.SuspendLayout();
            this.gbHolidays.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEditEmployee
            // 
            this.lblEditEmployee.AutoSize = true;
            this.lblEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEmployee.Location = new System.Drawing.Point(12, 9);
            this.lblEditEmployee.Name = "lblEditEmployee";
            this.lblEditEmployee.Size = new System.Drawing.Size(0, 20);
            this.lblEditEmployee.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(820, 617);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 26);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(714, 617);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 26);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(872, 63);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 32;
            // 
            // btnQualifications
            // 
            this.btnQualifications.Location = new System.Drawing.Point(772, 243);
            this.btnQualifications.Name = "btnQualifications";
            this.btnQualifications.Size = new System.Drawing.Size(100, 26);
            this.btnQualifications.TabIndex = 34;
            this.btnQualifications.Text = "Qualifications";
            this.btnQualifications.UseVisualStyleBackColor = true;
            this.btnQualifications.Click += new System.EventHandler(this.btnQualifications_Click);
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.tabMain);
            this.tabEmployees.Controls.Add(this.tabHolidays);
            this.tabEmployees.Location = new System.Drawing.Point(18, 63);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.SelectedIndex = 0;
            this.tabEmployees.Size = new System.Drawing.Size(920, 540);
            this.tabEmployees.TabIndex = 35;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.chkLeaver);
            this.tabMain.Controls.Add(this.lblLeaver);
            this.tabMain.Controls.Add(this.btnQualifications);
            this.tabMain.Controls.Add(this.dtDateStarted);
            this.tabMain.Controls.Add(this.dtDateLeft);
            this.tabMain.Controls.Add(this.lblDateStarted);
            this.tabMain.Controls.Add(this.lblDateLeft);
            this.tabMain.Controls.Add(this.tbNINO);
            this.tabMain.Controls.Add(this.lblNino);
            this.tabMain.Controls.Add(this.cbReportsTo);
            this.tabMain.Controls.Add(this.lblReportsTo);
            this.tabMain.Controls.Add(this.tbExtensionNumber);
            this.tabMain.Controls.Add(this.lblExtensionNumber);
            this.tabMain.Controls.Add(this.cbOfficeLocation);
            this.tabMain.Controls.Add(this.lblOfficeLocation);
            this.tabMain.Controls.Add(this.cbTypeOfEmployee);
            this.tabMain.Controls.Add(this.lblTypeOfEmployee);
            this.tabMain.Controls.Add(this.tbSalary);
            this.tabMain.Controls.Add(this.lblSalary);
            this.tabMain.Controls.Add(this.cbDepartment);
            this.tabMain.Controls.Add(this.lblDepartment);
            this.tabMain.Controls.Add(this.tbJobTitle);
            this.tabMain.Controls.Add(this.lblJobTitle);
            this.tabMain.Controls.Add(this.cbMaritalStatus);
            this.tabMain.Controls.Add(this.lblMaritalStatus);
            this.tabMain.Controls.Add(this.cbGender);
            this.tabMain.Controls.Add(this.lblGender);
            this.tabMain.Controls.Add(this.gbAddress);
            this.tabMain.Controls.Add(this.lblDateOfBirth);
            this.tabMain.Controls.Add(this.dtDateOfBirth);
            this.tabMain.Controls.Add(this.gbName);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(912, 514);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // chkLeaver
            // 
            this.chkLeaver.AutoSize = true;
            this.chkLeaver.Location = new System.Drawing.Point(480, 283);
            this.chkLeaver.Name = "chkLeaver";
            this.chkLeaver.Size = new System.Drawing.Size(15, 14);
            this.chkLeaver.TabIndex = 52;
            this.chkLeaver.UseVisualStyleBackColor = true;
            // 
            // lblLeaver
            // 
            this.lblLeaver.AutoSize = true;
            this.lblLeaver.Location = new System.Drawing.Point(428, 283);
            this.lblLeaver.Name = "lblLeaver";
            this.lblLeaver.Size = new System.Drawing.Size(46, 13);
            this.lblLeaver.TabIndex = 63;
            this.lblLeaver.Text = "Leaver?";
            // 
            // dtDateStarted
            // 
            this.dtDateStarted.Location = new System.Drawing.Point(480, 245);
            this.dtDateStarted.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtDateStarted.Name = "dtDateStarted";
            this.dtDateStarted.Size = new System.Drawing.Size(200, 20);
            this.dtDateStarted.TabIndex = 50;
            this.dtDateStarted.Value = new System.DateTime(2021, 8, 9, 0, 0, 0, 0);
            // 
            // dtDateLeft
            // 
            this.dtDateLeft.Location = new System.Drawing.Point(480, 311);
            this.dtDateLeft.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtDateLeft.Name = "dtDateLeft";
            this.dtDateLeft.Size = new System.Drawing.Size(200, 20);
            this.dtDateLeft.TabIndex = 53;
            this.dtDateLeft.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lblDateStarted
            // 
            this.lblDateStarted.AutoSize = true;
            this.lblDateStarted.Location = new System.Drawing.Point(407, 250);
            this.lblDateStarted.Name = "lblDateStarted";
            this.lblDateStarted.Size = new System.Drawing.Size(67, 13);
            this.lblDateStarted.TabIndex = 62;
            this.lblDateStarted.Text = "Date Started";
            // 
            // lblDateLeft
            // 
            this.lblDateLeft.AutoSize = true;
            this.lblDateLeft.Location = new System.Drawing.Point(423, 315);
            this.lblDateLeft.Name = "lblDateLeft";
            this.lblDateLeft.Size = new System.Drawing.Size(51, 13);
            this.lblDateLeft.TabIndex = 61;
            this.lblDateLeft.Text = "Date Left";
            // 
            // tbNINO
            // 
            this.tbNINO.BackColor = System.Drawing.SystemColors.Window;
            this.tbNINO.Location = new System.Drawing.Point(133, 352);
            this.tbNINO.Name = "tbNINO";
            this.tbNINO.Size = new System.Drawing.Size(200, 20);
            this.tbNINO.TabIndex = 44;
            // 
            // lblNino
            // 
            this.lblNino.AutoSize = true;
            this.lblNino.Location = new System.Drawing.Point(14, 355);
            this.lblNino.Name = "lblNino";
            this.lblNino.Size = new System.Drawing.Size(120, 13);
            this.lblNino.TabIndex = 60;
            this.lblNino.Text = "National Insurance No.*";
            // 
            // cbReportsTo
            // 
            this.cbReportsTo.FormattingEnabled = true;
            this.cbReportsTo.Location = new System.Drawing.Point(480, 385);
            this.cbReportsTo.Name = "cbReportsTo";
            this.cbReportsTo.Size = new System.Drawing.Size(200, 21);
            this.cbReportsTo.TabIndex = 56;
            // 
            // lblReportsTo
            // 
            this.lblReportsTo.AutoSize = true;
            this.lblReportsTo.Location = new System.Drawing.Point(414, 388);
            this.lblReportsTo.Name = "lblReportsTo";
            this.lblReportsTo.Size = new System.Drawing.Size(60, 13);
            this.lblReportsTo.TabIndex = 58;
            this.lblReportsTo.Text = "Reports To";
            // 
            // tbExtensionNumber
            // 
            this.tbExtensionNumber.BackColor = System.Drawing.SystemColors.Window;
            this.tbExtensionNumber.Location = new System.Drawing.Point(480, 352);
            this.tbExtensionNumber.Name = "tbExtensionNumber";
            this.tbExtensionNumber.Size = new System.Drawing.Size(200, 20);
            this.tbExtensionNumber.TabIndex = 54;
            // 
            // lblExtensionNumber
            // 
            this.lblExtensionNumber.AutoSize = true;
            this.lblExtensionNumber.Location = new System.Drawing.Point(381, 355);
            this.lblExtensionNumber.Name = "lblExtensionNumber";
            this.lblExtensionNumber.Size = new System.Drawing.Size(93, 13);
            this.lblExtensionNumber.TabIndex = 55;
            this.lblExtensionNumber.Text = "Extension Number";
            // 
            // cbOfficeLocation
            // 
            this.cbOfficeLocation.FormattingEnabled = true;
            this.cbOfficeLocation.Location = new System.Drawing.Point(480, 420);
            this.cbOfficeLocation.Name = "cbOfficeLocation";
            this.cbOfficeLocation.Size = new System.Drawing.Size(200, 21);
            this.cbOfficeLocation.TabIndex = 57;
            // 
            // lblOfficeLocation
            // 
            this.lblOfficeLocation.AutoSize = true;
            this.lblOfficeLocation.Location = new System.Drawing.Point(395, 423);
            this.lblOfficeLocation.Name = "lblOfficeLocation";
            this.lblOfficeLocation.Size = new System.Drawing.Size(79, 13);
            this.lblOfficeLocation.TabIndex = 51;
            this.lblOfficeLocation.Text = "Office Location";
            // 
            // cbTypeOfEmployee
            // 
            this.cbTypeOfEmployee.FormattingEnabled = true;
            this.cbTypeOfEmployee.Location = new System.Drawing.Point(480, 456);
            this.cbTypeOfEmployee.Name = "cbTypeOfEmployee";
            this.cbTypeOfEmployee.Size = new System.Drawing.Size(200, 21);
            this.cbTypeOfEmployee.TabIndex = 59;
            // 
            // lblTypeOfEmployee
            // 
            this.lblTypeOfEmployee.AutoSize = true;
            this.lblTypeOfEmployee.Location = new System.Drawing.Point(382, 459);
            this.lblTypeOfEmployee.Name = "lblTypeOfEmployee";
            this.lblTypeOfEmployee.Size = new System.Drawing.Size(92, 13);
            this.lblTypeOfEmployee.TabIndex = 49;
            this.lblTypeOfEmployee.Text = "Type of Employee";
            // 
            // tbSalary
            // 
            this.tbSalary.BackColor = System.Drawing.SystemColors.Window;
            this.tbSalary.Location = new System.Drawing.Point(133, 456);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(200, 20);
            this.tbSalary.TabIndex = 48;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(91, 459);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 46;
            this.lblSalary.Text = "Salary";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(133, 421);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(200, 21);
            this.cbDepartment.TabIndex = 47;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(65, 424);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 42;
            this.lblDepartment.Text = "Department";
            // 
            // tbJobTitle
            // 
            this.tbJobTitle.BackColor = System.Drawing.SystemColors.Window;
            this.tbJobTitle.Location = new System.Drawing.Point(133, 388);
            this.tbJobTitle.Name = "tbJobTitle";
            this.tbJobTitle.Size = new System.Drawing.Size(200, 20);
            this.tbJobTitle.TabIndex = 45;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(80, 391);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(47, 13);
            this.lblJobTitle.TabIndex = 40;
            this.lblJobTitle.Text = "Job Title";
            // 
            // cbMaritalStatus
            // 
            this.cbMaritalStatus.FormattingEnabled = true;
            this.cbMaritalStatus.Location = new System.Drawing.Point(133, 315);
            this.cbMaritalStatus.Name = "cbMaritalStatus";
            this.cbMaritalStatus.Size = new System.Drawing.Size(200, 21);
            this.cbMaritalStatus.TabIndex = 43;
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(59, 318);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(71, 13);
            this.lblMaritalStatus.TabIndex = 38;
            this.lblMaritalStatus.Text = "Marital Status";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(133, 280);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(200, 21);
            this.cbGender.TabIndex = 41;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(85, 283);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 37;
            this.lblGender.Text = "Gender";
            // 
            // gbAddress
            // 
            this.gbAddress.Controls.Add(this.tbAddress2);
            this.gbAddress.Controls.Add(this.tbAddress3);
            this.gbAddress.Controls.Add(this.tbPostcode);
            this.gbAddress.Controls.Add(this.tbAddress4);
            this.gbAddress.Controls.Add(this.tbAddress1);
            this.gbAddress.Location = new System.Drawing.Point(534, 31);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Size = new System.Drawing.Size(345, 166);
            this.gbAddress.TabIndex = 36;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "Address";
            // 
            // tbAddress2
            // 
            this.tbAddress2.Location = new System.Drawing.Point(15, 58);
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(323, 20);
            this.tbAddress2.TabIndex = 5;
            this.tbAddress2.Text = "Address Line 2*";
            // 
            // tbAddress3
            // 
            this.tbAddress3.Location = new System.Drawing.Point(15, 84);
            this.tbAddress3.Name = "tbAddress3";
            this.tbAddress3.Size = new System.Drawing.Size(323, 20);
            this.tbAddress3.TabIndex = 6;
            this.tbAddress3.Text = "Address Line 3";
            // 
            // tbPostcode
            // 
            this.tbPostcode.Location = new System.Drawing.Point(15, 136);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(127, 20);
            this.tbPostcode.TabIndex = 8;
            this.tbPostcode.Text = "Postcode";
            // 
            // tbAddress4
            // 
            this.tbAddress4.Location = new System.Drawing.Point(15, 110);
            this.tbAddress4.Name = "tbAddress4";
            this.tbAddress4.Size = new System.Drawing.Size(323, 20);
            this.tbAddress4.TabIndex = 7;
            this.tbAddress4.Text = "Address Line 4";
            // 
            // tbAddress1
            // 
            this.tbAddress1.Location = new System.Drawing.Point(15, 32);
            this.tbAddress1.Name = "tbAddress1";
            this.tbAddress1.Size = new System.Drawing.Size(323, 20);
            this.tbAddress1.TabIndex = 4;
            this.tbAddress1.Text = "Address Line 1*";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(59, 250);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.lblDateOfBirth.TabIndex = 35;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.Location = new System.Drawing.Point(133, 245);
            this.dtDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtDateOfBirth.TabIndex = 39;
            this.dtDateOfBirth.Value = new System.DateTime(2021, 7, 23, 0, 0, 0, 0);
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.lblKnownAs);
            this.gbName.Controls.Add(this.lblMiddleName);
            this.gbName.Controls.Add(this.lblForename);
            this.gbName.Controls.Add(this.lblSurname);
            this.gbName.Controls.Add(this.tbKnownAs);
            this.gbName.Controls.Add(this.tbMiddleName);
            this.gbName.Controls.Add(this.tbForename);
            this.gbName.Controls.Add(this.tbSurname);
            this.gbName.Location = new System.Drawing.Point(17, 29);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(434, 168);
            this.gbName.TabIndex = 34;
            this.gbName.TabStop = false;
            this.gbName.Text = "Name";
            // 
            // lblKnownAs
            // 
            this.lblKnownAs.AutoSize = true;
            this.lblKnownAs.Location = new System.Drawing.Point(222, 93);
            this.lblKnownAs.Name = "lblKnownAs";
            this.lblKnownAs.Size = new System.Drawing.Size(55, 13);
            this.lblKnownAs.TabIndex = 36;
            this.lblKnownAs.Text = "Known As";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(12, 96);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(80, 13);
            this.lblMiddleName.TabIndex = 35;
            this.lblMiddleName.Text = "Middle Name(s)";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(222, 31);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(58, 13);
            this.lblForename.TabIndex = 34;
            this.lblForename.Text = "Forename*";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 31);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(53, 13);
            this.lblSurname.TabIndex = 33;
            this.lblSurname.Text = "Surname*";
            // 
            // tbKnownAs
            // 
            this.tbKnownAs.Location = new System.Drawing.Point(225, 112);
            this.tbKnownAs.Name = "tbKnownAs";
            this.tbKnownAs.Size = new System.Drawing.Size(175, 20);
            this.tbKnownAs.TabIndex = 3;
            this.tbKnownAs.Text = "Known As";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(15, 112);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(175, 20);
            this.tbMiddleName.TabIndex = 2;
            this.tbMiddleName.Text = "Middle Name(s)";
            // 
            // tbForename
            // 
            this.tbForename.Location = new System.Drawing.Point(225, 47);
            this.tbForename.Name = "tbForename";
            this.tbForename.Size = new System.Drawing.Size(175, 20);
            this.tbForename.TabIndex = 1;
            this.tbForename.Text = "Forename";
            // 
            // tbSurname
            // 
            this.tbSurname.BackColor = System.Drawing.SystemColors.Window;
            this.tbSurname.Location = new System.Drawing.Point(15, 47);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(175, 20);
            this.tbSurname.TabIndex = 0;
            this.tbSurname.Text = "Surname";
            // 
            // tabHolidays
            // 
            this.tabHolidays.Controls.Add(this.btnEditHoliday);
            this.tabHolidays.Controls.Add(this.btnDeleteHoliday);
            this.tabHolidays.Controls.Add(this.gvEmployeeHolidays);
            this.tabHolidays.Controls.Add(this.gbRequestHoliday);
            this.tabHolidays.Controls.Add(this.gbHolidays);
            this.tabHolidays.Location = new System.Drawing.Point(4, 22);
            this.tabHolidays.Name = "tabHolidays";
            this.tabHolidays.Padding = new System.Windows.Forms.Padding(3);
            this.tabHolidays.Size = new System.Drawing.Size(912, 514);
            this.tabHolidays.TabIndex = 1;
            this.tabHolidays.Text = "Holidays";
            this.tabHolidays.UseVisualStyleBackColor = true;
            // 
            // btnEditHoliday
            // 
            this.btnEditHoliday.Location = new System.Drawing.Point(20, 303);
            this.btnEditHoliday.Name = "btnEditHoliday";
            this.btnEditHoliday.Size = new System.Drawing.Size(100, 26);
            this.btnEditHoliday.TabIndex = 58;
            this.btnEditHoliday.Text = "Edit Holiday";
            this.btnEditHoliday.UseVisualStyleBackColor = true;
            this.btnEditHoliday.Click += new System.EventHandler(this.btnEditHoliday_Click);
            // 
            // btnDeleteHoliday
            // 
            this.btnDeleteHoliday.Location = new System.Drawing.Point(126, 303);
            this.btnDeleteHoliday.Name = "btnDeleteHoliday";
            this.btnDeleteHoliday.Size = new System.Drawing.Size(100, 26);
            this.btnDeleteHoliday.TabIndex = 59;
            this.btnDeleteHoliday.Text = "Delete Holiday";
            this.btnDeleteHoliday.UseVisualStyleBackColor = true;
            this.btnDeleteHoliday.Click += new System.EventHandler(this.btnDeleteHoliday_Click);
            // 
            // gvEmployeeHolidays
            // 
            this.gvEmployeeHolidays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmployeeHolidays.Location = new System.Drawing.Point(20, 335);
            this.gvEmployeeHolidays.Name = "gvEmployeeHolidays";
            this.gvEmployeeHolidays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvEmployeeHolidays.Size = new System.Drawing.Size(848, 150);
            this.gvEmployeeHolidays.TabIndex = 53;
            // 
            // gbRequestHoliday
            // 
            this.gbRequestHoliday.Controls.Add(this.chApproved);
            this.gbRequestHoliday.Controls.Add(this.lblApproved);
            this.gbRequestHoliday.Controls.Add(this.tbNotes);
            this.gbRequestHoliday.Controls.Add(this.lblNotes);
            this.gbRequestHoliday.Controls.Add(this.btnSubmitHoliday);
            this.gbRequestHoliday.Controls.Add(this.tbNumberOfHolidays);
            this.gbRequestHoliday.Controls.Add(this.dtHolidayEnd);
            this.gbRequestHoliday.Controls.Add(this.dtHolidayStart);
            this.gbRequestHoliday.Controls.Add(this.lblNumberOfDays);
            this.gbRequestHoliday.Controls.Add(this.lblEndDate);
            this.gbRequestHoliday.Controls.Add(this.lblStartDate);
            this.gbRequestHoliday.Location = new System.Drawing.Point(482, 28);
            this.gbRequestHoliday.Name = "gbRequestHoliday";
            this.gbRequestHoliday.Size = new System.Drawing.Size(386, 301);
            this.gbRequestHoliday.TabIndex = 52;
            this.gbRequestHoliday.TabStop = false;
            this.gbRequestHoliday.Text = "Request Holiday";
            // 
            // chApproved
            // 
            this.chApproved.AutoSize = true;
            this.chApproved.Checked = true;
            this.chApproved.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chApproved.Location = new System.Drawing.Point(132, 252);
            this.chApproved.Name = "chApproved";
            this.chApproved.Size = new System.Drawing.Size(15, 14);
            this.chApproved.TabIndex = 57;
            this.chApproved.UseVisualStyleBackColor = true;
            // 
            // lblApproved
            // 
            this.lblApproved.AutoSize = true;
            this.lblApproved.Location = new System.Drawing.Point(12, 252);
            this.lblApproved.Name = "lblApproved";
            this.lblApproved.Size = new System.Drawing.Size(53, 13);
            this.lblApproved.TabIndex = 56;
            this.lblApproved.Text = "Approved";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(132, 175);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(200, 71);
            this.tbNotes.TabIndex = 55;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(12, 175);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 54;
            this.lblNotes.Text = "Notes";
            // 
            // btnSubmitHoliday
            // 
            this.btnSubmitHoliday.Location = new System.Drawing.Point(232, 252);
            this.btnSubmitHoliday.Name = "btnSubmitHoliday";
            this.btnSubmitHoliday.Size = new System.Drawing.Size(100, 26);
            this.btnSubmitHoliday.TabIndex = 53;
            this.btnSubmitHoliday.Text = "Submit";
            this.btnSubmitHoliday.UseVisualStyleBackColor = true;
            this.btnSubmitHoliday.Click += new System.EventHandler(this.btnSubmitHoliday_Click);
            // 
            // tbNumberOfHolidays
            // 
            this.tbNumberOfHolidays.BackColor = System.Drawing.SystemColors.Window;
            this.tbNumberOfHolidays.Location = new System.Drawing.Point(132, 126);
            this.tbNumberOfHolidays.Name = "tbNumberOfHolidays";
            this.tbNumberOfHolidays.Size = new System.Drawing.Size(200, 20);
            this.tbNumberOfHolidays.TabIndex = 52;
            // 
            // dtHolidayEnd
            // 
            this.dtHolidayEnd.Location = new System.Drawing.Point(132, 73);
            this.dtHolidayEnd.Name = "dtHolidayEnd";
            this.dtHolidayEnd.Size = new System.Drawing.Size(200, 20);
            this.dtHolidayEnd.TabIndex = 37;
            // 
            // dtHolidayStart
            // 
            this.dtHolidayStart.Location = new System.Drawing.Point(132, 27);
            this.dtHolidayStart.Name = "dtHolidayStart";
            this.dtHolidayStart.Size = new System.Drawing.Size(200, 20);
            this.dtHolidayStart.TabIndex = 36;
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Location = new System.Drawing.Point(12, 129);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(85, 13);
            this.lblNumberOfDays.TabIndex = 35;
            this.lblNumberOfDays.Text = "Number Of Days";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(12, 80);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 34;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 31);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 33;
            this.lblStartDate.Text = "Start Date";
            // 
            // gbHolidays
            // 
            this.gbHolidays.Controls.Add(this.btnResetHoliday);
            this.gbHolidays.Controls.Add(this.tbHolidaysLeft);
            this.gbHolidays.Controls.Add(this.tbHolidaysTaken);
            this.gbHolidays.Controls.Add(this.tbTotalHolidays);
            this.gbHolidays.Controls.Add(this.lblHolidaysLeft);
            this.gbHolidays.Controls.Add(this.lblHolidaysTaken);
            this.gbHolidays.Controls.Add(this.lblTotalHolidays);
            this.gbHolidays.Location = new System.Drawing.Point(20, 28);
            this.gbHolidays.Name = "gbHolidays";
            this.gbHolidays.Size = new System.Drawing.Size(417, 210);
            this.gbHolidays.TabIndex = 35;
            this.gbHolidays.TabStop = false;
            this.gbHolidays.Text = "Holidays";
            // 
            // btnResetHoliday
            // 
            this.btnResetHoliday.Location = new System.Drawing.Point(245, 168);
            this.btnResetHoliday.Name = "btnResetHoliday";
            this.btnResetHoliday.Size = new System.Drawing.Size(100, 26);
            this.btnResetHoliday.TabIndex = 54;
            this.btnResetHoliday.Text = "Reset";
            this.btnResetHoliday.UseVisualStyleBackColor = true;
            // 
            // tbHolidaysLeft
            // 
            this.tbHolidaysLeft.BackColor = System.Drawing.SystemColors.Window;
            this.tbHolidaysLeft.Location = new System.Drawing.Point(145, 122);
            this.tbHolidaysLeft.Name = "tbHolidaysLeft";
            this.tbHolidaysLeft.Size = new System.Drawing.Size(200, 20);
            this.tbHolidaysLeft.TabIndex = 51;
            // 
            // tbHolidaysTaken
            // 
            this.tbHolidaysTaken.BackColor = System.Drawing.SystemColors.Window;
            this.tbHolidaysTaken.Location = new System.Drawing.Point(145, 73);
            this.tbHolidaysTaken.Name = "tbHolidaysTaken";
            this.tbHolidaysTaken.Size = new System.Drawing.Size(200, 20);
            this.tbHolidaysTaken.TabIndex = 50;
            this.tbHolidaysTaken.Leave += new System.EventHandler(this.tbHolidaysTaken_Leave);
            // 
            // tbTotalHolidays
            // 
            this.tbTotalHolidays.BackColor = System.Drawing.SystemColors.Window;
            this.tbTotalHolidays.Location = new System.Drawing.Point(145, 28);
            this.tbTotalHolidays.Name = "tbTotalHolidays";
            this.tbTotalHolidays.Size = new System.Drawing.Size(200, 20);
            this.tbTotalHolidays.TabIndex = 49;
            this.tbTotalHolidays.Leave += new System.EventHandler(this.tbTotalHolidays_Leave);
            // 
            // lblHolidaysLeft
            // 
            this.lblHolidaysLeft.AutoSize = true;
            this.lblHolidaysLeft.Location = new System.Drawing.Point(12, 129);
            this.lblHolidaysLeft.Name = "lblHolidaysLeft";
            this.lblHolidaysLeft.Size = new System.Drawing.Size(68, 13);
            this.lblHolidaysLeft.TabIndex = 35;
            this.lblHolidaysLeft.Text = "Holidays Left";
            // 
            // lblHolidaysTaken
            // 
            this.lblHolidaysTaken.AutoSize = true;
            this.lblHolidaysTaken.Location = new System.Drawing.Point(12, 80);
            this.lblHolidaysTaken.Name = "lblHolidaysTaken";
            this.lblHolidaysTaken.Size = new System.Drawing.Size(81, 13);
            this.lblHolidaysTaken.TabIndex = 34;
            this.lblHolidaysTaken.Text = "Holidays Taken";
            // 
            // lblTotalHolidays
            // 
            this.lblTotalHolidays.AutoSize = true;
            this.lblTotalHolidays.Location = new System.Drawing.Point(12, 31);
            this.lblTotalHolidays.Name = "lblTotalHolidays";
            this.lblTotalHolidays.Size = new System.Drawing.Size(74, 13);
            this.lblTotalHolidays.TabIndex = 33;
            this.lblTotalHolidays.Text = "Total Holidays";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(19, 34);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 64;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 666);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tabEmployees);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblEditEmployee);
            this.Name = "EditEmployee";
            this.Text = "Edit Employee";
            this.Load += new System.EventHandler(this.EditEmployee_Load);
            this.tabEmployees.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.tabHolidays.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeHolidays)).EndInit();
            this.gbRequestHoliday.ResumeLayout(false);
            this.gbRequestHoliday.PerformLayout();
            this.gbHolidays.ResumeLayout(false);
            this.gbHolidays.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditEmployee;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnQualifications;
        private System.Windows.Forms.TabControl tabEmployees;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.CheckBox chkLeaver;
        private System.Windows.Forms.Label lblLeaver;
        private System.Windows.Forms.DateTimePicker dtDateStarted;
        private System.Windows.Forms.DateTimePicker dtDateLeft;
        private System.Windows.Forms.Label lblDateStarted;
        private System.Windows.Forms.Label lblDateLeft;
        private System.Windows.Forms.TextBox tbNINO;
        private System.Windows.Forms.Label lblNino;
        private System.Windows.Forms.ComboBox cbReportsTo;
        private System.Windows.Forms.Label lblReportsTo;
        private System.Windows.Forms.TextBox tbExtensionNumber;
        private System.Windows.Forms.Label lblExtensionNumber;
        private System.Windows.Forms.ComboBox cbOfficeLocation;
        private System.Windows.Forms.Label lblOfficeLocation;
        private System.Windows.Forms.ComboBox cbTypeOfEmployee;
        private System.Windows.Forms.Label lblTypeOfEmployee;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox tbJobTitle;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.ComboBox cbMaritalStatus;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.TextBox tbAddress3;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbAddress4;
        private System.Windows.Forms.TextBox tbAddress1;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtDateOfBirth;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.Label lblKnownAs;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbKnownAs;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.TextBox tbForename;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TabPage tabHolidays;
        private System.Windows.Forms.GroupBox gbHolidays;
        private System.Windows.Forms.TextBox tbHolidaysLeft;
        private System.Windows.Forms.TextBox tbHolidaysTaken;
        private System.Windows.Forms.TextBox tbTotalHolidays;
        private System.Windows.Forms.Label lblHolidaysLeft;
        private System.Windows.Forms.Label lblHolidaysTaken;
        private System.Windows.Forms.Label lblTotalHolidays;
        private System.Windows.Forms.GroupBox gbRequestHoliday;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DataGridView gvEmployeeHolidays;
        private System.Windows.Forms.Button btnSubmitHoliday;
        private System.Windows.Forms.TextBox tbNumberOfHolidays;
        private System.Windows.Forms.DateTimePicker dtHolidayEnd;
        private System.Windows.Forms.DateTimePicker dtHolidayStart;
        private System.Windows.Forms.Button btnResetHoliday;
        private System.Windows.Forms.CheckBox chApproved;
        private System.Windows.Forms.Label lblApproved;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnEditHoliday;
        private System.Windows.Forms.Button btnDeleteHoliday;
    }
}