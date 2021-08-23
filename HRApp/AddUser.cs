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
    public partial class AddUser : Form
    {
        private readonly HRAppEntities _db;
        private readonly ManageUsers _manageUsers;

        public AddUser(ManageUsers manageUsers = null)
        {
            InitializeComponent();
            _db = new HRAppEntities();
            _manageUsers = manageUsers;
        }
        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _db.Roles.Select(q => new
            {
                ID = q.id,
                q.RoleName
            }).ToList();
            cbRoles.DataSource = roles;
            cbRoles.DisplayMember = "RoleName";
            cbRoles.ValueMember = "id";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var hashed_password = Utils.Hash_Password(tbPassword.Text);
            var newUser = new User
            {
                Username = tbUsername.Text,
                Password = hashed_password,
                RoleId = (int)cbRoles.SelectedValue,
                isActive = true
                
            };
            _db.Users.Add(newUser);
            _db.SaveChanges();
            MessageBox.Show($"New user: {newUser.Username} added");
            _manageUsers.PopulateUsers();
            Close();

            
        }

        
    }
}
