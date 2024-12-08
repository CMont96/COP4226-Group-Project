using GroupProject7.BookStoreDataSetTableAdapters;
using GroupProject7.DataDirectory.Model.DataAccessClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject7
{
    public partial class frmShoppingCart : Form
    {
        public ShoppingCartOrder newShoppingCart = new ShoppingCartOrder();
        BookStoreDataAccess bookTitles;
        private DataTable dataTable;

        public frmShoppingCart()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        private void txtOrderNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeDataTable()
        {
            // Initialize DataTable with 3 relevant columns
            dataTable = new DataTable();

            // Define only the 3 relevant columns
            dataTable.Columns.Add("TitleId", typeof(int));
            dataTable.Columns.Add("TitleName", typeof(string));
            dataTable.Columns.Add("Price", typeof(decimal));

            // Bind DataTable to DataGridView
            dgvShoppingCart.DataSource = dataTable;
        }


        // Method to populate items from search text from database. 
        private void btnSearchEnter_Click(object sender, EventArgs e)
        {
            bookTitles = new BookStoreDataAccess();
            string searchBooks = txtSearchItems.Text.Trim();

            // if search button is clicked but no value is inputed.
            if (string.IsNullOrEmpty(searchBooks))
            {
                MessageBox.Show("Please enter a value for the search");
                return;
            }
            //add variable for connection string 
            string connectionString = bookTitles.ConnectionString;
            // our query for the database communication.
            string query = "SELECT * FROM titles WHERE title LIKE @searchBooks";

            // logic for the book title search to populate items that have a partial match .
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                command.Parameters.AddWithValue("@searchBooks", "%" + searchBooks + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);


                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No records found.");
                }
                else
                {
                    frmBookSearchSelection bookSearchForm = new frmBookSearchSelection();
                    bookSearchForm.setDataSource(dt);
                    bookSearchForm.ShowDialog();
                }

            }

        }
        // Method to add item to his form datagridview control when an item is selected from the BookSearchSelection form 
        public void addItemtoShoppingCart(DataRow selectedRow)
        {
            // Ensure the selectedRow has the relevant number of columns
            if (dataTable == null)
            {
                MessageBox.Show("DataTable is not initialized.");
                return;
            }

            // Create a new row with only the relevant columns (TitleId, TitleName, Price)
            DataRow newRow = dataTable.NewRow();
            newRow["title_id"] = selectedRow["title_id"];
            newRow["TitleName"] = selectedRow["TitleName"];
            newRow["Price"] = selectedRow["Price"];

            // Add the new row to the DataTable
            dataTable.Rows.Add(newRow);

            // Refresh DataGridView to display the added row
            dgvShoppingCart.Refresh();
        }


        private void frmShoppingCart_Load(object sender, EventArgs e)
        {
        
            }


        }
    }
