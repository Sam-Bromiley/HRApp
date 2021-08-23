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
    public partial class Features : Form
    {
        private HRAppEntities _db;

        public Features()
        {
            InitializeComponent();
            _db = new HRAppEntities();
        }
        private void Features_Load(object sender, EventArgs e)
        {
            
            PopulateList();

        }
        private void PopulateList()
        {
            try
            {
                var featureList = _db.Features.Select(q => new
                {
                    q.completed,
                    q.id,
                    q.FeatureName,
                    q.notes
                }).ToList();

                gvFeatures.DataSource = featureList;
                gvFeatures.Columns["id"].HeaderText = "ID";
                gvFeatures.Columns["FeatureName"].HeaderText = "Feature Name";
                gvFeatures.Columns["completed"].HeaderText = "Completed";
                gvFeatures.Columns["notes"].HeaderText = "Notes";
                gvFeatures.Columns["notes"].Width = 328;
                gvFeatures.Columns["FeatureName"].Width = 200;
                gvFeatures.Enabled = true;

                //for (int i = 0; i < featureList.Count; i++)
                //{
                //    bool completed = (bool)gvFeatures.SelectedRows[i].Cells["completed"].Value;
                //    if (completed)
                //    {
                //        Font font = new Font("Microsoft Sans Serif", 8, FontStyle.Strikeout);
                //        gvFeatures.SelectedRows[i].DefaultCellStyle.Font = font;
                //    }
                //}

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                
            }
            
           
        }

        private void btnAddFeature_Click(object sender, EventArgs e)
        {
            if (tbAddFeature.Text == "New Feature" || tbAddFeature.Text == "")
            {
                MessageBox.Show("Please enter a description for the new feature");
            }
            else
            {
                var newFeature = new Feature
                {
                    FeatureName = tbAddFeature.Text,
                    completed = false,
                    notes = null
                };
                _db.Features.Add(newFeature);
                _db.SaveChanges();
                PopulateList();
                tbAddFeature.Text = "";
            }
        }

       
        private void tbAddFeature_Click(object sender, EventArgs e)
        {
            if(tbAddFeature.Text == "New Feature")
            {
                tbAddFeature.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            var id = (int)gvFeatures.SelectedRows[0].Cells["id"].Value;
            lblId.Text = id.ToString();
            var feature = _db.Features.FirstOrDefault(q => q.id == id);

            
            if((bool)feature.completed)
            {
                feature.completed = false;
            }
            else
            {
                feature.completed = true;
            }

            _db.SaveChanges();
            PopulateList();
        }
    }
}
