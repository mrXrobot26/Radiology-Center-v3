using Radiology_Center.Screens.Forms;
using Radiology_Center.Screens.Forms.Acountant;
using Radiology_Center.Screens.Forms.Admin;
using Radiology_Center.Screens.Forms.Assistant;
using Radiology_Center.Screens.Forms.Department.Doctor_Profile;
using Radiology_Center.Screens.Forms.Department;
using Radiology_Center.Screens.Forms.Ray;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Radiology_Center.Models;

namespace Radiology_Center.Screens.Admin
{

    public partial class AdminHomePage : Form
    {
        RadiologyEntities _db = new RadiologyEntities();

        private string _fullName;
        private string _email;
        private string _imagePath;
        private int _brach_id;
        private int _role_id;
        public AdminHomePage(string fullName, string email, string imagePath, int role_id, int branch_id)
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            _role_id = role_id;
            _fullName = fullName;
            _email = email;
            _imagePath = imagePath;
            _brach_id = branch_id;

            SetBranchLabel(branch_id);

            lbl_name.Text = fullName;
            lbl_email.Text = email;
            if (!string.IsNullOrEmpty(imagePath))
            {
                pic_user.ImageLocation = imagePath;
            }

            lbl_generl.Text = "Doctor";
            DataGridViewForDoctor();
            grd_sAdmin.CellClick += grd_doctors_sAdmin_CellClick;
        }
        private void SetBranchLabel(int branchId)
        {
            var branchName = _db.branches.FirstOrDefault(b => b.id == branchId)?.name;
            if (branchName != null)
            {
                lbl_branch.Text = "Radiology-Center " + branchName;
            }
            else
            {
                lbl_branch.Text = "Unknown Branch";
            }
        }
        private void Comb_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbl_generl.Text == "Doctor")
            {
                DataGridViewForDoctor();
            }
            else if (lbl_generl.Text == "Assistant")
            {
                DataGridViewForAssistant();
            }
            else if (lbl_generl.Text == "Accountant")
            {
                DataGridViewForAcountant();
            }
            else if (lbl_generl.Text == "Admin")
            {
                DataGridViewForAdmin();
            }

        }


        private void DataGridViewForDoctor()
        {


            var res = from Doc in _db.doctors
                      join Dep in _db.departments on Doc.dep_id equals Dep.id
                      join usr in _db.user_ on Doc.user_id equals usr.id
                      join branch in _db.branches on usr.branch_id equals branch.id
                      where branch.id == _brach_id
                      orderby usr.branch_id
                      select new
                      {
                          Id = Doc.id,
                          DoctorFullName = Doc.fName + " " + Doc.lName,
                          Salary = (decimal)Doc.salary,
                          BirthDate = Doc.birthdate,
                          PhoneNumber = Doc.phone_number,
                          Gender = Doc.gender,
                          depNeme = Dep.name,
                          Branch = branch.name
                      };

            var DoctorDataList = res.ToList();
            grd_sAdmin.DataSource = DoctorDataList;
            grd_sAdmin.AutoGenerateColumns = true;
        }




        private void DataGridViewForDepartment()
        {

            var res = _db.departments.Select(x => new { x.id, x.name });
            var depDataList = res.ToList();
            grd_sAdmin.DataSource = depDataList;
            grd_sAdmin.AutoGenerateColumns = true;
        }

        private void DataGridViewForPatiant()
        {

            var res = from pd in _db.patient_data
                      join pi in _db.patient_info on pd.patient_id equals pi.id
                      join d in _db.doctors on pd.doctor_id equals d.id
                      join dep in _db.departments on d.dep_id equals dep.id
                      join r in _db.rays on pd.ray_id equals r.id
                      join a in _db.assisatants on pd.assistant_id equals a.id
                      join branch in _db.branches on pd.branch_id equals branch.id
                      where branch.id == _brach_id
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
                          Assistant = a.fName + " " + a.lName,
                          Branch = branch.name,

                      };

            var patiantDataList = res.ToList();
            grd_sAdmin.DataSource = patiantDataList;
            grd_sAdmin.AutoGenerateColumns = true;
        }


        private void DataGridViewForAssistant()
        {

            var res = from assis in _db.assisatants
                      join usr in _db.user_ on assis.user_id equals usr.id
                      join branch in _db.branches on usr.branch_id equals branch.id
                      where branch.id == _brach_id
                      select new
                      {
                          Id = assis.id,
                          Name = assis.fName + " " + assis.lName,
                          Salary = (decimal)assis.salary,
                          Birthdate = assis.birthdate,
                          PhoneNumber = assis.phone_number,
                          Gender = assis.gender,
                          NationalID = assis.nationalID,
                          Branch = branch.name
                      };
            var assistantDataList = res.ToList();
            grd_sAdmin.DataSource = assistantDataList;
            grd_sAdmin.AutoGenerateColumns = true;
        }



        private void DataGridViewForAcountant()
        {

            var res = from acc in _db.accountants
                      join usr in _db.user_ on acc.user_id equals usr.id
                      join branch in _db.branches on usr.branch_id equals branch.id
                      where branch.id == _brach_id
                      select new
                      {
                          Id = acc.id,
                          Name = acc.fName + " " + acc.lName,
                          Salary = (decimal)acc.salary,
                          Birthdate = acc.birthdate,
                          PhoneNumber = acc.phone_number,
                          Gender = acc.gender,
                          NationalID = acc.nationalID,
                          Branch = branch.name
                      };
            var AccountantDataList = res.ToList();
            grd_sAdmin.DataSource = AccountantDataList;
            grd_sAdmin.AutoGenerateColumns = true;
        }

        private void DataGridViewForAdmin()
        {

            var res = from admin in _db.admins
                      join usr in _db.user_ on admin.user_id equals usr.id
                      join branch in _db.branches on usr.branch_id equals branch.id
                      where branch.id == _brach_id
                      select new
                      {
                          Id = admin.id,
                          Name = admin.fName + " " + admin.lName,
                          Salary = (decimal)admin.Salary,
                          Birthdate = admin.birthdate,
                          PhoneNumber = admin.phone_number,
                          Gender = admin.gender,
                          NationalID = admin.nationalID,
                          Branch = branch.name
                      };
            var AdminDataList = res.ToList();
            grd_sAdmin.DataSource = AdminDataList;
            grd_sAdmin.AutoGenerateColumns = true;
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
            grd_sAdmin.DataSource = raysDataList;
            grd_sAdmin.AutoGenerateColumns = true;
        }




        private void btn_profile_Click_1(object sender, EventArgs e)
        {
            ResetButtonColors();
            var userForProfile = _db.user_.FirstOrDefault(u => u.email == _email);
            if (userForProfile.role_id == 1)
            {
                if (userForProfile != null)
                {
                    var SuperadminForProfile = _db.super_admin.FirstOrDefault(a => a.user_id == userForProfile.id);
                    var roleForProfile = _db.roles.FirstOrDefault(r => r.id == userForProfile.role_id);
                    Profile_W profile = new Profile_W();
                    profile.SetProfileData(
                        userForProfile.id,
                        SuperadminForProfile.fName + " " + SuperadminForProfile.lName,
                        SuperadminForProfile.nationalID,
                        SuperadminForProfile.gender,
                        SuperadminForProfile.phone_number,
                        userForProfile.email,
                        (decimal)SuperadminForProfile.salary,
                        roleForProfile.role_name,
                        SuperadminForProfile.image,
                        (DateTime)SuperadminForProfile.birthdate,
                        "myProfile"
                    );

                    profile.Show();

                }

            }
            else if (userForProfile.role_id == 2)
            {
                if (userForProfile != null)
                {
                    var adminForProfile = _db.admins.FirstOrDefault(a => a.user_id == userForProfile.id);
                    var roleForProfile = _db.roles.FirstOrDefault(r => r.id == userForProfile.role_id);
                    Profile_W profile = new Profile_W();
                    profile.SetProfileData(
                        userForProfile.id,
                        adminForProfile.fName + " " + adminForProfile.lName,
                        adminForProfile.nationalID,
                        adminForProfile.gender,
                        adminForProfile.phone_number,
                        userForProfile.email,
                        (decimal)adminForProfile.Salary,
                        roleForProfile.role_name,
                        adminForProfile.image,
                        (DateTime)adminForProfile.birthdate,
                        "myProfile"
                    );

                    profile.Show();

                }

            }

        }


        private void btn_addDoctor_Click_1(object sender, EventArgs e)
        {
            if (lbl_generl.Text == "Doctor")
            {
                Docter docter = new Docter(_role_id, _brach_id);
                docter.DoctorAdd += OnDoctorAdded;

                docter.ShowDialog();
            }
            else if (lbl_generl.Text == "Department")
            {
                DepartmentForm dep = new DepartmentForm();

                dep.DepartmentAdded += OnDepartmentAdded;

                dep.Show();
            }
            else if (lbl_generl.Text == "Assistant")
            {
                Assistant assis = new Assistant(_role_id, _brach_id);

                assis.AssistantAdd += OnAssistantAdded;
                assis.Show();
            }
            else if (lbl_generl.Text == "Accountant")
            {
                AcountantForm acc = new AcountantForm(_role_id, _brach_id);

                acc.AccountantAdd += OnAcountantAdded;

                acc.Show();
            }
            else if (lbl_generl.Text == "Admin")
            {
                AdminForm admin = new AdminForm(_role_id, _brach_id);

                admin.AdminAdd += OnAdminAdded;

                admin.Show();
            }
            else if (lbl_generl.Text == "Ray")
            {
                RayForm ray = new RayForm();

                ray.RayEventHandler += OnRayAdded;

                ray.Show();
            }

        }
        private void OnRayAdded()
        {
            DataGridViewForRay();
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

        private void btn_patient_Click_1(object sender, EventArgs e)
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
        private void btn_assistant_Click_1(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_assistant.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Assistant";
            CheckLabelAndSetButtonVisibility();

            DataGridViewForAssistant();
        }

        private void btn_accountant_Click_1(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_accountant.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Accountant";
            CheckLabelAndSetButtonVisibility();

            DataGridViewForAcountant();


        }

        private void btn_ray_Click_1(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_ray.BackColor = ColorTranslator.FromHtml("#182E42");
            lbl_generl.Text = "Ray";
            CheckLabelAndSetButtonVisibility();

            DataGridViewForRay();

        }



        private void ResetButtonColors()
        {
            btn_profile.BackColor = Color.FromArgb(20, 39, 55);
            btn_departments.BackColor = Color.FromArgb(20, 39, 55);
            btn_doc_names.BackColor = Color.FromArgb(20, 39, 55);
            btn_patient.BackColor = Color.FromArgb(20, 39, 55);
            btn_assistant.BackColor = Color.FromArgb(20, 39, 55);
            btn_accountant.BackColor = Color.FromArgb(20, 39, 55);
            btn_ray.BackColor = Color.FromArgb(20, 39, 55);

        }



        private void grd_doctors_sAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (lbl_generl.Text == "Doctor")
                {
                    int doctorId = int.Parse(grd_sAdmin.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    var doctorForProfile = _db.doctors.FirstOrDefault(x => x.id == doctorId);
                    if (doctorForProfile != null)
                    {
                        var userForDoctorProfile = _db.user_.FirstOrDefault(x => x.id == doctorForProfile.user_id);
                        var depForDoctorProfile = _db.departments.FirstOrDefault(x => x.id == doctorForProfile.dep_id);

                        DoctorProfile doctorProfile = new DoctorProfile();
                        doctorProfile.SetDoctorProfileData(

                                doctorId,
                                doctorForProfile.fName + " " + doctorForProfile.lName,
                                doctorForProfile.nationalID,
                                doctorForProfile.gender,
                                doctorForProfile.phone_number,
                                userForDoctorProfile.email,
                                (decimal)doctorForProfile.salary,
                                doctorForProfile.image,
                                (DateTime)doctorForProfile.birthdate,
                                depForDoctorProfile.name,
                                "!myProfile"
                            );
                        doctorProfile.Show();
                    }
                }
                else if (lbl_generl.Text == "Department")
                {
                    int depId = int.Parse(grd_sAdmin.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    var depForProfile = _db.departments.FirstOrDefault(x => x.id == depId);
                    if (depForProfile != null)
                    {
                        DepartmentProfile departmentProfile = new DepartmentProfile();

                        departmentProfile.setDataForDepartment(depForProfile.id, depForProfile.name);

                        departmentProfile.Show();

                    }
                }
                else if (lbl_generl.Text == "Assistant")
                {
                    int assistantId = int.Parse(grd_sAdmin.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    var assistantForProfile = _db.assisatants.FirstOrDefault(x => x.id == assistantId);
                    if (assistantForProfile != null)
                    {
                        var userForDoctorProfile = _db.user_.FirstOrDefault(x => x.id == assistantForProfile.user_id);
                        var roleForDoctorProfile = _db.roles.FirstOrDefault(x => x.id == userForDoctorProfile.role_id);

                        Profile_W assisProfile = new Profile_W();
                        assisProfile.SetProfileData(
                                assistantId,
                                assistantForProfile.fName + " " + assistantForProfile.lName,
                                assistantForProfile.nationalID,
                                assistantForProfile.gender,
                                assistantForProfile.phone_number,
                                userForDoctorProfile.email,
                                (decimal)assistantForProfile.salary,
                                roleForDoctorProfile.role_name,
                                assistantForProfile.image,
                                (DateTime)assistantForProfile.birthdate,
                                "!myProfile"
                            );
                        assisProfile.Show();
                    }
                }
                else if (lbl_generl.Text == "Accountant")
                {
                    int acctId = int.Parse(grd_sAdmin.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    var accountantForProfile = _db.accountants.FirstOrDefault(x => x.id == acctId);
                    if (accountantForProfile != null)
                    {
                        var userForAcountanrProfile = _db.user_.FirstOrDefault(x => x.id == accountantForProfile.user_id);
                        var roleForAccountantProfile = _db.roles.FirstOrDefault(x => x.id == userForAcountanrProfile.role_id);

                        Profile_W accountantProfile = new Profile_W();
                        accountantProfile.SetProfileData(
                                acctId,
                                accountantForProfile.fName + " " + accountantForProfile.lName,
                                accountantForProfile.nationalID,
                                accountantForProfile.gender,
                                accountantForProfile.phone_number,
                                userForAcountanrProfile.email,
                                (decimal)accountantForProfile.salary,
                                roleForAccountantProfile.role_name,
                                accountantForProfile.image,
                                (DateTime)accountantForProfile.birthdate,
                                "!myProfile"
                            );
                        accountantProfile.Show();
                    }
                }
                else if (lbl_generl.Text == "Admin")
                {
                    int adminId = int.Parse(grd_sAdmin.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    var adminForProfile = _db.admins.FirstOrDefault(x => x.id == adminId);
                    if (adminForProfile != null)
                    {
                        var userForAdminProfile = _db.user_.FirstOrDefault(x => x.id == adminForProfile.user_id);
                        var roleForAdminProfile = _db.roles.FirstOrDefault(x => x.id == userForAdminProfile.role_id);

                        Profile_W adminProfile = new Profile_W();
                        adminProfile.SetProfileData(
                                adminId,
                                adminForProfile.fName + " " + adminForProfile.lName,
                                adminForProfile.nationalID,
                                adminForProfile.gender,
                                adminForProfile.phone_number,
                                userForAdminProfile.email,
                                (decimal)adminForProfile.Salary,
                                roleForAdminProfile.role_name,
                                adminForProfile.image,
                                (DateTime)adminForProfile.birthdate,
                                "!myProfile"
                            );
                        adminProfile.Show();
                    }
                }




            }
        }

        private void brn_refresh_Click_1(object sender, EventArgs e)
        {
            if (lbl_generl.Text == "Doctor")
            {
                OnDoctorAdded();
            }
            else if (lbl_generl.Text == "Department")
            {
                OnDepartmentAdded();

            }
            else if (lbl_generl.Text == "Assistant")
            {
                OnAssistantAdded();
            }
            else if (lbl_generl.Text == "Accountant")
            {
                OnAcountantAdded();
            }
            else if (lbl_generl.Text == "Admin")
            {
                OnAdminAdded();
            }
            else if (lbl_generl.Text == "Ray")
            {
                OnRayAdded();
            }
        }

        private void btn_search_Click_1(object sender, EventArgs e)
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
                case "Assistant":
                    FilterAssistants(txt_search.Text);
                    break;
                case "Ray":
                    FilterRays(txt_search.Text);
                    break;
                case "Accountant":
                    FilterAccountants(txt_search.Text);
                    break;
                default:
                    break;
            }

        }


        //============================================filter============================


        private void FilterDoctors(string searchText)
        {


            var filteredList = (from Doc in _db.doctors
                                join Dep in _db.departments on Doc.dep_id equals Dep.id
                                join usr in _db.user_ on Doc.user_id equals usr.id
                                join branch in _db.branches on usr.branch_id equals branch.id
                                where (Doc.fName + " " + Doc.lName).ToLower().Contains(searchText)
                                where branch.id == _brach_id

                                orderby usr.branch_id
                                select new
                                {
                                    Id = Doc.id,
                                    DoctorFullName = Doc.fName + " " + Doc.lName,
                                    Salary = (decimal)Doc.salary,
                                    BirthDate = Doc.birthdate,
                                    PhoneNumber = Doc.phone_number,
                                    Gender = Doc.gender,
                                    depNeme = Dep.name,
                                    Branch = branch.name
                                }).ToList();

            grd_sAdmin.DataSource = filteredList;
        }
        private void FilterDepartments(string searchText)
        {
            var filteredList = _db.departments
                .Where(dep => dep.name.ToLower().Contains(searchText))
                .Select(dep => new { dep.id, dep.name })
                .ToList();

            grd_sAdmin.DataSource = filteredList;
        }
        private void FilterPatients(string searchText)
        {

            var filteredList = (from pd in _db.patient_data
                                join pi in _db.patient_info on pd.patient_id equals pi.id
                                join d in _db.doctors on pd.doctor_id equals d.id
                                join dep in _db.departments on d.dep_id equals dep.id
                                join r in _db.rays on pd.ray_id equals r.id
                                join a in _db.assisatants on pd.assistant_id equals a.id
                                join branch in _db.branches on pd.branch_id equals branch.id
                                where (pi.fName + " " + pi.lName).ToLower().Contains(searchText)
                                where branch.id == _brach_id

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
                                    Assistant = a.fName + " " + a.lName,
                                    Branch = branch.name,

                                }).ToList();

            grd_sAdmin.DataSource = filteredList;
        }
        private void FilterAssistants(string searchText)
        {
            var filteredList = (from a in _db.assisatants
                                join usr in _db.user_ on a.user_id equals usr.id
                                join b in _db.branches on usr.branch_id equals b.id
                                where (a.fName + " " + a.lName).ToLower().Contains(searchText.ToLower())
                                where usr.branch_id == _brach_id
                                select new
                                {
                                    Id = a.id,
                                    Name = a.fName + " " + a.lName,
                                    Salary = (decimal)a.salary,
                                    Birthdate = a.birthdate,
                                    PhoneNumber = a.phone_number,
                                    Gender = a.gender,
                                    NationalID = a.nationalID,
                                    BranchName = b.name 
                                }).ToList();

            grd_sAdmin.DataSource = filteredList;
            grd_sAdmin.AutoGenerateColumns = true;
        }
        private void FilterAccountants(string searchText)
        {
            var filteredList = (from a in _db.accountants
                                join usr in _db.user_ on a.user_id equals usr.id
                                join b in _db.branches on usr.branch_id equals b.id
                                where (a.fName + " " + a.lName).ToLower().Contains(searchText.ToLower()) 
                                && usr.branch_id == _brach_id 
                                select new
                                {
                                    Id = a.id,
                                    Name = a.fName + " " + a.lName,
                                    Salary = (decimal)a.salary,
                                    Birthdate = a.birthdate,
                                    PhoneNumber = a.phone_number,
                                    Gender = a.gender,
                                    NationalID = a.nationalID,
                                    BranchName = b.name 
                                }).ToList();

            grd_sAdmin.DataSource = filteredList;
            grd_sAdmin.AutoGenerateColumns = true;
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

            grd_sAdmin.DataSource = filteredList;
        }

        private void btn_logOut_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(() => Application.Run(new LogIn()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

    
    }
}
