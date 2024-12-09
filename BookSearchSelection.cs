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
    public partial class frmBookSearchSelection : Form
    {
        private frmShoppingCart shoppingCartItem;
        public frmBookSearchSelection(frmShoppingCart shoppingCartItem)
        {
            InitializeComponent();
            this.shoppingCartItem = shoppingCartItem;
        }

        public frmBookSearchSelection() 
        {
            InitializeComponent();
        }

        public void setDataSource(DataTable datatable) 
        {
            dgvSearchItems.DataSource = datatable;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
          
            if (dgvSearchItems.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvSearchItems.SelectedRows[0];
                // Get the DataRow from the selected row
                DataRowView dataRowView = (DataRowView)selectedRow.DataBoundItem;
                // Assuming shoppingCartItem is an instance of frmShoppingCart
                shoppingCartItem.addItemtoShoppingCart(((DataRowView)selectedRow.DataBoundItem).Row);

                MessageBox.Show("Item added to cart.");
            }
        }

        private void dgvSearchItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
