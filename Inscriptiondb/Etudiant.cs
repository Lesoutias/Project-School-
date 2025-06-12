using Microsoft.Data.SqlClient;
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

        public int AjouterEtudiant(Etudiant Etu)
        {
            int resultat = 0;
            string requete = "INSERT INTO tEtudiant (matricule, nom, postnom, prenom, etatcivile, datenaissance, lieunaissance) VALUES (@matricule, @nom, @postnom, @prenom, @etatcivile, @datenaissance, @lieunaissance)";

            if (DataAccess.Instance.OpenConection())
            {
                SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn);
                cmd.Parameters.AddWithValue("@matricule", Etu.Matricule);
                cmd.Parameters.AddWithValue("@nom", Etu.Nom);
                cmd.Parameters.AddWithValue("@postnom", Etu.Postnom);
                cmd.Parameters.AddWithValue("@prenom", Etu.Prenom);
                cmd.Parameters.AddWithValue("@etatcivile", Etu.Etatcivile);
                cmd.Parameters.AddWithValue("@datenaissance", Etu.Datenaissance);
                cmd.Parameters.AddWithValue("@lieunaissance", Etu.Lieunaissance);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            return resultat;
        }

        public int ModifierEtudiant(Etudiant Etu)
        {
            int resultat = 0;
            string requete = "update tEtudiant set nom = @nom, postnom = @postnom, prenom = @prenom, etatcivile = @etatcivile, datenaissance = @datenaissance, lieunaissance = @lieunaissance where matricule = @matricule";

            if (DataAccess.Instance.OpenConection())
            {
                SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn);
                cmd.Parameters.AddWithValue("@matricule", Etu.Matricule);
                cmd.Parameters.AddWithValue("@nom", Etu.Nom);
                cmd.Parameters.AddWithValue("@postnom", Etu.Postnom);
                cmd.Parameters.AddWithValue("@prenom", Etu.Prenom);
                cmd.Parameters.AddWithValue("@etatcivile", Etu.Etatcivile);
                cmd.Parameters.AddWithValue("@datenaissance", Etu.Datenaissance);
                cmd.Parameters.AddWithValue("@lieunaissance", Etu.Lieunaissance);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            return resultat;
        }

        public int SupprimerEtudiant(Etudiant etudiant)
        {
            int resultat = 0;
            string requete = "delete from tEtudiant where matricule = @matricule";

            if (DataAccess.Instance.OpenConection())
            {
                using (SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn))
                {
                    cmd.Parameters.AddWithValue("@matricule", etudiant.Matricule);
                    resultat = cmd.ExecuteNonQuery();
                }
            }
            return resultat;
        }

        public List<Etudiant> getEtudiant()
        {
            List<Etudiant> list = new List<Etudiant>();
            string requete = "select * from tEtudiant";
            if (DataAccess.Instance.OpenConection())
            {
                SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Etudiant etudiant = new Etudiant();
                    etudiant.Matricule = Convert.ToString(reader["matricule"]);
                    etudiant.Nom = Convert.ToString(reader["nom"]);
                    etudiant.Postnom = Convert.ToString(reader["postnom"]);
                    etudiant.Prenom = Convert.ToString(reader["prenom"]);
                    etudiant.Etatcivile = Convert.ToString(reader["etatcivile"]);
                    etudiant.Datenaissance = Convert.ToString(reader["datenaissance"]);
                    etudiant.Lieunaissance = Convert.ToString(reader["lieunaissance"]);
                    list.Add(etudiant);
                }
                reader.Close();
                cmd.Dispose();
            }
            return list;
        }
    }
}
