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
    public partial class Product : UserControl
    {
        private static Product _PUC;
        public static Product PUC
        {
            get
            {
                if (_PUC == null)
                    _PUC = new Product();
                return _PUC;
            }
        }
        public Product()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.BackColor = Color.Transparent;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            ps.fillcombo(cm_cat, ps.GetCategoriesOrdered(), "Category_Name", "Category_ID", "اختر اسم الفئه");
            autocomplete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Searchpanel.Width = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Searchpanel.Width==0)
            {
                Searchpanel.Width = 200;
            }
            else
            {
                Searchpanel.Width = 0;
            }
        }
        int pid = -1;
        projectsp.projectstored ps = new projectsp.projectstored();
        private void button3_Click(object sender, EventArgs e)
        {
            cm_cat.SelectedIndex = 0;
            txt_name.Text = "";
            txt_price.Text = "";
        }
        public void autocomplete()
        {
            searchtextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchtextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            DataTable dt = ps.GetProducts();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                {
                    string name = dt.Rows[i]["Product_Name"].ToString();
                    col.Add(name);
                }
            }

            searchtextBox.AutoCompleteCustomSource = col;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double price = 0;
            if (cm_cat.SelectedIndex == 0)
                MessageBox.Show("يجب اختيار فئه");
            else if (txt_name.Text == "")
                MessageBox.Show("يجب ادخال اسم المنتج");
            else if (txt_price.Text == "")
                MessageBox.Show("يجب ادخال سعر المنتج");
            else if (!double.TryParse(txt_price.Text, out price))
                MessageBox.Show("يجب ان يكون سعر المنتج رقم");
            else
            {
                if (ps.InsertNewProduct(txt_name.Text, price, Convert.ToInt32(cm_cat.SelectedValue)))
                {
                    MessageBox.Show("تم ادخال المنتج بنجاح");
                    autocomplete();
                    //button3_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("حدث خطا بالتسجيل");
                }
            }


        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = ps.GetProducts("Product_Name", searchtextBox.Text);
            if (dt.Rows.Count == 1)
            {
                pid = int.Parse(dt.Rows[0][0].ToString());
                txt_name.Text = dt.Rows[0][1].ToString();
                txt_price.Text = dt.Rows[0][2].ToString();
                cm_cat.SelectedValue = dt.Rows[0][3];
            }
            else
            {
                MessageBox.Show("لم يتم العثور علي المنتج");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pid != -1)
            {
                ps.DeleteProduct(pid);
                autocomplete();
                MessageBox.Show("تم حذف المنتج بنجاح");
            }
            else
            {
                MessageBox.Show("حدث خطا في الحذف");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double price = 0;
            if (pid == -1)
                MessageBox.Show("حدث خطا في التحديث");
            else if (cm_cat.SelectedIndex == 0)
                MessageBox.Show("يجب اختيار فئه");
            else if (txt_name.Text == "")
                MessageBox.Show("يجب ادخال اسم المنتج");
            else if (txt_price.Text == "")
                MessageBox.Show("يجب ادخال سعر المنتج");
            else if (!double.TryParse(txt_price.Text, out price))
                MessageBox.Show("يجب ان يكون سعر المنتج رقم");
            else
            {
                if (ps.UpdateProduct(pid, txt_name.Text, price, Convert.ToInt32(cm_cat.SelectedValue)))
                {
                    MessageBox.Show("تم تحديث المنتج بنجاح");
                    autocomplete();
                    button3_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("حدث خطا في التحديث");
                }
            }
        }

        private void cm_cat_MouseHover(object sender, EventArgs e)
        {
            DataTable dt = ps.GetCategoriesOrdered();
            if (cm_cat.Items.Count != dt.Rows.Count + 1) 
            {
                ps.fillcombo(cm_cat, ps.GetCategoriesOrdered(), "Category_Name", "Category_ID", "اختر اسم الفئه");
            }
        }

        private void Product_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void Product_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Product_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                button4_Click(sender, e);
            }

        }

        private void txt_name_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4_Click(sender, e);
            }
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_price_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4_Click(sender, e);
            }
        }
    }
}
