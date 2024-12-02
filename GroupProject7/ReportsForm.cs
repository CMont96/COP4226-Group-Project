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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void btnReportsGenerate_Click(object sender, EventArgs e)
        {
            //report date range converted to string
            string reportFrom = dtpReportsFrom.Value.ToString("yyyy-MM-dd");
            string reportsTo = dtpReportsTo.Value.ToString("yyyy-MM-dd");

            //create and show export form
            ReportExportForm reportExportForm = new ReportExportForm();
            reportExportForm.ShowDialog();
        }

        private void btnReportsClear_Click(object sender, EventArgs e)
        {
            //clears dates
            dtpReportsFrom.Value = DateTime.Now;
            dtpReportsTo.Value = DateTime.Now;
        }
    }
}
