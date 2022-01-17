using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales.Report
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }
        public int sid
        {
            get; set;
        }
        private void Invoice_Load(object sender, EventArgs e)
        {
            
            this.report_SingleInvoiceTableAdapter.Fill(this.cafeDataSet.Report_SingleInvoice, sid);
            this.reportViewer1.RefreshReport();

        }
    }
}
