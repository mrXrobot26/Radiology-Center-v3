﻿using Radiology_Center.Models;
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

namespace Radiology_Center.Screens.Forms.Assistant
{
    public partial class Assistant : Form
    {
        public delegate void AssistantAddEventHandler();

        public event AssistantAddEventHandler AssistantAdd;

        RadiologyEntities _db = new RadiologyEntities();
        string oldPath = "";

        public Assistant()
        {
            InitializeComponent();
            comb_role.Items.AddRange(_db.roles.Select(x => x.role_name).ToArray());
            comb_role.SelectedIndex = 3;


        }



        private void btn_addAssistant_Click(object sender, EventArgs e)
        {
            try
            {
                var assitant = new assisatant
                {
                    lName = txt_Lname.Text,
                    fName = txt_Fname.Text,
                    salary = decimal.Parse(txt_salary.Text),
                    birthdate = dataTime_birthDate.Value,
                    phone_number = txt_phone.Text,
                    gender = (Male_CheckBox.Checked ? "Male" : (Female_CheckBox.Checked) ? "Female" : null),
                    nationalID = txt_NationalId.Text,

                };

                string newPath = $@"{Environment.CurrentDirectory}\AssistantImage\{Guid.NewGuid()}.jpg";
                File.Copy(oldPath, newPath);
                assitant.image = newPath;
                user_ user = new user_
                {
                    email = txt_email.Text,
                    pass = txt_password.Text,
                    role_id = comb_role.SelectedIndex + 1
                };
                assitant.user_id = user.id;
                _db.assisatants.Add(assitant);
                _db.user_.Add(user);
                _db.SaveChanges();
                MessageBox.Show($"{assitant.fName} {assitant.lName} add Successfully");

                AssistantAdd?.Invoke();

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                oldPath = openFileDialog.FileName;
                guna2CirclePictureBox1.ImageLocation = openFileDialog.FileName;

            }
        }
    }
}

