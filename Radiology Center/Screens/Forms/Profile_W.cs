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
    public partial class Profile_W : Form
    {

        public delegate void DeleteDelegateEventHandler();
        public event DeleteDelegateEventHandler DeleteEventHandler;


        RadiologyEntities _db = new RadiologyEntities();
        public Profile_W()

        {

            InitializeComponent();



        }
        private string _profile;
        public void SetProfileData(int id,
        string name, string nationalId, string gender,
        string phone, string email, decimal salary
        ,string role, string profileImage,DateTime birthDate,string profile)
        {
            lbl_id.Text = id.ToString();
            lbl_profileName.Text = name;
            lbl_profileNationalId.Text = nationalId;
            lbl_profileGender.Text = gender;
            lbl_profilePhone.Text = phone;
            lbl_profileEmail.Text = email;
            lbl_profileSalary.Text = salary.ToString("C");
            lbl_profileRole.Text = role;
            pic_profileUser.ImageLocation = profileImage;
            lbl_birthDate.Text = birthDate.ToShortDateString();
            _profile = profile;
            DeleteBtnVisabilty();
        }

        private void DeleteBtnVisabilty()
        {
            if (_profile == "myProfile")
            {
                guna2Button1.Visible = false;
            }
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void foxLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Profile_W_Load(object sender, EventArgs e)
        {

        }

        private void btrn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
      
            if (int.TryParse(lbl_id.Text, out int IdOfUser))
            {
                if (lbl_profileRole.Text == "Assistant")
                {
                    var assisatant = _db.assisatants.FirstOrDefault(x => x.id == IdOfUser);
                    if (assisatant != null)
                    {
                        _db.assisatants.Remove(assisatant);
                        _db.SaveChanges();
                        MessageBox.Show($"{assisatant.fName} deleted successfully");
                        DeleteEventHandler?.Invoke();
                        this.Close();
                    }
                }
                else if (lbl_profileRole.Text == "Accountant")
                {
                    var accountant = _db.accountants.FirstOrDefault(x => x.id == IdOfUser);
                    if (accountant != null)
                    {
                        _db.accountants.Remove(accountant);
                        _db.SaveChanges();
                        MessageBox.Show($"{accountant.fName} deleted successfully");
                        DeleteEventHandler?.Invoke();

                        this.Close();
                    }
                }
                else if (lbl_profileRole.Text == "Admin")
                {
                    var admin = _db.admins.FirstOrDefault(x => x.id == IdOfUser);
                    if (admin != null)
                    {
                        _db.admins.Remove(admin);
                        _db.SaveChanges();
                        MessageBox.Show($"{admin.fName} deleted successfully");
                        DeleteEventHandler?.Invoke();
                        this.Close();
                    }
                }
                else if (lbl_profileRole.Text == "Doctor")
                {
                    var doctor = _db.doctors.FirstOrDefault(x => x.id == IdOfUser);
                    if (doctor != null)
                    {
                        _db.doctors.Remove(doctor);
                        _db.SaveChanges();
                        MessageBox.Show($"{doctor.fName} deleted successfully");
                        DeleteEventHandler?.Invoke();
                        this.Close();
                    }
                }
            }
        }
    }
}
