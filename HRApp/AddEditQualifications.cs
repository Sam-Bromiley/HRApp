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
    public partial class AddEditQualifications : Form
    {
        private readonly HRAppEntities _db;
        private bool isEditMode;
        public Qualifications _qualifications1;
        private Employee _employee;
        public AddEditQualifications(Employee employee, Qualifications qualifications1 = null)
        {
            InitializeComponent();
            _db = new HRAppEntities();
            isEditMode = false;
            _qualifications1 = qualifications1;
            _employee = employee;
        }

        public AddEditQualifications(Employee employee, Qualification qualifications, Qualifications qualifications1 = null)
        {
            InitializeComponent();
            _db = new HRAppEntities();
            isEditMode = true;
            PopulateFields(qualifications);
            _qualifications1 = qualifications1;
            _employee = employee;
        }

        private void PopulateFields(Qualification qualifications)
        {
            tbQualificationName.Text = qualifications.QualificationName;
            dtDateObtained.Value = (DateTime)qualifications.DateCompleted;
            dtExpiryDate.Value = (DateTime)qualifications.ExpiryDate;
            tbNotes.Text = qualifications.Notes;
            lblId.Text = qualifications.id.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(isEditMode)
                {
                    var id = int.Parse(lblId.Text);
                    var qualificationToEdit = _db.Qualifications.FirstOrDefault(q => q.id == id);
                    qualificationToEdit.QualificationName = tbQualificationName.Text;
                    qualificationToEdit.DateCompleted = dtDateObtained.Value;
                    qualificationToEdit.ExpiryDate = dtExpiryDate.Value;
                    qualificationToEdit.Notes = tbNotes.Text;
                    qualificationToEdit.employeeId = _employee.id;

                    _db.SaveChanges();
                    _qualifications1.PopulateList();
                    Close();
                }
                else
                {
                    var addQualification = new Qualification
                    {
                        QualificationName = tbQualificationName.Text,
                        DateCompleted = dtDateObtained.Value,
                        ExpiryDate = dtExpiryDate.Value,
                        Notes = tbNotes.Text,
                        employeeId = _employee.id
                };
                    _db.Qualifications.Add(addQualification);
                    _db.SaveChanges();
                    _qualifications1.PopulateList();
                    Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
