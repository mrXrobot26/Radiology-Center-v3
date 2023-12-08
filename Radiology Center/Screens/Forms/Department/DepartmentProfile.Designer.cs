namespace Radiology_Center.Screens.Forms.Department
{
    partial class DepartmentProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentProfile));
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_depId = new ReaLTaiizor.Controls.FoxBigLabel();
            this.btrn_close = new System.Windows.Forms.Button();
            this.lbl_DepName = new ReaLTaiizor.Controls.FoxBigLabel();
            this.foxLabel7 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel5 = new ReaLTaiizor.Controls.FoxLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.btrn_close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(795, 57);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 47;
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_depId
            // 
            this.lbl_depId.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lbl_depId.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_depId.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.lbl_depId.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbl_depId.Location = new System.Drawing.Point(92, 155);
            this.lbl_depId.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_depId.Name = "lbl_depId";
            this.lbl_depId.Size = new System.Drawing.Size(360, 22);
            this.lbl_depId.TabIndex = 53;
            this.lbl_depId.Text = "12345678";
            // 
            // btrn_close
            // 
            this.btrn_close.BackColor = System.Drawing.SystemColors.Control;
            this.btrn_close.FlatAppearance.BorderSize = 0;
            this.btrn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btrn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrn_close.Location = new System.Drawing.Point(718, 18);
            this.btrn_close.Name = "btrn_close";
            this.btrn_close.Size = new System.Drawing.Size(35, 23);
            this.btrn_close.TabIndex = 51;
            this.btrn_close.Text = "X";
            this.btrn_close.UseVisualStyleBackColor = false;
            this.btrn_close.Click += new System.EventHandler(this.btrn_close_Click);
            // 
            // lbl_DepName
            // 
            this.lbl_DepName.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lbl_DepName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_DepName.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.lbl_DepName.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbl_DepName.Location = new System.Drawing.Point(92, 288);
            this.lbl_DepName.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_DepName.Name = "lbl_DepName";
            this.lbl_DepName.Size = new System.Drawing.Size(360, 22);
            this.lbl_DepName.TabIndex = 55;
            this.lbl_DepName.Text = "Male";
            // 
            // foxLabel7
            // 
            this.foxLabel7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.foxLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.foxLabel7.Location = new System.Drawing.Point(92, 224);
            this.foxLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.foxLabel7.Name = "foxLabel7";
            this.foxLabel7.Size = new System.Drawing.Size(132, 30);
            this.foxLabel7.TabIndex = 54;
            this.foxLabel7.Text = "Department";
            // 
            // foxLabel5
            // 
            this.foxLabel5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.foxLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.foxLabel5.Location = new System.Drawing.Point(92, 111);
            this.foxLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.foxLabel5.Name = "foxLabel5";
            this.foxLabel5.Size = new System.Drawing.Size(132, 30);
            this.foxLabel5.TabIndex = 52;
            this.foxLabel5.Text = "ID";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(648, 81);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(105, 42);
            this.guna2Button1.TabIndex = 59;
            this.guna2Button1.Text = "Delete";
            this.guna2Button1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DepartmentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 430);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lbl_depId);
            this.Controls.Add(this.lbl_DepName);
            this.Controls.Add(this.foxLabel7);
            this.Controls.Add(this.foxLabel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepartmentProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentProfile";
            this.Load += new System.EventHandler(this.DepartmentProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btrn_close;
        private ReaLTaiizor.Controls.FoxBigLabel lbl_depId;
        private ReaLTaiizor.Controls.FoxBigLabel lbl_DepName;
        private ReaLTaiizor.Controls.FoxLabel foxLabel7;
        private ReaLTaiizor.Controls.FoxLabel foxLabel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}