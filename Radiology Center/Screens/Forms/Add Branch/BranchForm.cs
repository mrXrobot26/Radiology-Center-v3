using Radiology_Center.Models;
using System;
using System.Windows.Forms;

namespace Radiology_Center.Screens.Forms.Add_Branch
{
    public partial class BranchForm : Form
    {
        public delegate void BranchEventHandler();
        public event BranchEventHandler BranchChanged;
        RadiologyEntities _db = new RadiologyEntities();
        public BranchForm()
        {
            InitializeComponent();
        }

        private void btn_addBranch_Click(object sender, EventArgs e)
        {
            var branch = new branch
            {
                name = txt_branch.Text,
            };
            _db.branches.Add(branch);
            _db.SaveChanges();
            BranchChanged?.Invoke();
            MessageBox.Show($"{branch.name} add Succesfully");
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
