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
        public Profile_W()

        {

            InitializeComponent();



        }

        public void SetProfileData(
        string name, string nationalId, string gender,
        string phone, string email, decimal salary
        ,string role, string profileImage,DateTime birthDate)
        {
            lbl_profileName.Text = name;
            lbl_profileNationalId.Text = nationalId;
            lbl_profileGender.Text = gender;
            lbl_profilePhone.Text = phone;
            lbl_profileEmail.Text = email;
            lbl_profileSalary.Text = salary.ToString("C");
            lbl_profileRole.Text = role;
            pic_profileUser.ImageLocation = profileImage;
            lbl_birthDate.Text = birthDate.ToShortDateString();
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
    }
}
