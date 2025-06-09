using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscriptiondb
{
    internal class Etudiant
    {
        string matricule;
        string nom;
	    string postnom;
        string prenom;
	    string etatcivile;
        string datenaissance;
	    string lieunaissance;

        public string Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Postnom { get => postnom; set => postnom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Etatcivile { get => etatcivile; set => etatcivile = value; }
        public string Datenaissance { get => datenaissance; set => datenaissance = value; }
        public string Lieunaissance { get => lieunaissance; set => lieunaissance = value; }
    }
}
