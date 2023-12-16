using Radiology_Center.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Radiology_Center.Screens.Forms.Add_Patient
{
    public partial class AddPatientForm : Form
    {
        public delegate void PatiantAddEventHandler();

        public event PatiantAddEventHandler patiantAdd;
        RadiologyEntities _db = new RadiologyEntities();
        string _email;
        private int _branch_id;
        public AddPatientForm(string email, int brach_id)
        {
            InitializeComponent();
            _email = email;
            _branch_id = brach_id;

            LoadDepartments();
        }

        private void LoadDepartments()
        {
            comb_department.DisplayMember = "name";
            comb_department.ValueMember = "id";
            comb_department.DataSource = _db.departments
                .Select(d => new { id = d.id, name = d.name })
                .ToList();

            comb_department.SelectedIndexChanged += comb_department_SelectedIndexChanged;
        }

        private void comb_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_department.SelectedValue is int departmentId)
            {
                LoadDoctors(departmentId);
                LoadRays(departmentId);
            }
        }

        private void LoadDoctors(int departmentId)
        {
            comb_doctor.DisplayMember = "name";
            comb_doctor.ValueMember = "id";
            comb_doctor.DataSource = _db.doctors
                .Where(d => d.dep_id == departmentId)
                .Select(d => new { id = d.id, name = d.fName + " " + d.lName })
                .ToList();
        }

        private void LoadRays(int departmentId)
        {
            comb_ray.DisplayMember = "name";
            comb_ray.ValueMember = "id";
            comb_ray.DataSource = _db.rays
                .Where(r => r.dep_id == departmentId)
                .Select(r => new { id = r.id, name = r.name })
                .ToList();
        }

        private void btn_addAssistant_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _db.user_.FirstOrDefault(x => x.email == _email);
                var assistant = _db.assisatants.FirstOrDefault(x => x.user_id == user.id);

                var patient = new patient_info
                {
                    lName = txt_Lname.Text,
                    fName = txt_Fname.Text,
                    birthdate = dataTime_birthDate.Value,
                    Phone_number = txt_phoneNumber.Text,
                    gender = (Male_CheckBox.Checked ? "Male" : (Female_CheckBox.Checked) ? "Female" : null),
                };

                _db.patient_info.Add(patient);
                _db.SaveChanges(); 
                var patientData = new patient_data
                {
                    patient_id = patient.id, 
                    ray_id = (int)comb_ray.SelectedValue,
                    dep_id = (int)comb_department.SelectedValue,
                    doctor_id = (int)comb_doctor.SelectedValue,
                    pay_status = txt_paymentStatus.Text,
                    doctor_report = txt_docReport.Text,
                    history = txt_history.Text,
                    deliverdate = dateTime_deliverDate.Value,
                    daydate = DateTime.Now,
                    assistant_id = assistant.id,
                    branch_id = _branch_id 
            };

                _db.patient_data.Add(patientData);
                _db.SaveChanges();

                MessageBox.Show($"{patient.fName} {patient.lName} added Successfully");

                patiantAdd?.Invoke();

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


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
