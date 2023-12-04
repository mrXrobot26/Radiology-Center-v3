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
	public partial class Docter : Form
	{
		RadiologyEntities _db = new RadiologyEntities();	

		public Docter()
		{
			InitializeComponent();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

        private void txt_Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addDoc_Click(object sender, EventArgs e)
        {
			try
			{
				var doctor = new Docter
				{
					
				};
				
			}catch(Exception ex)
			{

			}finally 
			{ 

			}
        }
    }
}
