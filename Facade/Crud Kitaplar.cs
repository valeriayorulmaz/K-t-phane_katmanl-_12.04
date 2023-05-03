using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Facade
{
    public class Crud_Kitaplar
    {
        public static DataTable klistele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("klistele", DBağlantı.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool kekle(Kitaplar kitaplar)
        {
            SqlCommand cmd = new SqlCommand("kekle", DBağlantı.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("kad", kitaplar.kad);
            cmd.Parameters.AddWithValue("kyazar", kitaplar.kyazar);
            cmd.Parameters.AddWithValue("baskiyili", kitaplar.baskiyili);
            cmd.Parameters.AddWithValue("sayfasayisi", kitaplar.sayfasayisi);
            cmd.Parameters.AddWithValue("yayinevi", kitaplar.yayinevi);
            cmd.Parameters.AddWithValue("dil", kitaplar.dil);
            cmd.Parameters.AddWithValue("tur", kitaplar.tur);
            cmd.Parameters.AddWithValue("rafkodu", kitaplar.rafkodu);
            return DBağlantı.exec(cmd);
        }
        public static bool kyenile(Kitaplar kitaplar)
        {
            SqlCommand cmd = new SqlCommand("kyenile", DBağlantı.con);
            cmd.CommandType=CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("kitapno", kitaplar.kitapno);
            cmd.Parameters.AddWithValue("kad", kitaplar.kad);
            cmd.Parameters.AddWithValue("kyazar", kitaplar.kyazar);
            cmd.Parameters.AddWithValue("baskiyili", kitaplar.baskiyili);
            cmd.Parameters.AddWithValue("sayfasayisi", kitaplar.sayfasayisi);
            cmd.Parameters.AddWithValue("yayinevi", kitaplar.yayinevi);
            cmd.Parameters.AddWithValue("dil", kitaplar.dil);
            cmd.Parameters.AddWithValue("tur", kitaplar.tur);
            cmd.Parameters.AddWithValue("rafkodu", kitaplar.rafkodu);
            return DBağlantı.exec(cmd);
        }
        public static bool ksil(Kitaplar kitaplar)
        {
            SqlCommand cmd = new SqlCommand("ksil", DBağlantı.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("kitapno", kitaplar.kitapno);

            return DBağlantı.exec(cmd);
        }

        public static DataTable kara(Kitaplar k1)
        {
            SqlCommand cmd = new SqlCommand("kara", DBağlantı.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("kad", k1.kad);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            dr.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dr.Fill(dt);

            return dt;
        }


    }
}
