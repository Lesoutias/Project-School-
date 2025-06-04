using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice
{
    internal class Agent : Personne
    {
        string codeAgent;
        double salaire;

        public string CodeAgent { get => codeAgent; set => codeAgent = value; }
        public double Salaire { get => salaire; set => salaire = value; }

        public void AfficherAgent()
        {
            base.Afficher();
            Console.WriteLine("Code : " + CodeAgent);
            Console.WriteLine("Salaire : " + Salaire);
        }
    }
}
