﻿using Radiology_Center.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiology_Center.Screens.Forms.Ray
{
    public partial class RayForm : Form
    {
        public delegate void RayFormEventHandler();
        public event RayFormEventHandler RayEventHandler;
        RadiologyEntities _db = new RadiologyEntities();
        public RayForm()
        {
            InitializeComponent();
            comb_dep.Items.AddRange(_db.departments.Select(x => x.name).ToArray());
            comb_dep.SelectedIndex = 0;
        }

        private void RayForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addDoc_Click(object sender, EventArgs e)
        {
            var ray = new ray
            {
                name = txt_rayName.Text,
                cost = decimal.Parse(txt_rayCost.Text),
                dep_id = comb_dep.SelectedIndex + 1,
            };
            _db.rays.Add(ray);
            _db.SaveChanges();

            MessageBox.Show($"{ray.name} add Successfully");

            RayEventHandler?.Invoke();
            this.Close();
        }
    }
}
