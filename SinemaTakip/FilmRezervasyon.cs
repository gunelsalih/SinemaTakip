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
using System.Collections;

namespace SinemaTakip
{
    public partial class FilmRezervasyon : Form
    {
        public FilmRezervasyon()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=JOKER;Initial catalog=SinemaBiletDB;Integrated Security=true");
          
         
    

       public string film_adi = "";
       public  string seans_saati = "";

        ArrayList koltuklar = new ArrayList();

        ArrayList iptalKoltuk = new ArrayList();

        
        List<string> hafiz = new List<string>();

        private void btnKoltuk_Click(object sender, EventArgs e)
        {

            if (((Button)sender).BackColor == Color.LightGreen)
            {

                ((Button)sender).BackColor = Color.Orange;

                if (!koltuklar.Contains(((Button)sender).Text))
                {

                    koltuklar.Add(((Button)sender).Text);

                }

                koltukYazdir();

            }

            else if (((Button)sender).BackColor == Color.Orange)
            {

                ((Button)sender).BackColor = Color.LightGreen;

                if (koltuklar.Contains(((Button)sender).Text))
                {

                    koltuklar.Remove(((Button)sender).Text);

                }

                koltukYazdir();

            }

            else
            {

                if (!iptalKoltuk.Contains(((Button)sender).Text))
                {

                    iptalKoltuk.Add(((Button)sender).Text);

                }

                else
                {

                    iptalKoltuk.Remove(((Button)sender).Text);

                }

               
                

            }

        }

        void koltukYazdir()
        {

            string koltuk = "";

            for (int i = 0; i < koltuklar.Count; i++)
            {

                koltuk += koltuklar[i].ToString() +",";
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();

                }
                else
                {
                    try
                    {
                        string sqlekle = "";

                        sqlekle = "INSERT INTO Koltuk (koltuk_adi) values ('" + koltuklar[i].ToString() + "')";

                        SqlCommand cmdekle = new SqlCommand(sqlekle, baglanti);
                        cmdekle.ExecuteNonQuery();



                        baglanti.Close();
                        label18.Text = koltuk;

                    }
                    catch (Exception)
                    {
                        string sqlsil = "";

                        sqlsil = "DELETE FROM Koltuk WHERE koltuk_adi=('" + koltuklar[i].ToString() + "')";

                        SqlCommand cmdekle = new SqlCommand(sqlsil, baglanti);
                        cmdekle.ExecuteNonQuery();
                        MessageBox.Show("Lütfen koltuk seçiminizi daha dikkatli yapınız. Geri dönülüyor.");

                        

                        baglanti.Close();
                    }
                
            }

           
             
        }

        }

       

