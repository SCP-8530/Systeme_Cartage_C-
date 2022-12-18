using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final
{
    internal class Fee : Utilisateur
    {
        //Attribut
        private string proprietaire_de;

        //Get-Set
        public string ProprietaireDe
        {
            get { return proprietaire_de; }
            set {
                    if (value == "Langitia")
                        proprietaire_de = value;
                    else if (value == "Lurminia")
                        proprietaire_de = value;
                    else if (value == "Technoria")
                        proprietaire_de = value;
                    else if (value == "Cartage")
                        proprietaire_de = value;
                    else if (value == "Vierde")
                        proprietaire_de = value;
            }
        }

        //Construct
        public Fee()
        {
            Console.WriteLine("Utilisateur creer");
        }

        public Fee(
            string p_matricule = "",
            string p_nom = "",
            int p_droit = 3, //les fee ont automatiquement un droit admin
            string p_proprietaire_de = ""
            ):base(p_matricule,p_nom,p_droit)
        {
            this.matricule = p_matricule;
            this.nom = p_nom;
            this.droit = p_droit;
            this.proprietaire_de = p_proprietaire_de;

            Console.WriteLine("Utilisateur creer");
        }
    
        //Methode
    }
}
