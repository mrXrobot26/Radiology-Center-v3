using Radiology_Center.Screens.Forms;
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

namespace Radiology_Center.Screens.Admin
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(() => Application.Run(new LogIn()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
