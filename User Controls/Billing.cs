using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales;
using CreateDynamicTextBoxes_CS;

namespace Sales
{
    public partial class Billing : UserControl
    {
        private static Billing _BUC;
        public static Billing BUC
        {
            get
            {
                if (_BUC == null)
                    _BUC = new Billing();
                return _BUC;
            }
        }
        public Billing()
        {
            InitializeComponent();
        }
        projectsp.projectstored ps = new projectsp.projectstored();

        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            ps.filllistbox(lb_cat, ps.GetCategoriesOrdered(), "Category_Name", "Category_ID");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

            //CreateButtons MakeButtons = new CreateButtons()
            //{
            //    ParentControl = flowLayoutPanel1,
            //    Base = 10,
            //    ButtonBaseName = "btn",
            //    BaseAddition = 60,
            //    ButtonSize = new Size(100, 50)
            //};
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < listBox1.Items.Count)
            {
                Graphics g = e.Graphics;

                // Background Color
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(101, 156, 0) : Color.White);
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                //string itemText = lb_product.Items[itemIndex].ToString();
                string itemText = listBox1.GetItemText(listBox1.Items[e.Index]);

                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.White) : new SolidBrush(Color.Black);
                g.DrawString(itemText, e.Font, itemTextColorBrush, listBox1.GetItemRectangle(itemIndex).Location);

                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }
        }

        private void lb_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_cat.SelectedValue.ToString() != "System.Data.DataRowView")
                ps.filllistbox(listBox1, ps.GetProducts("Category_ID", lb_cat.SelectedValue.ToString()), "Product_Name", "Product_ID");
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            decimal tot = nm_total.Value;
            decimal d = nm_discount.Value;
            if (d > tot || tot == 0)
            {

                nm_disratio.Value = 0;
                nm_discount.Value = 0;
                return;

            }
            decimal c = d / (tot * 1.14M) * 100;
            nm_disratio.Value = c;
            net();

        }


        private void calc()
        {
            decimal tot = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                tot += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
            }
            nm_total.Value = tot;


        }
        private void net()
        {
            calc();
            double tot = double.Parse(nm_total.Text);
            //  double tt = tot*0.14;
            double d = Convert.ToDouble(nm_discount.Value);

            double net = (tot * 1.14) - d;
            nm_nettotal.Value = Convert.ToDecimal(net);

        }
        private void button2_Click(object sender, EventArgs e)
        {

            //item code - item name-quantity-unit price -totall
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (listBox1.SelectedValue.ToString() == dataGridView1.Rows[i].Cells[1].Value.ToString())
                {
                    int oq = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    int nw = int.Parse(nm_quantity.Text) + oq;
                    //DataTable pdt = ps.GetProducts("Product_ID", lb_product.SelectedValue.ToString());

                    double tot = nw * double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    dataGridView1.Rows[i].Cells[3].Value = nw;
                    dataGridView1.Rows[i].Cells[5].Value = tot;
                    //  calc();
                    net();
                    return;

                }
            }
            DataTable pdt = ps.GetProducts("Product_ID", listBox1.SelectedValue.ToString());
            string uprice = pdt.Rows[0][2].ToString();
            double total = int.Parse(nm_quantity.Text) * double.Parse(uprice);
            dataGridView1.Rows.Add("Delete", listBox1.SelectedValue, listBox1.Text, nm_quantity.Text, uprice, total.ToString());
            //   calc();
            net();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                //calc();
                net();
            }
        }

        private void nm_disratio_ValueChanged(object sender, EventArgs e)
        {
            decimal tot = nm_total.Value;
            decimal d = nm_disratio.Value;

            if (d > 100)
            {
                nm_disratio.Value = 0;
                nm_discount.Value = 0;
                return;
            }
            decimal c = d * (tot * 1.14M) / 100;
            nm_discount.Value = c;
            net();
        }

        private void nm_total_ValueChanged(object sender, EventArgs e)
        {
            decimal tot = nm_total.Value;
            decimal d = nm_disratio.Value;

            if (d > 100)
            {
                nm_disratio.Value = 0;
                nm_discount.Value = 0;
                return;
            }
            decimal c = d * (tot * 1.14M) / 100;
            nm_discount.Value = c;
            net();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int sid = ps.GetCurrentShift();
            int oid = ps.getOrderNumber();
            decimal tax = nm_total.Value * 0.14M;
            int id = -1;
            id = ps.InsertNewInvoice(sid, oid, nm_discount.Value, tax, nm_total.Value, nm_nettotal.Value, txt_notes.Text);
            if (id == -1)
            {
                MessageBox.Show("حدث خطا في تسجيل الفاتوره");
                return;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int itemid = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                int quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                decimal price = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                ps.InsertNewInvoiceDetail(id, itemid, quantity, price);
            }
            ps.IncrementOrderNumber();
            //report
            Report.Invoice inv = new Report.Invoice();
            inv.sid = id;
            inv.Show();
            dataGridView1.Rows.Clear();
            net();

            //MessageBox.Show("Success");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow d in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(d);
            }


        }

        private void lb_product_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (listBox1.SelectedValue.ToString() == dataGridView1.Rows[i].Cells[1].Value.ToString())
                {
                    int oq = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    int nw = 1 + oq;
                    //DataTable pdt = ps.GetProducts("Product_ID", lb_product.SelectedValue.ToString());

                    double tot = nw * double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    dataGridView1.Rows[i].Cells[3].Value = nw;
                    dataGridView1.Rows[i].Cells[5].Value = tot;
                    //  calc();
                    net();
                    return;

                }
            }
            DataTable pdt = ps.GetProducts("Product_ID", listBox1.SelectedValue.ToString());
            string uprice = pdt.Rows[0][2].ToString();
            double total = double.Parse(uprice);
            dataGridView1.Rows.Add("Delete", listBox1.SelectedValue, listBox1.Text, 1, uprice, total.ToString());
            //   calc();
            net();
        }

        private void lb_cat_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < lb_cat.Items.Count)
            {
                Graphics g = e.Graphics;

                // Background Color
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(101, 156, 0) : Color.White);
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                //string itemText = lb_shift.Items[itemIndex].ToString();
                string itemText = lb_cat.GetItemText(lb_cat.Items[e.Index]);

                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.White) : new SolidBrush(Color.Black);
                g.DrawString(itemText, e.Font, itemTextColorBrush, lb_cat.GetItemRectangle(itemIndex).Location);

                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }
        }
    }
}