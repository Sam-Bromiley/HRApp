
namespace HRApp
{
    partial class Qualifications
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
            this.lblQualifications = new System.Windows.Forms.Label();
            this.gvQualifications = new System.Windows.Forms.DataGridView();
            this.btnEditQualification = new System.Windows.Forms.Button();
            this.btnAddQualification = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteQualification = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvQualifications)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQualifications
            // 
            this.lblQualifications.AutoSize = true;
            this.lblQualifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualifications.Location = new System.Drawing.Point(12, 9);
            this.lblQualifications.Name = "lblQualifications";
            this.lblQualifications.Size = new System.Drawing.Size(104, 20);
            this.lblQualifications.TabIndex = 2;
            this.lblQualifications.Text = "Qualifications";
            // 
            // gvQualifications
            // 
            this.gvQualifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQualifications.Location = new System.Drawing.Point(16, 84);
            this.gvQualifications.Name = "gvQualifications";
            this.gvQualifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvQualifications.Size = new System.Drawing.Size(583, 150);
            this.gvQualifications.TabIndex = 3;
            // 
            // btnEditQualification
            // 
            this.btnEditQualification.Location = new System.Drawing.Point(122, 394);
            this.btnEditQualification.Name = "btnEditQualification";
            this.btnEditQualification.Size = new System.Drawing.Size(100, 26);
            this.btnEditQualification.TabIndex = 28;
            this.btnEditQualification.Text = "Edit";
            this.btnEditQualification.UseVisualStyleBackColor = true;
            this.btnEditQualification.Click += new System.EventHandler(this.btnEditQualification_Click);
            // 
            // btnAddQualification
            // 
            this.btnAddQualification.Location = new System.Drawing.Point(16, 394);
            this.btnAddQualification.Name = "btnAddQualification";
            this.btnAddQualification.Size = new System.Drawing.Size(100, 26);
            this.btnAddQualification.TabIndex = 29;
            this.btnAddQualification.Text = "Add";
            this.btnAddQualification.UseVisualStyleBackColor = true;
            this.btnAddQualification.Click += new System.EventHandler(this.btnAddQualification_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(499, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 26);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteQualification
            // 
            this.btnDeleteQualification.Location = new System.Drawing.Point(228, 394);
            this.btnDeleteQualification.Name = "btnDeleteQualification";
            this.btnDeleteQualification.Size = new System.Drawing.Size(100, 26);
            this.btnDeleteQualification.TabIndex = 31;
            this.btnDeleteQualification.Text = "Delete";
            this.btnDeleteQualification.UseVisualStyleBackColor = true;
            this.btnDeleteQualification.Click += new System.EventHandler(this.btnDeleteQualification_Click);
            // 
            // Qualifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.btnDeleteQualification);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddQualification);
            this.Controls.Add(this.btnEditQualification);
            this.Controls.Add(this.gvQualifications);
            this.Controls.Add(this.lblQualifications);
            this.Name = "Qualifications";
            this.Text = "Qualifications";
            this.Load += new System.EventHandler(this.Qualifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvQualifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQualifications;
        private System.Windows.Forms.DataGridView gvQualifications;
        private System.Windows.Forms.Button btnEditQualification;
        private System.Windows.Forms.Button btnAddQualification;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteQualification;
    }
}