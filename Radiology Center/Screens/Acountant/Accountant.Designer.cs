namespace Radiology_Center.Screens.Acountant
{
    partial class Accountant
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accountant));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_user = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_profile = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_payment = new System.Windows.Forms.Button();
            this.Comb_days = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Grid_Acc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.chart1 = new LiveCharts.WinForms.CartesianChart();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lbl_branch = new ReaLTaiizor.Controls.BigLabel();
            this.lbl_generl = new ReaLTaiizor.Controls.BigLabel();
            this.nightControlBox2 = new ReaLTaiizor.Controls.NightControlBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.analysisVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Acc)).BeginInit();
            this.panel10.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pic_user);
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Controls.Add(this.lbl_email);
            this.panel2.Location = new System.Drawing.Point(2, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 104);
            this.panel2.TabIndex = 3;
            // 
            // pic_user
            // 
            this.pic_user.Image = ((System.Drawing.Image)(resources.GetObject("pic_user.Image")));
            this.pic_user.ImageRotate = 0F;
            this.pic_user.Location = new System.Drawing.Point(10, 8);
            this.pic_user.Name = "pic_user";
            this.pic_user.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic_user.Size = new System.Drawing.Size(90, 90);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_user.TabIndex = 8;
            this.pic_user.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(114, 41);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(38, 20, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(96, 21);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Layla Elbessa";
            this.lbl_name.UseCompatibleTextRendering = true;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.lbl_email.Font = new System.Drawing.Font("Sans Serif Collection", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(111, 72);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(38, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(183, 17);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "LaylaElbessa10@email.com";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_profile);
            this.panel3.Location = new System.Drawing.Point(1, 130);
            this.panel3.Margin = new System.Windows.Forms.Padding(1, 16, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 67);
            this.panel3.TabIndex = 5;
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.ForeColor = System.Drawing.Color.White;
            this.btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_profile.Image")));
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.Location = new System.Drawing.Point(4, 0);
            this.btn_profile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btn_profile.Size = new System.Drawing.Size(360, 67);
            this.btn_profile.TabIndex = 2;
            this.btn_profile.Text = "           Profile";
            this.btn_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_payment);
            this.panel4.Location = new System.Drawing.Point(1, 201);
            this.panel4.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(364, 67);
            this.panel4.TabIndex = 6;
            // 
            // btn_payment
            // 
            this.btn_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.btn_payment.FlatAppearance.BorderSize = 0;
            this.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.ForeColor = System.Drawing.Color.White;
            this.btn_payment.Image = global::Radiology_Center.Properties.Resources.icons8_bill_24;
            this.btn_payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payment.Location = new System.Drawing.Point(4, 0);
            this.btn_payment.Margin = new System.Windows.Forms.Padding(2);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btn_payment.Size = new System.Drawing.Size(360, 67);
            this.btn_payment.TabIndex = 2;
            this.btn_payment.Text = "           Payment";
            this.btn_payment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payment.UseVisualStyleBackColor = false;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // Comb_days
            // 
            this.Comb_days.BackColor = System.Drawing.Color.Transparent;
            this.Comb_days.BorderRadius = 5;
            this.Comb_days.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.Comb_days.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Comb_days.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comb_days.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Comb_days.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Comb_days.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Comb_days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Comb_days.ItemHeight = 30;
            this.Comb_days.Location = new System.Drawing.Point(1316, 16);
            this.Comb_days.Name = "Comb_days";
            this.Comb_days.Size = new System.Drawing.Size(167, 36);
            this.Comb_days.TabIndex = 109;
            this.Comb_days.Visible = false;
            this.Comb_days.SelectedIndexChanged += new System.EventHandler(this.Comb_days_SelectedIndexChanged_1);
            // 
            // Grid_Acc
            // 
            this.Grid_Acc.AllowUserToAddRows = false;
            this.Grid_Acc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.Grid_Acc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Acc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_Acc.ColumnHeadersHeight = 39;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Acc.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_Acc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.Grid_Acc.Location = new System.Drawing.Point(421, 138);
            this.Grid_Acc.Margin = new System.Windows.Forms.Padding(2);
            this.Grid_Acc.MultiSelect = false;
            this.Grid_Acc.Name = "Grid_Acc";
            this.Grid_Acc.ReadOnly = true;
            this.Grid_Acc.RowHeadersVisible = false;
            this.Grid_Acc.RowHeadersWidth = 50;
            this.Grid_Acc.RowTemplate.Height = 40;
            this.Grid_Acc.ShowEditingIcon = false;
            this.Grid_Acc.Size = new System.Drawing.Size(1449, 554);
            this.Grid_Acc.TabIndex = 101;
            this.Grid_Acc.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.Grid_Acc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.Grid_Acc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Grid_Acc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Grid_Acc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Grid_Acc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Grid_Acc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Grid_Acc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.Grid_Acc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.Grid_Acc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Grid_Acc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Acc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Grid_Acc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid_Acc.ThemeStyle.HeaderStyle.Height = 39;
            this.Grid_Acc.ThemeStyle.ReadOnly = true;
            this.Grid_Acc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.Grid_Acc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Grid_Acc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Acc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Grid_Acc.ThemeStyle.RowsStyle.Height = 40;
            this.Grid_Acc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.Grid_Acc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Grid_Acc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewpayment_CellContentClick);
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(673, 681);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(866, 359);
            this.chart1.TabIndex = 113;
            this.chart1.Text = "cartesianChart1";
            this.chart1.Visible = false;
          
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txt_search);
            this.panel10.Controls.Add(this.btn_search);
            this.panel10.Controls.Add(this.Comb_days);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(365, 43);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1505, 70);
            this.panel10.TabIndex = 116;
            // 
            // txt_search
            // 
            this.txt_search.BorderRadius = 5;
            this.txt_search.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(36, 16);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Search";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(332, 39);
            this.txt_search.TabIndex = 12;
            // 
            // btn_search
            // 
            this.btn_search.BorderRadius = 5;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(374, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(61, 39);
            this.btn_search.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.btn_reports);
            this.flowLayoutPanel2.Controls.Add(this.btn_logOut);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 43);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(365, 864);
            this.flowLayoutPanel2.TabIndex = 115;
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.btn_reports.FlatAppearance.BorderSize = 0;
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.Color.White;
            this.btn_reports.Image = global::Radiology_Center.Properties.Resources.icons8_report_24;
            this.btn_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reports.Location = new System.Drawing.Point(2, 272);
            this.btn_reports.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btn_reports.Size = new System.Drawing.Size(360, 67);
            this.btn_reports.TabIndex = 3;
            this.btn_reports.Text = "           Reports";
            this.btn_reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reports.UseVisualStyleBackColor = false;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.btn_logOut.FlatAppearance.BorderSize = 0;
            this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logOut.ForeColor = System.Drawing.Color.White;
            this.btn_logOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_logOut.Image")));
            this.btn_logOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logOut.Location = new System.Drawing.Point(2, 343);
            this.btn_logOut.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btn_logOut.Size = new System.Drawing.Size(360, 67);
            this.btn_logOut.TabIndex = 13;
            this.btn_logOut.Text = "           Log out";
            this.btn_logOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logOut.UseVisualStyleBackColor = false;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.lbl_branch);
            this.panel15.Controls.Add(this.lbl_generl);
            this.panel15.Controls.Add(this.nightControlBox2);
            this.panel15.Controls.Add(this.pictureBox2);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1870, 43);
            this.panel15.TabIndex = 114;
            // 
            // lbl_branch
            // 
            this.lbl_branch.AutoSize = true;
            this.lbl_branch.BackColor = System.Drawing.Color.Transparent;
            this.lbl_branch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_branch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl_branch.Location = new System.Drawing.Point(49, 8);
            this.lbl_branch.Name = "lbl_branch";
            this.lbl_branch.Size = new System.Drawing.Size(191, 30);
            this.lbl_branch.TabIndex = 6;
            this.lbl_branch.Text = "Radiology-Center ";
            // 
            // lbl_generl
            // 
            this.lbl_generl.AutoSize = true;
            this.lbl_generl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_generl.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_generl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl_generl.Location = new System.Drawing.Point(368, -3);
            this.lbl_generl.Name = "lbl_generl";
            this.lbl_generl.Size = new System.Drawing.Size(199, 45);
            this.lbl_generl.TabIndex = 3;
            this.lbl_generl.Text = "Accountant";
            // 
            // nightControlBox2
            // 
            this.nightControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox2.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox2.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox2.DefaultLocation = true;
            this.nightControlBox2.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox2.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox2.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox2.EnableMaximizeButton = true;
            this.nightControlBox2.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox2.EnableMinimizeButton = true;
            this.nightControlBox2.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox2.Location = new System.Drawing.Point(1731, 0);
            this.nightControlBox2.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox2.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox2.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox2.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox2.Name = "nightControlBox2";
            this.nightControlBox2.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // analysisVMBindingSource
            // 
            this.analysisVMBindingSource.DataSource = typeof(Radiology_Center.ViewModels.AnalysisVM);
            // 
            // Accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1870, 907);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Grid_Acc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(2288, 1614);
            this.Name = "Accountant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acountant";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Acc)).EndInit();
            this.panel10.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_payment;
        private Guna.UI2.WinForms.Guna2ComboBox Comb_days;
        private System.Windows.Forms.Button btn_reports;
        private Guna.UI2.WinForms.Guna2DataGridView Grid_Acc;
        private System.Windows.Forms.BindingSource analysisVMBindingSource;
        private LiveCharts.WinForms.CartesianChart chart1;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel15;
        private ReaLTaiizor.Controls.BigLabel lbl_generl;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic_user;
        private System.Windows.Forms.Button btn_logOut;
        private ReaLTaiizor.Controls.BigLabel lbl_branch;
    }
}