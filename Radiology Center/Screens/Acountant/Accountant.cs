using Radiology_Center;
using Radiology_Center.Models;
using Radiology_Center.Screens.Forms;
using Radiology_Center.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Radiology_Center.Screens.Acountant
{
    public partial class Accountant : Form
    {
        RadiologyEntities _db = new RadiologyEntities();
        int x;

        private string _fullName;
        private string _email;
        private string _imagePath;
        private string _nationalId;
        private string _gender;
        private string _phone;
        private string _salary;
        private string _department;
        private string _role;
        private Image _profileImage;
        private void DataGridViewpayment()
        {
            var pay = from PD in _db.patient_data
                      join PI in _db.patient_info on PD.patient_id equals PI.id
                      select new PaymentVM
                      {
                          Id = PD.id,
                          Name = PI.fName + " " + PI.lName,
                          Status = PD.pay_status,
                          Phone_Number = PI.Phone_number
                      };
            var PaymentList = pay.ToList();
            Grid_payment.DataSource = PaymentList;
            Grid_payment.AutoGenerateColumns = true;

        }
        private void DataGridViewReport()

        {
            var rep = from Ac in _db.reports
                      select new ReportVM
                      {
                          Title = Ac.title,
                          Date = Ac.date,
                          Note = Ac.note
                      };
            var ReportsList = rep.ToList();
            Grid_reports.DataSource = ReportsList;
            Grid_reports.AutoGenerateColumns = true;

        }
        private void DataGridViewAnalaysis(int x)

        {
            //DateTime threeDaysAgo = DateTime.Now.AddDays(-3);

            //var res =  _db.rays
            //    // .Where(patient_data => patient_data.daydate >= threeDaysAgo)
            //   .GroupBy(ray => ray.Rayname)           
            // .Select(group => new AnalysisVM
            // {
            //  RayName = group.Key,
            // Count = group.Count(),

            //  });

            //  var RayList = res.ToList();
            //guna2DataGridView2.DataSource = RayList;
            //guna2DataGridView2.AutoGenerateColumns = true;

            DateTime DaysAmount = DateTime.Now.AddDays(x);
            var res = from R in _db.rays
                      join PD in _db.patient_data on R.id equals PD.ray_id
                      where PD.daydate >= DaysAmount
                      group new { R, PD } by R.name into grouped
                      select new AnalysisVM
                      {
                          RayName = grouped.Key,
                          Count = grouped.Count(),

                      };
            var RayList = res.ToList();
            Grid_rays.DataSource = RayList;
            Grid_rays.AutoGenerateColumns = true;
        }



        public Accountant(string fullName, string email, string imagePath)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            _fullName = fullName;
            _email = email;
            _imagePath = imagePath;

            lbl_name.Text = fullName;
            lbl_email.Text = email;
            if (!string.IsNullOrEmpty(imagePath))
            {
                //  pic_user.ImageLocation = imagePath;
            }
            string[] arr = { " The Last 3 Days ", " The Last 7 Days ", " The Last 14 Days", " The Last 24 " };
            Comb_days.Items.AddRange(arr);
            Grid_payment.CellClick += GridViewpayment_CellContentClick;

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Comb_days_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comb_days.SelectedIndex == 0)
            {
                x = -1;
                DataGridViewAnalaysis(x);
            }
            else if (Comb_days.SelectedIndex == 1)
                DataGridViewAnalaysis(-7);
            else if (Comb_days.SelectedIndex == 2)
                DataGridViewAnalaysis(-14);
            else
                DataGridViewAnalaysis(-24);


        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btn_report_Click(object sender, EventArgs e)
        {

        }

        private void btn_reports_Click(object sender, EventArgs e)
        {

            Grid_reports.Visible = true;
            Grid_rays.Visible = true;
            Comb_days.Visible = true;
            Grid_payment.Visible = false;
            btn_add.Visible = true;
            DataGridViewReport();
            DataGridViewAnalaysis(0);
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            DataGridViewpayment();
            Grid_reports.Visible = false;
            Grid_rays.Visible = false;
            Comb_days.Visible = false;
            Grid_payment.Visible = true;
            btn_add.Visible = false;

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            var userForProfile = _db.user_.FirstOrDefault(x => x.email == _email);

            if (userForProfile != null)
            {

                var accountantForProfile = _db.accountants.FirstOrDefault(a => a.user_id == userForProfile.id);
                var roleForProfile = _db.roles.FirstOrDefault(r => r.id == userForProfile.role_id);

                Grid_reports.Visible = false;
                Grid_rays.Visible = false;
                Comb_days.Visible = false;
                Grid_payment.Visible = false;
                btn_add.Visible = false;
                AcountantProfile accountantProfile = new AcountantProfile();
                accountantProfile.SetAccountantProfileData(

                      accountantForProfile.fName + " " + accountantForProfile.lName,
                      accountantForProfile.nationalID,
                      accountantForProfile.gender,
                      accountantForProfile.phone_number,
                      userForProfile.email,
                      (decimal)accountantForProfile.salary,
                       roleForProfile.role_name,
                      accountantForProfile.image,
                       (DateTime)accountantForProfile.birthdate

                    );
                accountantProfile.Show();
            }
        }

        private void GridViewpayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Payment pay = new Payment();




            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                int patientId = int.Parse(Grid_payment.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                //  int unquId = _db.patient_info.Select
                var patientdata = _db.patient_data.FirstOrDefault(x => x.id == patientId);
                int unqId = (int)patientdata.patient_id;
                int docId = (int)patientdata.doctor_id;
                int rayId = (int)patientdata.ray_id;
                var patientinfo = _db.patient_info.FirstOrDefault(x => x.id == unqId);
                var doctor = _db.doctors.FirstOrDefault(x => x.id == docId);
                var ray = _db.rays.FirstOrDefault(x => x.id.Equals(rayId));


                pay.setpaydata(patientId, patientinfo.fName, patientinfo.lName, doctor.fName, doctor.lName, ray.name, (decimal)ray.cost, patientdata.pay_status);

                pay.Show();
            }
        }
    }
}