        private void FilmRezervasyon_Load(object sender, EventArgs e)
        {
            label16.Text = KullaniciGirisi.ad;
            label17.Text = KullaniciGirisi.parola;
            if (SinemaEkran.heryerden.hafiza == 0)
            {
                label9.Text = "Demir Adam 3";
            }

            else if (SinemaEkran.heryerden.hafiza == 1)
            {
                label9.Text = "Sherlock Holmes";
            }

            else if (SinemaEkran.heryerden.hafiza == 2)
            {
                label9.Text = "Terminal";
            }


            label14.Text = SinemaEkran.heryerden.zaman;
            label15.Text = SinemaEkran.heryerden.seans;
         if(baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();

                }
            else
            { 
            string sql = "";
            
            sql = "SELECT koltuk_adi FROM Koltuk";

            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                for (int i = 0; i <= dr.FieldCount; i++)
                {
                    hafiz.Add(dr["koltuk_adi"].ToString());
                }
            }
           
            for (int j=0;j<=hafiz.Count-1;j++)
            {
                for (int i = 1; i < 70; i++)
                {
                    if (buttonA1.Text == hafiz[j])
                    {
                        buttonA1.BackColor = Color.DarkRed;
                        buttonA1.Enabled = false;
                    }
                    else if (buttonA2.Text == hafiz[j])
                    {
                        buttonA2.BackColor = Color.DarkRed;
                        buttonA2.Enabled = false;
                    }

                    else if (buttonA3.Text == hafiz[j])
                    {
                        buttonA3.BackColor = Color.DarkRed;
                        buttonA3.Enabled = false;
                    }

                    else if (buttonA4.Text == hafiz[j])
                    {
                        buttonA4.BackColor = Color.DarkRed;
                        buttonA4.Enabled = false;
                    }

                    else if (buttonA5.Text == hafiz[j])
                    {
                        buttonA5.BackColor = Color.DarkRed;
                        buttonA5.Enabled = false;
                    }

                    else if (buttonB1.Text == hafiz[j])
                    {
                        buttonB1.BackColor = Color.DarkRed;
                        buttonB1.Enabled = false;
                    }

                    else if (buttonB2.Text == hafiz[j])
                    {
                        buttonB2.BackColor = Color.DarkRed;
                        buttonB2.Enabled = false;
                    }

                    else if (buttonB3.Text == hafiz[j])
                    {
                        buttonB3.BackColor = Color.DarkRed;
                        buttonB3.Enabled = false;
                    }

                    else if (buttonB4.Text == hafiz[j])
                    {
                        buttonB4.BackColor = Color.DarkRed;
                        buttonB4.Enabled = false;
                    }

                    else if (buttonB5.Text == hafiz[j])
                    {
                        buttonB5.BackColor = Color.DarkRed;
                        buttonB5.Enabled = false;
                    }

                    else if (buttonC1.Text == hafiz[j])
                    {
                        buttonC1.BackColor = Color.DarkRed;
                        buttonC1.Enabled = false;
                    }

                    else if (buttonC2.Text == hafiz[j])
                    {
                        buttonC2.BackColor = Color.DarkRed;
                        buttonC2.Enabled = false;
                    }

                    else if (buttonC3.Text == hafiz[j])
                    {
                        buttonC3.BackColor = Color.DarkRed;
                        buttonC3.Enabled = false;
                    }

                    else if (buttonC4.Text == hafiz[j])
                    {
                        buttonC4.BackColor = Color.DarkRed;
                        buttonC4.Enabled = false;
                    }

                    else if (buttonC5.Text == hafiz[j])
                    {
                        buttonC5.BackColor = Color.DarkRed;
                        buttonC5.Enabled = false;
                    }

                    else if (buttonD1.Text == hafiz[j])
                    {
                        buttonD1.BackColor = Color.DarkRed;
                        buttonD1.Enabled = false;
                    }

                    else if (buttonD2.Text == hafiz[j])
                    {
                        buttonD2.BackColor = Color.DarkRed;
                        buttonD2.Enabled = false;
                    }

                    else if (buttonD3.Text == hafiz[j])
                    {
                        buttonD3.BackColor = Color.DarkRed;
                        buttonD3.Enabled = false;
                    }

                    else if (buttonD4.Text == hafiz[j])
                    {
                        buttonD4.BackColor = Color.DarkRed;
                        buttonD4.Enabled = false;
                    }

                    else if (buttonD5.Text == hafiz[j])
                    {
                        buttonD5.BackColor = Color.DarkRed;
                        buttonD5.Enabled = false;
                    }
                    baglanti.Close();
                }
                }

            }
        }  

      
        void Bilet()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

            }
            else
            {

                string ucret = "";

                if (checkBox2.Checked) ucret = "10";

                else ucret = "12";

                for (int i = 0; i < koltuklar.Count; i++)
                {
                    string sql = "INSERT INTO Bilet(film_adi,salon_adi,tarih,saati,koltukID,satisID VALUES (" + label9.Text + "," + SinemaEkran.heryerden.salon + ",'" + label14.Text + "','" + label15.Text + "'," + Convert.ToInt32(koltuklar[i]) + ",'" + ucret + "')";


                }

                baglanti.Close();

            }



        }
      

       



    }
}


   

   

   