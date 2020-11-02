using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corona_project
{
    /*



        zover heb ik dit nog noet werkent gekregen

        het lukt mij niet of van af hier de form te sluiten en een niewe te openen



    */

    class EndMessage 
    {
        public static void ShowMessageBox(string str)
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
                frmTopo.Focus();
                if (Application.OpenForms[0].Name == "frmTopo")
                {
                    Application.OpenForms[0].Close();
                }

            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                Application.OpenForms["frmTopo"].Close();
            }
        }

        
            
        
    }
}
