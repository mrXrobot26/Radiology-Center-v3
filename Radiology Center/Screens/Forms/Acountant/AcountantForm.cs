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

namespace Radiology_Center.Screens.Forms.Acountant
{
    public partial class AcountantForm : Form
    {
        public delegate void AccountantAddEventHandler();

        public event AccountantAddEventHandler AccountantAdd;

        RadiologyEntities _db = new RadiologyEntities();
        string oldPath = "";
        private int _branch_id;
        public AcountantForm(int role_id, int branch_id)
        {
            InitializeComponent();
            comb_role.Items.AddRange(_db.roles.Select(x => x.role_name).ToArray());
            comb_role.SelectedIndex = 4;
            _branch_id = branch_id;
            Comb_branch.Items.AddRange(_db.branches.OrderBy(b => b.id).Skip(1).Select(x => x.name).ToArray());
            //  Comb_branch.SelectedIndex = branch_id-2;
            Comb_branch.SelectedIndex = _branch_id - 2;
            if (role_id == 2)
            {
                Comb_branch.Enabled = false;
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

        private void btn_addAssistant_Click_1(object sender, EventArgs e)
        {
            try
            {
                var accountant = new accountant
                {
                    lName = txt_Lname.Text,
                    fName = txt_Fname.Text,
                    salary = decimal.Parse(txt_salary.Text),
                    birthdate = dataTime_birthDate.Value,
                    phone_number = txt_phone.Text,
                    gender = (Male_CheckBox.Checked ? "Male" : (Female_CheckBox.Checked) ? "Female" : null),
                    nationalID = txt_NationalId.Text,

                };

                string newPath = $@"{Environment.CurrentDirectory}\accountanttImage\{Guid.NewGuid()}.jpg";
                File.Copy(oldPath, newPath);
                accountant.image = newPath;
                user_ user = new user_
                {
                    email = txt_email.Text,
                    pass = txt_password.Text,
                    role_id = comb_role.SelectedIndex + 1,
                    branch_id = _branch_id
                };
                _db.accountants.Add(accountant);
                _db.user_.Add(user);
                _db.SaveChanges();
                accountant.user_id = user.id;
                _db.SaveChanges();
                MessageBox.Show($"{accountant.fName} {accountant.lName} add Successfully");

                AccountantAdd?.Invoke();

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

