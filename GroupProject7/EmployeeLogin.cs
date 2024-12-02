using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GroupProject7.DataDirectory;

namespace GroupProject7
{
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text.Trim();
            string employeeID = textBoxEmployeeID.Text.Trim();

            //Validating user input
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(employeeID))
            {
                MessageBox.Show("Enter both First Name and Employee ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //connect the string to the database
            //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\USERS\MAREL\DOWNLOADS\GROUPPROJECT7\GROUPPROJECT7\GROUPPROJECT7\BIN\DEBUG\DATADIRECTORY\BOOKSTORE.MDF;Integrated Security=True;Connect Timeout=30;";
            DataAccess dataAccess = new DataAccess();
            string connectionString = dataAccess.GetConnectionString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM dbo.employee WHERE fname = @FirstName AND emp_id = @EmployeeID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        //Adding parameters
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);

                        int result = (int)command.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Login Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Redirect to the next form
                            Form1 mainForm = new Form1();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            }
        }
