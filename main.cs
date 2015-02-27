using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace irogami
{
    public partial class main : Form
    {
        public bool mousePressed = false;
        public Point mousePoint;

        int colorR = 255;
        int colorG = 255;
        int colorB = 255;

        public main()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = 200;
            this.Height = 200;

            textBoxColorCode.SelectionStart = Int32.MaxValue;
            textBoxColorCode.SelectionLength = Int32.MaxValue;

            checkColorCode(textBoxColorCode.Text);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            var g = pe.Graphics;
            SolidBrush b = new SolidBrush(Color.FromArgb(255, colorR, colorG, colorB));
            g.FillRectangle(b, 0, 0, Width, Height);
        }

        private void textBoxColorCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void main_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                mousePressed = true;
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void main_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
        }

        private void main_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (mousePressed == true)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
                Invalidate();
            }
        }

        private void textBoxColorCode_TextChanged(object sender, EventArgs e)
        {
            checkColorCode(textBoxColorCode.Text);
        }

        private void checkColorCode(string colorCodeStr)
        {
            if (colorCodeStr.Length != 7) return;
            if (colorCodeStr.Substring(0, 1) != "#") return;

            string strR = colorCodeStr.Substring(1, 2);
            string strG = colorCodeStr.Substring(3, 2);
            string strB = colorCodeStr.Substring(5, 2);

            colorR = int.Parse(strR, System.Globalization.NumberStyles.HexNumber);
            colorG = int.Parse(strG, System.Globalization.NumberStyles.HexNumber);
            colorB = int.Parse(strB, System.Globalization.NumberStyles.HexNumber);

            Invalidate();
        }

    }
}
