using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscriptiondb
{
    internal class Inscription
    {
        int id;
        string matriculeEtudiant;
	    string codePromotion;
        string AnneeAcademinque;
	    string dateInscription;
        string observation;

        public int Id { get => id; set => id = value; }
        public string MatriculeEtudiant { get => matriculeEtudiant; set => matriculeEtudiant = value; }
        public string CodePromotion { get => codePromotion; set => codePromotion = value; }
        public string AnneeAcademinque1 { get => AnneeAcademinque; set => AnneeAcademinque = value; }
        public string DateInscription { get => dateInscription; set => dateInscription = value; }
        public string Observation { get => observation; set => observation = value; }

        public void Ajouter()
        {

        }

        public void Modifier()
        {

        }

        public void Supprimer()
        {

        }
    }
}
