using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Facade;
using Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace Kütüphane_katmanlı_12._04
{
    public partial class KitapForm : Form
    {
        public KitapForm()
        {
            InitializeComponent();
        }

        private void KitapForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();
            kitap.kad = textBox2.Text;
            kitap.kyazar = textBox3.Text;
            kitap.baskiyili =Convert.ToInt32( textBox4.Text);
            kitap.sayfasayisi = Convert.ToInt32(textBox5.Text);
            kitap.yayinevi=textBox6.Text;
            kitap.dil=textBox7.Text;
            kitap.tur=textBox8.Text;
            kitap.rafkodu=textBox9.Text;

            //kontrol
            dataGridView1.DataSource = Crud_Kitaplar.kekle(kitap);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();

            kitap.kitapno = Convert.ToInt32(textBox1.Text);
            kitap.kad = textBox2.Text;
            kitap.kyazar = textBox3.Text;
            kitap.baskiyili = Convert.ToInt32(textBox4.Text);
            kitap.sayfasayisi = Convert.ToInt32(textBox5.Text);
            kitap.yayinevi = textBox6.Text;
            kitap.dil = textBox7.Text;
            kitap.tur = textBox8.Text;
            kitap.rafkodu = textBox9.Text;

            if (!Crud_Kitaplar.kyenile(kitap))
            {
                MessageBox.Show("Başarısız.");
            }
            dataGridView1.DataSource = Crud_Kitaplar.klistele();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();
            kitap.kitapno = Convert.ToInt32(textBox1.Text);
            if (!Crud_Kitaplar.ksil(kitap))
            {
                MessageBox.Show("Başarısız.");
            }
            dataGridView1.DataSource = Crud_Kitaplar.klistele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Text = row.Cells["kitapno"].Value.ToString();
            textBox2.Text = row.Cells["kad"].Value.ToString();
            textBox3.Text = row.Cells["kyazar"].Value.ToString();
            textBox4.Text = row.Cells["baskiyili"].Value.ToString();
            textBox5.Text = row.Cells["sayfasayisi"].Value.ToString();
            textBox6.Text = row.Cells["yayinevi"].Value.ToString();
            textBox7.Text = row.Cells["dil"].Value.ToString();
            textBox8.Text = row.Cells["tur"].Value.ToString();
            textBox9.Text = row.Cells["rafkodu"].Value.ToString();

        }

        private void üyeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜyeForm go = new ÜyeForm();
            go.Show();
            this.Hide();
        }

        private void emanetFomrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetForm go = new EmanetForm();
            go.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-8RSV7HJ\\SQLKODLAMALAB;Database=Kütüphane;Integrated Security=true;");

            dataGridView1.Visible = true;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "kara";

                    cmd.Parameters.AddWithValue("kad", textBox2.Text);
                  

                    SqlDataAdapter dr = new SqlDataAdapter(cmd);
                    DataTable doldur = new DataTable();
                    dr.Fill(doldur);
                    dataGridView1.DataSource = doldur;

                    textBox1.Clear();
                }

            }
            catch (Exception Hata)
            {
                MessageBox.Show("Bir hata oluştu!", Hata.Message);
            }
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;
            dataGridView1.DataSource = Crud_Kitaplar.klistele();
        }

        private void emanetFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetForm go = new EmanetForm();
            go.Show();
            this.Hide();
        }

        private void üToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜyeForm go = new ÜyeForm();
            go.Show();
            this.Hide();
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.Text = "Kitap Adı Ara";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Text = "Ara";
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlar go = new Raporlar();
            go.Show();
            this.Hide();
        }
    }
}
