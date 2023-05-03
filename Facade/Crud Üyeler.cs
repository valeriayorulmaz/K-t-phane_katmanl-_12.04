using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Facade
{
    public class Crud_Üyeler
    {
        public string uadsoyad;

        public static DataTable ulistele()
        { 
        SqlDataAdapter adp = new SqlDataAdapter("ulistele", DBağlantı.con);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        adp.Fill(dt);
         return dt;
        }
        public static bool uekle( Üyeler uyeler)
        {
            SqlCommand cmd = new SqlCommand("uekle", DBağlantı.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("uadsoyad", uyeler.uadsoyad);
            cmd.Parameters.AddWithValue("utel", uyeler.utel);
            cmd.Parameters.AddWithValue("uposta", uyeler.uposta);
            cmd.Parameters.AddWithValue("uadres", uyeler.uadres);
            return DBağlantı.exec(cmd);
        }
        public static bool uyenile(Üyeler uyeler)
        {
            SqlCommand cmd = new SqlCommand("uyenile", DBağlantı.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("uyeno", uyeler.uyeno);
            cmd.Parameters.AddWithValue("uadsoyad", uyeler.uadsoyad);
            cmd.Parameters.AddWithValue("utel", uyeler.utel);
            cmd.Parameters.AddWithValue("uposta", uyeler.uposta);
            cmd.Parameters.AddWithValue("uadres", uyeler.uadres);
            return DBağlantı.exec(cmd);
        }
        public static bool usil(Üyeler uyeler)
        {
            SqlCommand cmd = new SqlCommand("usil", DBağlantı.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("uyeno", uyeler.uyeno);
           
            return DBağlantı.exec(cmd);
        }
        public static DataTable uara(Üyeler k1)
        {
            SqlCommand cmd = new SqlCommand("uara", DBağlantı.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("uadsoyad", k1.uadsoyad);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            dr.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dr.Fill(dt);

            return dt;
        }
    }
}
