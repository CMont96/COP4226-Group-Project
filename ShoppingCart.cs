using GroupProject7.BookStoreDataSetTableAdapters;
using GroupProject7.DataDirectory.Model.DataAccessClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            bookTitles = new BookStoreDataAccess();
            dataTable = bookTitles.InitializeShoppingCartDataTable();
            dgvShoppingCart.DataSource = dataTable;
        }

        private void txtOrderNumber_TextChanged(object sender, EventArgs e)
        {

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
                    frmBookSearchSelection bookSearchForm = new frmBookSearchSelection(this);
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

            //Code that checks if the same item is already in the datagridview in the shopping cart
            // to increase its quantity count.
            DataRow existingRow = dataTable.Rows.Cast<DataRow>().FirstOrDefault
                (row => row["title_id"].ToString() == selectedRow["title_id"].ToString());

            if (existingRow != null)
            {
                existingRow["quantity"] = (int)existingRow["quantity"] + 1;
                
            }
            
            else
            {
                // Create a new row with only the relevant columns (TitleId, TitleName, Price)
                DataRow newRow = dataTable.NewRow();
                newRow["title_id"] = selectedRow["title_id"];
                newRow["title"] = selectedRow["title"];
                newRow["price"] = selectedRow["price"];
                newRow["quantity"] = 1;

                // Add the new row to the DataTable
                dataTable.Rows.Add(newRow);
                
            }calculateTotals();// calculates the totals once the items are updated in the datagridview
            // Refresh DataGridView to display the added row
            dgvShoppingCart.Refresh();
        }

        public void calculateTotals()
        {
            decimal subtotal = 0;
            decimal taxAmount = 0.1m;
            decimal total = 0;

            //looping through each row of the datagridview
            foreach (DataRow row in dataTable.Rows)
            {

                // converting values from columns to usable datatypes\
                if (row["price"] == null)
                {
                    MessageBox.Show("Error this item has no price and needs updating, please choose a seperate item.");
                }
                else {
                    decimal price = Convert.ToDecimal(row["price"]);
                    int quantityCount = Convert.ToInt32(row["quantity"]);
                    // caluclates subtotal
                    decimal itemTotal = price * quantityCount;
                    subtotal += itemTotal;
                }


            }
            //calculates tax amount & total amounts 
            decimal totalTax = subtotal * taxAmount;
            total = subtotal + totalTax;

            // display figures in the textbox.
            txtSubTotal.Text = subtotal.ToString("C");
            txtTax.Text = totalTax.ToString("C");
            txtTotal.Text = total.ToString("C");





        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            //code that removes an item from the shopping cart and updates the totals.

            if(dgvShoppingCart.SelectedRows.Count > 0 ) 
            {
                DataGridViewRow selectedRow = dgvShoppingCart.SelectedRows[0];
                DataRow dataRow = ((DataRowView)selectedRow.DataBoundItem).Row;
                dataTable.Rows.Remove(dataRow);
                MessageBox.Show("Item removed, order updated!");
                calculateTotals();
                
            }
        }
    }
}

