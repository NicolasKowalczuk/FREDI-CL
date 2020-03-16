using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FREDI_CL
{
    class Licencie
    {
        private String nom;
        private String prenom;
        private String mail;
        private String mdp;
        private int age;
        private String telephone;
        private String adresseRue;
        private String adresseVille;
        private List<NoteDeFrais> lesNoteDeFrais = new List<NoteDeFrais>();
        private List<Deplacement> lesDeplacements = new List<Deplacement>();

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public int Age { get => age; set => age = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string AdresseRue { get => adresseRue; set => adresseRue = value; }
        public string AdresseVille { get => adresseVille; set => adresseVille = value; }
        internal List<NoteDeFrais> LesNoteDeFrais { get => lesNoteDeFrais; set => lesNoteDeFrais = value; }
        internal List<Deplacement> LesDeplacements { get => lesDeplacements; set => lesDeplacements = value; }

        public void ajouteNoteDeFrais(NoteDeFrais uneNDF)
        {
            this.lesNoteDeFrais.Add(uneNDF);
        }

        public void ajouteDeplacement(Deplacement unD)
        {
            this.lesDeplacements.Add(unD);
        }
    }
}
