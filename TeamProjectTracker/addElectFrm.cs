using System;
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

        Electronic existingElec;

        public addElectFrm(Electronic electronic)
        {
            InitializeComponent();
            nameTxt.Text = electronic.Name;
            manufactTxt.Text = electronic.Manufacturer;
            priceTxt.Text = electronic.Price.ToString();
            categoryCbx.Text = electronic.Category;

            addElectCmd.Text = "Update Electronic";
            this.Text = "Update " + electronic.Name;

            existingElec = electronic;
        }

        private void addElectCmd_Click(object sender, EventArgs e)
        {
            if (existingElec == null)
            {
                Electronic electToAdd = new Electronic();
                electToAdd.Name = nameTxt.Text;
                electToAdd.Manufacturer = manufactTxt.Text;
                electToAdd.Price = Convert.ToDouble(priceTxt.Text);
                electToAdd.Category = categoryCbx.Text;

                ElectronicDb.Add(electToAdd);
            }
            else
            {
                existingElec.Name = nameTxt.Text;
                existingElec.Manufacturer = manufactTxt.Text;
                existingElec.Price = Convert.ToDouble(priceTxt.Text);
                existingElec.Category = categoryCbx.Text;

                ElectronicDb.Update(existingElec);
                MessageBox.Show("Successfully updated item " + existingElec.Name);
            }

            Close();
        }

        private void addElectFrm_Load(object sender, EventArgs e)
        {
            List<String> allCategories = ElectronicDb.GetAllCategories();
            populateList(allCategories, categoryCbx);
        }

        private void populateList(List<String> populateFromList, ComboBox box)
        {
            foreach (String toAdd in populateFromList)
            {
                box.Items.Add(toAdd);
            }
        }
    }
}
