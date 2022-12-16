using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project_Final
{
    internal abstract class Utilisateur
    {
        //Attribut
        protected string matricule;
        protected string nom;
        protected int droit;

        //Get-Set
        public string Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Droit
        {
            get { return droit; }
            set { if (value >= 0 && value <= 3) { droit = value; } }
        }

        //Construct
        public Utilisateur(
            string p_martricule = "",
            string p_nom = "",
            int p_droit = 0)
        {
            this.matricule = p_martricule;
            this.nom = p_nom;
            this.droit = p_droit;
        }

        //Methode
        
    }
}
