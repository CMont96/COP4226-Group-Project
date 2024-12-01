using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupProject7.Model;
using System.Windows.Forms;
using System.ComponentModel;

namespace GroupProject7.DataDirectory
{
    internal class DataAccess
    {
        private string ConnectionString => ConfigurationManager.ConnectionStrings["UsersConnection"].ConnectionString;

        public string GetConnectionString()
        {
            return ConnectionString;
        }

        public List<Title> FindTitles()
        {
            
            try
            {
                List<Title> titles = new List<Title>();
                Title title = null; // default return value

                string selectStatement =
                    "SELECT * " +
                    "FROM titles";

                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                SqlConnection connection = sqlConnection;
                SqlCommand command = new SqlCommand(selectStatement, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader(
                    CommandBehavior.SingleRow & CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    titles.Add(new Title()
                    {
                        TitleId = reader["title_id"].ToString(), // Assuming 'tid' is mapped to an integer
                        TitleName = reader["title"].ToString(),
                        Type = reader["type"].ToString(),
                        PubId = reader["pub_id"].ToString(), // Handle nullable fields
                        Price = reader["price"].ToString(),
                        Advance = reader["advance"].ToString(),
                        Royalty = reader["royalty"].ToString(),
                        YtdSales = reader["ytd_sales"].ToString(),
                        Notes = reader["notes"].ToString(),
                        PubDate = reader["pubdate"].ToString()
                    });
                }
                return titles;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Title> FindTitle(string Id)
        {
            try
            {
                Title title = null; // default return value
                List<Title> titles = new List<Title>();
                string selectStatement =
                    "SELECT * " +
                    "FROM titles " +
                    "WHERE title_id = @Id";

                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                SqlConnection connection = sqlConnection;
                SqlCommand command = new SqlCommand(selectStatement, connection);
                command.Parameters.AddWithValue("@Id", Id);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader(
                    CommandBehavior.SingleRow & CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    title = new Title()
                    {
                        TitleId = reader["title_id"].ToString(), // Assuming 'tid' is mapped to an integer
                        TitleName = reader["title"].ToString(),
                        Type = reader["type"].ToString(),
                        PubId = reader["pub_id"].ToString(), // Handle nullable fields
                        Price = reader["price"].ToString(),
                        Advance = reader["advance"].ToString(),
                        Royalty = reader["royalty"].ToString(),
                        YtdSales = reader["ytd_sales"].ToString(),
                        Notes = reader["notes"].ToString(),
                        PubDate = reader["pubdate"].ToString()
                    };
                    titles.Add(title);
                }
                return titles;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateTitle(Title title)
        {
            string updateStatement =
                "UPDATE titles " +
                "SET title = @title, " +
                "    type = @type, " +
                "    pub_id = @pub_id, " +
                "    price = @price, " +
                "    advance = @advance, " +
                "    royalty = @royalty, " +
                "    ytd_sales = @ytd_sales, " +
                "    notes = @notes, " +
                "    pubdate = @pubdate " +
                "WHERE title_id = @title_id";

             SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(updateStatement, connection);

            // Add parameters for the 'Title' object
            command.Parameters.AddWithValue("@title_id", title.TitleId); // Primary key for WHERE clause
            command.Parameters.AddWithValue("@title", title.TitleName);
            command.Parameters.AddWithValue("@type", title.Type);
            command.Parameters.AddWithValue("@pub_id", title.PubId);
            command.Parameters.AddWithValue("@price", title.Price);
            command.Parameters.AddWithValue("@advance", title.Advance);
            command.Parameters.AddWithValue("@royalty", title.Royalty);
            command.Parameters.AddWithValue("@ytd_sales", title.YtdSales);
            command.Parameters.AddWithValue("@notes", title.Notes);
            command.Parameters.AddWithValue("@pubdate", title.PubDate);

            connection.Open();
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {
                connection.Close();
                return 1;
            }
            else return 0;
        }
    }

    
}
