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

namespace Radiology_Center.Screens.Forms.Department
{
    public partial class DepartmentForm : Form
    {
        public delegate void DepartmentAddedEventHandler();

        public event DepartmentAddedEventHandler DepartmentAdded;

        RadiologyEntities _db = new RadiologyEntities();
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void btn_addDoc_Click(object sender, EventArgs e)
        {
            try
            {
                var department = new department
                {
                    name = txt_department.Text
                };
                _db.departments.Add(department);
                _db.SaveChanges();
                MessageBox.Show($" {department.name} add Successfully");

                DepartmentAdded?.Invoke();

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
