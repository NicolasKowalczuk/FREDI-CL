using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FREDI_CL
{
    class Deplacement
    {
        private DateTime date;
        private Lieu lieuDepart;
        private Lieu lieuArrive;
        private Double remboursementPeage;
        private Double remboursementRepas;
        private Double remboursementNuite;
        private List<NoteDeFrais> lesNotesDeFrais = new List<NoteDeFrais>();

        public DateTime Date { get => date; set => date = value; }
        public double RemboursementPeage { get => remboursementPeage; set => remboursementPeage = value; }
        public double RemboursementRepas { get => remboursementRepas; set => remboursementRepas = value; }
        public double RemboursementNuite { get => remboursementNuite; set => remboursementNuite = value; }
        internal Lieu LieuDepart { get => lieuDepart; set => lieuDepart = value; }
        internal Lieu LieuArrive { get => lieuArrive; set => lieuArrive = value; }
        internal List<NoteDeFrais> LesNotesDeFrais { get => lesNotesDeFrais; set => lesNotesDeFrais = value; }

        public void ajouteNoteDeFrais(NoteDeFrais uneNDF)
        {
            this.lesNotesDeFrais.Add(uneNDF);
        }
    }
}
