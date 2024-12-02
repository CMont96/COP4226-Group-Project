using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject7
{
    public partial class ReportExportForm : Form
    {
        private void LoadData()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BookStore.mdf;Integrated Security=True;";
            string query = "SELECT ord_num, title_id, qty, ord_date FROM sales WHERE 1=1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }
        public ReportExportForm()
        {
            InitializeComponent();

            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReportClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            //exports data to .csv file
            StringBuilder sb = new StringBuilder();

            //adds headers
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                sb.Append(column.HeaderText + ",");
            }
            sb.AppendLine();

            //adds rows
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sb.Append(cell.Value?.ToString().Replace(",", " ") + ","); // Replace commas to prevent CSV issues
                    }
                    sb.AppendLine();
                }
            }

            //write to file
            File.WriteAllText(filePath, sb.ToString());
        }

        private void btnReportExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToCSV(dataGridView1, saveFileDialog.FileName);
                    MessageBox.Show("Exported successfully to CSV!");
                }
            }
        }
    }
}
