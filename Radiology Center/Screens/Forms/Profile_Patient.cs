using Radiology_Center.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiology_Center.Screens.Forms
{
    public partial class Profile_Patient : Form
    {
        RadiologyEntities _db = new RadiologyEntities();
        int _id;

        public Profile_Patient()

        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
          

        }



        public void SetPatientProfileData(
          int id,
      string name, string gender,
      string phone, DateTime birthDate, string DocName, string RayName, DateTime daydate, DateTime deliverdate, string History)
        {
            Patient_Id.Text = id.ToString();
            _id = id;
            Patient_Name.Text = name;
            Patient_Gender.Text = gender;
            Patient_Phone.Text = phone;
            Patient_Birth.Text = birthDate.ToShortDateString();
            Patient_Doc.Text = DocName;
            Patient_ray.Text = RayName;
            Patient_reservation_day.Text = daydate.ToShortDateString();
            Patient_Deliver_Day.Text = deliverdate.ToShortDateString();
            Patient_History.Text = History;

        }
        /* public Profile_Patient()
         {
             InitializeComponent();
         }*/



        private void btrn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addReport_Click(object sender, EventArgs e)
        {
            var patiant = _db.patient_data.FirstOrDefault(x=>x.id  == _id);
            if (patiant != null)
            {
                patiant.doctor_report = "Added";
                _db.SaveChanges();
                MessageBox.Show("Report status updated successfully.");
            }

        }
    }
}
