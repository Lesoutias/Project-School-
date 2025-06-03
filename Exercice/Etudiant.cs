using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice
{
    internal class Etudiant : Personne
    {
        string matricule;

        public string Matricule { get => matricule; set => matricule = value; }
    

        public void Ajouter(Etudiant etu)
        {
            matricule = etu.Matricule;
        }
        public void Afficher(Etudiant etu)
        {
            Console.WriteLine("Matricule : " + etu.Matricule);
            Console.WriteLine("Nom : " + etu.Nom);
            Console.WriteLine("PostNom : " + etu.Postnom);
        }
    }
}
