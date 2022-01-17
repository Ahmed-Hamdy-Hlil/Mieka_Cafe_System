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
    public partial class ShiftItems : Form
    {
        public ShiftItems()
        {
            InitializeComponent();
        }
        public int sid
        {
            get; set;
        }
        private void ShiftItems_Load(object sender, EventArgs e)
        {
         //   sid = 15;
            this.report_ShiftItemsTableAdapter.Fill(this.cafeDataSet.Report_ShiftItems, sid);
            this.reportViewer1.RefreshReport();
        }
    }
}
