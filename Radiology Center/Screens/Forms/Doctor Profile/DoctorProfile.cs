using Radiology_Center.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiology_Center.Screens.Forms.Department.Doctor_Profile
{
    public partial class DoctorProfile : Form
    {
        RadiologyEntities _db = new RadiologyEntities();
        public DoctorProfile()
        {
            InitializeComponent();
        }
        public void SetDoctorProfileData(
            int id,
        string name, string nationalId, string gender,
        string phone, string email, decimal salary
       , string profileImage, DateTime birthDate, string department)
        {
            lbl_id.Text = id.ToString();
            lbl_profileName.Text = name;
            lbl_profileNationalId.Text = nationalId;
            lbl_profileGender.Text = gender;
            lbl_profilePhone.Text = phone;
            lbl_profileEmail.Text = email;
            lbl_profileSalary.Text = salary.ToString("C");
            pic_profileUser.ImageLocation = profileImage;
            lbl_birthDate.Text = birthDate.ToShortDateString();
            lbl_profileDepartment.Text = department;
        }

        private void DoctorProfile_Load(object sender, EventArgs e)
        {

        }

        private void btrn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lbl_id.Text, out int DocId))
            {
                var doc = _db.doctors.FirstOrDefault(x => x.id == DocId);
                if (doc != null)
                {
                    _db.doctors.Remove(doc);
                    _db.SaveChanges();
                    MessageBox.Show($"{doc.fName} deleted successfully");
                    this.Close();
                }

            }
        }
    }
}
