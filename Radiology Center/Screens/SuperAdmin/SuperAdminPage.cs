using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Radiology_Center
{
    public partial class SuperAdminPage : Form
    {
        public SuperAdminPage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0,0,picBX_Profile.Width,picBX_Profile.Height);
            Region rg = new Region(path);
            picBX_Profile.Region = rg;


        }

        private void btn_profile_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radiology_centerDataSet4.Doctor' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'radiology_centerDataSet2.Doctor' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'radiology_centerDataSet1.Doctor' table. You can move, or remove it, as needed.

            this.Bounds = Screen.PrimaryScreen.Bounds;

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
