using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eindopdracht_periode_4_museum_applicatie
{
    public partial class HeaderStrip : UserControl
    {

        Point dragCursorPoint = new Point();
        Point dragFormpoint = new Point();

        bool ingedrukt = false;

        public HeaderStrip()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form form = (Form)Parent;
            form.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Form form = (Form)Parent;
            form.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxNorm_Click(object sender, EventArgs e)
        {
            Form form = (Form)Parent;
            if (form.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Maximized;
                btnMaxNorm.Text = "-";
            }
            else if (form.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Normal;
                btnMaxNorm.Text = "+";
            }
        }

        private void HeaderStrip_Load(object sender, EventArgs e)
        {
            Form form = (Form)Parent;
        }

        private void HeaderStrip_MouseDown(object sender, MouseEventArgs e)
        {
            Form form = (Form)Parent;
            dragCursorPoint = Cursor.Position;
            dragFormpoint = form.Location;
            ingedrukt = true;
        }

        private void HeaderStrip_MouseMove(object sender, MouseEventArgs e)
        {
            Form form = (Form)Parent;

            if (ingedrukt == true)
            {    
                if (ingedrukt)
                {
                    Point dif = Point.Subtract(MousePosition, (Size)dragCursorPoint);
                    form.Location = Point.Add(dragFormpoint, (Size)dif);
                }
            }
        }

        private void HeaderStrip_MouseUp(object sender, MouseEventArgs e)
        {
            Form form = (Form)Parent;
            ingedrukt = false;
        }
    }
}
