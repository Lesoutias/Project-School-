using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice
{
    internal class Utilisateur : Personne
    {
        int MatriculeUtilisateur;
        string MotDePasseUtilisateur;
        string RoleUtilisateur;

        public int MatriculeUtilisateur1 { get => MatriculeUtilisateur; set => MatriculeUtilisateur = value; }
        public string MotDePasseUtilisateur1 { get => MotDePasseUtilisateur; set => MotDePasseUtilisateur = value; }
        public string RoleUtilisateur1 { get => RoleUtilisateur; set => RoleUtilisateur = value; }
    }
}
