
namespace HRApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officeLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featuresRoadmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutHRAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLoggedInAs = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsNumberOfEmployees = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeesToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // manageEmployeesToolStripMenuItem
            // 
            this.manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            this.manageEmployeesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageEmployeesToolStripMenuItem.Text = "Manage Employees";
            this.manageEmployeesToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentsToolStripMenuItem,
            this.officeLocationsToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.departmentsToolStripMenuItem.Text = "Manage Departments";
            this.departmentsToolStripMenuItem.Click += new System.EventHandler(this.departmentsToolStripMenuItem_Click);
            // 
            // officeLocationsToolStripMenuItem
            // 
            this.officeLocationsToolStripMenuItem.Name = "officeLocationsToolStripMenuItem";
            this.officeLocationsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.officeLocationsToolStripMenuItem.Text = "Manage Office Locations";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.featuresRoadmapToolStripMenuItem,
            this.aboutHRAppToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // featuresRoadmapToolStripMenuItem
            // 
            this.featuresRoadmapToolStripMenuItem.Name = "featuresRoadmapToolStripMenuItem";
            this.featuresRoadmapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.featuresRoadmapToolStripMenuItem.Text = "Features Roadmap";
            this.featuresRoadmapToolStripMenuItem.Click += new System.EventHandler(this.featuresRoadmapToolStripMenuItem_Click);
            // 
            // aboutHRAppToolStripMenuItem
            // 
            this.aboutHRAppToolStripMenuItem.Name = "aboutHRAppToolStripMenuItem";
            this.aboutHRAppToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutHRAppToolStripMenuItem.Text = "About HR App";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLoggedInAs,
            this.tsNumberOfEmployees});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLoggedInAs
            // 
            this.tsLoggedInAs.Name = "tsLoggedInAs";
            this.tsLoggedInAs.Size = new System.Drawing.Size(0, 17);
            // 
            // tsNumberOfEmployees
            // 
            this.tsNumberOfEmployees.Name = "tsNumberOfEmployees";
            this.tsNumberOfEmployees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsNumberOfEmployees.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "HR App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officeLocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featuresRoadmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutHRAppToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLoggedInAs;
        private System.Windows.Forms.ToolStripStatusLabel tsNumberOfEmployees;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
    }
}

