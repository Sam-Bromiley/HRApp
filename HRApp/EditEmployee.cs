
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRApp
{
    public partial class EditEmployee : Form
    {
        private readonly HRAppEntities _db;
        private ManageEmployees _manageEmployees;
        private bool isEditMode;
        private User _user;
        public bool isValid = true;



        //Initialise fields for adding a new employees and set some fields as default
        public EditEmployee(User user, ManageEmployees manageEmployees = null)
        {
            InitializeComponent();
            _db = new HRAppEntities();
            _manageEmployees = manageEmployees;
            lblEditEmployee.Text = "Add New Employee";
            this.Text = "Add New Employee";
            isEditMode = false;

            dtDateOfBirth.Value = DateTime.Today;
            dtDateStarted.Value = DateTime.Today;
            dtDateLeft.Value = DateTime.Today;
            _user = user;
            tbTotalHolidays.Text = 26.ToString();
            tbHolidaysTaken.Text = "0";
            tbHolidaysLeft.Text = 26.ToString();
            cbPayFrequency.SelectedItem = "Monthly";
            tbAnnualSalary.Text = "0";
            tbPeriodSalary.Text = "0";
            tbHourlyRate.Text = "0";
            tbHoursPerPeriod.Text = "0";
            CalculateNumberOfHolidays();

        }

        //initialise fields for editing employee and pull through their details
        public EditEmployee(Employee employeeToEdit, User user, ManageEmployees manageEmployees = null)
        {
            InitializeComponent();
            _db = new HRAppEntities();
            _manageEmployees = manageEmployees;
            lblEditEmployee.Text = "Edit Employee";
            this.Text = "Edit Employee";
            PopulateFields(employeeToEdit);
            isEditMode = true;
            _user = user;
            CalculateNumberOfHolidays();
        }

        //Populate fields in employee record
        private void PopulateFields(Employee employeeToEdit)
        {

            lblId.Text = employeeToEdit.id.ToString();
            tbSurname.Text = employeeToEdit.Surname;
            tbForename.Text = employeeToEdit.Forename;
            tbMiddleName.Text = employeeToEdit.MiddleName;
            tbKnownAs.Text = employeeToEdit.KnownAs;
            tbAddress1.Text = employeeToEdit.Address1;
            tbAddress2.Text = employeeToEdit.Address2;
            tbAddress3.Text = employeeToEdit.Address3;
            tbAddress4.Text = employeeToEdit.Address4;
            tbPostcode.Text = employeeToEdit.Postcode;
            dtDateOfBirth.Value = (DateTime)employeeToEdit.DateOfBirth;
            tbNINO.Text = employeeToEdit.NationalInsuranceNo;
            tbJobTitle.Text = employeeToEdit.JobTitle;
            tbSalary.Text = employeeToEdit.Salary.ToString();
            dtDateStarted.Value = (DateTime)employeeToEdit.DateStarted;
            dtDateLeft.Value = (DateTime)employeeToEdit.DateLeft;
            chkLeaver.Checked = (bool)employeeToEdit.Leaver;
            tbExtensionNumber.Text = employeeToEdit.ExtensionNumber.ToString();
            cbDepartment.SelectedValue = (int)employeeToEdit.DepartmentId;
            cbOfficeLocation.SelectedValue = (int)employeeToEdit.OfficeLocationId;
            tbTotalHolidays.Text = employeeToEdit.TotalHolidays.ToString();
            tbHolidaysTaken.Text = employeeToEdit.HolidaysTaken.ToString();
            tbHolidaysLeft.Text = employeeToEdit.HolidaysLeft.ToString();
            tbAnnualSalary.Text = employeeToEdit.AnnualSalary.ToString();
            tbPeriodSalary.Text = employeeToEdit.AnnualSalary.ToString();
            cbStudentLoan.SelectedValue = (int)employeeToEdit.StudentLoanId;
            chkPostgradLoan.Checked = (bool)employeeToEdit.PostGradLoan;
            cbNILetters.SelectedValue = (int)employeeToEdit.NILetterId;
            tbTaxCode.Text = employeeToEdit.TaxCode;
            chkWeek1.Checked = (bool)employeeToEdit.TaxBasisW1;
            tbHourlyRate.Text = employeeToEdit.HourlyRate.ToString();
            tbHoursPerPeriod.Text = employeeToEdit.HoursPerPeriod.ToString();
            if ((bool)employeeToEdit.PayBasis)
            {
                radSalary.Checked = true;
            }
            else 
            {
                radHourlyRate.Checked = true;
            }


            //addEditEmployee.AnnualSalary = int.Parse(tbAnnualSalary.Text);
            //addEditEmployee.PeriodSalary = int.Parse(tbPeriodSalary.Text);
            //addEditEmployee.StudentLoanId = (int)cbStudentLoan.SelectedValue;
            //addEditEmployee.PostGradLoan = chkPostgradLoan.Checked;
            //addEditEmployee.NILetterId = (int)cbNILetters.SelectedValue;
            //addEditEmployee.TaxCode = tbTaxCode.Text;
            //addEditEmployee.TaxBasisW1 = chkWeek1.Checked;

            PopulateHolidays();
            PopulateFrequency();


        }

        //change text on Period Salary and hours/period fields depending on frequency selected
        private void PopulateFrequency()
        {
            try
            {
                if (cbPayFrequency.SelectedIndex == 0)
                {
                    lblPeriodSalary.Text = "Monthly Salary";
                    lblHoursInPeriod.Text = "Hours/Month";
                }
                else if (cbPayFrequency.SelectedIndex == 1)
                {
                    lblPeriodSalary.Text = "Weekly Salary";
                    lblHoursInPeriod.Text = "Hours/Week";
                }
                else if (cbPayFrequency.SelectedIndex == 2)
                {
                    lblPeriodSalary.Text = "Two Weekly Salary";
                    lblHoursInPeriod.Text = "Hours/Two Weeks";
                }
                else if (cbPayFrequency.SelectedIndex == 3)
                {
                    lblPeriodSalary.Text = "Four Weekly Salary";
                    lblHoursInPeriod.Text = "Hours/Four Weeks";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }

        //populate the table of holidays for the employee
        private void PopulateHolidays()
        {
            var id = int.Parse(lblId.Text);
            var holidayList = _db.Holidays
                .Where(q => q.Employee_id == id)
                .Select(q => new
                {
                    ID = q.id,
                    q.NumberOfDays,
                    q.StartDate,
                    q.EndDate,
                    q.isApproved,
                    q.Notes
                }).ToList();
            gvEmployeeHolidays.DataSource = holidayList;
            gvEmployeeHolidays.Columns["id"].Visible = false;
            gvEmployeeHolidays.Columns["NumberOfDays"].HeaderText = "Number Of Days";
            gvEmployeeHolidays.Columns["isApproved"].HeaderText = "Approved";
            gvEmployeeHolidays.Columns["StartDate"].HeaderText = "Start Date";
            gvEmployeeHolidays.Columns["EndDate"].HeaderText = "End Date";
            
        }

        //load dropdowns on screen open and set colour if adding employee
        private void EditEmployee_Load(object sender, EventArgs e)
        {
            var gender = _db.Genders.ToList();
            cbGender.ValueMember = "Gender_id";
            cbGender.DisplayMember = "GenderName";
            cbGender.DataSource = gender;

            var maritalStatus = _db.MaritalStatus.ToList();
            cbMaritalStatus.DisplayMember = "MaritalStatus";
            cbMaritalStatus.ValueMember = "MaritalStatus_id";
            cbMaritalStatus.DataSource = maritalStatus;

            var department = _db.Departments.ToList();
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "department_id";
            cbDepartment.DataSource = department;

            var typeOfEmployee = _db.TypeOfEmployees.ToList();
            cbTypeOfEmployee.ValueMember = "Type_id";
            cbTypeOfEmployee.DisplayMember = "TypeOfEmployee1";
            cbTypeOfEmployee.DataSource = typeOfEmployee;

            var officeLocations = _db.OfficeLocations.ToList();
            cbOfficeLocation.ValueMember = "office_id";
            cbOfficeLocation.DisplayMember = "OfficeLocation1";
            cbOfficeLocation.DataSource = officeLocations;

            var niLetters = _db.NILetters.ToList();
            cbNILetters.ValueMember = "Ni_Id";
            cbNILetters.DisplayMember = "NiLetter1";            
            cbNILetters.DataSource = niLetters;

            var payFrequencies = _db.PayFrequencies.ToList();
            cbPayFrequency.ValueMember = "Frequency_id";
            cbPayFrequency.DisplayMember = "PayFrequency1";
            cbPayFrequency.DataSource = payFrequencies;

            var studentLoan = _db.StudentLoans.ToList();
            cbStudentLoan.ValueMember = "Sloan_Id";
            cbStudentLoan.DisplayMember = "PlanType";
            cbStudentLoan.DataSource = studentLoan;
            

            if (!chkLeaver.Checked)
            {
                dtDateLeft.Enabled = false;
            }

            if(!isEditMode)
            {
                tbSurname.BackColor = Color.LightGoldenrodYellow;
                tbForename.BackColor = Color.LightGoldenrodYellow;
                tbAddress1.BackColor = Color.LightGoldenrodYellow;
                tbAddress2.BackColor = Color.LightGoldenrodYellow;
                tbPostcode.BackColor = Color.LightGoldenrodYellow;
                tbNINO.BackColor = Color.LightGoldenrodYellow;
                tbTaxCode.BackColor = Color.LightGoldenrodYellow;
                lblMessage.Text = "Please ensure all mandatory fields highlighted have been filled out correctly before saving";
            }

            //disable fields for reviewer role
            if (_user.RoleId == 3)
            {
                tbSurname.Enabled = false;
                tbForename.Enabled = false;
                tbMiddleName.Enabled = false;
                tbKnownAs.Enabled = false;
                tbAddress1.Enabled = false;
                tbAddress2.Enabled = false;
                tbAddress3.Enabled = false;
                tbAddress4.Enabled = false;
                tbPostcode.Enabled = false;
                dtDateOfBirth.Enabled = false;
                tbNINO.Enabled = false;
                cbGender.Enabled = false;
                cbMaritalStatus.Enabled = false;
                tbJobTitle.Enabled = false;
                cbDepartment.Enabled = false;
                tbSalary.Enabled = false;
                dtDateStarted.Enabled = false;
                chkLeaver.Enabled = false;
                dtDateLeft.Enabled = false;
                tbExtensionNumber.Enabled = false;
                cbReportsTo.Enabled = false;
                cbOfficeLocation.Enabled = false;
                cbTypeOfEmployee.Enabled = false;
                btnSave.Visible = false;
                btnCancel.Text = "OK";
                tbTotalHolidays.Enabled = false;
                tbHolidaysTaken.Enabled = false;
                tbHolidaysLeft.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEditMode)
                {
                    bool payBasis = true;
                    if (radSalary.Checked)
                    {
                        payBasis = true;
                    }
                    else if (radHourlyRate.Checked)
                    {
                        payBasis = false;
                    }
                    //save the fields to the database tha have been edited
                    var id = int.Parse(lblId.Text);
                    var addEditEmployee = _db.Employees.FirstOrDefault(q => q.id == id);


                    addEditEmployee.Surname = tbSurname.Text;
                    addEditEmployee.Forename = tbForename.Text;
                    addEditEmployee.MiddleName = tbMiddleName.Text;
                    addEditEmployee.KnownAs = tbKnownAs.Text;
                    addEditEmployee.Address1 = tbAddress1.Text;
                    addEditEmployee.Address2 = tbAddress2.Text;
                    addEditEmployee.Address3 = tbAddress3.Text;
                    addEditEmployee.Address4 = tbAddress4.Text;
                    addEditEmployee.Postcode = tbPostcode.Text;
                    addEditEmployee.DateOfBirth = dtDateOfBirth.Value;
                    addEditEmployee.GenderId = (int)cbGender.SelectedValue;
                    addEditEmployee.DateOfBirth = dtDateOfBirth.Value;
                    addEditEmployee.DateStarted = dtDateStarted.Value;
                    addEditEmployee.DateLeft = dtDateLeft.Value;
                    addEditEmployee.MaritalStatusId = (int)cbMaritalStatus.SelectedValue;
                    addEditEmployee.DepartmentId = (int)cbDepartment.SelectedValue;
                    addEditEmployee.OfficeLocationId = (int)cbOfficeLocation.SelectedValue;
                    addEditEmployee.TypeOfEmployeeId = (int)cbTypeOfEmployee.SelectedValue;
                    addEditEmployee.NationalInsuranceNo = tbNINO.Text;
                    addEditEmployee.JobTitle = tbJobTitle.Text;
                    double editSalary = double.Parse(tbSalary.Text);
                    addEditEmployee.Salary = (decimal)editSalary;
                    addEditEmployee.ExtensionNumber = int.Parse(tbExtensionNumber.Text);
                    addEditEmployee.Leaver = chkLeaver.Checked;
                    addEditEmployee.TotalHolidays = int.Parse(tbTotalHolidays.Text);
                    addEditEmployee.HolidaysTaken = int.Parse(tbHolidaysTaken.Text);
                    addEditEmployee.HolidaysLeft = int.Parse(tbHolidaysLeft.Text);
                    addEditEmployee.AnnualSalary = double.Parse(tbAnnualSalary.Text);
                    addEditEmployee.PeriodSalary = double.Parse(tbPeriodSalary.Text);
                    addEditEmployee.StudentLoanId = (int)cbStudentLoan.SelectedValue;
                    addEditEmployee.PostGradLoan = chkPostgradLoan.Checked;
                    addEditEmployee.NILetterId = (int)cbNILetters.SelectedValue;
                    addEditEmployee.TaxCode = tbTaxCode.Text;
                    addEditEmployee.TaxBasisW1 = chkWeek1.Checked;
                    addEditEmployee.HourlyRate = double.Parse(tbHourlyRate.Text);
                    addEditEmployee.HoursPerPeriod = double.Parse(tbHoursPerPeriod.Text);
                    addEditEmployee.PayBasis = payBasis;
                    

                    _db.SaveChanges();
                    _manageEmployees.PopulateEmployees();
                    Close();
                }
                else
                {
                    
                    //get new employee details on when adding
                    string ErrorMessage = "Please ensure you have filled out the following fields: \n\r";
                    
                    string MiddleName = "";
                    string KnownAs = "";
                    string Address3 = "";
                    string Address4 = "";
                    string JobTitle = "";
                    decimal Salary = 0;
                    int Extension = 0;
                    //checking if fields have been updated and setting the values
                    if(tbMiddleName.Text != "Middle Name(s)")
                    {                    
                        MiddleName = tbMiddleName.Text;
                    }

                    if (tbKnownAs.Text != "Known As")
                    {
                        KnownAs = tbKnownAs.Text;
                    }

                    if (tbAddress3.Text != "Address Line 3")
                    {
                        Address3 = tbAddress3.Text;
                    }
                    if (tbAddress4.Text != "Address Line 4")
                    {
                        Address4 = tbAddress4.Text;
                    }
                    if (tbJobTitle.Text == "Job Title")
                    {
                        JobTitle = tbJobTitle.Text;
                    }
                    if (tbSalary.Text != "")
                    {
                        Salary = decimal.Parse(tbSalary.Text);
                    }
                    if (tbExtensionNumber.Text != "")
                    {
                        Extension= int.Parse(tbExtensionNumber.Text);
                    }
                    if (cbNILetters.SelectedValue == null)
                    {
                        cbNILetters.SelectedValue = 0;
                    }
                    if (cbStudentLoan.SelectedValue == null)
                    {
                        cbStudentLoan.SelectedValue = 0;
                    }
                    //validation for the fields to ensure values have been entered
                    if (tbSurname.Text == "Surname" || tbSurname.Text == "")
                    {
                        isValid = false;
                        ErrorMessage += "Surname \n\r";
                    }
                    if (tbForename.Text == "Forename" || tbForename.Text == "")
                    {
                        isValid = false;
                        ErrorMessage += "Forename \n\r";
                    }

                    if (tbAddress1.Text == "Address Line 1*" || tbAddress1.Text == "")
                    {
                        isValid = false;
                        ErrorMessage += "Address Line 1 \n\r";
                    }
                    if (tbAddress2.Text == "Address Line 2*" || tbAddress2.Text == "")
                    {
                        isValid = false;
                        ErrorMessage += "Address Line 2 \n\r";
                    }
                    if (tbPostcode.Text == "Postcode" || tbPostcode.Text == "")
                    {
                        isValid = false;
                        ErrorMessage += "Postcode \n\r";
                    }
                    if (tbNINO.Text == "")
                    {
                        isValid = false;
                        ErrorMessage += "National Insurance Number";
                    }
                    

                    //check if employee has taken more holidays than allowance
                    if (int.Parse(tbHolidaysLeft.Text) < 0)
                    {
                        isValid = false;
                        MessageBox.Show("Employee cannot take more holidays than their allowance \n\r" +
                        "Please correct this before saving");
                    }
                    //adding employee to database
                    if (isValid)
                    {
                        bool payBasis = true;
                        if (radSalary.Checked)
                        {
                            payBasis = true;
                        }
                        else if(radHourlyRate.Checked)
                        {
                            payBasis = false;
                        }
                        var addEditEmployee = new Employee
                        {
                            Surname = tbSurname.Text,
                            Forename = tbForename.Text,
                            MiddleName = MiddleName,
                            KnownAs = KnownAs,
                            Address1 = tbAddress1.Text,
                            Address2 = tbAddress2.Text,
                            Address3 = Address3,
                            Address4 = Address4,
                            Postcode = tbPostcode.Text,
                            DateOfBirth = dtDateOfBirth.Value,
                            GenderId = (int)cbGender.SelectedValue,
                            DateStarted = dtDateStarted.Value,
                            DateLeft = dtDateLeft.Value,
                            MaritalStatusId = (int)cbMaritalStatus.SelectedValue,
                            DepartmentId = (int)cbDepartment.SelectedValue,
                            //ReportsToId = (int)cbReportsTo.SelectedValue,
                            OfficeLocationId = (int)cbOfficeLocation.SelectedValue,
                            TypeOfEmployeeId = (int)cbTypeOfEmployee.SelectedValue,
                            NationalInsuranceNo = tbNINO.Text,
                            JobTitle = JobTitle,
                            Salary = Salary,
                            ExtensionNumber = Extension,
                            Leaver = chkLeaver.Checked,
                            TotalHolidays = int.Parse(tbTotalHolidays.Text),
                            HolidaysTaken = int.Parse(tbHolidaysTaken.Text),
                            HolidaysLeft = int.Parse(tbHolidaysLeft.Text),
                            TaxCode = tbTaxCode.Text,
                            TaxBasisW1 = chkWeek1.Checked,
                            NILetterId = (int)cbNILetters.SelectedValue,
                            AnnualSalary = double.Parse(tbAnnualSalary.Text),
                            PeriodSalary = double.Parse(tbPeriodSalary.Text),
                            StudentLoanId = (int)cbStudentLoan.SelectedValue,
                            PostGradLoan = chkPostgradLoan.Checked,
                            Frequency_id = (int)cbPayFrequency.SelectedValue,
                            HourlyRate = double.Parse(tbHourlyRate.Text),
                            HoursPerPeriod = double.Parse(tbHoursPerPeriod.Text),
                            PayBasis = payBasis

                        };

                        _db.Employees.Add(addEditEmployee);
                        _db.SaveChanges();
                        _manageEmployees.PopulateEmployees();
                        Close();

                    } 
                    else
                    {
                        MessageBox.Show(ErrorMessage);
                    }
                }
              

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message} \n\r" +
                    $"Please ensure all fields have been filled out correctly");
            }
            
        }

        //enable date left field if leaver is checked
        private void chkLeaver_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkLeaver.Checked)
            {
                dtDateLeft.Enabled = false;
            }
            else
            {
                dtDateLeft.Enabled = true;
            }
        }
        //setting fields to blank if not been edited
        private void tbSurname_Click(object sender, EventArgs e)
        {
            if (tbSurname.Text == "Surname")
            {
                tbSurname.Text = "";
            }
        }

        private void tbForename_Click(object sender, EventArgs e)
        {
            if (tbForename.Text == "Forename")
            {
                tbForename.Text = "";
            }
        }

        private void tbMiddleName_Click(object sender, EventArgs e)
        {
            if (tbMiddleName.Text == "Middle Name(s)")
            {
                tbMiddleName.Text = "";
            }
        }

        private void tbKnownAs_Click(object sender, EventArgs e)
        {
            if (tbKnownAs.Text == "Known As")
            {
                tbKnownAs.Text = "";
            }
        }

        private void tbAddress1_Click(object sender, EventArgs e)
        {
            if (tbAddress1.Text == "Address Line 1*")
            {
                tbAddress1.Text = "";
            }
        }

        private void tbAddress2_Click(object sender, EventArgs e)
        {
            if (tbAddress2.Text == "Address Line 2*")
            {
                tbAddress2.Text = "";
            }
        }

        private void tbAddress3_Click(object sender, EventArgs e)
        {
            if (tbAddress3.Text == "Address Line 3")
            {
                tbAddress3.Text = "";
            }
        }

        private void tbAddress4_Click(object sender, EventArgs e)
        {
            if (tbAddress4.Text == "Address Line 4")
            {
                tbAddress4.Text = "";
            }
        }

        private void tbPostcode_Click(object sender, EventArgs e)
        {
            if (tbPostcode.Text == "Postcode")
            {
                tbPostcode.Text = "";
            }

        }

        //Open qualifications page
        private void btnQualifications_Click(object sender, EventArgs e)
        {
            var id = int.Parse(lblId.Text);
            var employee = _db.Employees.FirstOrDefault(q => q.id == id);
            var qualifications = new Qualifications(employee);
            qualifications.MdiParent = this.MdiParent;
            qualifications.StartPosition = FormStartPosition.CenterScreen;
            qualifications.Show();

        }

        //calculate holidays left field based on total and holidays taken
        private void CalculateHolidays()
        {
            try
            {
                var holidaysTaken = 0;
                if(tbHolidaysTaken.Text != "0" && tbHolidaysTaken.Text != "")
                {
                     holidaysTaken = int.Parse(tbHolidaysTaken.Text);
                } 
                else
                {
                    holidaysTaken = 0;
                }
                var holidaysLeft = int.Parse(tbTotalHolidays.Text) - holidaysTaken;
                if(holidaysLeft < 0)
                {
                    MessageBox.Show("Employee cannot take more holidays than their allowance \n\r" +
                        "Please correct this before saving");
                   
                }
                tbHolidaysLeft.Text = holidaysLeft.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Holidays Error: {ex.Message}");
            }
            
        }

       
        //run CalculateHolidays method when clicking out of either total holidays or holidays taken
        private void tbTotalHolidays_Leave(object sender, EventArgs e)
        {
            CalculateHolidays();
        }

        private void tbHolidaysTaken_Leave(object sender, EventArgs e)
        {
            CalculateHolidays();
        }

        //save a new holiday record 
        private void btnSubmitHoliday_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime holStart = Convert.ToDateTime(dtHolidayStart.Value);
                DateTime holEnd = Convert.ToDateTime(dtHolidayEnd.Value);
                int numberOfHolidays = int.Parse(tbNumberOfHolidays.Text);
                int HolidaysTaken = int.Parse(tbHolidaysTaken.Text);
                if (!isEditMode) // cannot add to new employee and needs to be current
                {
                    MessageBox.Show("Please save the employees record before adding holidays");
                }
                else if (holStart > holEnd) //checking holiday dates are valid
                {
                    MessageBox.Show("Please enter valid dates"); 
                }
                else
                {
                    DialogResult dr = MessageBox.Show($"Are you sure you want to add add holidaye for {tbForename.Text} {tbSurname.Text} for the following dates: \n\r" +
                        $"Start Date: {dtHolidayStart.Value}\n\r" +
                        $"End Date: {dtHolidayEnd.Value}", "Add Holiday", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        var newHolidayRequest = new Holiday
                        {
                            Employee_id = int.Parse(lblId.Text),
                            StartDate = dtHolidayStart.Value,
                            EndDate = dtHolidayEnd.Value,
                            NumberOfDays = (holEnd.Subtract(holStart).Days) + 1,
                            Notes = tbNotes.Text,
                            isApproved = chApproved.Checked
                        };
                       
                        _db.Holidays.Add(newHolidayRequest);
                        _db.SaveChanges();

                    }
                }
                int id = int.Parse(lblId.Text);
                var employee = _db.Employees.FirstOrDefault(q => q.id == id);
                employee.HolidaysTaken += numberOfHolidays; //add number of holidays added to holidays taken field
                PopulateFields(employee); //populate details so that all holidays can be recalculated
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            


        }

       //edit holidays --not yet implemented
        private void btnEditHoliday_Click(object sender, EventArgs e)
        {
            
        }

        //removed holiday record
        private void btnDeleteHoliday_Click(object sender, EventArgs e)
        {
            DateTime holStart = Convert.ToDateTime(dtHolidayStart.Value);
            DateTime holEnd = Convert.ToDateTime(dtHolidayEnd.Value);
            int numberOfHolidays = int.Parse(tbNumberOfHolidays.Text);
            int HolidaysTaken = int.Parse(tbHolidaysTaken.Text);
            var id = (int)gvEmployeeHolidays.SelectedRows[0].Cells["id"].Value;
            var holiday = _db.Holidays.FirstOrDefault(q => q.id == id);
            DialogResult dr = MessageBox.Show($"Are you sure you want delete the holiday entry for {tbForename.Text} {tbSurname.Text} for the following dates: \n\r" +
                        $"Start Date: {holiday.StartDate}\n\r" +
                        $"End Date: {holiday.EndDate}", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                _db.Holidays.Remove(holiday);
                _db.SaveChanges();
                
                int employee_id = int.Parse(lblId.Text);
                var employee = _db.Employees.FirstOrDefault(q => q.id == employee_id);
                employee.HolidaysTaken -= (numberOfHolidays + 1);
                PopulateFields(employee);
            }
        }


        //calculate number of holidays before adding a new record
        private void CalculateNumberOfHolidays()
        {
            DateTime holStart = Convert.ToDateTime(dtHolidayStart.Value);
            DateTime holEnd = Convert.ToDateTime(dtHolidayEnd.Value);
            if (holStart > holEnd)
            {
                MessageBox.Show("Please enter valid dates");
            } else
            {
                int numberOfDays = (holEnd.Subtract(holStart).Days) + 1;
                tbNumberOfHolidays.Text = numberOfDays.ToString();
            }

        }

        //run CalculateNumberOfHolidays method to calculate number of holidays before adding a new record
        private void dtHolidayStart_ValueChanged(object sender, EventArgs e)
        {
            CalculateNumberOfHolidays();
        }


        //run CalculateNumberOfHolidays method to calculate number of holidays before adding a new record
        private void dtHolidayEnd_ValueChanged(object sender, EventArgs e)
        {
            CalculateNumberOfHolidays();
        }

        //on changing frequency, change the text and recalculate period salary
        private void cbPayFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFrequency();
            CalculatePeriodSalary();
        }

        
        //calculate period salary by dividing annual salary by number of periods in frequency
        private void CalculatePeriodSalary()
        {
            try
            {
                double periodSalary = 0;
                var numberOfPeriods = 12;
                if (cbPayFrequency.SelectedIndex == 1)
                {
                    numberOfPeriods = 52;
                }
                else if (cbPayFrequency.SelectedIndex == 2)
                {
                    numberOfPeriods = 26;
                }
                else if (cbPayFrequency.SelectedIndex == 3)
                {
                    numberOfPeriods = 13;
                }
                if (radSalary.Checked)
                {
                    periodSalary = Math.Round(double.Parse(tbAnnualSalary.Text) / numberOfPeriods, 2);
                    tbPeriodSalary.Text = periodSalary.ToString();
                }
                else if(radHourlyRate.Checked)
                {
                    periodSalary = Math.Round(double.Parse(tbHourlyRate.Text) * double.Parse(tbHoursPerPeriod.Text), 2);
                    tbPeriodSalary.Text = periodSalary.ToString();
                }
                
                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Period salary Error: {ex.Message}");
            }
        }

       //calculate period salary by multiplying number of periods in frequency by period salary
        private void CalculateAnnualSalary()
        {
            try
            {
                var numberOfPeriods = 12;
                if (cbPayFrequency.SelectedIndex == 1)
                {
                    numberOfPeriods = 52;
                }
                else if (cbPayFrequency.SelectedIndex == 2)
                {
                    numberOfPeriods = 26;
                }
                else if (cbPayFrequency.SelectedIndex == 3)
                {
                    numberOfPeriods = 13;
                }
                double annualSalary = Math.Round(double.Parse(tbPeriodSalary.Text) * numberOfPeriods, 2);
                tbAnnualSalary.Text = annualSalary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Annual salary Error: {ex.Message}");
            }
        }

        //calculate period salary after entering it in annual salary and clicking out the box
        private void tbAnnualSalary_Leave(object sender, EventArgs e)
        {
            CalculatePeriodSalary();
        }

        //calculate annual salary after entering it in period salary and clicking out the box
        private void tbPeriodSalary_Leave(object sender, EventArgs e)
        {
            CalculateAnnualSalary();
        }

        private void radHourlyRate_Click(object sender, EventArgs e)
        {
            CalculatePeriodSalary();
            CalculateAnnualSalary();
        }

        private void radSalary_Click(object sender, EventArgs e)
        {
            CalculatePeriodSalary();
            CalculateAnnualSalary();
        }

        private void tbHoursPerPeriod_Leave(object sender, EventArgs e)
        {
            CalculatePeriodSalary();
            CalculateAnnualSalary();
        }

        private void tbHourlyRate_Leave(object sender, EventArgs e)
        {
            CalculatePeriodSalary();
            CalculateAnnualSalary();
        }
    }
}
