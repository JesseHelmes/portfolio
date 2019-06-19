using System.Drawing;
using System.Windows.Forms;

namespace toetsPeriode2_opdracht_2
{
    class Auto
    {
        //constructor
        public Auto(PictureBox pictureBox, string merk, int bouwjaar)
        {
            _pictureBox = pictureBox;
            _Merk = merk;
            _Bouwjaar = bouwjaar;
        }
        //variable

        //private Point _Middelpunt = new Point(0, 0);
        private PictureBox _pictureBox = new PictureBox();
        private string _Merk;
        private int _Bouwjaar;

        // hier controleert die de bouwjaar, dan merk en dan geeft die de inruilwaarde
        public void inruilwaarde(Label label)
        {
            if(_Bouwjaar >= 2015)
            {
                if (_Merk == "Ford")
                {
                    label.Text = "8000";
                }
                else
                {
                    label.Text = "5500";
                }
            }

            else if (_Bouwjaar <= 2015)
            {
                if (_Merk == "Ford")
                {
                    label.Text = "2500";
                }
                else
                {
                    label.Text = "1000";
                }
            }
        }

        // hier teken je de auto
        public void teken()
        {
            Pen myPen = new Pen(Color.Black, 1);
            Graphics paper = _pictureBox.CreateGraphics();
            paper.DrawRectangle(myPen, 30, 30, 250, 90);
            paper.DrawEllipse(myPen, 12, 67, 50, 100);
            paper.DrawEllipse(myPen, 256, 67, 50, 100);
        }
    }
}