using System;
using System.CodeDom;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //modification graphique
            // # ChangerMenu("login");

            //charger les donne de la base de donne
            adoNET Ado = new adoNET();
            string Query = "Select * from Crystalien;";
            Ado.Command.CommandText = Query;
            Ado.Command.Connection = Ado.Connection;
            Ado.Adapter.SelectCommand = Ado.Command;
            Ado.Adapter.Fill(Ado.DsCartage);
            //chargement des crystaliens
            Ado.DtCrystalien = Ado.DsCartage.Tables[Name="Crystalien"];
            SClass.LstCR = new List<Crystalien> { };
            foreach (DataRow row in Ado.DtCrystalien.Rows)
            {
                Crystalien user = new Crystalien();
                user.Matricule = row[0].ToString();
                user.Nom = row[1].ToString();
                user.Droit = int.Parse(row[2].ToString());
                user.Habitant = row[3].ToString();
                SClass.LstCR.Add(user);
            }
            //chargement des fee
            Ado.DtFee = Ado.DsCartage.Tables[Name = "Fee"];
            SClass.LstFC = new List<Fee> { };
            foreach (DataRow row in Ado.DtFee.Rows)
            {
                Fee user = new Fee();
                user.Matricule = row[0].ToString();
                user.Nom = row[1].ToString();
                user.Droit = 3; 
                user.ProprietaireDe = row[3].ToString();
                SClass.LstFC.Add(user);
            }
            //chargement des mission
            //chargement des fee
            Ado.DtMission = Ado.DsCartage.Tables[Name = "Mission"];
            SClass.LstMS = new List<Mission> { };
            foreach (DataRow row in Ado.DtFee.Rows)
            {
                Mission user = new Mission();
                user.Identifiant = int.Parse(row[0].ToString());
                user.MissionPour = new Crystalien(p_matricule = row[1].ToString());
                user.MissionDe = new Utilisateur(p_martricule = row[2].ToString());
                user.Description = row[3].ToString();
                user.Statue = int.Parse(row[4].ToString());
                SClass.LstFC.Add(user);
            }
        }

        /// <summary>
        /// Gere l'affichage des menue necessaire celon les droits de l'utilisateur
        /// </summary>
        /// <param name="value">type de changement a faire</param>
        public void ChangerMenu(string value)
        {
            if (value == "connection") //Apres une connection (base)
            {
                //connection
                this.ML_Connecter.Visible = false;
                this.ML_NewCompte.Visible = false;
                this.ML_Deconneter.Visible = true;
                //outils
                this.M_Outils.Visible = true;
            }
            if (value == "login") //demarrage de l'application
            {
                //connection
                this.ML_Deconneter.Visible = false;
                //outils
                this.M_Outils.Visible= false;
                this.ML_listCrystalien.Visible = false;
            }
            if (value == "deconnection") //deconnection
            {
                //connection
                this.ML_Connecter.Visible = true;
                this.ML_NewCompte.Visible = true;
                this.ML_Deconneter.Visible = false;
                //outils
                this.M_Outils.Visible = false;
                this.ML_listCrystalien.Visible=false;
                this.ML_AjoutMission.Visible = false;
            }
            if (value == "admin") //connection d'un admin
            {
                this.ML_listCrystalien.Visible=true;
                this.ML_AjoutMission.Visible=true;
            }
            if (value == "mod") //connection d'un archiviste
            {
                this.ML_AjoutMission.Visible=true;
            }
        }

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionForm formulaire = new ConnectionForm();
            formulaire.MdiParent = this;
            formulaire.Show();
        }

        private void ML_NewCompte_Click(object sender, EventArgs e)
        {
            CreationForm formulaire = new CreationForm();
            formulaire.MdiParent = this;
            formulaire.Show();
        }

        private void listeDesCrystaliensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCrystalien formulaire = new ListCrystalien();
            formulaire.MdiParent = this;
            formulaire.Show();
        }

        private void ajouteUneMissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutMission formulaire = new AjoutMission();
            formulaire.MdiParent = this;
            formulaire.Show();
        }

        private void ML_Deconneter_Click(object sender, EventArgs e)
        {
            //fermeture de toute les formulaires
            this.ActiveMdiChild.Close();

            //desactiver les menus
            ChangerMenu("deconnection");
        }

        private void ML_listMission_Click(object sender, EventArgs e)
        {

        }
    }
}
