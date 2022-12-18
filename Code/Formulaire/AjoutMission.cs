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
    public partial class AjoutMission : Form
    {
        public AjoutMission()
        {
            InitializeComponent();
        }

        private void AjoutMission_Load(object sender, EventArgs e)
        {
            this.L_Erreur.Hide();
        }

        private void B_Creation_Click(object sender, EventArgs e)
        {
            //reset erreur
            this.L_Erreur.Hide();

            //verifier si le matricule existe
            bool present = false;
            foreach (Crystalien user in SClass.LstCR)
            {
                if (user.Matricule == this.TB_Matricule.Text) present = true;
            }

            if (present == false) //matricule qui n'existe pas
            {
                this.L_Erreur.Show();
            }
            else
            {
                //creation de la mission
                Mission mission = new Mission();
                mission.Identifiant = SClass.NbMission + 1;
                SClass.NbMission += 1;
                mission.MissionPour = this.TB_Matricule.Text;
                mission.MissionDe = SClass.Matricule;
                mission.Description = this.TB_Description.Text;
                mission.Statue = 0;

                //fermeture de la page
                this.Close();
            }

        }
    }
}
