using NederlandsEnEngels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corona_project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Load form 
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        //Klik op Button Rekenspel
        private void btnRekenSpel_Click(object sender, EventArgs e)
        {
            frmRekenspel frs = new frmRekenspel();
            frs.Show();
        }

        //Klik op Button Topospel
        private void btnTopoSpel_Click(object sender, EventArgs e)
        {
            frmTopo frt = new frmTopo();
            frt.Show();
        }

        //Klik op Button Nederland&Engels
        private void btnNederlandsEngelsSpel_Click(object sender, EventArgs e)
        {
            frmNederlandsEngels fne = new frmNederlandsEngels();
            fne.Show();
        }

        //Klik op Button TekenCanvas
        private void btnTekenCanvas_Click(object sender, EventArgs e)
        {
            tekenCanvasFrm tcf = new tekenCanvasFrm();
            tcf.Show();
        }

        //Klik op Button Verkeer
        private void btnVerkeerSpel_Click(object sender, EventArgs e)
        {
            verkeerFrm vkr = new verkeerFrm();
            vkr.Show();
        }


    }
}
