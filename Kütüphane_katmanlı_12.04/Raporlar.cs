using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Facade;

namespace Kütüphane_katmanlı_12._04
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=DESKTOP-8RSV7HJ\\SQLKODLAMALAB;Database=Kütüphane;Integrated Security=true;");

        private void button1_Click(object sender, EventArgs e)
        {
            //dili ingilizce olan kitaplar
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            if (radioButton3.Checked == true)
            { komut.CommandText = "kitapalmanca"; }

            else if (radioButton4.Checked == true)
            { komut.CommandText = "kitapingilizce"; }
            else
            { komut.CommandText = "dilsira"; }
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            if (radioButton1.Checked == true)
            { komut.CommandText = "roman"; }

            else if (radioButton2.Checked == true)
            { komut.CommandText = "kgelisim"; }
            else
            { komut.CommandText = "tursira"; }
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            if (radioButton5.Checked == true)
            { komut.CommandText = "kisakitap"; }

            else if (radioButton6.Checked == true)
            { komut.CommandText = "uzunkitap"; }

            else 
            { komut.CommandText = "sayfasirala"; }
            
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {

        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa go = new Anasayfa();
            go.Show();
            this.Hide();

        }
    }
}
