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
    public partial class ManageEmployees : Form
    {
        private readonly HRAppEntities _db;
        private User _user;
        public ManageEmployees(User user)
        {
            InitializeComponent();
            _db = new HRAppEntities();
            _user = user;
        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {
            
            var searchTypeDropdown = _db.SearchTypes.Select(q => new
            {
                ID = q.id,
                q.SearchType1
            }).ToList();
            cbSearchType.DataSource = searchTypeDropdown;
            cbSearchType.DisplayMember = "SearchType1";
            cbSearchType.ValueMember = "ID";
            cbSearchType.SelectedIndex = 1;


            var filterDepartment = _db.Departments.Select(q => new
            {
                ID = q.department_id,
                q.DepartmentName
            }).ToList();
            cbDepartmentFilter.DataSource = filterDepartment;
            cbDepartmentFilter.DisplayMember = "DepartmentName";
            cbDepartmentFilter.ValueMember = "ID";
            cbDepartmentFilter.SelectedItem = null;
            cbDepartmentFilter.Text = "--Select--";

            var filterLocation = _db.OfficeLocations.Select(q => new
            {
                ID = q.office_id,
                q.OfficeLocation1
            }).ToList();
            cbLocationFilter.DataSource = filterLocation;
            cbLocationFilter.DisplayMember = "OfficeLocation1";
            cbLocationFilter.ValueMember = "ID";
            cbLocationFilter.SelectedItem = null;
            cbLocationFilter.Text = "--Select--";
            //btnSearch.BackColor = Color.FromArgb(125,65,221);
            if(_user.RoleId == 3)
            {
                btnAddEmployee.Enabled = false;
                btnEditEmployee.Text = "View Employee";
                btnDeleteEmployee.Enabled = false;
            }
            PopulateEmployees();
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var addEmployee = new EditEmployee(_user, this);
            addEmployee.StartPosition = FormStartPosition.CenterScreen;
            addEmployee.MdiParent = this.MdiParent;
            addEmployee.Show();
        }
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            var id = (int)gvEmployeeList.SelectedRows[0].Cells["id"].Value;
            var employee = _db.Employees.FirstOrDefault(q => q.id == id);
            var editEmployee = new EditEmployee(employee, _user, this);

            editEmployee.StartPosition = FormStartPosition.CenterScreen;
            editEmployee.MdiParent = this.MdiParent;
            editEmployee.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void PopulateEmployees()
        {
            var employees = _db.Employees
               .Select(q => new
               {
                   ID = q.id,
                   q.Surname,
                   q.Forename,
                   q.KnownAs,
                   Gender = q.Gender.GenderName,
                   q.DateOfBirth,
                   q.NationalInsuranceNo,
                   Department = q.Department.DepartmentName,
                   OfficeLocation = q.OfficeLocation.OfficeLocation1,
                   q.ExtensionNumber
               })
               .ToList();
            gvEmployeeList.DataSource = employees;
            
        }
        public void PopulateEmployees(int DepartmnentId)
        {
            var filterOption = _db.Employees.Where(q => q.DepartmentId == DepartmnentId);
            if(cbDepartmentFilter.SelectedValue == null)
            {
                filterOption = _db.Employees.Where(q => q.OfficeLocationId == DepartmnentId);
            }
            var employees = filterOption
                .Select(q => new
            {
                ID = q.id,
                q.Surname,
                q.Forename,
                q.KnownAs,
                Gender = q.Gender.GenderName,
                q.DateOfBirth,
                q.NationalInsuranceNo,
                Department = q.Department.DepartmentName,
                OfficeLocation = q.OfficeLocation.OfficeLocation1,
                q.ExtensionNumber
            })
               .ToList();
            gvEmployeeList.DataSource = employees;
        }

        public void PopulateEmployees(string searchText, string searchType)
        {
            int searchId = int.Parse(searchType);
            var searchOption = _db.Employees.Where(q => q.Surname == searchText);
            if(searchId == 0)
            {
                searchOption = _db.Employees.Where(q => q.id.ToString() == searchText);
            }
            else if(searchId == 1)
            {
                searchOption = _db.Employees.Where(q => q.Surname == searchText);
            }
            else if(searchId == 2)
            {
                searchOption = _db.Employees.Where(q => q.Forename == searchText);
            }
            else if(searchId == 3)
            {
                searchOption = _db.Employees.Where(q => q.NationalInsuranceNo == searchText);
            }           
            else
            {
                MessageBox.Show("Invalid Search option selected");
            }
            var employees = searchOption.Select(q => new
               {
                   ID = q.id,
                   q.Surname,
                   q.Forename,
                   q.KnownAs,
                   Gender = q.Gender.GenderName,
                   q.DateOfBirth,
                   q.NationalInsuranceNo,
                   Department = q.Department.DepartmentName,
                   OfficeLocation = q.OfficeLocation.OfficeLocation1,
                   q.ExtensionNumber
               })
               .ToList();
            gvEmployeeList.DataSource = employees;
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            var id = (int)gvEmployeeList.SelectedRows[0].Cells["id"].Value;
            var employee = _db.Employees.FirstOrDefault(q => q.id == id);
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete {employee.Forename} {employee.Surname}?",
                "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                _db.Employees.Remove(employee);
                _db.SaveChanges();
                PopulateEmployees();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = tbSearch.Text;
                string searchType = cbSearchType.SelectedIndex.ToString();
                btnClearSearch.Visible = true;
                cbLocationFilter.SelectedItem = null;
                cbLocationFilter.Text = "--Select--";
                cbDepartmentFilter.SelectedItem = null;
                cbDepartmentFilter.Text = "--Select--";
                PopulateEmployees(searchText, searchType);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            PopulateEmployees();
        }

        private void cbDepartmentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            var departmentId = cbDepartmentFilter.SelectedIndex +1;
            cbLocationFilter.SelectedItem = null;
            cbLocationFilter.Text = "--Select--";
            PopulateEmployees(departmentId);
        }

        private void cbLocationFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var departmentId = cbLocationFilter.SelectedIndex + 1;
            cbDepartmentFilter.SelectedItem = null;
            cbDepartmentFilter.Text = "--Select--";
            PopulateEmployees(departmentId);
        }
    }
}

