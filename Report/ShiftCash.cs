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
    public partial class ShiftCash : Form
    {
        public ShiftCash()
        {
            InitializeComponent();
        }

        public int sid
        {
            get; set;
        }
        public DateTime start
        {
            get;set;
        }
        public DateTime end
        {
            get;set;
        }

        private void ShiftCash_Load(object sender, EventArgs e)
        {
            //sid = 0;
            //start = DateTime.Parse("1-1-2000");
            //end = DateTime.Parse("1-1-2200");
            this.report_CashTableAdapter.Fill(this.cafeDataSet.Report_Cash, sid,start,end);
            this.reportViewer1.RefreshReport();
        }
    }
}
