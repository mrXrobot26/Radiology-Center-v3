namespace Radiology_Center.Screens.Forms
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.panel_Side = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.User_TBox = new ReaLTaiizor.Controls.BigTextBox();
            this.Pass_TBox = new ReaLTaiizor.Controls.BigTextBox();
            this.User_label = new System.Windows.Forms.Label();
            this.Pass_Label = new System.Windows.Forms.Label();
            this.Log_btn = new System.Windows.Forms.Button();
            this.Cancle_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_Side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Side
            // 
            this.panel_Side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.panel_Side.Controls.Add(this.pictureBox1);
            this.panel_Side.Location = new System.Drawing.Point(-1, -1);
            this.panel_Side.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Side.Name = "panel_Side";
            this.panel_Side.Size = new System.Drawing.Size(320, 420);
            this.panel_Side.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(640, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 3;
            // 
            // User_TBox
            // 
            this.User_TBox.BackColor = System.Drawing.Color.Transparent;
            this.User_TBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.User_TBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.User_TBox.ForeColor = System.Drawing.Color.DimGray;
            this.User_TBox.Image = null;
            this.User_TBox.Location = new System.Drawing.Point(390, 115);
            this.User_TBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.User_TBox.MaxLength = 32767;
            this.User_TBox.Multiline = false;
            this.User_TBox.Name = "User_TBox";
            this.User_TBox.ReadOnly = false;
            this.User_TBox.Size = new System.Drawing.Size(269, 41);
            this.User_TBox.TabIndex = 5;
            this.User_TBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.User_TBox.UseSystemPasswordChar = false;
            // 
            // Pass_TBox
            // 
            this.Pass_TBox.BackColor = System.Drawing.Color.Transparent;
            this.Pass_TBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pass_TBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Pass_TBox.ForeColor = System.Drawing.Color.DimGray;
            this.Pass_TBox.Image = null;
            this.Pass_TBox.Location = new System.Drawing.Point(390, 202);
            this.Pass_TBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pass_TBox.MaxLength = 32767;
            this.Pass_TBox.Multiline = false;
            this.Pass_TBox.Name = "Pass_TBox";
            this.Pass_TBox.ReadOnly = false;
            this.Pass_TBox.Size = new System.Drawing.Size(269, 41);
            this.Pass_TBox.TabIndex = 6;
            this.Pass_TBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pass_TBox.UseSystemPasswordChar = false;
            // 
            // User_label
            // 
            this.User_label.AutoSize = true;
            this.User_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.User_label.Location = new System.Drawing.Point(387, 93);
            this.User_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(93, 18);
            this.User_label.TabIndex = 7;
            this.User_label.Text = "User Name";
            // 
            // Pass_Label
            // 
            this.Pass_Label.AutoSize = true;
            this.Pass_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.Pass_Label.Location = new System.Drawing.Point(387, 180);
            this.Pass_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pass_Label.Name = "Pass_Label";
            this.Pass_Label.Size = new System.Drawing.Size(83, 18);
            this.Pass_Label.TabIndex = 8;
            this.Pass_Label.Text = "Password";
            // 
            // Log_btn
            // 
            this.Log_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.Log_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_btn.ForeColor = System.Drawing.Color.White;
            this.Log_btn.Location = new System.Drawing.Point(404, 278);
            this.Log_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Log_btn.Name = "Log_btn";
            this.Log_btn.Size = new System.Drawing.Size(92, 48);
            this.Log_btn.TabIndex = 9;
            this.Log_btn.Text = "LOGIN";
            this.Log_btn.UseVisualStyleBackColor = false;
            // 
            // Cancle_btn
            // 
            this.Cancle_btn.BackColor = System.Drawing.Color.White;
            this.Cancle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancle_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.Cancle_btn.Location = new System.Drawing.Point(516, 278);
            this.Cancle_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancle_btn.Name = "Cancle_btn";
            this.Cancle_btn.Size = new System.Drawing.Size(92, 48);
            this.Cancle_btn.TabIndex = 10;
            this.Cancle_btn.Text = "CANCLE";
            this.Cancle_btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(356, 110);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(356, 206);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 415);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Cancle_btn);
            this.Controls.Add(this.Log_btn);
            this.Controls.Add(this.Pass_Label);
            this.Controls.Add(this.User_label);
            this.Controls.Add(this.Pass_TBox);
            this.Controls.Add(this.User_TBox);
            this.Controls.Add(this.nightControlBox1);
            this.Controls.Add(this.panel_Side);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.panel_Side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Side;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.BigTextBox User_TBox;
        private ReaLTaiizor.Controls.BigTextBox Pass_TBox;
        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.Label Pass_Label;
        private System.Windows.Forms.Button Log_btn;
        private System.Windows.Forms.Button Cancle_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}