using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final
{
    internal class Crystalien : Utilisateur
    {
        //Attribut
        private string habitant;
        public List<Mission> lstMission;

        //Get-Set
        public string Habitant
        {
            get { return habitant; }
            set {
                if (value == "Langitia")
                    habitant = value;
                else if (value == "Lurminia")
                    habitant = value;
                else if (value == "Technoria")
                    habitant = value;
                else if (value == "Cartage")
                    habitant = value;
                else if (value == "Vierde")
                    habitant = value;
                else habitant = "";
            }
        }

        //Construct
        public Crystalien()
        {
            Console.WriteLine("Utilisateur creer");
        }

        public Crystalien(
            string p_matricule = "",
            string p_nom = "",
            int p_droit = 0,
            string p_habitant = ""
            ):base(p_matricule,p_nom,p_droit)
        {
            this.matricule = p_matricule;
            this.nom = p_nom;
            this.droit = p_droit;
            this.habitant= p_habitant;

            Console.WriteLine("Utilisateur creer");
        }

        //Methode
        public void Save()
        {

        }
    }
}
