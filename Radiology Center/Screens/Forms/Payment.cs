using Radiology_Center.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Radiology_Center.Screens.Forms
{



    public partial class Payment : Form
    {
        public delegate void paymentAddEventHandler();

        public event paymentAddEventHandler paymentAdd;
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
                paymentAdd?.Invoke();
                this.Close();
            }
        }

       


 
        
    }
}
