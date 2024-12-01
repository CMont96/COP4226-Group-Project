using GroupProject7.DataDirectory;
using GroupProject7.Model;
using System;
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
    public partial class EditForm : Form
    {
        // receive the id from the othe form and send the sql statement to edit the record
        private string id;
        private DataAccess da;
        private Title localRecord;
        public EditForm(string ID = null)
        {
            InitializeComponent();
            id = ID;
        }

        private void LoadData()
        {
            if (!String.IsNullOrEmpty(id) && localRecord != null)
            {
                textBoxId.Text = id;
                textBoxTitle.Text = localRecord.TitleName;
                textBoxType.Text = localRecord.Type;
                textBoxPubId.Text = localRecord.PubId;
                textBoxPrice.Text = localRecord.Price;
                textBoxAdvance.Text = localRecord.Advance;
                textBoxRoyalty.Text = localRecord.Royalty;
                textBoxYTDSales.Text = localRecord.YtdSales;
                textBoxNotes.Text = localRecord.Notes;
                textBoxPublishedOn.Text = localRecord.PubDate;
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            da = new DataAccess();
            List<Title> title = da.FindTitle(id);
            if(title.Count > 0)
            {
                localRecord = title[0];
            }
             LoadData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pubId;
            decimal price, advance;
            int royalty, ytdSales;

            // Validate numeric inputs
            if (!int.TryParse(textBoxPubId.Text, out pubId))
            {
                MessageBox.Show("Invalid PubId. It must be a numeric value.");
                return;
            }
            if (!decimal.TryParse(textBoxPrice.Text, out price))
            {
                MessageBox.Show("Invalid Price. It must be a numeric value.");
                return;
            }
            if (!decimal.TryParse(textBoxAdvance.Text, out advance))
            {
                MessageBox.Show("Invalid Advance. It must be a numeric value.");
                return;
            }
            if (!int.TryParse(textBoxRoyalty.Text, out royalty))
            {
                MessageBox.Show("Invalid Royalty. It must be a numeric value.");
                return;
            }
            if (!int.TryParse(textBoxYTDSales.Text, out ytdSales))
            {
                MessageBox.Show("Invalid YTD Sales. It must be a numeric value.");
                return;
            }

            Title title = new Title(
               textBoxId.Text,
               textBoxTitle.Text,
               textBoxType.Text,
               textBoxPubId.Text,
               textBoxPrice.Text,
               textBoxAdvance.Text,
               textBoxRoyalty.Text,
               textBoxYTDSales.Text,
               textBoxNotes.Text,
               textBoxPublishedOn.Text);

            if (da.UpdateTitle(title) > 0)
            {
                MessageBox.Show("Updated Record #" + title.TitleId);
            }
            else MessageBox.Show("Update Failed");
        }
    }
}
