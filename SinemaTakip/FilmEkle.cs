using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SinemaTakip
{
    public partial class FilmEkle : Form
    {
        public FilmEkle()
        {
            InitializeComponent();
        }

        string film_adi, tur, oyuncu1, oyuncu2, yonetmen;
        SqlConnection baglanti = new SqlConnection();

        void baglantiKur()
        {
            baglanti.ConnectionString = "Server=.;Database=SinemaBiletDB;Trusted_Connection=true;";

            baglanti.Open();

        }

        void temizle()
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox1.Focus();
        }


        void verileriAl()
        {

            film_adi = textBox6.Text;
            tur = textBox1.Text;
            oyuncu1 = textBox2.Text;
            oyuncu2 = textBox4.Text;
            yonetmen = textBox3.Text;
           
        }

        void sqlveriYaz()
        {
            try
            {
                string sql = "";

                baglantiKur();
              
                sql = "INSERT INTO Film (film_adi,tur,oyuncu1,oyuncu2,yonetmen) values ('" + film_adi + "','" + tur + "','" + oyuncu1 + "','" + oyuncu2 + "','" + yonetmen + "')";

                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.ExecuteNonQuery();

                baglanti.Close();
            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

          if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox6.Text != "" && textBox3.Text != "")
            {

                verileriAl();
                sqlveriYaz();
                temizle();

                MessageBox.Show("Kayıt işleminiz başarıyla tamamlandı.");

                  
               Admin grs = new Admin();
               grs.Show();
               this.Hide();
            }
          else
          {
              MessageBox.Show("Hatalı veya eksik bilgi girdiniz.");

            }
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }


    }
}
