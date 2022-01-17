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
    public partial class Categories : UserControl
    {
        private static Categories _CUC;
        public static Categories CUC
        {
            get
            {
                if (_CUC == null)
                    _CUC = new Categories();
                return _CUC;
            }
        }
        public Categories()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            autocomplete();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Searchpanel.Width = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Searchpanel.Width == 0)
            {
                Searchpanel.Width = 200;
            }
            else
            {
                Searchpanel.Width = 0;
            }
        }
        int cat_id = -1;
        projectsp.projectstored ps = new projectsp.projectstored();
        private void button3_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            cat_id = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                txt_name.Focus();
                MessageBox.Show("يجب ادخال اسم الفئه");
            }
            else
            {
                if (ps.InsertNewCategory(txt_name.Text))
                {
                    MessageBox.Show("تم ادخال الفئه بنجاح");
                    autocomplete();
                    button3_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("حدث خطا بالتسجيل");
                }
            }
        }
        public void autocomplete()
        {
            searchtextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchtextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            DataTable dt = ps.GetCategories();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                {
                    string name = dt.Rows[i]["Category_Name"].ToString();
                    col.Add(name);
                }
            }

            searchtextBox.AutoCompleteCustomSource = col;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cat_id != -1)
            {
                ps.DeleteCategory(cat_id);
                autocomplete();
                MessageBox.Show("تم حذف الفئه بنجاح");
            }
            else
            {
                MessageBox.Show("حدث خطا في الحذف");
            }
        }


        private void searchbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = ps.GetCategories("Category_Name", searchtextBox.Text);
            if (dt.Rows.Count == 1)
            {
                cat_id = int.Parse(dt.Rows[0][0].ToString());
                txt_name.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("لم يتم العثور علي الفئه");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cat_id == -1)
            {
                MessageBox.Show("حدث خطا في التحديث");
            }
            else if (txt_name.Text == "")
            {
                txt_name.Focus();
                MessageBox.Show("يجب ادخال اسم الفئه");
            }
            else
            {
                if (ps.UpdateCategory(cat_id, txt_name.Text))
                {
                    MessageBox.Show("تم تحديث الفئه بنجاح");
                    autocomplete();
                    button3_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("حدث خطا في التحديث");
                }
            }
        }
    }
}
