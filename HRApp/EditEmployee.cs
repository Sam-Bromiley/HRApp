
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
        }

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
        }

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
            cbDepartment.SelectedValue = employeeToEdit.DepartmentId;
            cbOfficeLocation.SelectedValue = employeeToEdit.OfficeLocationId;



        }

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

            //var reportsTo = _db.Employees.ToList();
            //cbReportsTo.ValueMember = "Forename" + " " + "Surname";
            //cbReportsTo.DataSource = reportsTo;

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
                lblMessage.Text = "Please ensure all mandatory fields highlighted have been filled out correctly before saving";
            }

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
                    //Edit code
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
                    //addEditEmployee.ReportsToId = (int)cbReportsTo.SelectedValue;
                    addEditEmployee.OfficeLocationId = (int)cbOfficeLocation.SelectedValue;
                    addEditEmployee.TypeOfEmployeeId = (int)cbTypeOfEmployee.SelectedValue;
                    addEditEmployee.NationalInsuranceNo = tbNINO.Text;
                    addEditEmployee.JobTitle = tbJobTitle.Text;
                    double editSalary = double.Parse(tbSalary.Text);
                    addEditEmployee.Salary = (decimal)editSalary;
                    addEditEmployee.ExtensionNumber = int.Parse(tbExtensionNumber.Text);
                    addEditEmployee.Leaver = chkLeaver.Checked;

                    _db.SaveChanges();
                    _manageEmployees.PopulateEmployees();
                    Close();
                }
                else
                {
                    
                    bool isValid = true;
                    string ErrorMessage = "Please ensure you have filled out the following fields: \n\r";
                    //Add code
                    string MiddleName = "";
                    string KnownAs = "";
                    string Address3 = "";
                    string Address4 = "";
                    string JobTitle = "";
                    decimal Salary = 0;
                    int Extension = 0;

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

                    if(tbSurname.Text == "Surname" || tbSurname.Text == "")
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
                    if (isValid)
                    {
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
                            Leaver = chkLeaver.Checked

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

        private void btnQualifications_Click(object sender, EventArgs e)
        {
            var id = int.Parse(lblId.Text);
            var employee = _db.Employees.FirstOrDefault(q => q.id == id);
            var qualifications = new Qualifications(employee);
            qualifications.MdiParent = this.MdiParent;
            qualifications.StartPosition = FormStartPosition.CenterScreen;
            qualifications.Show();

        }
    }
}
