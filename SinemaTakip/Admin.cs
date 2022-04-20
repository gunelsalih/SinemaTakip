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
    public partial class Admin : Form
    {



        SqlConnection baglanti = new SqlConnection("Data Source=JOKER;Initial catalog=SinemaBiletDB;Integrated Security=true");
      
        
        public Admin()
        {
            InitializeComponent();
        }



        private void Listele()
        {
           

            SqlCommand komutListele = new SqlCommand("SELECT * FROM Film", baglanti);

            SqlDataAdapter adaptor = new SqlDataAdapter(komutListele);

            DataSet ds = new DataSet();

            adaptor.Fill(ds);

            FilmTablosu.DataSource = ds.Tables[0];


            FilmTablosu.Columns["film_id"].Visible = false;
            FilmTablosu.Columns["film_adi"].HeaderText = "Film_Adi";
            FilmTablosu.Columns["tur"].HeaderText = "Tur";
            FilmTablosu.Columns["oyuncu1"].HeaderText = "Oyuncu1";
            FilmTablosu.Columns["oyuncu2"].HeaderText = "Oyuncu2";
            FilmTablosu.Columns["yonetmen"].HeaderText = "yonetmen";

            baglanti.Close();
        }

        private void FilmSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz ?",
            "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {

               
                string komutsil = "";
                komutsil = "DELETE FROM Film WHERE film_id=@film_id";

                SqlCommand cmd = new SqlCommand(komutsil, baglanti);
                
                cmd.Parameters.AddWithValue("@film_id", FilmTablosu.CurrentRow.Cells[0].Value);

                baglanti.Open();
                cmd.ExecuteNonQuery();

                Listele();
                baglanti.Close();


            }
        }


        private void Listele2()
        {


            SqlCommand komutListele2 = new SqlCommand("SELECT * FROM UyeEkle", baglanti);

            SqlDataAdapter adaptor2 = new SqlDataAdapter(komutListele2);

            DataSet ds2 = new DataSet();

            adaptor2.Fill(ds2);

            KullaniciTablosu.DataSource = ds2.Tables[0];


            KullaniciTablosu.Columns["uye_id"].Visible = false;
            KullaniciTablosu.Columns["uAdi"].HeaderText = "Uye_Adi";
            KullaniciTablosu.Columns["uSoyadi"].HeaderText = "Uye_Soyadi";
            KullaniciTablosu.Columns["parola"].HeaderText = "Parola";
            KullaniciTablosu.Columns["email"].HeaderText = "Email";
            KullaniciTablosu.Columns["telefon"].HeaderText = "Telefon";
            KullaniciTablosu.Columns["kul_adi"].HeaderText = "Kullanici_Adi";
            KullaniciTablosu.Columns["yetki"].HeaderText = "Yetki";



        }


        private void Admin_Load(object sender, EventArgs e)
        {
            Listele();
            Listele2();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cevap2;
            cevap2 = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz ?",
            "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap2 == DialogResult.Yes)
            {


                string komutsil2 = "";
                komutsil2 = "DELETE FROM UyeEkle WHERE uye_id=@uye_id";

                SqlCommand cmd2 = new SqlCommand(komutsil2, baglanti);

                cmd2.Parameters.AddWithValue("@uye_id", KullaniciTablosu.CurrentRow.Cells[5].Value);

                baglanti.Open();
                cmd2.ExecuteNonQuery();

                Listele2();
                baglanti.Close();

            }


        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            FilmEkle fe = new FilmEkle();
            fe.Show();
            this.Hide();
        }

      
        }
    }


          

