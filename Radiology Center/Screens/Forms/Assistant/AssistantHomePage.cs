using Radiology_Center.Models;
using Radiology_Center.Screens.Forms.Add_Patient;
using Radiology_Center.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Radiology_Center.Screens.Forms.Assistant
{
    public partial class AssistantHomePage : Form
    {
        RadiologyEntities _db = new RadiologyEntities();
        private int _id;
        private string _fullName;
        private string _email;
        private string _imagePath;
        private int _brach_id;

        public AssistantHomePage(string fullName, string email, string imagePath, int branch_id)
        {
            InitializeComponent();

            _fullName = fullName;
            _email = email;
            _imagePath = imagePath;
            _brach_id = branch_id;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            lbl_name.Text = fullName;
            lbl_email.Text = email;
            if (!string.IsNullOrEmpty(imagePath))
            {
                pic_user.ImageLocation = imagePath;
            }
            lbl_generl.Text = "Patient";
            DataGridViewForPatiant();
        }
        private void DataGridViewForPatiant()
        {
            var res = from pd in _db.patient_data
                      join pi in _db.patient_info on pd.patient_id equals pi.id
                      join d in _db.doctors on pd.doctor_id equals d.id
                      join dep in _db.departments on d.dep_id equals dep.id
                      join r in _db.rays on pd.ray_id equals r.id
                      where pd.branch_id == _brach_id
                      select new
                      {
                          Id = pd.id,
                          Name = pi.fName + " " + pi.lName,
                          Status = pd.pay_status,
                          Date = pd.daydate,
                          Report = pd.doctor_report,
                          Doctor = d.fName + " " + d.lName,
                          department = dep.name,
                          Ray = r.name,
                      };
            var patiantDataList = res.ToList();
            grd_assistant.DataSource = patiantDataList;
            grd_assistant.AutoGenerateColumns = true;

        }

        private void DataGridViewForRay()
        {
            var res = from ry in _db.rays
                      join dep in _db.departments on ry.dep_id equals dep.id
                      select new
                      {
                          Id = ry.id,
                          Name = ry.name,
                          Cost = ry.cost,
                          Department = dep.name
                      };

            var raysDataList = res.ToList();
            grd_assistant.DataSource = raysDataList;
            grd_assistant.AutoGenerateColumns = true;
        }
        private void DataGridViewForDepartment()
        {
            var res = _db.departments.Select(x => new { x.id, x.name });
            var depDataList = res.ToList();
            grd_assistant.DataSource = depDataList;
            grd_assistant.AutoGenerateColumns = true;
        }

        private void DataGridViewForDoctor()
        {
            var res = from Doc in _db.doctors
                      join Dep in _db.departments on Doc.dep_id equals Dep.id
                      join usr in _db.user_ on Doc.user_id equals usr.id
                      where usr.branch_id == _brach_id
                      select new 
                      {
                          Id = Doc.id,
                          DoctorFullName = Doc.fName + " " + Doc.lName,
                          PhoneNumber = Doc.phone_number,
                          depNeme = Dep.name,
                      };
            var DoctorDataList = res.ToList();
            grd_assistant.DataSource = DoctorDataList;
            grd_assistant.AutoGenerateColumns = true;
        }
        private void ResetButtonColors()
        {
            btn_profile.BackColor = Color.FromArgb(20, 39, 55);
            btn_departments.BackColor = Color.FromArgb(20, 39, 55);
            btn_doc_names.BackColor = Color.FromArgb(20, 39, 55);
            btn_patient.BackColor = Color.FromArgb(20, 39, 55);
            btn_ray.BackColor = Color.FromArgb(20, 39, 55);
            

        }

        private void CheckLabelAndSetButtonVisibility()
        {
            if (lbl_generl.Text == "Patient")
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


        private void btn_patient_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_patient.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Patient";
            CheckLabelAndSetButtonVisibility();
            DataGridViewForPatiant();
        }

        private void btn_ray_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_ray.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Ray";
            CheckLabelAndSetButtonVisibility();
            DataGridViewForRay();
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

        private void btn_profile_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            var userForProfile = _db.user_.FirstOrDefault(u => u.email == _email);
 
                if (userForProfile != null)
                {
                    var assistantForProfile = _db.assisatants.FirstOrDefault(a => a.user_id == userForProfile.id);
                    var roleForProfile = _db.roles.FirstOrDefault(r => r.id == userForProfile.role_id);


                    Profile_W profile = new Profile_W();
                    profile.SetProfileData(
                        userForProfile.id,
                        assistantForProfile.fName + " " + assistantForProfile.lName,
                        assistantForProfile.nationalID,
                        assistantForProfile.gender,
                        assistantForProfile.phone_number,
                        userForProfile.email,
                        (decimal)assistantForProfile.salary,
                        roleForProfile.role_name,
                        assistantForProfile.image,
                        (DateTime)assistantForProfile.birthdate,
                        "myProfile"
                    );

                    profile.Show();

                }
            }


        private void btn_search_Click(object sender, EventArgs e)
        {
            switch (lbl_generl.Text)
            {
                case "Doctor":
                    FilterDoctors(txt_search.Text);
                    break;
                case "Department":
                    FilterDepartments(txt_search.Text);
                    break;
                case "Patient":
                    FilterPatients(txt_search.Text);
                    break;
                case "Ray":
                    FilterRays(txt_search.Text);
                    break;

                default:
                    break;
            }

        }


        //============================================filter============================

        private void FilterDoctors(string searchText)
        {
            var filteredList = (from d in _db.doctors
                                join dep in _db.departments on d.dep_id equals dep.id
                                join urs in _db.user_ on d.user_id equals urs.id
                                where (d.fName + " " + d.lName).ToLower().Contains(searchText) && urs.branch_id == _brach_id
                                select new 
                                {
                                    Id = d.id,
                                    DoctorFullName = d.fName + " " + d.lName,
                                    PhoneNumber = d.phone_number,
                                    depNeme = dep.name,
                                }).ToList();

            grd_assistant.DataSource = filteredList;
            grd_assistant.AutoGenerateColumns = true;
        }
        private void FilterDepartments(string searchText)
        {
            var filteredList = _db.departments
                .Where(dep => dep.name.ToLower().Contains(searchText))
                .Select(dep => new { dep.id, dep.name })
                .ToList();

            grd_assistant.DataSource = filteredList;
        }

        private void FilterPatients(string searchText)
        {
            var filteredList = (from pd in _db.patient_data
                                join pi in _db.patient_info on pd.id equals pi.id
                                join d in _db.doctors on pd.doctor_id equals d.id
                                join dep in _db.departments on d.dep_id equals dep.id
                                join r in _db.rays on pd.ray_id equals r.id
                                where (pi.fName + " " + pi.lName).ToLower().Contains(searchText) && pd.branch_id == _brach_id
                                select new
                                {
                                    Id = pd.id,
                                    Name = pi.fName + " " + pi.lName,
                                    Status = pd.pay_status,
                                    Date = pd.daydate,
                                    Report = pd.doctor_report,
                                    Doctor = d.fName + " " + d.lName,
                                    department = dep.name,
                                    Ray = r.name,
                                }).ToList();

            grd_assistant.DataSource = filteredList;
        }

 
        private void FilterRays(string searchText)
        {
            var filteredList = _db.rays
                .Where(r => r.name.ToLower().Contains(searchText))
                .Select(r => new
                {
                    Id = r.id,
                    Name = r.name,
                    Cost = r.cost,
                    Department = r.department.name
                })
                .ToList();

            grd_assistant.DataSource = filteredList;
        }

        private void btn_addDoctor_Click(object sender, EventArgs e)
        {
            AddPatientForm patiant = new AddPatientForm(_email, _brach_id);
            patiant.patiantAdd += DataGridViewForPatiant;
            patiant.Show();

        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(() => Application.Run(new LogIn()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
