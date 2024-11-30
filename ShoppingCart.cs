using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public frmShoppingCart()
        {
            InitializeComponent();
        }

        private void txtOrderNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            //Input for item one 
            string bookOne = "This is the first Item";
            int qtyOne = 33;
            decimal priceOne = 350.00m;

            txtItemName1.Text = bookOne;
            txtQuantity1.Text = qtyOne.ToString();
            txtPrice1.Text = priceOne.ToString("c");
            //Input for item two
            /* string bookTwo = "This is the second Item";
             int qtyTwo = 20;
             decimal priceTwo = 200.00m;
             txtItemName2.Text = bookTwo;
             txtQuantity2.Text = qtyTwo.ToString();
            txtPrice2.Text = priceTwo.ToString("c");
            */

            //Input item two -- exeception handling .
            try
            {
                string bookTwo = "This is the second Item";
                int qtyTwo = 20;
                decimal priceTwo = 200.00m;
                txtItemName2.Text = bookTwo;
                txtQuantity2.Text = qtyTwo.ToString();
                txtPrice2.Text = priceTwo.ToString("C");

            }

            catch (Exception ex)
            {
                MessageBox.Show("There is a error in your entry !");
            }
        }
    }
}
