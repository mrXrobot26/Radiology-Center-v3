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
        public Profile_Patient()

        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }



        public void SetPatientProfileData(
          int id,
      string name, string gender,
      string phone, DateTime birthDate, string DocName, string RayName, DateTime daydate, DateTime deliverdate, string History)
        {
            Patient_Id.Text = id.ToString();
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

        private void Profile_Patient_Load(object sender, EventArgs e)
        {

        }

        private void foxBigLabel6_Click(object sender, EventArgs e)
        {

        }

        private void foxLabel10_Click(object sender, EventArgs e)
        {

        }

        private void foxBigLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
