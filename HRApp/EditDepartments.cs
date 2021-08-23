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
    public partial class EditDepartments : Form
    {
        public readonly HRAppEntities _db;
        public EditDepartments()
        {
            InitializeComponent();
            _db = new HRAppEntities();
        }

        private void EditDepartments_Load(object sender, EventArgs e)
        {
            PopulateList();
        }

        public void PopulateList()
        {
            var departmentList = _db.Departments.Select(q => new { q.department_id, q.DepartmentName }).ToList();
            gvDepartments.DataSource = departmentList;
            gvDepartments.Columns[0].HeaderText = "ID";
            gvDepartments.Columns[1].HeaderText = "Department Name";
            gvDepartments.Columns[1].Width = 304;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            var addEditDepartment = new AddEditDepartment(this);
            addEditDepartment.MdiParent = this.MdiParent;
            addEditDepartment.StartPosition = FormStartPosition.CenterScreen;
            addEditDepartment.Show();
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvDepartments.SelectedRows[0].Cells["department_id"].Value;
                var department = _db.Departments.FirstOrDefault(q => q.department_id == id);

                var addEditDepartment = new AddEditDepartment(department, this);
                addEditDepartment.MdiParent = this.MdiParent;
                addEditDepartment.StartPosition = FormStartPosition.CenterScreen;
                addEditDepartment.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message} \n\r" +
                    $"Please ensure you have selected a valid department and try again");
            }
            
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            
            var id = (int)gvDepartments.SelectedRows[0].Cells["department_id"].Value;
            var department = _db.Departments.FirstOrDefault(q => q.department_id == id);
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete the {department.DepartmentName} department?"
                , "Delete", MessageBoxButtons.YesNoCancel
                , MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                _db.Departments.Remove(department);
                _db.SaveChanges();
                PopulateList();
            }
        }

        private void btnCloseDepartments_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
