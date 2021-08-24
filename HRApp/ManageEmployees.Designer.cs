
namespace HRApp
{
    partial class ManageEmployees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblManageEmployees = new System.Windows.Forms.Label();
            this.gvEmployeeList = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.gbDepartmentFilter = new System.Windows.Forms.GroupBox();
            this.cbDepartmentFilter = new System.Windows.Forms.ComboBox();
            this.gbLocationFilter = new System.Windows.Forms.GroupBox();
            this.cbLocationFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeList)).BeginInit();
            this.gbDepartmentFilter.SuspendLayout();
            this.gbLocationFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManageEmployees
            // 
            this.lblManageEmployees.AutoSize = true;
            this.lblManageEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageEmployees.Location = new System.Drawing.Point(13, 13);
            this.lblManageEmployees.Name = "lblManageEmployees";
            this.lblManageEmployees.Size = new System.Drawing.Size(149, 20);
            this.lblManageEmployees.TabIndex = 0;
            this.lblManageEmployees.Text = "Manage Employees";
            // 
            // gvEmployeeList
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvEmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmployeeList.Location = new System.Drawing.Point(11, 86);
            this.gvEmployeeList.Name = "gvEmployeeList";
            this.gvEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvEmployeeList.Size = new System.Drawing.Size(1054, 599);
            this.gvEmployeeList.TabIndex = 1;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(13, 691);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(100, 26);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(119, 691);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(100, 26);
            this.btnEditEmployee.TabIndex = 3;
            this.btnEditEmployee.Text = "Edit Employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(225, 691);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(100, 26);
            this.btnDeleteEmployee.TabIndex = 4;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(971, 691);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 26);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(675, 53);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(224, 20);
            this.tbSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1014, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 26);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(561, 50);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(108, 26);
            this.btnClearSearch.TabIndex = 8;
            this.btnClearSearch.Text = "Clear All Filters";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // cbSearchType
            // 
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Location = new System.Drawing.Point(905, 53);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(103, 21);
            this.cbSearchType.TabIndex = 9;
            // 
            // gbDepartmentFilter
            // 
            this.gbDepartmentFilter.Controls.Add(this.cbDepartmentFilter);
            this.gbDepartmentFilter.Location = new System.Drawing.Point(7, 40);
            this.gbDepartmentFilter.Name = "gbDepartmentFilter";
            this.gbDepartmentFilter.Size = new System.Drawing.Size(230, 42);
            this.gbDepartmentFilter.TabIndex = 10;
            this.gbDepartmentFilter.TabStop = false;
            this.gbDepartmentFilter.Text = "Filter By Department";
            // 
            // cbDepartmentFilter
            // 
            this.cbDepartmentFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDepartmentFilter.FormattingEnabled = true;
            this.cbDepartmentFilter.Location = new System.Drawing.Point(7, 14);
            this.cbDepartmentFilter.Name = "cbDepartmentFilter";
            this.cbDepartmentFilter.Size = new System.Drawing.Size(217, 21);
            this.cbDepartmentFilter.TabIndex = 0;
            this.cbDepartmentFilter.SelectedIndexChanged += new System.EventHandler(this.cbDepartmentFilter_SelectedIndexChanged);
            // 
            // gbLocationFilter
            // 
            this.gbLocationFilter.Controls.Add(this.cbLocationFilter);
            this.gbLocationFilter.Location = new System.Drawing.Point(253, 40);
            this.gbLocationFilter.Name = "gbLocationFilter";
            this.gbLocationFilter.Size = new System.Drawing.Size(230, 42);
            this.gbLocationFilter.TabIndex = 11;
            this.gbLocationFilter.TabStop = false;
            this.gbLocationFilter.Text = "Filter By Location";
            // 
            // cbLocationFilter
            // 
            this.cbLocationFilter.FormattingEnabled = true;
            this.cbLocationFilter.Location = new System.Drawing.Point(6, 14);
            this.cbLocationFilter.Name = "cbLocationFilter";
            this.cbLocationFilter.Size = new System.Drawing.Size(217, 21);
            this.cbLocationFilter.TabIndex = 1;
            this.cbLocationFilter.SelectedIndexChanged += new System.EventHandler(this.cbLocationFilter_SelectedIndexChanged);
            // 
            // ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 729);
            this.Controls.Add(this.gbLocationFilter);
            this.Controls.Add(this.gbDepartmentFilter);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.gvEmployeeList);
            this.Controls.Add(this.lblManageEmployees);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ManageEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employees";
            this.Load += new System.EventHandler(this.ManageEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeList)).EndInit();
            this.gbDepartmentFilter.ResumeLayout(false);
            this.gbLocationFilter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageEmployees;
        private System.Windows.Forms.DataGridView gvEmployeeList;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.GroupBox gbDepartmentFilter;
        private System.Windows.Forms.ComboBox cbDepartmentFilter;
        private System.Windows.Forms.GroupBox gbLocationFilter;
        private System.Windows.Forms.ComboBox cbLocationFilter;
    }
}