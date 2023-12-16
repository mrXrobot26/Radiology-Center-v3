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
        public delegate void DoctorAddEventHandler();

        public event DoctorAddEventHandler DoctorAdd;
        
        RadiologyEntities _db = new RadiologyEntities();
        string oldPath = "";
        private int _branch_id;
        public Docter(int role_id,int branch_id)
        {
            InitializeComponent();
            comb_role.Items.AddRange(_db.roles.Select(x => x.role_name).ToArray());
            comb_role.SelectedIndex = 2;
            comb_Dep.Items.AddRange(_db.departments.Select(x => x.name).ToArray());
            _branch_id = branch_id;
            Comb_branch.Items.AddRange(_db.branches.OrderBy(b => b.id).Skip(1).Select(x => x.name).ToArray());
            Comb_branch.SelectedIndex = _branch_id - 2;
            if (role_id==2)
            {
                Comb_branch.Enabled = false;
            }

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
                string folderPath = Path.Combine(Environment.CurrentDirectory, "DoctorImage");

               string newPath = $@"{Environment.CurrentDirectory}\DoctorImage\{Guid.NewGuid()}.jpg";
                File.Copy(oldPath, newPath);
                doctor.image = newPath;
                user_ user = new user_
                {
                    email = txt_email.Text,
                    pass = txt_password.Text,
                    role_id = comb_role.SelectedIndex + 1,
                    branch_id = Comb_branch.SelectedIndex+2
                };
                _db.doctors.Add(doctor);
                _db.user_.Add(user);
                _db.SaveChanges();
                doctor.user_id = user.id;
                _db.SaveChanges();
                MessageBox.Show($"{doctor.fName} {doctor.lName} add Successfully");

                DoctorAdd?.Invoke();

                this.Close();

            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                var errorMessages = dbEx.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                var fullErrorMessage = string.Join("; ", errorMessages);
                var exceptionMessage = string.Concat("Validation errors: ", fullErrorMessage);

                MessageBox.Show(exceptionMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
