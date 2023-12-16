namespace Radiology_Center.Screens.Forms.Assistant
{
    partial class AssistantHomePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssistantHomePage));
            this.grd_assistant = new Guna.UI2.WinForms.Guna2DataGridView();
            this.brn_refresh = new ReaLTaiizor.Controls.AloneButton();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addDoctor = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_user = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_ray = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_profile = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_doc_names = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_departments = new System.Windows.Forms.Button();
            this.btn_patient = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.lbl_generl = new ReaLTaiizor.Controls.BigLabel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_branch = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grd_assistant)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_assistant
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.grd_assistant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_assistant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd_assistant.ColumnHeadersHeight = 39;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_assistant.DefaultCellStyle = dataGridViewCellStyle3;
            this.grd_assistant.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.grd_assistant.Location = new System.Drawing.Point(3, 0);
            this.grd_assistant.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.grd_assistant.MultiSelect = false;
            this.grd_assistant.Name = "grd_assistant";
            this.grd_assistant.ReadOnly = true;
            this.grd_assistant.RowHeadersVisible = false;
            this.grd_assistant.RowHeadersWidth = 20;
            this.grd_assistant.RowTemplate.Height = 50;
            this.grd_assistant.RowTemplate.ReadOnly = true;
            this.grd_assistant.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_assistant.ShowEditingIcon = false;
            this.grd_assistant.Size = new System.Drawing.Size(1435, 828);
            this.grd_assistant.TabIndex = 101;
            this.grd_assistant.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.grd_assistant.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.grd_assistant.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grd_assistant.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grd_assistant.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grd_assistant.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grd_assistant.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grd_assistant.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.grd_assistant.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.grd_assistant.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grd_assistant.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_assistant.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grd_assistant.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd_assistant.ThemeStyle.HeaderStyle.Height = 39;
            this.grd_assistant.ThemeStyle.ReadOnly = true;
            this.grd_assistant.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.grd_assistant.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grd_assistant.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_assistant.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grd_assistant.ThemeStyle.RowsStyle.Height = 50;
            this.grd_assistant.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.grd_assistant.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // brn_refresh
            // 
            this.brn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brn_refresh.EnabledCalc = true;
            this.brn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.brn_refresh.Location = new System.Drawing.Point(1209, 16);
            this.brn_refresh.Name = "brn_refresh";
            this.brn_refresh.Size = new System.Drawing.Size(120, 39);
            this.brn_refresh.TabIndex = 15;
            this.brn_refresh.Text = "Refresh";
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
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_addDoctor
            // 
            this.btn_addDoctor.BorderRadius = 3;
            this.btn_addDoctor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addDoctor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addDoctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addDoctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addDoctor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addDoctor.ForeColor = System.Drawing.Color.White;
            this.btn_addDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btn_addDoctor.Image")));
            this.btn_addDoctor.Location = new System.Drawing.Point(1335, 16);
            this.btn_addDoctor.Name = "btn_addDoctor";
            this.btn_addDoctor.Size = new System.Drawing.Size(139, 39);
            this.btn_addDoctor.TabIndex = 11;
            this.btn_addDoctor.Text = "Add";
            this.btn_addDoctor.Click += new System.EventHandler(this.btn_addDoctor_Click);
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
            this.pic_user.Location = new System.Drawing.Point(10, 11);
            this.pic_user.Name = "pic_user";
            this.pic_user.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic_user.Size = new System.Drawing.Size(90, 90);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_user.TabIndex = 7;
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
            // panel10
            // 
            this.panel10.Controls.Add(this.brn_refresh);
            this.panel10.Controls.Add(this.txt_search);
            this.panel10.Controls.Add(this.btn_search);
            this.panel10.Controls.Add(this.btn_addDoctor);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(365, 43);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1362, 70);
            this.panel10.TabIndex = 19;
            // 
            // btn_ray
            // 
            this.btn_ray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.btn_ray.FlatAppearance.BorderSize = 0;
            this.btn_ray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ray.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ray.ForeColor = System.Drawing.Color.White;
            this.btn_ray.Image = ((System.Drawing.Image)(resources.GetObject("btn_ray.Image")));
            this.btn_ray.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ray.Location = new System.Drawing.Point(4, 0);
            this.btn_ray.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ray.Name = "btn_ray";
            this.btn_ray.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btn_ray.Size = new System.Drawing.Size(360, 67);
            this.btn_ray.TabIndex = 2;
            this.btn_ray.Text = "           Rays";
            this.btn_ray.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ray.UseVisualStyleBackColor = false;
            this.btn_ray.Click += new System.EventHandler(this.btn_ray_Click);
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
            this.panel4.Controls.Add(this.btn_doc_names);
            this.panel4.Location = new System.Drawing.Point(1, 272);
            this.panel4.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(364, 67);
            this.panel4.TabIndex = 6;
            // 
            // btn_doc_names
            // 
            this.btn_doc_names.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.btn_doc_names.FlatAppearance.BorderSize = 0;
            this.btn_doc_names.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doc_names.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doc_names.ForeColor = System.Drawing.Color.White;
            this.btn_doc_names.Image = ((System.Drawing.Image)(resources.GetObject("btn_doc_names.Image")));
            this.btn_doc_names.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doc_names.Location = new System.Drawing.Point(4, 0);
            this.btn_doc_names.Margin = new System.Windows.Forms.Padding(2);
            this.btn_doc_names.Name = "btn_doc_names";
            this.btn_doc_names.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btn_doc_names.Size = new System.Drawing.Size(360, 67);
            this.btn_doc_names.TabIndex = 2;
            this.btn_doc_names.Text = "           Doctors";
            this.btn_doc_names.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doc_names.UseVisualStyleBackColor = false;
            this.btn_doc_names.Click += new System.EventHandler(this.btn_doc_names_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_departments);
            this.panel5.Location = new System.Drawing.Point(1, 343);
            this.panel5.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(364, 67);
            this.panel5.TabIndex = 7;
            // 
            // btn_departments
            // 
            this.btn_departments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.btn_departments.FlatAppearance.BorderSize = 0;
            this.btn_departments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_departments.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_departments.ForeColor = System.Drawing.Color.White;
            this.btn_departments.Image = ((System.Drawing.Image)(resources.GetObject("btn_departments.Image")));
            this.btn_departments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_departments.Location = new System.Drawing.Point(4, 0);
            this.btn_departments.Margin = new System.Windows.Forms.Padding(2);
            this.btn_departments.Name = "btn_departments";
            this.btn_departments.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btn_departments.Size = new System.Drawing.Size(360, 67);
            this.btn_departments.TabIndex = 2;
            this.btn_departments.Text = "           Departments";
            this.btn_departments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_departments.UseVisualStyleBackColor = false;
            this.btn_departments.Click += new System.EventHandler(this.btn_departments_Click);
            // 
            // btn_patient
            // 
            this.btn_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.btn_patient.FlatAppearance.BorderSize = 0;
            this.btn_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient.ForeColor = System.Drawing.Color.White;
            this.btn_patient.Image = ((System.Drawing.Image)(resources.GetObject("btn_patient.Image")));
            this.btn_patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_patient.Location = new System.Drawing.Point(4, 0);
            this.btn_patient.Margin = new System.Windows.Forms.Padding(2);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btn_patient.Size = new System.Drawing.Size(360, 67);
            this.btn_patient.TabIndex = 2;
            this.btn_patient.Text = "           Patients";
            this.btn_patient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_patient.UseVisualStyleBackColor = false;
            this.btn_patient.Click += new System.EventHandler(this.btn_patient_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_patient);
            this.panel6.Location = new System.Drawing.Point(1, 201);
            this.panel6.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(364, 67);
            this.panel6.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btn_ray);
            this.panel12.Location = new System.Drawing.Point(1, 414);
            this.panel12.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(364, 67);
            this.panel12.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel12);
            this.flowLayoutPanel1.Controls.Add(this.btn_logOut);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(365, 804);
            this.flowLayoutPanel1.TabIndex = 18;
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
            this.btn_logOut.Location = new System.Drawing.Point(2, 485);
            this.btn_logOut.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btn_logOut.Size = new System.Drawing.Size(360, 67);
            this.btn_logOut.TabIndex = 12;
            this.btn_logOut.Text = "           Log out";
            this.btn_logOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logOut.UseVisualStyleBackColor = false;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // lbl_generl
            // 
            this.lbl_generl.AutoSize = true;
            this.lbl_generl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_generl.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_generl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl_generl.Location = new System.Drawing.Point(368, -3);
            this.lbl_generl.Name = "lbl_generl";
            this.lbl_generl.Size = new System.Drawing.Size(141, 45);
            this.lbl_generl.TabIndex = 3;
            this.lbl_generl.Text = "Doctors";
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
            this.nightControlBox1.Location = new System.Drawing.Point(1588, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.grd_assistant);
            this.panel11.Location = new System.Drawing.Point(401, 139);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1425, 831);
            this.panel11.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_branch);
            this.panel1.Controls.Add(this.lbl_generl);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1727, 43);
            this.panel1.TabIndex = 17;
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
            this.lbl_branch.TabIndex = 8;
            this.lbl_branch.Text = "Radiology-Center ";
            // 
            // AssistantHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1727, 847);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssistantHomePage";
            this.Text = "AssistantHomePage";
            ((System.ComponentModel.ISupportInitialize)(this.grd_assistant)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView grd_assistant;
        private ReaLTaiizor.Controls.AloneButton brn_refresh;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2Button btn_addDoctor;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic_user;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btn_ray;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_doc_names;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_departments;
        private System.Windows.Forms.Button btn_patient;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.BigLabel lbl_generl;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_logOut;
        private ReaLTaiizor.Controls.BigLabel lbl_branch;
    }
}