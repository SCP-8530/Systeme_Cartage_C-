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
        private int identifiant;
        private string mission_pour;
        private string mission_de;
        private string description;
        private int statue;

        //Get-Set
        public int Identifiant
        {
            get { return identifiant; }
            set { identifiant = value; }
        }

        public string MissionPour 
        {
            get { return mission_pour;}
            set { mission_pour = value;}
        }

        public string MissionDe
        {
            get { return mission_de;}
            set { mission_de = value;}
        }

        public string Description
        {
            get { return description;}
            set { description = value;}
        }

        public int Statue 
        {
            get { return statue;}
            set { statue = value;} 
        }
    }

}
