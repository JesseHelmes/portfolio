using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace Corona_project
{

    public partial class frmTopo : Form
    {
       
        string[] provinces = { "Gelderland", "Drenthe", "Overijsel", "Groningen", "Friesland", "Flevoland", "Utrecht",
                                    "Noord-Brabant", "Limburg", "Zeeland", "Zuid-Holland", "Noord-Holland" };
        string[] rprovinces;

        int points;
        int currentIndex;
        public frmTopo()
        {
            InitializeComponent();


        }
        
        private void frmTopo_Load(object sender, EventArgs e)
        {
            lbxAnswer.Items.Clear();
            lblCurrentPoints.Text = points.ToString();

            points = 0;
            currentIndex = 0;

            Random randy = new Random();
            int rindex;

            for (int i = 0; i < provinces.Length; i++)
            {
                rindex = province(randy);
            }
            askQuest();

            pcbMap.Image = Corona_project.Properties.Resources.knp;
        }

        private void askQuest()
        {
            lblProvince.Text = rprovinces[currentIndex];
        }

        private int province(Random randy)
        {
            
            int rindex;
            {
                do
                {
                    rindex = randy.Next(provinces.Length);
                } while (lbxAnswer.Items.IndexOf(provinces[rindex]) != -1);
                //var query = provinces.Select((province, index) => new { rindex, str = province.Substring(0) });
                Console.WriteLine("{0}", provinces[rindex]);
                lbxAnswer.Items.Add(provinces[rindex]);
                rprovinces = lbxAnswer.Items.OfType<string>().ToArray();
            }
            
            return rindex;
        }


        public void ShowMessageBox(string str)
        {
            string message = "Gefeliciteerd je bent klaar an hebt " + str + " punten behaald!";
            string caption = "Finished";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message + "\n" + "Will je opnieuw proberen?", caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                frmTopo frmTopo = new frmTopo();
                frmTopo.Show();
                this.Dispose(false);

            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                this.Close();
            }
        }

        private void ShowMessageBox()
        {
            
            ShowMessageBox(lblCurrentPoints.Text);
            
        }

        private void btnGroningen_Click(object sender, EventArgs e)
        {
            if (lblProvince != null)
            {

                if (lblProvince.Text == "Groningen")
                {
                    points += 1;
                    lblCurrentPoints.Text = points.ToString();
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
                else if (lblProvince.Text != "Groningen")
                {
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
            }
        }

        private void btnFriesland_Click(object sender, EventArgs e)
        {
            if (lblProvince != null)
            {

                if (lblProvince.Text == "Friesland")
                {
                    points += 1;
                    lblCurrentPoints.Text = points.ToString();
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
                else if (lblProvince.Text != "Friesland")
                {
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
            }
        }

        private void btnDrenthe_Click(object sender, EventArgs e)
        {
            if (lblProvince != null)
            {

                if (lblProvince.Text == "Drenthe")
                {
                    points += 1;
                    lblCurrentPoints.Text = points.ToString();
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
                else if (lblProvince.Text != "Drenthe")
                {
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
            }
        }

        private void btnOverijsel_Click(object sender, EventArgs e)
        {
            if (lblProvince != null)
            {

                if (lblProvince.Text == "Overijsel")
                {
                    points += 1;
                    lblCurrentPoints.Text = points.ToString();
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
                else if (lblProvince.Text != "Overijsel")
                {
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
            }
        }

        private void btnFelevoland_Click(object sender, EventArgs e)
        {
            if (lblProvince != null)
            {

                if (lblProvince.Text == "Flevoland")
                {
                    points += 1;
                    lblCurrentPoints.Text = points.ToString();
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
                else if (lblProvince.Text != "Flevoland")
                {
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
            }
        }

        private void btnNoordHolland_Click(object sender, EventArgs e)
        {
            if (lblProvince != null)
            {

                if (lblProvince.Text == "Noord-Holland")
                {
                    points += 1;
                    lblCurrentPoints.Text = points.ToString();
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
                else if (lblProvince.Text != "Noord-Holland")
                {
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
            }
        }

        private void btnUtrecht_Click(object sender, EventArgs e)
        {
            if (lblProvince != null)
            {

                if (lblProvince.Text == "Utrecht")
                {
                    points += 1;
                    lblCurrentPoints.Text = points.ToString();
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
                else if (lblProvince.Text != "Utrecht")
                {
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
            }
        }

        private void btnGelderland_Click(object sender, EventArgs e)
        {
            if (lblProvince != null)
            {

                if (lblProvince.Text == "Gelderland")
                {
                    points += 1;
                    lblCurrentPoints.Text = points.ToString();
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
                else if (lblProvince.Text != "Gelderland")
                {
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
            }
        }

        private void btnZuidHolland_Click(object sender, EventArgs e)
        {
            if (lblProvince != null)
            {

                if (lblProvince.Text == "Zuid-Holland")
                {
                    points += 1;
                    lblCurrentPoints.Text = points.ToString();
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
                else if (lblProvince.Text != "Zuid-Holland")
                {
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
            }
        }

        private void btnNoordBrabant_Click(object sender, EventArgs e)
        {
            if (lblProvince != null)
            {

                if (lblProvince.Text == "Noord-Brabant")
                {
                    points += 1;
                    lblCurrentPoints.Text = points.ToString();
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
                else if (lblProvince.Text != "Noord-Brabant")
                {
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
            }
        }

        private void btnZeeland_Click(object sender, EventArgs e)
        {
            if (lblProvince != null)
            {

                if (lblProvince.Text == "Zeeland")
                {
                    points += 1;
                    lblCurrentPoints.Text = points.ToString();
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
                else if (lblProvince.Text != "Zeeland")
                {
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
            }
        }

        private void btnLimburg_Click(object sender, EventArgs e)
        {
            if (lblProvince != null)
            {

                if (lblProvince.Text == "Limburg")
                {
                    points += 1;
                    lblCurrentPoints.Text = points.ToString();
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
                else if (lblProvince.Text != "Limburg")
                {
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
            }
        }
    }



}
