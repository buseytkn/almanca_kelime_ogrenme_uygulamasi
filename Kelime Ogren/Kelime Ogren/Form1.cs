using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kelime_Ogren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KACV7HQ\\SQLEXPRESS;Initial Catalog=AlmancaSozluk;Integrated Security=True");
        Random rast = new Random();
        int sure = 90;
        int dogru = 0;
        int yanlis = 0;
        public string isim;

        void getir()
        {
            int sayi;
            sayi = rast.Next(1, 75);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLSOZLUK where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAlmanca.Text = dr[1].ToString();
                LblCevap.Text = dr[2].ToString();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            timer1.Start();
            LblOyuncu.Text = "Hoşgeldiniz" + " " + isim;
        }

        private void TxtTurkce_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                if(TxtTurkce.Text == LblCevap.Text)
                {
                    dogru++;
                    LblDogru.Text = dogru.ToString();
                    getir();
                    TxtTurkce.Clear();
                }
                else
                {
                    yanlis++;
                    LblYanlis.Text = yanlis.ToString();
                    getir();
                    TxtTurkce.Clear();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            LblSure.Text = sure.ToString(); 
            if(sure == 0)
            {
                TxtTurkce.Enabled = false;
                TxtAlmanca.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Süreniz bitti.Doğru sayınız:" + LblDogru.Text + " Yanlış sayınız:" + LblYanlis.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update TBLOYUNCULAR set Dogru=@p1,Yanlis=@p2 where OyuncuAdSoyad=@p3",baglanti);
                komut.Parameters.AddWithValue("@p1",LblDogru.Text);
                komut.Parameters.AddWithValue("@p2",LblYanlis.Text);
                komut.Parameters.AddWithValue("@p3", isim);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmIstatistik fr = new FrmIstatistik(); 
            fr.Show();
        }
    }
}
