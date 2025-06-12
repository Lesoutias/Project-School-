using Microsoft.Data.SqlClient;
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
        int codePromotion;
        string AnneeAcademinque;
        string dateInscription;
        string observation;

        public int Id { get => id; set => id = value; }
        public string MatriculeEtudiant { get => matriculeEtudiant; set => matriculeEtudiant = value; }
        public int CodePromotion { get => codePromotion; set => codePromotion = value; }
        public string AnneeAcademinque1 { get => AnneeAcademinque; set => AnneeAcademinque = value; }
        public string DateInscription { get => dateInscription; set => dateInscription = value; }
        public string Observation { get => observation; set => observation = value; }

        public int AjouterInscription(Inscription inscri)
        {
            int resultat = 0;
            string requete = "INSERT INTO tInscription (matriculeEtudiant, codePromotion, AnneeAcademinque, dateInscription, observation) VALUES (@matriculeEtudiant, @codePromotion, @AnneeAcademinque, @dateInscription, @observation)";

            if (DataAccess.Instance.OpenConection())
            {
                SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn);
                cmd.Parameters.AddWithValue("@matriculeEtudiant", inscri.MatriculeEtudiant);
                cmd.Parameters.AddWithValue("@codePromotion", inscri.CodePromotion);
                cmd.Parameters.AddWithValue("@AnneeAcademinque", inscri.AnneeAcademinque1);
                cmd.Parameters.AddWithValue("@dateInscription", inscri.DateInscription);
                cmd.Parameters.AddWithValue("@observation", inscri.Observation);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            return resultat;
        }

        public int ModifierInscription(Inscription inscri)
        {
            int resultat = 0;
            string requete = "update tInscription set matriculeEtudiant = @matriculeEtudiant, codePromotion = @codePromotion, AnneeAcademinque = @AnneeAcademinque, dateInscription = @dateInscription, observation = @observation where id = @id" ;

            if (DataAccess.Instance.OpenConection())
            {
                SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn);
                cmd.Parameters.AddWithValue("@matriculeEtudiant", inscri.MatriculeEtudiant);
                cmd.Parameters.AddWithValue("@codePromotion", inscri.CodePromotion);
                cmd.Parameters.AddWithValue("@AnneeAcademinque", inscri.AnneeAcademinque1);
                cmd.Parameters.AddWithValue("@dateInscription", inscri.DateInscription);
                cmd.Parameters.AddWithValue("@observation", inscri.Observation);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            return resultat;
        }

        public List<Inscription> getInscription()
        {
            List<Inscription> list = new List<Inscription>();
            string requete = "select * from tInscription";
            if (DataAccess.Instance.OpenConection())
            {
                SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Inscription inscription = new Inscription();
                    inscription.Id = Convert.ToInt32(reader["id"]);
                    inscription.MatriculeEtudiant = Convert.ToString(reader["matriculeEtudiant"]);
                    inscription.CodePromotion = Convert.ToInt32(reader["codePromotion"]);
                    inscription.DateInscription = Convert.ToString(reader["dateInscription"]);
                    inscription.AnneeAcademinque1 = Convert.ToString(reader["AnneeAcademinque"]);
                    inscription.Observation = Convert.ToString(reader["observation"]);
                    list.Add(inscription);
                }
                reader.Close();
                cmd.Dispose();
            }
            return list;
        }
    }
}
