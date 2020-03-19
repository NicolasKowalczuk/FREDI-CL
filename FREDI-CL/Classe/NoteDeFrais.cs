using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FREDI_CL.Classes
{
    class NoteDeFrais
    {
        private Double montantPeage;
        private int nbRepas;
        private int nbNuitee;
        private Double km;
        private Boolean faireDon;
        private Licencie unLicencie;
        private Deplacement unDeplacement;

        public double MontantPeage { get => montantPeage; set => montantPeage = value; }
        public int NbRepas { get => nbRepas; set => nbRepas = value; }
        public int NbNuitee { get => nbNuitee; set => nbNuitee = value; }
        public double Km { get => km; set => km = value; }
        public bool FaireDon { get => faireDon; set => faireDon = value; }
        internal Licencie UnLicencie { get => unLicencie; set => unLicencie = value; }
        internal Deplacement UnDeplacement { get => unDeplacement; set => unDeplacement = value; }
    }
}
