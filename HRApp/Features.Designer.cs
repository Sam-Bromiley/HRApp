
namespace HRApp
{
    partial class Features
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.gvFeatures = new System.Windows.Forms.DataGridView();
            this.tbAddFeature = new System.Windows.Forms.TextBox();
            this.btnAddFeature = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvFeatures)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatures.Location = new System.Drawing.Point(12, 9);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(73, 20);
            this.lblFeatures.TabIndex = 2;
            this.lblFeatures.Text = "Features";
            // 
            // gvFeatures
            // 
            this.gvFeatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFeatures.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvFeatures.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvFeatures.Location = new System.Drawing.Point(16, 49);
            this.gvFeatures.Name = "gvFeatures";
            this.gvFeatures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvFeatures.Size = new System.Drawing.Size(772, 242);
            this.gvFeatures.TabIndex = 3;
            // 
            // tbAddFeature
            // 
            this.tbAddFeature.Location = new System.Drawing.Point(411, 310);
            this.tbAddFeature.Name = "tbAddFeature";
            this.tbAddFeature.Size = new System.Drawing.Size(262, 20);
            this.tbAddFeature.TabIndex = 4;
            this.tbAddFeature.Text = "New Feature";
            this.tbAddFeature.Click += new System.EventHandler(this.tbAddFeature_Click);
            // 
            // btnAddFeature
            // 
            this.btnAddFeature.Location = new System.Drawing.Point(679, 310);
            this.btnAddFeature.Name = "btnAddFeature";
            this.btnAddFeature.Size = new System.Drawing.Size(109, 23);
            this.btnAddFeature.TabIndex = 5;
            this.btnAddFeature.Text = "Add";
            this.btnAddFeature.UseVisualStyleBackColor = true;
            this.btnAddFeature.Click += new System.EventHandler(this.btnAddFeature_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(679, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.Location = new System.Drawing.Point(16, 307);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(109, 23);
            this.btnCompleted.TabIndex = 7;
            this.btnCompleted.Text = "Mark Complete";
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(752, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Visible = false;
            // 
            // Features
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddFeature);
            this.Controls.Add(this.tbAddFeature);
            this.Controls.Add(this.gvFeatures);
            this.Controls.Add(this.lblFeatures);
            this.Name = "Features";
            this.Text = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvFeatures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeatures;
        private System.Windows.Forms.DataGridView gvFeatures;
        private System.Windows.Forms.TextBox tbAddFeature;
        private System.Windows.Forms.Button btnAddFeature;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Label lblId;
    }
}