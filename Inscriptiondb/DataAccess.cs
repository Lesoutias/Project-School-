using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Inscriptiondb
{
    internal class DataAccess
    {
        private static DataAccess instance = null;

        public static DataAccess Instance 
        { get 
            {
                if (instance == null)
                {
                    instance = new DataAccess();
                }
                return instance; 
            } 

        }

        public SqlConnection Conn { get => conn; set => conn = value; }

        SqlConnection conn = null;

        public bool OpenConection()
        {
            //try
            //{
                string connectionString = "data source = DESKTOP-T8O1S1A\\SQLEXPRESS ;initial catalog = BdInscription   ;  persist security info = True; Integrated Security = SSPI; encrypt=false";
                Conn = new SqlConnection(connectionString);
                Conn.Open();
                return true;
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}
        }


        

        

    }
}
