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
    public partial class AddEditDepartment : Form
    {
        private readonly HRAppEntities _db;
        private bool isEditMode;
        private EditDepartments _editDepartments;
        public AddEditDepartment(EditDepartments editDepartments = null)
        {
            InitializeComponent();
            _db = new HRAppEntities();
            this.Text = "Add Department";
            lblAddEditDepartment.Text = "Add New Department";
            isEditMode = false;
            _editDepartments = editDepartments;
        }

        public AddEditDepartment(Department departmentToEdit, EditDepartments editDepartments = null)
        {
            InitializeComponent();
            _db = new HRAppEntities();
            this.Text = "Edit Department";
            lblAddEditDepartment.Text = "Edit Department";
            PopulateFields(departmentToEdit);
            isEditMode = true;
            _editDepartments = editDepartments;
        }

        private void PopulateFields(Department departmentToEdit)
        {
            lblId.Text = departmentToEdit.department_id.ToString();
            tbDepartmentName.Text = departmentToEdit.DepartmentName;
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
                    var id = int.Parse(lblId.Text);
                    var addEditDepartment = _db.Departments.FirstOrDefault(q => q.department_id == id);

                    addEditDepartment.DepartmentName = tbDepartmentName.Text;

                }
                else
                {
                    var addEditDepartment = new Department
                    {
                        DepartmentName = tbDepartmentName.Text
                    };
                    _db.Departments.Add(addEditDepartment);

                }
                _db.SaveChanges();

                _editDepartments.PopulateList();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }
    }
}
