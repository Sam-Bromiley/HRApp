
namespace HRApp
{
    partial class EditDepartments
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
            this.lblManageDepartments = new System.Windows.Forms.Label();
            this.gvDepartments = new System.Windows.Forms.DataGridView();
            this.btnCloseDepartments = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageDepartments
            // 
            this.lblManageDepartments.AutoSize = true;
            this.lblManageDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageDepartments.Location = new System.Drawing.Point(12, 9);
            this.lblManageDepartments.Name = "lblManageDepartments";
            this.lblManageDepartments.Size = new System.Drawing.Size(164, 20);
            this.lblManageDepartments.TabIndex = 1;
            this.lblManageDepartments.Text = "Manage Departments";
            // 
            // gvDepartments
            // 
            this.gvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDepartments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvDepartments.Location = new System.Drawing.Point(16, 45);
            this.gvDepartments.Name = "gvDepartments";
            this.gvDepartments.Size = new System.Drawing.Size(447, 277);
            this.gvDepartments.TabIndex = 2;
            // 
            // btnCloseDepartments
            // 
            this.btnCloseDepartments.Location = new System.Drawing.Point(363, 424);
            this.btnCloseDepartments.Name = "btnCloseDepartments";
            this.btnCloseDepartments.Size = new System.Drawing.Size(100, 26);
            this.btnCloseDepartments.TabIndex = 24;
            this.btnCloseDepartments.Text = "Close";
            this.btnCloseDepartments.UseVisualStyleBackColor = true;
            this.btnCloseDepartments.Click += new System.EventHandler(this.btnCloseDepartments_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(16, 355);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(100, 26);
            this.btnAddDepartment.TabIndex = 25;
            this.btnAddDepartment.Text = "Add";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.Location = new System.Drawing.Point(121, 355);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(100, 26);
            this.btnEditDepartment.TabIndex = 26;
            this.btnEditDepartment.Text = "Edit";
            this.btnEditDepartment.UseVisualStyleBackColor = true;
            this.btnEditDepartment.Click += new System.EventHandler(this.btnEditDepartment_Click);
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Location = new System.Drawing.Point(227, 355);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(100, 26);
            this.btnDeleteDepartment.TabIndex = 27;
            this.btnDeleteDepartment.Text = "Delete";
            this.btnDeleteDepartment.UseVisualStyleBackColor = true;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // EditDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 495);
            this.Controls.Add(this.btnDeleteDepartment);
            this.Controls.Add(this.btnEditDepartment);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.btnCloseDepartments);
            this.Controls.Add(this.gvDepartments);
            this.Controls.Add(this.lblManageDepartments);
            this.Name = "EditDepartments";
            this.Text = "EditDepartments";
            this.Load += new System.EventHandler(this.EditDepartments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageDepartments;
        private System.Windows.Forms.DataGridView gvDepartments;
        private System.Windows.Forms.Button btnCloseDepartments;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnEditDepartment;
        private System.Windows.Forms.Button btnDeleteDepartment;
    }
}