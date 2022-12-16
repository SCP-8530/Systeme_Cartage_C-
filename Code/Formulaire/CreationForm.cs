using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Project_Final
{
    public partial class CreationForm : Form
    {
        public CreationForm()
        {
            InitializeComponent();
        }

        private void CreationForm_Load(object sender, EventArgs e)
        {
            this.L_Erreur.Hide();
        }

        private void Erreur(int value)
        {
            //Afficher le label
            Label E = this.L_Erreur;
            E.Show();

            //changer son message
            if (value == 1)
                E.Text = "Aucun matricule referrancer";
            else if (value == 2)
                E.Text = "Le format est pas valide (Exemple : CR2429)";
            else if (value == 3)
                E.Text = "Aucun nom referrancer";
            else if (value == 4)
                E.Text = "Aucune Habilitation selectionner";
            else if (value == 5)
                E.Text = "Aucune ile selectionner";
        }

        /// <summary>
        /// Recupere l'option de la combobox pour la traduire en int
        /// </summary>
        /// <returns></returns>
        private int TraductionCB_Droit() 
        { 
            //recupere le texte
            string T = this.CB_Droit.Text;

            //Traduction
            if (T == "Voyageur") return 1;
            else if (T == "Archiviste") return 2;
            else return 0;
        }

        private void B_Creation_Click(object sender, EventArgs e)
        {
            //reset erreur
            this.L_Erreur.Hide();

            //Recupere les valeurs
            string P_Matricule = this.TB_Matricule.Text;
            string P_Nom = this.TB_Nom.Text;
            int P_Droit = TraductionCB_Droit();
            string P_Habitant = this.CB_Habitant.Text;

            //Initialisation de la class et ajout des donnees
            Crystalien User = new Crystalien();
            User.Matricule = P_Matricule;
            User.Nom = P_Nom;
            User.Droit = P_Droit;
            User.Habitant = P_Habitant;

            //set regex
            Regex MatR = new Regex("^CR+\\d{4}$");

            //Validation des crystaliens            
            if (User.Matricule == "")
                this.Erreur(1);//Donne vide          
            else if (MatR.IsMatch(User.Matricule) == false)
                this.Erreur(2);//Matricule invalide            
            else if (User.Nom == "")
                this.Erreur(3);//Donne vide            
            else if (User.Droit == 0)
                this.Erreur(4);//Donne vide            
            else if (User.Habitant == "")
                this.Erreur(5);//Donne vide
            else //Tout est correct
            {
                MessageBox.Show("Compte creer!");
                User.Save();
                this.Close();
            }
        }
    }
}
