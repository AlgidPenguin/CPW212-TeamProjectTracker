﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProjectTracker
{
    public partial class addElectFrm : Form
    {
        public addElectFrm()
        {
            InitializeComponent();
        }

        public addElectFrm(Electronic electronic)
        {
            InitializeComponent();
            nameTxt.Text = electronic.Name;
            manufactTxt.Text = electronic.Manufacturer;
            priceTxt.Text = electronic.Price.ToString();
            categoryTxt.Text = electronic.Category;

            addElectCmd.Text = "Update Electronic";
            this.Text = "Update " + electronic.Name;
            

            ElectronicDb.Update(electronic);
        }

        private void addElectCmd_Click(object sender, EventArgs e)
        {
            Electronic electToAdd = new Electronic();
            electToAdd.Name = nameTxt.Text;
            electToAdd.Manufacturer = manufactTxt.Text;
            electToAdd.Price = Convert.ToDouble(priceTxt.Text);
            electToAdd.Category = categoryTxt.Text;

            ElectronicDb.Add(electToAdd);


        }
    }
}
