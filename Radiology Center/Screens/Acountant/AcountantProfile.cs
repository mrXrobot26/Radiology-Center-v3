using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiology_Center.Screens.Acountant
{
    public partial class AcountantProfile : Form
    {
        public AcountantProfile()
        {
            InitializeComponent();
        }

        private void AccountantProfile_Load(object sender, EventArgs e)
        {

        }
        public void SetAccountantProfileData(
           string name, string nationalId, string gender,
        string phone, string email, decimal salary
        , string role, string profileImage, DateTime birthDate)
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

     
        private void btrn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
