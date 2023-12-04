using Radiology_Center.Models;
using Radiology_Center.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiology_Center.Screens.Forms
{
    public partial class Docter : Form
    {
        RadiologyEntities _db = new RadiologyEntities();
        string oldPath = "";

        public Docter()
        {
            InitializeComponent();
            comb_role.Items.AddRange(_db.roles.Select(x => x.role_name).ToArray());
            comb_role.SelectedIndex = 2;

            comb_Dep.Items.AddRange(_db.departments.Select(x => x.name).ToArray());

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txt_Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addDoc_Click(object sender, EventArgs e)
        {
            try
            {
                var doctor = new doctor
                {
                    lName = txt_Lname.Text,
                    fName = txt_Fname.Text,
                    salary = decimal.Parse(txt_salary.Text),
                    birthdate = dataTime_birthDate.Value,
                    phone_number = txt_phone.Text,
                    gender = (Male_CheckBox.Checked ? "Male" : (Female_CheckBox.Checked) ? "Female" : null),
                    dep_id = comb_Dep.SelectedIndex + 1,
                    nationalID = txt_NationalId.Text,

                };

                string newPath = $@"{Environment.CurrentDirectory}\DoctorImage\{Guid.NewGuid()}.jpg";
                File.Copy(oldPath, newPath);
                doctor.image = newPath;
                user_ user = new user_
                {
                    email = txt_email.Text,
                    pass = txt_password.Text,
                    role_id = comb_role.SelectedIndex + 1
                };
                doctor.user_id = user.id;
                _db.doctors.Add(doctor);
                _db.user_.Add(user);
                _db.SaveChanges();
                MessageBox.Show($"{doctor.fName} {doctor.lName} add Successfully");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void comb_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Phone_lbl_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                oldPath = openFileDialog.FileName;
                guna2CirclePictureBox1.ImageLocation = openFileDialog.FileName;

            }
        } 

        //     private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        //     {
        //OpenFileDialog openFileDialog = new OpenFileDialog();
        //if (openFileDialog.ShowDialog() == DialogResult.OK)
        //{
        //	oldPath = openFileDialog.FileName;
        //             guna2CirclePictureBox1.ImageLocation = openFileDialog.FileName;

        //         }
        //     }
    }
}
