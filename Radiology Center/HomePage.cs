using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Radiology_Center
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0,0,picBX_Profile.Width,picBX_Profile.Height);
            Region rg = new Region(path);
            picBX_Profile.Region = rg;


        }


        private void HomePage_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;

        }

        
    }
}
