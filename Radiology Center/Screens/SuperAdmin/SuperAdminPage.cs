using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Radiology_Center.Models;
using Radiology_Center.ViewModels;
using Radiology_Center.Screens.Forms;

namespace Radiology_Center
{
    public partial class SuperAdminPage : Form
    {
        RadiologyEntities _db = new RadiologyEntities();

        public void DataGridViewForDoctor()
        {
            var res = from Doc in _db.doctors
                      join Dep in _db.departments on Doc.dep_id equals Dep.id
                      select new DoctorVM
                      {
                          Id = Doc.id,
                          DoctorFullName = Doc.fName + " " + Doc.lName,
                          Salary = (decimal)Doc.salary,
                          BirthDate = Doc.birthdate,
                          PhoneNumber = Doc.phone_number,
                          Gender = Doc.gender,
                          depNeme = Dep.name,
                      };
            var DoctorDataList = res.ToList();
            grd_doctors_sAdmin.DataSource = DoctorDataList;
            grd_doctors_sAdmin.AutoGenerateColumns = true;
        }
        public SuperAdminPage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            DataGridViewForDoctor();


        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_profile.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "My Profile";
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radiology_centerDataSet4.Doctor' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'radiology_centerDataSet2.Doctor' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'radiology_centerDataSet1.Doctor' table. You can move, or remove it, as needed.

            this.Bounds = Screen.PrimaryScreen.Bounds;

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_doctors_sAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_addDoctor_Click(object sender, EventArgs e)
        {
            Docter docter = new Docter();
            docter.ShowDialog();
        }

        private void grd_doctors_sAdmin_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_doctors_sAdmin_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_departments_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_departments.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Department";

        }

        private void btn_doc_names_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_doc_names.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Doctor";

        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_patient.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Patient";

        }

        private void btn_assistant_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_assistant.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Assistant";

        }

        private void btn_accountant_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_accountant.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Accountant";

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_admin.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Admin";

        }
        private void ResetButtonColors()
        {
            btn_profile.BackColor = Color.FromArgb(20, 39, 55);
            btn_departments.BackColor = Color.FromArgb(20, 39, 55);
            btn_doc_names.BackColor = Color.FromArgb(20, 39, 55);
            btn_patient.BackColor = Color.FromArgb(20, 39, 55);
            btn_assistant.BackColor = Color.FromArgb(20, 39, 55);
            btn_accountant.BackColor = Color.FromArgb(20, 39, 55);
            btn_admin.BackColor = Color.FromArgb(20, 39, 55);
        }

        private void brn_refresh_Click(object sender, EventArgs e)
        {
            DataGridViewForDoctor();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
