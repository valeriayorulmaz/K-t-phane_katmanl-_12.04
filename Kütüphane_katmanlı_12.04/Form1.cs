using Facade;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Kütüphane_katmanlı_12._04
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=DESKTOP-8RSV7HJ\\SQLKODLAMALAB;Database=Kütüphane;Integrated Security=true;");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "Giris";
            cmd.Parameters.AddWithValue("kad", textBox1.Text);
            cmd.Parameters.AddWithValue("sifre", textBox2.Text);

            con.Open(); //parametreyi aç
            SqlDataReader dr; //sql deki dataları oku
            dr = cmd.ExecuteReader();   //satır satır oku

            if (dr.Read())//eğer okuduysa
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız");
                Anasayfa arayuz = new Anasayfa();
                arayuz.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız veya şifreniz yanlış");
                textBox1.Clear();
                textBox2.Clear();

            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "kullaniciekle";
            komut.Parameters.AddWithValue("@kullaniciadi", textBox3.Text);

            komut.Parameters.AddWithValue("sifre", textBox4.Text);
            komut.ExecuteNonQuery();
            con.Close();
           // kulistele();

            MessageBox.Show("Üye oldunuz! Lütfen giriş yapınız.");
        }
    }
}
