using Entity;
using Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace Kütüphane_katmanlı_12._04
{
    public partial class ÜyeForm : Form
    {
        public ÜyeForm()
        {
            InitializeComponent();
        }

        private void ÜyeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Crud_Üyeler.ulistele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Üyeler üye = new Üyeler();
            üye.uadsoyad = textBox2.Text;
            üye.utel=textBox3.Text;
            üye.uposta= textBox4.Text;
            üye.uadres= textBox5.Text;
            if (controlüye.Yurut(üye)==true) 
            {
                MessageBox.Show("Başarılı Kayıt");
            }
            else
            {
                MessageBox.Show("Başarısız Kayıt");
            }
            dataGridView1.DataSource =Crud_Üyeler.ulistele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Üyeler üye = new Üyeler();

            üye.uyeno = Convert.ToInt32(textBox1.Text);
            üye.uadsoyad = textBox2.Text;
            üye.utel = textBox3.Text;
            üye.uposta = textBox4.Text;
            üye.uadres = textBox5.Text;

            if (!Crud_Üyeler.uyenile(üye))
                MessageBox.Show("Başarısız.");
            dataGridView1.DataSource = Crud_Üyeler.ulistele();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Üyeler üye = new Üyeler();
            üye.uyeno = Convert.ToInt32(textBox1.Text);
            if (!Crud_Üyeler.usil(üye))
            {
                MessageBox.Show("Başarısız.");
            }
            dataGridView1.DataSource = Crud_Üyeler.ulistele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row =dataGridView1.CurrentRow;
            textBox1.Text = row.Cells["uyeno"].Value.ToString();
            textBox2.Text = row.Cells["uadsoyad"].Value.ToString();
            textBox3.Text = row.Cells["utel"].Value.ToString();
            textBox4.Text = row.Cells["uposta"].Value.ToString();
            textBox5.Text = row.Cells["uadres"].Value.ToString();
        }

        private void emanetFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetForm go = new EmanetForm();
            go.Show();
            this.Hide();
        }

        private void kitapFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapForm go = new KitapForm();
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
                    cmd.CommandText = "uara";


                    cmd.Parameters.AddWithValue("uadsoyad", textBox2.Text);

                    SqlDataAdapter dr = new SqlDataAdapter(cmd);
                    DataTable doldur = new DataTable();
                    dr.Fill(doldur);
                    dataGridView1.DataSource = doldur;

                }

            }
            catch (Exception Hata)
            {
                MessageBox.Show("Bir hata oluştu!", Hata.Message);
            }
            con.Close();
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.Text = "Üye Adı Soyadı Ara";
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
