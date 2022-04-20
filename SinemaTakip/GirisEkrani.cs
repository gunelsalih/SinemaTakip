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
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }
        
        public static string ad,parola = "";
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                textBox2.PasswordChar = new char(); 
            }

            else
            {

                textBox2.PasswordChar = '*'; 
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = "Server=.;Database=SinemaBiletDB;Trusted_Connection=true;";

                baglanti.Open();

                

                SqlParameter prm1 = new SqlParameter("@kul_adi", textBox1.Text);
                SqlParameter prm2 = new SqlParameter("@parola", textBox2.Text);
                string sql = "";
                sql = "SELECT yetki,uAdi,uSoyadi FROM UyeEkle WHERE kul_adi = @kul_adi AND parola = @parola ";
             

                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                SqlDataReader dr = cmd.ExecuteReader();
              
                string yetqi ="";

               
              
                if (dr.Read())
                {
                     yetqi = dr["yetki"].ToString();
                     ad = dr["uAdi"].ToString();
                     parola = dr["uSoyadi"].ToString();
                     dr.Close();
                }


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);



                if (dt.Rows.Count > 0 )
                {
                    if (yetqi == "0")
                    {
                        SinemaEkran snmekrn = new SinemaEkran();
                        snmekrn.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        Admin adm = new Admin();
                        adm.Show();
                        this.Hide();
                        
                    }
                        
                }

                
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifreyi yanlış girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Kullanıcı adı ya da şifreyi yanlış girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeOl uol = new UyeOl();
            uol.Show();
            this.Hide();
        }

      

        }
    }
