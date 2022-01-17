using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales.User_Controls
{
    public partial class Reports : UserControl
    {
        private static Reports _REP;
        public static Reports REP
        {
            get
            {
                if (_REP == null)
                    _REP = new Reports();
                return _REP;
            }
        }
        public Reports()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        projectsp.projectstored ps = new projectsp.projectstored();
        private void Reports_Load(object sender, EventArgs e)
        {
            ps.filllistbox(lb_shift, ps.GetShifts(), "Shift_Name", "Shift_ID");
            this.Dock = DockStyle.Fill;
        }

        private void lb_shift_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_shift.SelectedValue.ToString() != "System.Data.DataRowView")
                ps.filllistbox(lb_order, ps.GetInvoices("Shift_ID", lb_shift.SelectedValue.ToString()), "Oder_No", "Invoice_ID");

        }

        private void lb_order_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_order.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                dgv_details.DataSource = ps.GetInvoiceDetails(Convert.ToInt32(lb_order.SelectedValue));
            }
        }

        private void btn_shiftcash_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(lb_shift.SelectedValue);
            
                Report.ShiftCash f1 = new Report.ShiftCash();
                f1.sid = sid;
                f1.start = DateTime.Parse("1-1-2000");
                f1.end = DateTime.Parse("1-1-2200");
                f1.Show();
            
        }

        private void btn_shiftsales_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(lb_shift.SelectedValue);

            Report.SalesRep f1 = new Report.SalesRep();
            f1.sid = sid;
            f1.start = DateTime.Parse("1-1-2000");
            f1.end = DateTime.Parse("1-1-2200");
            f1.Show();
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lb_order.SelectedValue);
            Report.Invoice inv = new Report.Invoice();
            inv.sid = id;
            inv.Show();
        }

        private void btn_datesales_Click(object sender, EventArgs e)
        {
            

            Report.SalesRep f1 = new Report.SalesRep();
            f1.sid = 0;
            f1.start = dt_from.Value;
            f1.end =dt_to.Value;
            f1.Show();
        }

        private void btn_datecash_Click(object sender, EventArgs e)
        {
            Report.ShiftCash f1 = new Report.ShiftCash();
            f1.sid = 0;
            f1.start = dt_from.Value;
            f1.end = dt_to.Value;
            f1.Show();
        }

        private void lb_order_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void lb_shift_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < lb_shift.Items.Count)
            {
                Graphics g = e.Graphics;

                // Background Color
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(255, 135, 13) : Color.White);
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                //string itemText = lb_shift.Items[itemIndex].ToString();
                string itemText = lb_shift.GetItemText(lb_shift.Items[e.Index]);

                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.White) : new SolidBrush(Color.Black);
                g.DrawString(itemText, e.Font, itemTextColorBrush, lb_shift.GetItemRectangle(itemIndex).Location);

                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }
        }

        private void lb_order_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < lb_order.Items.Count)
            {
                Graphics g = e.Graphics;

                // Background Color
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(255, 135, 13) : Color.White);
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                //string itemText = lb_shift.Items[itemIndex].ToString();
                string itemText = lb_order.GetItemText(lb_order.Items[e.Index]);

                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.White) : new SolidBrush(Color.Black);
                g.DrawString(itemText, e.Font, itemTextColorBrush, lb_order.GetItemRectangle(itemIndex).Location);

                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }
        }
    }
}
