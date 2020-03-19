using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FREDI_CL.Classes
{
    class Lieu
    {
        private String ville;
        private String adresseRue;
        private String cp;

        public string Ville { get => ville; set => ville = value; }
        public string AdresseRue { get => adresseRue; set => adresseRue = value; }
        public string Cp { get => cp; set => cp = value; }
    }
}
