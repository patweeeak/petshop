﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petshop
{
    public partial class Product : Form
    {
        private Form currentchildForm1;
        public Product()
        {
            InitializeComponent();
        }

       

        private void OpenChildForm1(Form childForm, int xpos, int ypos)
        {
            if (currentchildForm1 != null)
            {
                currentchildForm1.Hide();
            }
            currentchildForm1 = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panel5.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
/*            childForm.Size = new Size(Convert.ToInt32(childForm.Width * 1.155), Convert.ToInt32(childForm.Height * 1.096));*/
            childForm.FormBorderStyle = FormBorderStyle.None;
/*            childForm.Location = new Point(xpos, ypos);*/
        }

      
        private void productCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new ProductsData(), 30, 135); 
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new productcategory(), 30, 135);
        }

        private void services_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new Services(), 30, 135);
        }

        private void Product_Load(object sender, EventArgs e)
        {
            productCategory_Click(null, null);
        }

        private void petManage_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new petManagement(), 30, 135);
        }
    }
}
