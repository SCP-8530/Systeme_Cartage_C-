using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Final
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
            this.L_Error.Hide();
        }

        private void B_Login_Click(object sender, EventArgs e)
        {
            //reset erreur
            this.L_Error.Hide();
            
            //recuperation du matricule
            SClass.Matricule = this.TB_Login.Text;

            // # Normalement je devrai faire une verification du matricule
            // # pseudo-code :
            // # boucle qui regarde chaque crystalien et fee
            // # si le matricule dans l'objet est pareil a celui du textbox
            // # mettre le matricule dans la class static et lance ChangeMenu avec le value celon le droit de l'utilisateur
            // # si rien est trouver, afficher l'erreur 

            //fermeture de la page # (si matricule est correct)
            this.Close();
           
        }
    }
}
