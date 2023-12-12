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

namespace Radiology_Center.Screens.Forms
{
    public partial class Payment : Form
    {
        RadiologyEntities _db = new RadiologyEntities();
        public Payment()
        {
            InitializeComponent();
        }
        string paystatus;
        int Id;
        public void setpaydata(int Id, string Pfname, string Plname, string Dfname, string Dlname, string Rname, decimal Salary, string paystatus)
        {
            lbl_PatientName.Text = Pfname + " " + Plname;
            lbl_Doc_Name.Text = Dfname + " " + Dlname;
            lbl_Ray_Name.Text = Rname;
            lbl_Psalary.Text = Salary.ToString();
            this.paystatus = paystatus;
            this.Id = Id;
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void foxBigLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (paystatus != "Done ✓")
            {
                var makepay = _db.patient_data.FirstOrDefault(x => x.id == Id);
                makepay.pay_status = "Done ✓";
                _db.SaveChanges();
                this.Close();
            }
        }

        private void lbl_Doc_Name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Patient_Click(object sender, EventArgs e)
        {

        }

        private void lbl_PatientName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Ray_Name_Click(object sender, EventArgs e)
        {

        }
    }
}
