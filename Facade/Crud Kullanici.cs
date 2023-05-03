using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Crud_Kullanici
    {
        public static DataTable kulistele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("kulistele", DBağlantı.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool kullaniciekle(Kullanıcalar kullanicilar)
        {
            SqlCommand cmd = new SqlCommand("kullaniciekle", DBağlantı.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("kullaniciadi", kullanicilar.kullaniciadi);
            cmd.Parameters.AddWithValue("sifre", kullanicilar.sifre);
            
            return DBağlantı.exec(cmd);
        }
    }
}
