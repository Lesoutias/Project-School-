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
            string requete = "INSERT INTO tPromotion (option1, designation) " +
                 "VALUES('" + promotion.Option1 + "', '" + promotion.Designation + "')";

            if (DataAccess.Instance.OpenConection())
            { 
                SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn);
                try
                {
                    resultat = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur lors de l'ajout de la promotion : " + ex.Message);
                }
                finally
                {
                    DataAccess.Instance.Conn.Close();
                }
            }
            return resultat;
        }

        public int Modifier(Promotion promotion)
        {
            int resultat = 0;
            string requete = "UPDATE tPromotion SET designation='" + promotion.Designation
             + "', option1='" + promotion.Option1
             + "' where code = '" + promotion.Code + "'";

            if (DataAccess.Instance.OpenConection())
            {
                SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn);
                try
                {
                    resultat = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show ("Erreur lors de l'ajout de la promotion : " + ex.Message);
                }
                finally
                {
                DataAccess.Instance.Conn.Close();
                }
            }
            return resultat;
        }

        public int Supprimer(int codeProm)
        {
            int resultat = 0;
            string requete = "delete from tPromotion where code ='" + codeProm + "'";

            if (DataAccess.Instance.OpenConection())
            {
                SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn);
                try
                {
                    resultat = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout de la promotion : " + ex.Message);
                }
                finally
                {
                    DataAccess.Instance.Conn.Close();
                }
            }
            return resultat;
        }

        public List<Promotion> getPromotion()
        {
            List<Promotion> promotions = new List<Promotion>();
            string requete = "select * from tpromotion";
            if (DataAccess.Instance.OpenConection())
            {
                SqlCommand cmd = new SqlCommand(requete, DataAccess.Instance.Conn);
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Promotion promotion = new Promotion
                        {
                            Code = reader.GetInt32(0),
                            Option1 = reader.GetInt32(1),
                            Designation = reader.GetString(2)
                        };
                        promotions.Add(promotion);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur lors de la récupération des promotions : " + ex.Message);
                }
                finally
                {
                    DataAccess.Instance.Conn.Close();
                }
            }
            return promotions;
        }
    }
}
