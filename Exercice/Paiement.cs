using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice
{
    internal class Paiement
    {
        int NumPaiement;
        string DatePaiement;
        double MontantPaiement;
        string ModePaiement;

        public int NumPaiement1 { get => NumPaiement; set => NumPaiement = value; }
        public string DatePaiement1 { get => DatePaiement; set => DatePaiement = value; }
        public double MontantPaiement1 { get => MontantPaiement; set => MontantPaiement = value; }
        public string ModePaiement1 { get => ModePaiement; set => ModePaiement = value; }
    }
}
