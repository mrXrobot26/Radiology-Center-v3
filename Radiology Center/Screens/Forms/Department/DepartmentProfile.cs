using Radiology_Center.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Radiology_Center.Screens.Forms.Department
{
    public partial class DepartmentProfile : Form
    {
        RadiologyEntities _db = new RadiologyEntities();

        public DepartmentProfile()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lbl_depId.Text, out int departmentId))
            {
                var dep = _db.departments.FirstOrDefault(x => x.id == departmentId);

                if (dep != null)
                {
                    _db.departments.Remove(dep);
                    _db.SaveChanges();
                    MessageBox.Show($"{dep.name} deleted sussefuly");
                    this.Close();
                }

            }
        }

            public void setDataForDepartment(int id , string depName)
        {
            lbl_depId.Text = id.ToString();                  
            lbl_DepName.Text = depName;
        }


        private void btrn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
