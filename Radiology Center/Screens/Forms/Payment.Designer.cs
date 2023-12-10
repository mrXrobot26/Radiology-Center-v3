namespace Radiology_Center.Screens.Forms
{
    partial class Payment
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
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Pay = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Patient = new System.Windows.Forms.Label();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_PatientName = new ReaLTaiizor.Controls.FoxBigLabel();
            this.lbl_doc = new System.Windows.Forms.Label();
            this.lbl_ray = new System.Windows.Forms.Label();
            this.lbl_Doc_Name = new ReaLTaiizor.Controls.FoxBigLabel();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.lbl_Psalary = new ReaLTaiizor.Controls.FoxBigLabel();
            this.lbl_Ray_Name = new ReaLTaiizor.Controls.FoxBigLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.btn_cancel.BorderRadius = 5;
            this.btn_cancel.BorderThickness = 2;
            this.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancel.FillColor = System.Drawing.Color.White;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(518, 511);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(97, 41);
            this.btn_cancel.TabIndex = 48;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Pay
            // 
            this.btn_Pay.BorderColor = System.Drawing.Color.White;
            this.btn_Pay.BorderRadius = 5;
            this.btn_Pay.BorderThickness = 2;
            this.btn_Pay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Pay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Pay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Pay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Pay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.btn_Pay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Pay.ForeColor = System.Drawing.Color.White;
            this.btn_Pay.Location = new System.Drawing.Point(295, 511);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(97, 41);
            this.btn_Pay.TabIndex = 49;
            this.btn_Pay.Text = "Pay";
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // lbl_Patient
            // 
            this.lbl_Patient.AutoSize = true;
            this.lbl_Patient.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Patient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Patient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.lbl_Patient.Location = new System.Drawing.Point(116, 156);
            this.lbl_Patient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Patient.Name = "lbl_Patient";
            this.lbl_Patient.Size = new System.Drawing.Size(115, 21);
            this.lbl_Patient.TabIndex = 47;
            this.lbl_Patient.Text = "Patient Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(919, 57);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 46;
            this.panel1.Text = "panel1";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(75, 9);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(212, 32);
            this.bigLabel1.TabIndex = 52;
            this.bigLabel1.Text = "Radiology Center";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_PatientName
            // 
            this.lbl_PatientName.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lbl_PatientName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_PatientName.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.lbl_PatientName.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbl_PatientName.Location = new System.Drawing.Point(263, 155);
            this.lbl_PatientName.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_PatientName.Name = "lbl_PatientName";
            this.lbl_PatientName.Size = new System.Drawing.Size(360, 22);
            this.lbl_PatientName.TabIndex = 50;
            // 
            // lbl_doc
            // 
            this.lbl_doc.AutoSize = true;
            this.lbl_doc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_doc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.lbl_doc.Location = new System.Drawing.Point(119, 213);
            this.lbl_doc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_doc.Name = "lbl_doc";
            this.lbl_doc.Size = new System.Drawing.Size(112, 21);
            this.lbl_doc.TabIndex = 51;
            this.lbl_doc.Text = "Doctor Name";
            // 
            // lbl_ray
            // 
            this.lbl_ray.AutoSize = true;
            this.lbl_ray.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ray.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.lbl_ray.Location = new System.Drawing.Point(119, 271);
            this.lbl_ray.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ray.Name = "lbl_ray";
            this.lbl_ray.Size = new System.Drawing.Size(88, 21);
            this.lbl_ray.TabIndex = 52;
            this.lbl_ray.Text = "Ray Name";
            // 
            // lbl_Doc_Name
            // 
            this.lbl_Doc_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lbl_Doc_Name.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Doc_Name.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.lbl_Doc_Name.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbl_Doc_Name.Location = new System.Drawing.Point(263, 212);
            this.lbl_Doc_Name.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_Doc_Name.Name = "lbl_Doc_Name";
            this.lbl_Doc_Name.Size = new System.Drawing.Size(360, 22);
            this.lbl_Doc_Name.TabIndex = 53;
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.lbl_salary.Location = new System.Drawing.Point(119, 329);
            this.lbl_salary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(90, 21);
            this.lbl_salary.TabIndex = 54;
            this.lbl_salary.Text = "Ray Salary";
            // 
            // lbl_Psalary
            // 
            this.lbl_Psalary.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lbl_Psalary.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Psalary.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.lbl_Psalary.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbl_Psalary.Location = new System.Drawing.Point(279, 317);
            this.lbl_Psalary.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_Psalary.Name = "lbl_Psalary";
            this.lbl_Psalary.Size = new System.Drawing.Size(360, 22);
            this.lbl_Psalary.TabIndex = 55;
            this.lbl_Psalary.Click += new System.EventHandler(this.foxBigLabel2_Click);
            // 
            // lbl_Ray_Name
            // 
            this.lbl_Ray_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lbl_Ray_Name.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Ray_Name.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.lbl_Ray_Name.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbl_Ray_Name.Location = new System.Drawing.Point(263, 270);
            this.lbl_Ray_Name.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_Ray_Name.Name = "lbl_Ray_Name";
            this.lbl_Ray_Name.Size = new System.Drawing.Size(360, 22);
            this.lbl_Ray_Name.TabIndex = 56;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 656);
            this.Controls.Add(this.lbl_Ray_Name);
            this.Controls.Add(this.lbl_Psalary);
            this.Controls.Add(this.lbl_salary);
            this.Controls.Add(this.lbl_Doc_Name);
            this.Controls.Add(this.lbl_ray);
            this.Controls.Add(this.lbl_doc);
            this.Controls.Add(this.lbl_PatientName);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.lbl_Patient);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2Button btn_Pay;
        private System.Windows.Forms.Label lbl_Patient;
        private ReaLTaiizor.Controls.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.FoxBigLabel lbl_PatientName;
        private System.Windows.Forms.Label lbl_doc;
        private System.Windows.Forms.Label lbl_ray;
        private ReaLTaiizor.Controls.FoxBigLabel lbl_Doc_Name;
        private System.Windows.Forms.Label lbl_salary;
        private ReaLTaiizor.Controls.FoxBigLabel lbl_Psalary;
        private ReaLTaiizor.Controls.FoxBigLabel lbl_Ray_Name;
    }
}