﻿using LiveCharts;
using LiveCharts.Defaults;
using Radiology_Center.Models;
using Radiology_Center.Screens.Forms;
using Radiology_Center.ViewModels;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace Radiology_Center.Screens.Acountant
{
    public partial class Accountant : Form
    {
        RadiologyEntities _db = new RadiologyEntities();
        int x = -300;

        private string _fullName;
        private string _email;
        private string _imagePath;
        private int _brach_id;
        private int _role_id;
        public Accountant(string fullName, string email, string imagePath, int branch_id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            lbl_generl.Text = "Payment";
            _fullName = fullName;
            _email = email;
            _imagePath = imagePath;
            _brach_id = branch_id;
            lbl_name.Text = fullName;
            lbl_email.Text = email;
            if (!string.IsNullOrEmpty(imagePath))
            {
                pic_user.ImageLocation = imagePath;
            }
            string[] arr = { " The Last 3 Days ", " The Last 7 Days ", " The Last 14 Days", " The Last 24 " };
            Comb_days.Items.AddRange(arr);
            Grid_Acc.CellClick += GridViewpayment_CellContentClick;
            DataGridViewpayment();

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
        private void DataGridViewpayment()
        {
            var pay = from PD in _db.patient_data
                      join PI in _db.patient_info on PD.patient_id equals PI.id
                      where PD.branch_id == _brach_id
                      select new PaymentVM
                      {
                          Id = PD.id,
                          Name = PI.fName + " " + PI.lName,
                          Status = PD.pay_status,
                          Phone_Number = PI.Phone_number

                      };
            var PaymentList = pay.ToList();
            Grid_Acc.DataSource = PaymentList;
            Grid_Acc.AutoGenerateColumns = true;

        }
       
        private void DataGridViewAnalaysis()
        {
            DateTime DaysAmount = DateTime.Now.AddDays(x);
            var res = from R in _db.rays
                      join PD in _db.patient_data on R.id equals PD.ray_id
                      where PD.daydate >= DaysAmount && PD.branch_id == _brach_id
                      group new { R, PD } by R.name into grouped
                      select new AnalysisVM
                      {
                          RayName = grouped.Key,

                          Count = grouped.Count(),
                          TotalCost = grouped.Count() * (grouped.FirstOrDefault().R.cost ?? 0),
                          FirstDate = grouped.Min(item => item.PD.daydate)
                      };

            var AnalaysisList = res.ToList();
            Grid_Acc.DataSource = AnalaysisList;
            Grid_Acc.AutoGenerateColumns = true;

            chart1.Series.Clear();

            foreach (var item in AnalaysisList)
            {
                var series = new LiveCharts.Wpf.ColumnSeries
                {
                    Title = (string)item.RayName,
                    Values = new ChartValues<ObservableValue> { new ObservableValue((double)item.Count) },
                };

            
                chart1.Series.Add(series);
            }
            chart1.AxisX.Clear();
            chart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Ray Name",
                Labels = res.ToList().Select(item => item.RayName).OfType<string>().ToList()
            
            });
            chart1.AxisY.Clear();
            chart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Count",
            });

            chart1.Update(true, true);

        }




    


        private void btn_reports_Click(object sender, EventArgs e)
        {
            lbl_generl.Text = "Report";
            chart1.Visible = true;
            Comb_days.Visible = true;
            Grid_Acc.Visible = true;
            DataGridViewAnalaysis();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {

            lbl_generl.Text = "Payment";
            DataGridViewpayment();
            chart1.Visible = false;
        
            Comb_days.Visible = false;
            Grid_Acc.Visible = true;
        

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
         

            var userForProfile = _db.user_.FirstOrDefault(x => x.email == _email);

            if (userForProfile != null)
            {

                var accountantForProfile = _db.accountants.FirstOrDefault(a => a.user_id == userForProfile.id);
                var roleForProfile = _db.roles.FirstOrDefault(r => r.id == userForProfile.role_id);


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
            if (lbl_generl.Text == "Payment")
            {
                Payment pay = new Payment();




                if (e.RowIndex >= 0)
                {
                    int patientId = int.Parse(Grid_Acc.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                   
                    var patientdata = _db.patient_data.FirstOrDefault(x => x.id == patientId);
                    int unqId = (int)patientdata.patient_id;
                    int docId = (int)patientdata.doctor_id;
                    int rayId = (int)patientdata.ray_id;
                    var patientinfo = _db.patient_info.FirstOrDefault(x => x.id == unqId);
                    var doctor = _db.doctors.FirstOrDefault(x => x.id == docId);
                    var ray = _db.rays.FirstOrDefault(x => x.id.Equals(rayId));


                    pay.setpaydata(patientId, patientinfo.fName, patientinfo.lName, doctor.fName, doctor.lName, ray.name, (decimal)ray.cost, patientdata.pay_status);
                    pay.paymentAdd += DataGridViewpayment;
                    pay.Show();
                }

            }


        }

        



        private void Comb_days_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Comb_days.SelectedIndex == 0)
            {
                x = -3;
                DataGridViewAnalaysis();
            }
            else if (Comb_days.SelectedIndex == 1)
            {
                x = -7;
                DataGridViewAnalaysis();
            }
            else if (Comb_days.SelectedIndex == 2)
            {
                x = -14;
                DataGridViewAnalaysis();
            }
            else if (Comb_days.SelectedIndex == 3)
            {
                x = -24;
                DataGridViewAnalaysis();
            }
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
