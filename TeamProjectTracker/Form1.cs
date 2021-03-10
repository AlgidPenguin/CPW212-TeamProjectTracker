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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the form loads, call a method to get all the electronics from the database
        /// and populate the listbox with them.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Electronic> allElectronics = ElectronicDb.GetAllElectronics();
            populateList(allElectronics);
        }

        /// <summary>
        /// Populate the listbox with the list that is passed in.
        /// </summary>
        /// <param name="allElectronics">The list used to populate the listbox</param>
        private void populateList(List<Electronic> allElectronics)
        {
            listBox1.Items.Clear();
            foreach (Electronic cat in allElectronics)
            {
                listBox1.Items.Add(cat.Category);
                foreach (Electronic elect in allElectronics)
                {
                    if (elect.Category == cat.Category)
                    {
                        listBox1.Items.Add("     " + elect);
                    }
                }
            }

        }

        /// <summary>
        /// When the Add Electronics button is clicked, open up a new form
        /// and then repopulate the list when it is closed.
        /// </summary>
        private void addElectCmd_Click(object sender, EventArgs e)
        {
            addElectFrm addForm = new addElectFrm();
            addForm.ShowDialog();

            List<Electronic> allElectronics = ElectronicDb.GetAllElectronics();
            populateList(allElectronics);
        }

        /// <summary>
        /// When the Update Electronic button is pressed, open up a new form
        /// with the information of that electronic already populated. The user may
        /// then update any information regarding the electronic. After closing,
        /// the listbox is once again repopulated. Displays an error
        /// message if there is no electronic selected.
        /// </summary>
        private void updateElectCmd_Click(object sender, EventArgs e)
        {
            if ( listBox1.SelectedIndex < 0 )
            {
                MessageBox.Show("You must choose a product to update.");
                return;
            }

            Electronic electToUpdate = listBox1.SelectedItem as Electronic;
            addElectFrm updateForm = new addElectFrm(electToUpdate);
            updateForm.ShowDialog();

            populateList(ElectronicDb.GetAllElectronics());
        }

        /// <summary>
        /// When the Delete Electronic button is pressed, a message box is 
        /// presented that prompts the user whether to actually delete the electronic or not.
        /// If yes is clicked, then the electronic is deleted from the database. Once again,
        /// the listbox is repopulated if the user clicks yes. Displays an error message if 
        /// there is no electronic selected.
        /// </summary>
        private void deleteElectCmd_Click(object sender, EventArgs e)
        {
            if( listBox1.SelectedIndex < 0 )
            {
                MessageBox.Show("You must select a product to delete.");
                return;
            }

            Electronic elecToDelete = listBox1.SelectedItem as Electronic;

            DialogResult result = MessageBox.Show(
                                    text: $"Are you sure you want to delete {elecToDelete.ProductId}:{elecToDelete.Manufacturer}:{elecToDelete.Name}",
                                    caption: "Delete?",
                                    buttons: MessageBoxButtons.YesNo,
                                    icon: MessageBoxIcon.Warning);
            if( result == DialogResult.Yes)
            {
                ElectronicDb.Delete(elecToDelete.ProductId);
                populateList(ElectronicDb.GetAllElectronics());
            }
        }
    }
}
