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
    public partial class Qualifications : Form
    {
        private readonly HRAppEntities _db;
        private Employee _employee;
        public Qualifications(Employee employee)
        {
            InitializeComponent();
            _db = new HRAppEntities();
            _employee = employee;
        }


        private void Qualifications_Load(object sender, EventArgs e)
        {
            
            PopulateList();

            
        }

        public void PopulateList()
        {
            
            var EmployeesQualifications = _db.Qualifications.Where(q => q.employeeId == _employee.id).Select(q => new
            {
                ID = q.id,
                q.QualificationName,
                q.DateCompleted,
                q.ExpiryDate,
                q.Notes
            }).ToList();

            gvQualifications.DataSource = EmployeesQualifications;
            gvQualifications.Columns["QualificationName"].HeaderText = "Qualification Name";
            gvQualifications.Columns["DateCompleted"].HeaderText = "Date Completed";
            gvQualifications.Columns["ExpiryDate"].HeaderText = "Expiry Date";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddQualification_Click(object sender, EventArgs e)
        {
            
            var addQualification = new AddEditQualifications(_employee, this);
            addQualification.MdiParent = this.MdiParent;
            addQualification.StartPosition = FormStartPosition.CenterScreen;
            addQualification.Show();
        }

        private void btnEditQualification_Click(object sender, EventArgs e)
        {
            var id = (int)gvQualifications.SelectedRows[0].Cells["id"].Value;
            var qualificationToEdit = _db.Qualifications.FirstOrDefault(q => q.id == id);
            var editQualifications = new AddEditQualifications(_employee, qualificationToEdit, this);
            editQualifications.MdiParent = this.MdiParent;
            editQualifications.StartPosition = FormStartPosition.CenterScreen;
            editQualifications.Show();
        }

        private void btnDeleteQualification_Click(object sender, EventArgs e)
        {
            var id = (int)gvQualifications.SelectedRows[0].Cells["id"].Value;
            var qualificationToDelete = _db.Qualifications.FirstOrDefault(q => q.id == id);
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete {qualificationToDelete.QualificationName} " +
                $"from {_employee.Forename} {_employee.Surname}?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if(dr == DialogResult.Yes)
            {
                _db.Qualifications.Remove(qualificationToDelete);
                _db.SaveChanges();
                PopulateList();
            } 
        }
    }
}
