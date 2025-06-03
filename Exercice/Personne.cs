using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice
{
    internal class Personne
    {
        string nom;
        string postnom;
        string prenom;
        string datenaiss;

        public string Nom { get => nom; set => nom = value; }
        public string Postnom { get => postnom; set => postnom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Datenaiss { get => datenaiss; set => datenaiss = value; }

        public void Ajouter(Personne pers)
        {
            nom = pers.Nom;
            postnom = pers.Postnom;
            prenom = pers.Prenom;
            datenaiss = pers.Datenaiss;
        }

        public void Afficher(Personne pers)
        {
            Console.WriteLine("Nom : " + pers.Nom);
            Console.WriteLine("Post-Nom" + pers.Postnom);
            Console.WriteLine("Prenom" + pers.Prenom);
            Console.WriteLine("Date de Naissance " + pers.Datenaiss);
        }
    }

    
}
