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
    public partial class UyeOl : Form
    {

      

        public UyeOl()
        {
            InitializeComponent();
        }

        string uAdi, uSoyadi, email, telefon, Komut, parola,kul_adi;

        void sqlveriYaz()
        {
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=SinemaBiletDB;Trusted_Connection=true;";
                con.Open();

                Komut = "INSERT INTO UyeEkle (uAdi,uSoyadi,telefon,email,parola,kul_adi,yetki) values ('" + uAdi + "','" + uSoyadi + "','" + telefon + "','" + email + "','" + parola + "','" + kul_adi + "','" + "0" + "')";

                SqlCommand cmd = new SqlCommand(Komut, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            
            catch (Exception e) { 
                
                MessageBox.Show(e.Message); 
            }
        }

        void temizle()
        {

            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Focus();
        }

        void verileriAl()
        {

            uAdi = textBox1.Text;
            uSoyadi = textBox2.Text;
            email = textBox4.Text;
            telefon = maskedTextBox1.Text;
            parola = textBox5.Text;
            kul_adi = textBox6.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && maskedTextBox1.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {

                verileriAl();
                sqlveriYaz();
                temizle();

                MessageBox.Show("Kayıt işleminiz başarıyla tamamlandı.");

                  
               KullaniciGirisi grs = new KullaniciGirisi();
               grs.Show();
               this.Hide();
            }
            else{

                MessageBox.Show("Hatalı veya eksik bilgi girdiniz.");
            }
            
          
        }
    }
}
