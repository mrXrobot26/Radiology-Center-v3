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

namespace Radiology_Center.Screens.Forms.Add_Patient
{
    public partial class AddPatientForm : Form
    {
        public delegate void PatiantAddEventHandler();

        public event PatiantAddEventHandler patiantAdd;
        RadiologyEntities _db = new RadiologyEntities();
        string _email;
        public AddPatientForm(string email)
        {
            InitializeComponent();
            _email = email;

            comb_department.SelectedIndexChanged += comb_department_SelectedIndexChanged;

            comb_department.Items.AddRange(_db.departments.Select(x => x.name).ToArray());
        }

        private void comb_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_department.SelectedItem != null)
            {
                string selectedDepartment = comb_department.SelectedItem.ToString();

                var doctorsInDepartment = _db.doctors
                    .Where(d => d.department.name == selectedDepartment)
                    .Select(d => d.fName + " " + d.lName)
                    .ToArray();

      


                comb_doctor.Items.Clear();

                comb_doctor.Items.AddRange(doctorsInDepartment);

                var raysInDepartment = _db.rays
           .Where(r => r.department.name == selectedDepartment)
           .Select(r => r.name)
           .ToArray();

                comb_ray.Items.Clear();

                comb_ray.Items.AddRange(raysInDepartment);
            }
        }
   
    private void AddPatientForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_addAssistant_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _db.user_.FirstOrDefault(x => x.email == _email);
                var assistant = _db.assisatants.FirstOrDefault(x => x.user_id == user.id);

                var patiant = new patient_info
                {
                    lName = txt_Lname.Text,
                    fName = txt_Fname.Text,
                    birthdate = dataTime_birthDate.Value,
                    Phone_number = txt_phoneNumber.Text,
                    gender = (Male_CheckBox.Checked ? "Male" : (Female_CheckBox.Checked) ? "Female" : null),

                };
                var patiantData = new patient_data
                {
                    ray_id = comb_ray.SelectedIndex + 1,
                    dep_id = comb_department.SelectedIndex + 1,
                    doctor_id = comb_doctor.SelectedIndex + 1,
                    pay_status = txt_paymentStatus.Text,
                    doctor_report = txt_docReport.Text,
                    history = txt_history.Text,
                    deliverdate = dateTime_deliverDate.Value,
                    daydate = DateTime.Now,
                    assistant_id = assistant.id,
                };

                patiantData.patient_id = patiant.id;
                _db.patient_info.Add(patiant);
                _db.patient_data.Add(patiantData);
                _db.SaveChanges();

                MessageBox.Show($"{patiant.fName} {patiant.lName} add Successfully");

                patiantAdd?.Invoke();

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
