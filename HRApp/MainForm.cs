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
    public partial class MainForm : Form
    {

        private readonly HRAppEntities _db;
        private Login _login;
        public User _user;
        public string _roleName;


        public MainForm(Login login, User user)
        {
            InitializeComponent();
            _db = new HRAppEntities();
            _login = login;
            _user = user;
            _roleName = user.Role.RoleName;
            this.WindowState = FormWindowState.Maximized;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            var totalEmployees = _db.Employees.Count();
            tsNumberOfEmployees.Text = $"| Total Number of Employees: {totalEmployees}";

            tsLoggedInAs.Text = $"Logged in as: {_user.Username} |";

            if(_user.Username != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }
        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageEmployees = new ManageEmployees();
            manageEmployees.MdiParent = this;
            manageEmployees.Show();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editDepartments = new EditDepartments();
            editDepartments.MdiParent = this;
            editDepartments.StartPosition = FormStartPosition.CenterScreen;
            editDepartments.Show();
        }

        private void featuresRoadmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newFeatures = new Features();
            newFeatures.MdiParent = this;
            newFeatures.StartPosition = FormStartPosition.CenterScreen;
            newFeatures.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageUsers = new ManageUsers();
            manageUsers.MdiParent = this.MdiParent;
            manageUsers.StartPosition = FormStartPosition.CenterScreen;
            manageUsers.Show();
        }
    }
}
