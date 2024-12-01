using GroupProject7.DataDirectory;
using GroupProject7.Model;
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
    public partial class MaintenanceForm : Form
    {
        private DataAccess da;
        private List<Title> titles = new List<Title>();
        public MaintenanceForm()
        {
            InitializeComponent();
            da = new DataAccess();
            titles = da.FindTitles();
            LoadData();
            //UpdateDataGridSource();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = titles;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            var id = textBoxSearch.Text;
            if (String.IsNullOrEmpty(id))
            {
                titles = da.FindTitles();
                LoadData();
            }
            else
            {
                try
                {
                    List<Title> titles = da.FindTitle(id);

                    if (titles != null)
                    {
                        MessageBox.Show("Found this: " + titles.First().TitleName);
                        dataGridView1.DataSource = titles;
                    }
                    else MessageBox.Show("Nothing was found");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //MessageBox.Show("Searching for: " + searchTerm);
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceForm maintenance = new MaintenanceForm();
            maintenance.ShowDialog();
        }

        private void MaintenanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookStoreDataSet.titles' table. You can move, or remove it, as needed.
            this.titlesTableAdapter.Fill(this.bookStoreDataSet.titles);
            // TODO: This line of code loads data into the 'bookStoreDataSet.authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.bookStoreDataSet.authors);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // open edit form and pass the title object to the form.
            // In the form, make the call to save the edit object.
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["titleId"].Value);
                MessageBox.Show("Editing Record #" + id);
                EditForm editForm = new EditForm(id);
                editForm.Show();
            }
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // refresh grid?
            //UpdateDataGridSource();
        }
    }
}
