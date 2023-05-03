using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Facade
{
    public class Crud_Emanetler
    {
        public static readonly SqlConnection con = new SqlConnection("Server=DESKTOP-8RSV7HJ\\SQLKODLAMALAB;Database=Kütüphane;Integrated Security=true;");
        public static DataTable elistele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("elistele", DBağlantı.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool eekle(Emanetler emanetler)
        {
            SqlCommand cmd = new SqlCommand("eekle", DBağlantı.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("uyeno", emanetler.uyeno);
            cmd.Parameters.AddWithValue("kitapno", emanetler.kitapno);
            cmd.Parameters.AddWithValue("veristarihi", emanetler.veristarihi);
            cmd.Parameters.AddWithValue("iadetarihi", emanetler.iadetarihi);
            cmd.Parameters.AddWithValue("kitapdurumu", emanetler.kitapdurumu);
            
            return DBağlantı.exec(cmd);
        }
        public static bool eyenile(Emanetler emanetler)
        {
            SqlCommand cmd = new SqlCommand("emanetyenile", DBağlantı.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("emanetno", emanetler.emanetno);
            cmd.Parameters.AddWithValue("uyeno", emanetler.uyeno);
            cmd.Parameters.AddWithValue("kitapno", emanetler.kitapno);
            cmd.Parameters.AddWithValue("veristarihi", emanetler.veristarihi);
            cmd.Parameters.AddWithValue("iadetarihi", emanetler.iadetarihi);
            cmd.Parameters.AddWithValue("kitapdurumu", emanetler.kitapdurumu);

            return DBağlantı.exec(cmd);
        }
        public static bool esil(Emanetler emanetler)
        {
            SqlCommand cmd = new SqlCommand("esil", DBağlantı.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("emanetno", emanetler.emanetno);

            return DBağlantı.exec(cmd);
        }
        public static DataTable eara(Emanetler e1)
        {
            SqlCommand cmd = new SqlCommand("eara", DBağlantı.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("emanetno", e1.emanetno);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            dr.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dr.Fill(dt);

            return dt;
        }
    }
}
