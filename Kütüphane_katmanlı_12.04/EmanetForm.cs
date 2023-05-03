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
    public partial class EmanetForm : Form
    {
        public EmanetForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Crud_Emanetler.elistele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Emanetler emanet = new Emanetler();
            emanet.uyeno = Convert.ToInt32(comboBox2.Text);
            emanet.kitapno = Convert.ToInt32(comboBox3.Text);
            emanet.veristarihi = Convert.ToDateTime(dateTimePicker1.Text);
            emanet.iadetarihi = Convert.ToDateTime(dateTimePicker2.Text);
            emanet.kitapdurumu = comboBox1.Text;
            if (!Crud_Emanetler.eekle(emanet))
            { MessageBox.Show("Başarısız."); }

            //kotrol

            dataGridView1.DataSource = Crud_Emanetler.elistele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Emanetler emanet = new Emanetler();
            emanet.emanetno = Convert.ToInt32(textBox1.Text);
            emanet.uyeno = Convert.ToInt32(comboBox2.SelectedItem);
            emanet.kitapno = Convert.ToInt32(comboBox3.SelectedItem);
            emanet.veristarihi = Convert.ToDateTime(dateTimePicker1.Text);
            emanet.iadetarihi = Convert.ToDateTime(dateTimePicker2.Text);
            emanet.kitapdurumu = Convert.ToString(comboBox1.SelectedItem);

            Crud_Emanetler.eyenile(emanet);


            dataGridView1.DataSource = Crud_Emanetler.elistele();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmanetForm_Load(object sender, EventArgs e)
        {

            //Facade.DBağlantı.Open();
            SqlConnection con = new SqlConnection("Server=DESKTOP-8RSV7HJ\\SQLKODLAMALAB;Database=Kütüphane;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand("Select*From Üye", con);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox2.Items.Add(dr["uyeno"]);
            }
            con.Close();

            SqlConnection con1 = new SqlConnection("Server=DESKTOP-8RSV7HJ\\SQLKODLAMALAB;Database=Kütüphane;Integrated Security=true;");
            SqlCommand cmd1 = new SqlCommand("Select*From Kitap", con1);
            con1.Open();
            SqlDataReader dr1;
            dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                comboBox3.Items.Add(dr1["kitapno"]);
            }
            con1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Emanetler emanet = new Emanetler();
            emanet.emanetno = Convert.ToInt32(textBox1.Text);
            if (!Crud_Emanetler.esil(emanet))
            {
                MessageBox.Show("Başarısız.");
            }
            dataGridView1.DataSource = Crud_Emanetler.elistele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Text = row.Cells["emanetno"].Value.ToString();
            comboBox2.Text = row.Cells["uyeno"].Value.ToString();
            comboBox3.Text = row.Cells["kitapno"].Value.ToString();
            dateTimePicker1.Text = row.Cells["veristarihi"].Value.ToString();
            dateTimePicker2.Text = row.Cells["iadetarihi"].Value.ToString();
            comboBox1.Text = row.Cells["kitapdurumu"].Value.ToString();
        }

        private void kitapFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapForm go = new KitapForm();
            go.Show();
            this.Hide();
        }

        private void üyeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜyeForm go = new ÜyeForm();
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
                    cmd.CommandText = "eara";

                    
                    cmd.Parameters.AddWithValue("kitapno", comboBox3.Text);

                    SqlDataAdapter dr = new SqlDataAdapter(cmd);
                    DataTable doldur = new DataTable();
                    dr.Fill(doldur);
                    dataGridView1.DataSource = doldur;

                }

            }
            catch(Exception Hata)
            {
                MessageBox.Show("Bir hata oluştu!", Hata.Message);
            }
            con.Close();
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.Text = "Kitap No Ara";
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
