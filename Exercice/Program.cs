using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Exercice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Somme(4, 6);
            //Console.WriteLine ("Votre Age est : " + GetAge("10-10-2000") + " ans");
            //Etudiant Etudiant1 = new Etudiant();
            //Etudiant1.Matricule = "24Liagej65876";
            //Etudiant1.Nom = "Yves";
            //Etudiant1.Postnom = "Metre";
            //Etudiant1.Ajouter(Etudiant1);
            //Etudiant1.Afficher(Etudiant1);

            //Etudiant etudiant3 = new Etudiant();
            //etudiant3.Matricule = "24Liage2021456";
            //etudiant3.Nom = "Claude";
            //etudiant3.Postnom = "Basile";
            //Console.WriteLine (etudiant3.Nom);

            //Agent agent = new Agent();
            //agent.Nom = "MOHINDO";
            //agent.Postnom = "SAFARI";
            //agent.Prenom = "Gertrude";
            //agent.Sexe = 'F';
            //agent.Datenaiss = "2002-10-10";
            //agent.CodeAgent = "202020";
            //agent.Salaire = 250;
            //agent.Afficher();
            //Console.WriteLine("******************");
            //agent.AfficherAgent();
            //Console.WriteLine("Age : " + GetAge(agent.Datenaiss));

            try
            {
                Console.WriteLine("Saisi un nombre : ");
                int Nbre = Convert.ToInt32(Console.ReadLine());
            } catch  (Exception ex) 
            { 
                Console.WriteLine("Nombre Invalide");
            }
        }

        public static void Somme(int Nbr1, int Nbr2)
        { 
            Console.WriteLine(Nbr1 + Nbr2);
        }

        public static int GetAge(String DateNaiss)
        {
            int Age = DateTime.Now.Year - Convert.ToDateTime (DateNaiss).Year;
            return Age;
        }

        

        
    }

}