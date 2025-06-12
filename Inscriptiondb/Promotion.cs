using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscriptiondb
{
    internal class Promotion
    {

        public int Code { get ; set; }
        public int Option1 { get; set; }
        public string Designation { get; set; }

        public int Ajouter(Promotion promotion)
        {
            int resultat = 0;
            string requete = "INSERT INTO tPromotion (option1, designation) VALUES (@option1, @designation)";

            if (DataAccess.Instance.OpenConection())
            { 
                SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn);
                cmd.Parameters.AddWithValue("@option1", promotion.Option1);
                cmd.Parameters.AddWithValue("@designation", promotion.Designation);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            return resultat;
        }

        public int Modifier(Promotion promotion)
        {
            int resultat = 0;
            string requete = "update tPromotion set designation = @designation, option1 = @option1 where code = @code";

            if (DataAccess.Instance.OpenConection())
            {
                using (SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn))
                {
                    cmd.Parameters.AddWithValue("@code", promotion.Code);
                    cmd.Parameters.AddWithValue("@option1", promotion.Option1);
                    cmd.Parameters.AddWithValue("@designation", promotion.Designation);
                    resultat = cmd.ExecuteNonQuery();
                }
            }
            return resultat;
        }

        public int Supprimer(Promotion promotion)
        {
            int resultat = 0;
            string requete = "delete from tPromotion where code = @code";

            if (DataAccess.Instance.OpenConection())
            {
                using (SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn))
                {
                    cmd.Parameters.AddWithValue("@code", promotion.Code);
                    resultat = cmd.ExecuteNonQuery();
                }
                
            }
            return resultat;
        }

        public List<Promotion> getPromotion()
        {
            List<Promotion> list = new List<Promotion>();
            string requete = "select * from tpromotion";
            if (DataAccess.Instance.OpenConection())
            {
                SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Promotion promotion = new Promotion();
                    promotion.Code = Convert.ToInt32(reader["code"]);
                    promotion.Designation = Convert.ToString(reader["designation"]);
                    promotion.Option1 = Convert.ToInt32(reader["option1"]);
                    list.Add(promotion);
                }
                reader.Close();
                cmd.Dispose();
            }
            return list;
        }
    }
}
