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
    public partial class Shift : UserControl
    {
        private static Shift _SUC;
        public static Shift SUC
        {
            get
            {
                if (_SUC == null)
                    _SUC = new Shift();
                return _SUC;
            }
        }
        public Shift()
        {
            InitializeComponent();
        }
        projectsp.projectstored ps = new projectsp.projectstored();
        private void Shift_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ps.StartShift())
                MessageBox.Show("حدث خطا لم يتم غلق الشيفت السابق");
            else
            {
                MessageBox.Show("تم بدا الشيفت بنجاح");
                ps.ResetOrderNumber();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sid = ps.GetCurrentShift();
            if (sid == 0)
                MessageBox.Show("يجب بدا شيفت");
            else
            {
                if (ps.EndShift())
                {
                    MessageBox.Show("تم انهاء الشيفت بنجاج");
                    Report.ShiftItems f2 = new Report.ShiftItems();
                    f2.sid = sid;
                    f2.Show();
                    Report.ShiftCash f1 = new Report.ShiftCash();
                    f1.sid = sid;
                    f1.start = DateTime.Parse("1-1-2000");
                    f1.end = DateTime.Parse("1-1-2200");
                    f1.Show();

                }

                else
                    MessageBox.Show("لا يوجد شيفت حاليا");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sid = ps.GetCurrentShift();
            if (sid == 0)
                MessageBox.Show("يجب بدا شيفت");
            else
            {
                Report.ShiftItems f1 = new Report.ShiftItems();
                f1.sid = sid;
             
                f1.Show();
            }
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            int sid = ps.GetCurrentShift();
            if (sid == 0)
                MessageBox.Show("يجب بدا شيفت");
            else
            {
                Report.ShiftCash f1 = new Report.ShiftCash();
                f1.sid = sid;
                f1.start = DateTime.Parse("1-1-2000");
                f1.end = DateTime.Parse("1-1-2200");
                f1.Show();
            }
        }
    }
}
