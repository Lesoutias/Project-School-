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
        char sexe;
        string datenaiss;

        public string Nom { get => nom; set => nom = value; }
        public string Postnom { get => postnom; set => postnom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Datenaiss { get => datenaiss; set => datenaiss = value; }
        public char Sexe { get => sexe; set => sexe = value; }

        public void Ajouter(Personne pers)
        {
            nom = pers.Nom;
            postnom = pers.Postnom;
            prenom = pers.Prenom;
            datenaiss = pers.Datenaiss;
            sexe = pers.Sexe;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Post-Nom : " + Postnom);
            Console.WriteLine("Prenom : " + Prenom);
            Console.WriteLine("Date de Naissance : " + Datenaiss);
            Console.WriteLine("Sexe : " + Sexe);
        }

        public int GetAge(String DateNaiss)
        {
            int Age = DateTime.Now.Year - Convert.ToDateTime(DateNaiss).Year;
            return Age;
        }
    }

    
}
