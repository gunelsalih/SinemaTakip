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
    
    public partial class SinemaEkran : Form
    {

        public class heryerden
        {
            public static int hafiza;
            public static string zaman,seans,salon;
        }
        SqlConnection baglanti = new SqlConnection();

        void baglantiKur()
        {
            baglanti.ConnectionString = "Server=.;Database=SinemaBiletDB;Trusted_Connection=true;";

            baglanti.Open();

        }

        void bilgiAl(string sql, ComboBox cmb)
        {

            cmb.Items.Clear();
            baglantiKur();

            SqlCommand cmd = new SqlCommand(sql, baglanti);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read() == true)
            {
                cmb.Items.Add(dr[0].ToString());

            }


            baglanti.Close();


        }

        void TarihKaydet(string sql,DateTimePicker dtm)
        {
            string komut;
           
            baglantiKur();

            komut = "INSERT INTO Bilet (tarih) values ('" + dtm + "')";
            
            SqlCommand cmd = new SqlCommand(komut, baglanti);
            cmd.ExecuteNonQuery();

            baglanti.Close();

        }
        public SinemaEkran()
        {
            InitializeComponent();
        }

       
        
        private void SinemaEkran_Load(object sender, EventArgs e)
        {
            bilgiAl("SELECT film_adi FROM Film", comboBox1);
            bilgiAl("SELECT salon_adi FROM Salon", comboBox2);
            bilgiAl("SELECT saati FROM Seans", comboBox3);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if(comboBox1.SelectedIndex !=-1 && comboBox2.SelectedIndex !=-1 && comboBox3.SelectedIndex !=-1 ){


                 if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
                 {
                     FilmRezervasyon flmr = new FilmRezervasyon();
                     heryerden.hafiza = comboBox1.SelectedIndex;
                     heryerden.seans = comboBox3.Text;
                     heryerden.zaman = dateTimePicker1.Text;
                     heryerden.salon = comboBox2.Text;
                     flmr.Show();
                     this.Hide();

                 }
                 else
                 {

                     MessageBox.Show("Bu film bu salonda oynamamaktadır...");
                 }
               
            }
            else
            {
                MessageBox.Show("Lütfen film bilgilerini eksiksiz giriniz..");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
      

        }
    }




                

                

                

                