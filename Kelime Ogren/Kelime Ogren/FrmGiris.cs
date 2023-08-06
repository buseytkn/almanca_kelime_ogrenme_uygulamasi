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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KACV7HQ\\SQLEXPRESS;Initial Catalog=AlmancaSozluk;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOYUNCULAR (OyuncuAdSoyad) values (@p1)",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            Form1 fr = new Form1();
            fr.isim = TxtAdSoyad.Text;
            fr.Show();
            this.Hide();

        }
    }
}
