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
    /// <summary>
    /// This form is used for both the Add Electronic and Update Electronic.
    /// </summary>
    public partial class addElectFrm : Form
    {
        public addElectFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This variable is used to determine whether an electronic is new or not.
        /// </summary>
        Electronic existingElec;

        /// <summary>
        /// Populates the form with the current electronic's data, if it exists.
        /// Then sets the variable existingElec to be the electronic that was passed in.
        /// </summary>
        /// <param name="electronic"></param>
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

        /// <summary>
        /// When the user clicks the Add Electronic button, if the variable existingElec
        /// is null it means the electronic being added is a new one so it is added to the database.
        /// If it is not null, it already exists in the database and is being updated instead.
        /// </summary>
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
