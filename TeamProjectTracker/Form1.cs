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

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Electronic> allElectronics = ElectronicDb.GetAllElectronics();
            populateList(allElectronics);
        }

        private void populateList(List<Electronic> allElectronics)
        {
            listBox1.Items.Clear();
            foreach (Electronic elect in allElectronics)
            {
                listBox1.Items.Add(elect);
            }
        }

        private void addElectCmd_Click(object sender, EventArgs e)
        {
            addElectFrm addForm = new addElectFrm();
            addForm.ShowDialog();

            List<Electronic> allElectronics = ElectronicDb.GetAllElectronics();
            populateList(allElectronics);
        }

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
