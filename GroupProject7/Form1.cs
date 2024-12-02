using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject7
{
    public partial class Form1 : Form
    {

        frmShoppingCart newShoppingCart= new frmShoppingCart();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAllRecords_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Records", "Dialog Box");
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.ShowDialog();
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceForm maintenanceForms = new MaintenanceForm();
            maintenanceForms.ShowDialog();
        }

        private void buttonMaintenance_Click(object sender, EventArgs e)
        {
            maintenanceToolStripMenuItem_Click(sender, e);
        }

        private void buttonShoppingCart_Click(object sender, EventArgs e)
        {
            
            newShoppingCart.Show();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }
    }
}
