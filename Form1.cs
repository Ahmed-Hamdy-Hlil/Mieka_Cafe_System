using Sales.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        //------------drop shadow

        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            max.Visible = false;
            restore.Visible = true;
        }

        private void restore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            max.Visible = true;
            restore.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void titlepanel_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(panel3.ClientRectangle, Color.FromArgb(156, 156, 156), Color.FromArgb(255, 255, 255), 45);
            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.FromArgb(156, 156, 156), Color.FromArgb(255, 255, 255), Color.FromArgb(156, 156, 156) };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };
            linearGradientBrush.InterpolationColors = cblend;
            e.Graphics.FillRectangle(linearGradientBrush, panel3.ClientRectangle);
        }
        projectsp.projectstored ps = new projectsp.projectstored();

        private void button1_Click(object sender, EventArgs e)
        {
            if (ps.GetCurrentShift() == 0)
            {
                MessageBox.Show("يجب بدا الشيفت");
            }
            else
            {
                if (!panel3.Controls.Contains(Billing.BUC))
                {
                    panel3.Controls.Add(Billing.BUC);
                    Billing.BUC.BringToFront();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Users.UUC))
            {
                panel3.Controls.Add(Users.UUC);
                Users.UUC.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Product.PUC))
            {
                panel3.Controls.Add(Product.PUC);
                Product.PUC.BringToFront();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Categories.CUC))
            {
                panel3.Controls.Add(Categories.CUC);
                Categories.CUC.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Shift.SUC))
            {
                panel3.Controls.Add(Shift.SUC);
                Shift.SUC.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Take_Away.TAUC))
            {
                panel3.Controls.Add(Take_Away.TAUC);
                Take_Away.TAUC.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Reports.REP))
            {
                panel3.Controls.Add(Reports.REP);
                Reports.REP.BringToFront();
            }
        }
    }
}
