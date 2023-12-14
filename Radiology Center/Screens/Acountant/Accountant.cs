using LiveCharts.Wpf;
using LiveCharts;
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

using LiveCharts.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.WinForms;


namespace Radiology_Center.Screens.Acountant
{
    public partial class Accountant : Form
    {
        RadiologyEntities _db = new RadiologyEntities();
        int x = -300;

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
            Grid_Acc.DataSource = PaymentList;
            Grid_Acc.AutoGenerateColumns = true;

        }
     /*   private void DataGridViewReport()

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

        }*/
        private void DataGridViewAnalaysis()
        {    DateTime DaysAmount = DateTime.Now.AddDays(x);
            var res = from R in _db.rays
                      join PD in _db.patient_data on R.id equals PD.ray_id
                      where PD.daydate >= DaysAmount
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


            //List<AnalysisVM> RayList = res.ToList();

            //// Set up the DataGridView
            //Grid_rays.DataSource = RayList;
            //Grid_rays.AutoGenerateColumns = true;



            chart1.Series.Clear(); // Clear previous data in the chart

            foreach (var item in AnalaysisList)
            {
                var series = new LiveCharts.Wpf.ColumnSeries
                {
                    Title = (string)item.RayName,
                    Values = new ChartValues<ObservableValue> { new ObservableValue((double)item.Count) },
                };

                // Add the series to the chart
                chart1.Series.Add(series);
            }
            chart1.AxisX.Clear();
            chart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Ray Name",
                Labels = res.ToList().Select(item => item.RayName).OfType<string>().ToList()
                // Title = "Time",
                //Labels = AnalaysisList.Select(item => item.FirstDate.HasValue ? item.FirstDate.Value.ToString("yyyy-MM-dd") : "").ToArray()
            });
            chart1.AxisY.Clear();
            chart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Count",
            });

            chart1.Update(true, true);

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
                pic_user.ImageLocation = imagePath;
            }
            string[] arr = { " The Last 3 Days ", " The Last 7 Days ", " The Last 14 Days", " The Last 24 " };
            Comb_days.Items.AddRange(arr);
            Grid_Acc.CellClick += GridViewpayment_CellContentClick;
            DataGridViewpayment();


        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btn_report_Click(object sender, EventArgs e)
        {

        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            lbl_generl.Text = "Report";
            chart1.Visible = true;
           // Grid_reports.Visible = true;
         //   Grid_rays.Visible = true;
            Comb_days.Visible = true;
            Grid_Acc.Visible = true;
         //   btn_add.Visible = true;
           // DataGridViewReport();
            DataGridViewAnalaysis();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {

            lbl_generl.Text = "Payment";
            DataGridViewpayment();
            chart1.Visible = false;
           // Grid_reports.Visible = false;
          //  Grid_rays.Visible = false;
            Comb_days.Visible = false;
            Grid_Acc.Visible = true;
        //    btn_add.Visible = false;

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            //lbl_generl.Text = "Accountant";

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
            if (lbl_generl.Text =="Payment")
            {
                Payment pay = new Payment();




                if (e.RowIndex >= 0)
                {
                    int patientId = int.Parse(Grid_Acc.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    //  int unquId = _db.patient_info.Select
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

        private void Accountant_Load(object sender, EventArgs e)
        {

            // DataGridViewAnalaysis();
            //analysisVMBindingSource.DataSource = new List<AnalysisVM>();
            //cartesianChart1.AxisX.Add(new Axis
            //{
            //    Title = "Ray Name",
            //    Labels = new[] { item.RayName }
            //});


        }

        private void Grid_rays_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void chart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void Comb_days_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Comb_days.SelectedIndex == 0)
            {
                x = -1;
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
