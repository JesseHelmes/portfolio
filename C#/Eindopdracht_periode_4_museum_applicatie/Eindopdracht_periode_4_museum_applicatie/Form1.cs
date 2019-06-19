using System;
using System.Threading;
using System.Windows.Forms;

namespace Eindopdracht_periode_4_museum_applicatie
{
    public partial class FrmLogin : Form
    {
        string passwoord = "admin";
        string username = "admin";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string txtpassword = txtPassword.Text;
            string txtusername = txtUsername.Text;

            // controlleerd of wachtwoord en gebruikersnaam goed is
            if (passwoord == txtpassword && username == txtusername)
            {
                //dit sluit de LoginForm
                this.Dispose();
                // en hier onder open die de form met alles foto's
                Thread th = new Thread(opennewForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

                /*
                this.Hide();
                FrmMainMenu mainFrm = new FrmMainMenu();
                mainFrm.ShowDialog(); // Shows FrmMainMenu
                this.Close();*/
            }
            //dit hier onder gebeurd alleen als de wachtwoord of gebruikersnaam leeg is of fout is
            else if (txtpassword.Equals("") && txtusername.Equals(""))
            {             
                    //MessageBox.Show("uw wachtwoord en gebruikersnaam zijn nog leeg");
            }
            else if (txtpassword.Equals(""))
            {
                MessageBox.Show("uw wachtwoord bent u vergeten in te vullen");
            }
            else if (txtusername.Equals(""))
            {
                MessageBox.Show("uw gebruikersnaam bent u vergeten in te vullen");
            }
            else
            {
                MessageBox.Show("fout uw wachtwoord of gebruikersnaam zijn niet correct");
            }
        }

        //methode om een new MainMenu te runnen
        private void opennewForm(object obj)
        {
            Application.Run(new FrmMainMenu());
        }
    }
}