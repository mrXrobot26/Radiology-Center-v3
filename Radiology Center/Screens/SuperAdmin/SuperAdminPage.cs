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
using Radiology_Center.Screens.Forms.Department;
using System.Runtime.Remoting.Contexts;
using Radiology_Center.Screens.Forms.Assistant;
using Radiology_Center.Screens.Forms.Acountant;
using Radiology_Center.Screens.Forms.Admin;

namespace Radiology_Center
{
    public partial class SuperAdminPage : Form
    {
        RadiologyEntities _db = new RadiologyEntities();


        public SuperAdminPage()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            lbl_generl.Text = "Doctor";
            DataGridViewForDoctor();

        }


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
        public void DataGridViewForDepartment()
        {
            var res = _db.departments.Select(x => new { x.id, x.name });
            var depDataList = res.ToList();
            grd_doctors_sAdmin.DataSource = depDataList;
            grd_doctors_sAdmin.AutoGenerateColumns = true;
        }

        public void DataGridViewForPatiant()
        {
            var res = from pd in _db.patient_data
                        join pi in _db.patient_info on pd.id equals pi.id
                        join d in _db.doctors on pd.doctor_id equals d.id
                        join dep in _db.departments on d.dep_id equals dep.id
                        join r in _db.rays on pd.ray_id equals r.id
                        select new
                        {
                            Name = pi.fName + " " + pi.lName,
                            Status = pd.pay_status,
                            Date = pd.daydate,
                            Report = pd.doctor_report,
                            Doctor = d.fName + " " + d.lName,
                            department = dep.name,
                            Ray =r.name,
                        };
            var patiantDataList = res.ToList();
            grd_doctors_sAdmin.DataSource = patiantDataList;
            grd_doctors_sAdmin.AutoGenerateColumns = true;
        }


        public void DataGridViewForAssistant()
        {
            var res = _db.assisatants.Select(x => new
            {
                Name = x.fName + " " + x.lName,
                Salary = (decimal)x.salary,
                Birthdate = x.birthdate,
                PhoneNumber = x.phone_number,
                Gender = x.gender,
                NationalID = x.nationalID,
            });
            var assistantDataList = res.ToList();
            grd_doctors_sAdmin.DataSource = assistantDataList;
            grd_doctors_sAdmin.AutoGenerateColumns = true;
        }



        public void DataGridViewForAcountant()
        {
            var res = _db.accountants.Select(x => new
            {
                Name = x.fName + " " + x.lName,
                Salary = (decimal)x.salary,
                Birthdate = x.birthdate,
                PhoneNumber = x.phone_number,
                Gender = x.gender,
                NationalID = x.nationalID,
            });
            var AccountantDataList = res.ToList();
            grd_doctors_sAdmin.DataSource = AccountantDataList;
            grd_doctors_sAdmin.AutoGenerateColumns = true;
        }
        
        public void DataGridViewForAdmin()
        {
            var res = _db.admins.Select(x => new
            {
                Name = x.fName + " " + x.lName,
                Salary = (decimal)x.Salary,
                Birthdate = x.birthdate,
                PhoneNumber = x.phone_number,
                Gender = x.gender,
                NationalID = x.nationalID,
            });
            var AdminDataList = res.ToList();
            grd_doctors_sAdmin.DataSource = AdminDataList;
            grd_doctors_sAdmin.AutoGenerateColumns = true;
        }



        private void btn_profile_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_profile.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "My Profile";
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

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
            if (lbl_generl.Text == "Doctor")
            {
                Docter docter = new Docter();

                docter.DoctorAdd += OnDoctorAdded;

                docter.ShowDialog();
            }
            else if(lbl_generl.Text == "Department")
            {
                DepartmentForm dep = new DepartmentForm();

                dep.DepartmentAdded += OnDepartmentAdded; 

                dep.Show();
            }
            else if (lbl_generl.Text == "Assistant")
            {
                Assistant assis = new Assistant();

                assis.AssistantAdd += OnAssistantAdded;

                assis.Show();
            }
            else if (lbl_generl.Text == "Accountant")
            {
                AcountantForm acc = new AcountantForm();

                acc.AccountantAdd += OnAcountantAdded;

                acc.Show();
            }
            else if (lbl_generl.Text == "Admin")
            {
                AdminForm admin = new AdminForm();

                admin.AdminAdd += OnAdminAdded;

                admin.Show();
            }
        }
        private void OnAdminAdded()
        {
            DataGridViewForAdmin();
        }
        private void OnAcountantAdded()
        {
            DataGridViewForAcountant();
        }
        private void OnAssistantAdded()
        {
            DataGridViewForAssistant();
        }
        private void OnDoctorAdded()
        {
            DataGridViewForDoctor();
        }
        private void OnDepartmentAdded()
        {
            DataGridViewForDepartment();
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
            CheckLabelAndSetButtonVisibility();

            DataGridViewForDepartment();


        }

        private void btn_doc_names_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_doc_names.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Doctor";
            CheckLabelAndSetButtonVisibility();
            
            DataGridViewForDoctor();


        }

        private void btn_patient_Click(object sender, EventArgs e)
        {

            ResetButtonColors();
            btn_patient.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Patient";

            CheckLabelAndSetButtonVisibility();

            DataGridViewForPatiant();



        }
        private void CheckLabelAndSetButtonVisibility()
        {
            if (lbl_generl.Text != "Patient")
            {
                btn_addDoctor.Visible = true;
                brn_refresh.Visible = true;
            }
            else
            {
                btn_addDoctor.Visible = false;
                brn_refresh.Visible = false;
            }

        }
        private void btn_assistant_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_assistant.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Assistant";
            CheckLabelAndSetButtonVisibility();
            DataGridViewForAssistant();
        }

        private void btn_accountant_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_accountant.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Accountant";
            CheckLabelAndSetButtonVisibility();
            DataGridViewForAcountant();


        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_admin.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Admin";
            CheckLabelAndSetButtonVisibility();
            DataGridViewForAdmin();


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


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
