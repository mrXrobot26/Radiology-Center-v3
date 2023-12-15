using Radiology_Center.Models;
using Radiology_Center.Screens.Acountant;
using Radiology_Center.Screens.Admin;
using Radiology_Center.Screens.Forms.Assistant;
using Radiology_Center.Screens.Doctor;
using Radiology_Center.Screens.Forms.Assistant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace Radiology_Center.Screens.Forms
{
    public partial class LogIn : Form
    {

        RadiologyEntities _db = new RadiologyEntities();

        public LogIn()
        {
            InitializeComponent();
        }

        private void Log_btn_Click(object sender, EventArgs e)
        {
                  
            {
                try
                {
                    if (txt_password.Text == "" || txt_email.Text == "")
                    {
                        throw new InvalidCredentialsException("Filed empty");

                    }
                    else
                    {
                        var foundedUser = _db.user_.FirstOrDefault(x => x.email == txt_email.Text && x.pass == txt_password.Text);
                        if (foundedUser != null)
                        {
                            this.Close();

                            int branch_id = (int)foundedUser.branch_id;


                            if (foundedUser.role_id == 1) 
                            {
                                var userDetail = _db.super_admin.FirstOrDefault(sa => sa.user_id == foundedUser.id);
                                string fullName = userDetail?.fName + " " + userDetail?.lName;
                                string email = foundedUser.email;
                                string imagePath = userDetail?.image;
                                int role_id = 1;
                                Thread th = new Thread(() => Application.Run(new SuperAdminHomePage(fullName,email,imagePath, role_id, branch_id)));
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }
                            else if (foundedUser.role_id == 2)
                            {
                                var userDetail = _db.admins.FirstOrDefault(sa => sa.user_id == foundedUser.id);
                                string fullName = userDetail?.fName + " " + userDetail?.lName;
                                string email = foundedUser.email;
                                string imagePath = userDetail?.image;
                                int role_id = 2;
                                Thread th = new Thread(() => Application.Run(new AdminHomePage(fullName, email, imagePath, role_id, branch_id)));
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }
                            else if (foundedUser.role_id == 3)
                            {
                                var userDetail = _db.doctors.FirstOrDefault(sa => sa.user_id == foundedUser.id);
                                string fullName = userDetail?.fName + " " + userDetail?.lName;
                                string email = foundedUser.email;
                                string imagePath = userDetail?.image;
                                Thread th = new Thread(() => Application.Run(new DoctorHomePage(fullName, email, imagePath, branch_id)));
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }
                            
                            else if (foundedUser.role_id == 4)
                            {
                                var userDetail = _db.assisatants.FirstOrDefault(sa => sa.user_id == foundedUser.id);
                                string fullName = userDetail?.fName + " " + userDetail?.lName;
                                string email = foundedUser.email;
                                string imagePath = userDetail?.image;
                                Thread th = new Thread(() => Application.Run(new AssistantHomePage(fullName, email, imagePath, branch_id)));
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }
                            
                            else if (foundedUser.role_id == 5)
                            {
                                var userDetail = _db.accountants.FirstOrDefault(sa => sa.user_id == foundedUser.id);
                                string AccName = userDetail?.fName + " " + userDetail?.lName;
                                string Accemail = foundedUser.email;
                                string AccimagePath = userDetail?.image;

                                Thread th = new Thread(() => Application.Run(new Accountant(AccName, Accemail, AccimagePath, branch_id)));
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }

                        }
                        else
                        {
                            throw new InvalidCredentialsException("Try again password or user name not match");
                        }
                    }

                }
                catch (InvalidCredentialsException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public class InvalidCredentialsException : Exception
        {
            public InvalidCredentialsException(string message) : base(message)
            {
            }
        }

        private void Cancle_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void LogIn_Load_1(object sender, EventArgs e)
        {

        }
    }
}
