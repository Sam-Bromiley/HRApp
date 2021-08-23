using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRApp
{
    public partial class Login : Form
    {
        
        private readonly HRAppEntities _db;

        public Login()
        {
            InitializeComponent();
            _db = new HRAppEntities();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tbUsername.Text.Trim();
                var hashed_password = Utils.Hash_Password(tbPassword.Text);

                var user = _db.Users.FirstOrDefault(q => q.Username == username && q.Password == hashed_password && q.isActive == true);

                    if(user == null)
                {
                    MessageBox.Show("Invalid credentials. Please enter your username and password to login");
                } 
                    else
                {
                    var mainForm = new MainForm(this, user);
                    mainForm.Show();
                    Hide();
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }
    }
}
