using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final
{
    internal class Mission
    {
        //Attribut
        private string identifiant;
        private Crystalien mission_pour;
        private Utilisateur mission_de;
        private int statue;

        //Get-Set
        public string Identifiant
        {
            get { return identifiant; }
            set { identifiant = value; }
        }

        public Crystalien MissionPour 
        {
            get { return mission_pour;}
            set { mission_pour = value;}
        }

        public Utilisateur MissionDe
        {
            get { return mission_de;}
            set { mission_de = value;}
        }

        public int Statue 
        {
            get { return statue;}
            set { statue = value;} 
        }
    }

}
