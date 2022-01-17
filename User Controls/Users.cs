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
    public partial class Users : UserControl
    {
        private static Users _UUC;
        public static Users UUC
        {
            get
            {
                if (_UUC == null)
                    _UUC = new Users();
                return _UUC;
            }
        }
        int uid = -1;
        projectsp.projectstored ps = new projectsp.projectstored();
        public Users()
        {
            InitializeComponent();
            autocomplete();
            rb_admin.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void Users_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
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

        private void button6_Click(object sender, EventArgs e)
        {
            Searchpanel.Width = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_pass.Text = "";
            txt_name.Text = "";
            uid = -1;
        }
        public void autocomplete()
        {
            searchtextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchtextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            DataTable dt = ps.Getusers();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                {
                    string name = dt.Rows[i]["User_Name"].ToString();
                    col.Add(name);
                }
            }

            searchtextBox.AutoCompleteCustomSource = col;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int type = 0;
            if (rb_admin.Checked) type = 1;
            else if (rb_cash.Checked) type = 2;
               
            if (txt_name.Text == "")
            {
                txt_name.Focus();
                MessageBox.Show("يجب ادخال اسم المستخدم");
            }
            else  if (txt_pass.Text == "")
            {
                txt_pass.Focus();
                MessageBox.Show("يجب ادخال كلمه المرور");
            }
            else
            {
                if (ps.InsertNewUser(txt_name.Text,txt_pass.Text,type))
                {
                    MessageBox.Show("تم ادخال المستخدم بنجاح");
                    autocomplete();
                    button3_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("حدث خطا بالتسجيل");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int type = 0;
            if (rb_admin.Checked) type = 1;
            else if (rb_cash.Checked) type = 2;

            if(uid==-1)
            {
                MessageBox.Show("حدث خطا في التحديث");
            }
            else if (txt_name.Text == "")
            {
                txt_name.Focus();
                MessageBox.Show("يجب ادخال اسم المستخدم");
            }
            else if (txt_pass.Text == "")
            {
                txt_pass.Focus();
                MessageBox.Show("يجب ادخال كلمه المرور");
            }
            else
            {
                if (ps.UpdateUser(uid,txt_name.Text, txt_pass.Text, type))
                {
                    MessageBox.Show("تم تحديث المستخدم بنجاح");
                    autocomplete();
                    button3_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("حدث خطا في التحديث");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (uid != -1)
            {
                ps.DeleteUser(uid);
                autocomplete();
                MessageBox.Show("تم حذف المستخدم بنجاح");
            }
            else
            {
                MessageBox.Show("حدث خطا في الحذف");
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = ps.Getusers("User_Name", searchtextBox.Text);
            if (dt.Rows.Count == 1)
            {
                uid = int.Parse(dt.Rows[0][0].ToString());
                txt_name.Text = dt.Rows[0][1].ToString();
                txt_pass.Text = dt.Rows[0][2].ToString();
                int t =  Convert.ToInt32(dt.Rows[0][3]);
                if (t == 1)
                    rb_admin.Checked = true;
                else rb_cash.Checked = true;
            }
            else
            {
                MessageBox.Show("لم يتم العثور علي مستخدم");

            }
        }
    }
}
