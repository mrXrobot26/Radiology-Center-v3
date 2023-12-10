namespace Radiology_Center.Screens.Forms.Ray
{
    partial class RayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RayForm));
            this.txt_rayName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addDoc = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_addDep = new System.Windows.Forms.Label();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_rayCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comb_dep = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_rayName
            // 
            this.txt_rayName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.txt_rayName.BorderRadius = 5;
            this.txt_rayName.BorderThickness = 2;
            this.txt_rayName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_rayName.DefaultText = "";
            this.txt_rayName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_rayName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_rayName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_rayName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_rayName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_rayName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_rayName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_rayName.Location = new System.Drawing.Point(120, 140);
            this.txt_rayName.Name = "txt_rayName";
            this.txt_rayName.PasswordChar = '\0';
            this.txt_rayName.PlaceholderText = "";
            this.txt_rayName.SelectedText = "";
            this.txt_rayName.Size = new System.Drawing.Size(239, 44);
            this.txt_rayName.TabIndex = 55;
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
            this.btn_cancel.Location = new System.Drawing.Point(234, 345);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(125, 41);
            this.btn_cancel.TabIndex = 53;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_addDoc
            // 
            this.btn_addDoc.BorderColor = System.Drawing.Color.White;
            this.btn_addDoc.BorderRadius = 5;
            this.btn_addDoc.BorderThickness = 2;
            this.btn_addDoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addDoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addDoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addDoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addDoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.btn_addDoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addDoc.ForeColor = System.Drawing.Color.White;
            this.btn_addDoc.Location = new System.Drawing.Point(459, 345);
            this.btn_addDoc.Name = "btn_addDoc";
            this.btn_addDoc.Size = new System.Drawing.Size(124, 41);
            this.btn_addDoc.TabIndex = 54;
            this.btn_addDoc.Text = "Add";
            this.btn_addDoc.Click += new System.EventHandler(this.btn_addDoc_Click);
            // 
            // lbl_addDep
            // 
            this.lbl_addDep.AutoSize = true;
            this.lbl_addDep.BackColor = System.Drawing.Color.Transparent;
            this.lbl_addDep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addDep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.lbl_addDep.Location = new System.Drawing.Point(116, 103);
            this.lbl_addDep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_addDep.Name = "lbl_addDep";
            this.lbl_addDep.Size = new System.Drawing.Size(88, 21);
            this.lbl_addDep.TabIndex = 52;
            this.lbl_addDep.Text = "Ray Name";
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
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 51;
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
            this.bigLabel1.Size = new System.Drawing.Size(332, 32);
            this.bigLabel1.TabIndex = 52;
            this.bigLabel1.Text = "Radiology Center - Add Ray";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // txt_rayCost
            // 
            this.txt_rayCost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.txt_rayCost.BorderRadius = 5;
            this.txt_rayCost.BorderThickness = 2;
            this.txt_rayCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_rayCost.DefaultText = "";
            this.txt_rayCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_rayCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_rayCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_rayCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_rayCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_rayCost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_rayCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_rayCost.Location = new System.Drawing.Point(450, 140);
            this.txt_rayCost.Name = "txt_rayCost";
            this.txt_rayCost.PasswordChar = '\0';
            this.txt_rayCost.PlaceholderText = "";
            this.txt_rayCost.SelectedText = "";
            this.txt_rayCost.Size = new System.Drawing.Size(239, 44);
            this.txt_rayCost.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(446, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ray Cost";
            // 
            // comb_dep
            // 
            this.comb_dep.BackColor = System.Drawing.Color.Transparent;
            this.comb_dep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comb_dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_dep.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comb_dep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comb_dep.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comb_dep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comb_dep.ItemHeight = 30;
            this.comb_dep.Location = new System.Drawing.Point(120, 248);
            this.comb_dep.Name = "comb_dep";
            this.comb_dep.Size = new System.Drawing.Size(225, 36);
            this.comb_dep.TabIndex = 58;
            this.comb_dep.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(116, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "Department Name";
            // 
            // RayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comb_dep);
            this.Controls.Add(this.txt_rayCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_rayName);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addDoc);
            this.Controls.Add(this.lbl_addDep);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RayForm";
            this.Text = "RayForm";
            this.Load += new System.EventHandler(this.RayForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_rayName;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2Button btn_addDoc;
        private System.Windows.Forms.Label lbl_addDep;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_rayCost;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox comb_dep;
        private System.Windows.Forms.Label label2;
    }
}