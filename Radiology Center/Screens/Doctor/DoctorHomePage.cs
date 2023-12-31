﻿using Radiology_Center.Models;
using Radiology_Center.Screens.Forms;
using Radiology_Center.Screens.Forms.Department.Doctor_Profile;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace Radiology_Center.Screens.Doctor
{
    public partial class DoctorHomePage : Form
    {
        RadiologyEntities _db = new RadiologyEntities();

        private int _id;
        private string _fullName;
        private string _email;
        private string _imagePath;
        private int _brach_id;
        public DoctorHomePage(string fullName, string email, string imagePath, int branch_id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            _fullName = fullName;
            _email = email;
            _imagePath = imagePath;
            _brach_id= branch_id;
            lbl_name.Text = fullName;
            lbl_email.Text = email;
            if (!string.IsNullOrEmpty(imagePath))
            {
                pic_user.ImageLocation = imagePath;
            }
            lbl_generl.Text = "Patient";
            DataGridViewForPatiant_doc();
            grd_Patient_Doc.CellClick += grd_Patient_Doc_CellClick;


            SetBranchLabel(branch_id);
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
        private void DoctorPage_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
        private void ResetButtonColors()
        {
            btn_profile.BackColor = Color.FromArgb(20, 39, 55);
            btn_patient.BackColor = Color.FromArgb(20, 39, 55);

        }


        public void DataGridViewForPatiant_doc()
        {
            var result = from pd in _db.patient_data
                         join pi in _db.patient_info on pd.patient_id equals pi.id
                         join d in _db.doctors on pd.doctor_id equals d.id
                         join dep in _db.departments on d.dep_id equals dep.id
                         join r in _db.rays on pd.ray_id equals r.id
                         where pd.branch_id == _brach_id
                         select new
                         {
                             Id = pi.id,
                             Name = pi.fName + " " + pi.lName,
                             Date = pd.daydate,
                             Report = pd.doctor_report,
                             Doctor = d.fName + " " + d.lName,
                             department = dep.name,
                             Ray = r.name,
                         };
            var patiantDataList = result.ToList();
            grd_Patient_Doc.DataSource = patiantDataList;
            grd_Patient_Doc.AutoGenerateColumns = true;
        }

        private void grd_Patient_Doc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int PatientId = int.Parse(grd_Patient_Doc.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            var PatientForProfile = _db.patient_data.FirstOrDefault(x => x.patient_id == PatientId);
            if (PatientForProfile != null)
            {

                var infoForPatientProfile = _db.patient_info.FirstOrDefault(x => x.id == PatientForProfile.patient_id);
                var DocForPatientProfile = _db.doctors.FirstOrDefault(x => x.id == PatientForProfile.doctor_id);
                var RayForPatientProfile = _db.rays.FirstOrDefault(x => x.id == PatientForProfile.ray_id);

                Profile_Patient patientProfile = new Profile_Patient();
                patientProfile.SetPatientProfileData(

                        PatientId,
                       infoForPatientProfile.fName + " " + infoForPatientProfile.lName,
                      infoForPatientProfile.gender,
                       infoForPatientProfile.Phone_number,
                        (DateTime)infoForPatientProfile.birthdate,
                        DocForPatientProfile.fName + " " + DocForPatientProfile.lName,
                        RayForPatientProfile.name,
                       (DateTime)PatientForProfile.daydate, //?? DateTime.MinValue, 
                       (DateTime)PatientForProfile.deliverdate,// ?? DateTime.MinValue,
                        PatientForProfile.history

                    );
                patientProfile.Show();

            }
        }
        

        private void btn_patient_Click_1(object sender, EventArgs e)
        {
            ResetButtonColors();
            btn_patient.BackColor = ColorTranslator.FromHtml("#182E42");
            DataGridViewForPatiant_doc();

        }





        private void btn_profile_Click(object sender, EventArgs e)
        {
            ResetButtonColors();


            var userForProfile = _db.user_.FirstOrDefault(u => u.email == _email);

            if (userForProfile != null)
            {
                var docForProfile = _db.doctors.FirstOrDefault(a => a.user_id == userForProfile.id);
                var depForDoctorProfile = _db.departments.FirstOrDefault(x => x.id == docForProfile.dep_id);


                DoctorProfile docprofile = new DoctorProfile();
                docprofile.SetDoctorProfileData(
                    docForProfile.id,
                    docForProfile.fName + " " + docForProfile.lName,
                    docForProfile.nationalID,
                    docForProfile.gender,
                    docForProfile.phone_number,
                    userForProfile.email,
                    (decimal)docForProfile.salary,
                    docForProfile.image,
                    (DateTime)docForProfile.birthdate,
                    depForDoctorProfile.name,
                    "myProfile"
                );


                docprofile.Show();

            }
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
                                    Id = pi.id,
                                    Name = pi.fName + " " + pi.lName,
                                    Date = pd.daydate,
                                    Report = pd.doctor_report,
                                    Doctor = d.fName + " " + d.lName,
                                    department = dep.name,
                                    Ray = r.name,
                                }).ToList();

            grd_Patient_Doc.DataSource = filteredList;
        }

        private void btn_logOut_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(() => Application.Run(new LogIn()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            switch (lbl_generl.Text)
            {
                case "Patient":
                    FilterPatients(txt_search.Text);
                    break;

                default:
                    break;
            }
        }

  
    }
}



