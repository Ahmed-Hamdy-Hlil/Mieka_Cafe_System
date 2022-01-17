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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            bunifuFormFadeTransition1.ShowAsyc(this);
        }
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //LinearGradientBrush linearGradientBrush = new LinearGradientBrush(panel1.ClientRectangle, Color.FromArgb(156, 156, 156), Color.FromArgb(255, 255, 255), 45);
            //ColorBlend cblend = new ColorBlend(3);
            //cblend.Colors = new Color[3] { Color.FromArgb(156, 156, 156), Color.FromArgb(255, 255, 255), Color.FromArgb(156, 156, 156) };
            //cblend.Positions = new float[3] { 0f, 0.5f, 1f };
            //linearGradientBrush.InterpolationColors = cblend;
            //e.Graphics.FillRectangle(linearGradientBrush, panel1.ClientRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
