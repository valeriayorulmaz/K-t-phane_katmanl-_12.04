using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Facade
{
    public class DBağlantı
    {
        public static readonly SqlConnection con = new SqlConnection("Server=DESKTOP-8RSV7HJ\\SQLKODLAMALAB;Database=Kütüphane;Integrated Security=true;");

        public static bool exec(SqlCommand cmd)
        {
            try
            {
                if(cmd.Connection.State !=ConnectionState.Open)
                {
                    cmd.Connection.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch {
                return false;

            }
            finally
            {
                if(cmd.Connection.State!=ConnectionState.Closed) 
                {
                    cmd.Connection.Close(); 
                }
            }
            return true;
        }
    }
}
