﻿using Guna.UI2.WinForms;
using Radiology_Center.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiology_Center.Screens.Forms.Admin
{
    public partial class AdminForm : Form
    {

        public delegate void AdminAddEventHandler();

        public event AdminAddEventHandler AdminAdd;

        RadiologyEntities _db = new RadiologyEntities();

        string oldPath = "";
        public AdminForm()
        {
            InitializeComponent();
            comb_role.Items.AddRange(_db.roles.Select(x => x.role_name).ToArray());
            comb_role.SelectedIndex = 1;
        }

        private void btn_addAssistant_Click(object sender, EventArgs e)
        {

            try
            {
                var admin = new admin
                {
                    lName = txt_Lname.Text,
                    fName = txt_Fname.Text,
                    Salary = decimal.Parse(txt_salary.Text),
                    birthdate = dataTime_birthDate.Value,
                    phone_number = txt_phone.Text,
                    gender = (Male_CheckBox.Checked ? "Male" : (Female_CheckBox.Checked) ? "Female" : null),
                    nationalID = txt_NationalId.Text,

                };

                string newPath = $@"{Environment.CurrentDirectory}\adminImage\{Guid.NewGuid()}.jpg";
                File.Copy(oldPath, newPath);
                admin.image = newPath;
                user_ user = new user_
                {
                    email = txt_email.Text,
                    pass = txt_password.Text,
                    role_id = comb_role.SelectedIndex + 1
                };
                admin.user_id = user.id;
                _db.admins.Add(admin);
                _db.user_.Add(user);
                _db.SaveChanges();
                MessageBox.Show($"{admin.fName} {admin.lName} add Successfully");

                AdminAdd?.Invoke();

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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