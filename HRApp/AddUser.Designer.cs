
namespace HRApp
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddUser = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRoleDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(12, 9);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(76, 20);
            this.lblAddUser.TabIndex = 3;
            this.lblAddUser.Text = "Add User";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(16, 71);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(16, 122);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(16, 168);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(37, 17);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Role";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(120, 71);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(266, 20);
            this.tbUsername.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(120, 119);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(266, 20);
            this.tbPassword.TabIndex = 10;
            // 
            // cbRoles
            // 
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(120, 168);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(266, 21);
            this.cbRoles.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(98, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(210, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 32);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRoleDescription
            // 
            this.lblRoleDescription.AutoSize = true;
            this.lblRoleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleDescription.Location = new System.Drawing.Point(19, 216);
            this.lblRoleDescription.Name = "lblRoleDescription";
            this.lblRoleDescription.Size = new System.Drawing.Size(0, 17);
            this.lblRoleDescription.TabIndex = 14;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 401);
            this.Controls.Add(this.lblRoleDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbRoles);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblAddUser);
            this.Name = "AddUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRoleDescription;
    }
}