using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Corona_project
{
    public partial class tekenCanvasFrm : Form
    {
        private Button[] toolBtns;
        private int x = -1, y = -1;
        private bool moving = false;
        private Graphics paper;
        private Pen pen, eraser;
        private Bitmap buffer;

        /*
        ToDo

        */

        /*paint
        https://www.youtube.com/watch?v=xyEG1e5Gnic
        keep graphics
        https://www.youtube.com/watch?v=txKQoqeSuRA

        */
        public tekenCanvasFrm()
        {
            InitializeComponent();
            btnPen.BackColor = Color.LightSteelBlue;
            toolBtns = new Button[] { btnEraser, btnPen };
            pen = new Pen(colorPicker.Color);
            currentColorBox.BackColor = colorPicker.Color;
            eraser = new Pen(canvasPicBox.BackColor);
            pen.StartCap = pen.EndCap = LineCap.Round;
        }

        private void tekenCanvasFrm_Load(object sender, EventArgs e)
        {
            buffer = new Bitmap(canvasPicBox.ClientSize.Width, canvasPicBox.ClientSize.Height, PixelFormat.Format32bppArgb);
            this.WindowState = FormWindowState.Normal;
            paper = Graphics.FromImage(buffer);
            paper.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorPicker.Color;
                currentColorBox.BackColor = colorPicker.Color;
            }
        }

        private void canvasPicBox_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
        }

        private void canvasPicBox_MouseDown(object sender, MouseEventArgs e)
        {
            float size = (float)brushSize.Value;
            pen.Width = size;
            moving = true;
            x = e.X;
            y = e.Y;
            canvasPicBox.Cursor = Cursors.Cross;
        }

        private void canvasPicBox_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            canvasPicBox.Cursor = Cursors.Default;
        }

        private void canvasPicBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                paper.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
                canvasPicBox.Invalidate();
            }
        }

        private void btnWissen_Click(object sender, EventArgs e)
        {
            paper.Clear(canvasPicBox.BackColor);
            canvasPicBox.Invalidate();
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            pen.Color = eraser.Color;
            resetToolSelection();
            btnEraser.BackColor = Color.LightSteelBlue;
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            pen.Color = colorPicker.Color;
            resetToolSelection();
            btnPen.BackColor = Color.LightSteelBlue;
        }

        private void resetToolSelection()
        {
            for (int i = 0; i < toolBtns.Length; i++)
            {
                toolBtns[i].BackColor = Color.LightGray;
            }
        }

        private void canvasPicBox_SizeChanged(object sender, EventArgs e)
        {
            canvasPicBox.Invalidate();
        }

        private void canvasPicBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(buffer, 0, 0);
        }
    }
}
