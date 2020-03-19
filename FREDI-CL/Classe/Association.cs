using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FREDI_CL.Classes
{
    class Association
    {
        private String nom;
        private String tarifRemboursement;
        private String adresseRue;
        private String adresseVille;
        private String cp;
        private String telephone;

        public string Nom { get => nom; set => nom = value; }
        public string TarifRemboursement { get => tarifRemboursement; set => tarifRemboursement = value; }
        public string AdresseRue { get => adresseRue; set => adresseRue = value; }
        public string AdresseVille { get => adresseVille; set => adresseVille = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Telephone { get => telephone; set => telephone = value; }
    }
}
