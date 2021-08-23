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
    public partial class ManageUsers : Form
    {
        private readonly HRAppEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new HRAppEntities();
        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateUsers();
        }

        public void PopulateUsers()
        {
            var users = _db.Users.Select(q => new
            {
                ID = q.id,
                q.Username,
                q.Role.RoleName,
                q.isActive
            }).ToList();

            gvUsers.DataSource = users;
            gvUsers.Columns["isActive"].HeaderText = "Active";
            gvUsers.Columns["RoleName"].HeaderText = "Role Name";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            var id = (int)gvUsers.SelectedRows[0].Cells["id"].Value;
            var user = _db.Users.FirstOrDefault(q => q.id == id);

            if((bool)user.isActive)
            {
                user.isActive = false;
            }
            else
            {
                user.isActive = true;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var addUser = new AddUser(this);
            addUser.MdiParent = this.MdiParent;
            addUser.StartPosition = FormStartPosition.CenterScreen;
            addUser.Show();
        }

        
    }
}
