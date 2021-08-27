
namespace HRApp
{
    partial class AddEditQualifications
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
            this.lblQualificationName = new System.Windows.Forms.Label();
            this.lblDateObtained = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.tbQualificationName = new System.Windows.Forms.TextBox();
            this.dtDateObtained = new System.Windows.Forms.DateTimePicker();
            this.dtExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQualifications
            // 
            this.lblQualifications.AutoSize = true;
            this.lblQualifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualifications.Location = new System.Drawing.Point(12, 9);
            this.lblQualifications.Name = "lblQualifications";
            this.lblQualifications.Size = new System.Drawing.Size(104, 20);
            this.lblQualifications.TabIndex = 3;
            this.lblQualifications.Text = "Qualifications";
            // 
            // lblQualificationName
            // 
            this.lblQualificationName.AutoSize = true;
            this.lblQualificationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualificationName.Location = new System.Drawing.Point(58, 64);
            this.lblQualificationName.Name = "lblQualificationName";
            this.lblQualificationName.Size = new System.Drawing.Size(127, 17);
            this.lblQualificationName.TabIndex = 4;
            this.lblQualificationName.Text = "Qualification Name";
            // 
            // lblDateObtained
            // 
            this.lblDateObtained.AutoSize = true;
            this.lblDateObtained.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateObtained.Location = new System.Drawing.Point(85, 102);
            this.lblDateObtained.Name = "lblDateObtained";
            this.lblDateObtained.Size = new System.Drawing.Size(100, 17);
            this.lblDateObtained.TabIndex = 5;
            this.lblDateObtained.Text = "Date Obtained";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.Location = new System.Drawing.Point(18, 144);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(169, 17);
            this.lblExpiryDate.TabIndex = 6;
            this.lblExpiryDate.Text = "Expiry Date (if applicable)";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(18, 191);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(111, 17);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "Additional Notes";
            // 
            // tbQualificationName
            // 
            this.tbQualificationName.Location = new System.Drawing.Point(264, 64);
            this.tbQualificationName.Name = "tbQualificationName";
            this.tbQualificationName.Size = new System.Drawing.Size(334, 20);
            this.tbQualificationName.TabIndex = 8;
            // 
            // dtDateObtained
            // 
            this.dtDateObtained.Location = new System.Drawing.Point(264, 102);
            this.dtDateObtained.Name = "dtDateObtained";
            this.dtDateObtained.Size = new System.Drawing.Size(200, 20);
            this.dtDateObtained.TabIndex = 9;
            // 
            // dtExpiryDate
            // 
            this.dtExpiryDate.Location = new System.Drawing.Point(264, 144);
            this.dtExpiryDate.Name = "dtExpiryDate";
            this.dtExpiryDate.Size = new System.Drawing.Size(200, 20);
            this.dtExpiryDate.TabIndex = 10;
            this.dtExpiryDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(21, 211);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(577, 157);
            this.tbNotes.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(392, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 26);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(498, 412);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 26);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(569, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 32;
            this.lblId.Visible = false;
            // 
            // AddEditQualifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.dtExpiryDate);
            this.Controls.Add(this.dtDateObtained);
            this.Controls.Add(this.tbQualificationName);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblDateObtained);
            this.Controls.Add(this.lblQualificationName);
            this.Controls.Add(this.lblQualifications);
            this.Name = "AddEditQualifications";
            this.Text = "AddEditQualifications";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQualifications;
        private System.Windows.Forms.Label lblQualificationName;
        private System.Windows.Forms.Label lblDateObtained;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox tbQualificationName;
        private System.Windows.Forms.DateTimePicker dtDateObtained;
        private System.Windows.Forms.DateTimePicker dtExpiryDate;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblId;
    }
}