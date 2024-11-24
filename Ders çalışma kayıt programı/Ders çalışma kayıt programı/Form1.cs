using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Ders_çalışma_kayıt_programı
{
    public partial class Form1 : Form
    {   

        DersGecmisi GecmısSayfa=new DersGecmisi();

        bool molaDurum = false;
        int saat = 0;
        int dakika = 0;
        int saniye = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Basla_Click(object sender, EventArgs e)
        {
            if (DersAd.Text != "" || DersAd.Text != " ")
            {
                sure.Start();
                Bitir.Enabled = true;
                MolaDevam.Enabled = true;
                Basla.Enabled = false;
                DersAd.Enabled = false;
            }

        }

        private void sure_Tick(object sender, EventArgs e)
        {
            if (molaDurum)
            {

            }
            else
            {

                if (saniye >= 59)
                {
                    saniye = 00;
                    Saniye.Text = saniye.ToString();
                    if (dakika >= 59)
                    {
                        dakika = 00;
                        saat++;
                        Saat.Text = saat.ToString();
                    }
                    else
                    {
                        dakika++;
                        Dakika.Text = dakika.ToString();
                    }
                }
                else
                {
                    saniye++;
                    Saniye.Text = saniye.ToString();
                }





            }

        }

        private void MolaDevam_Click(object sender, EventArgs e)
        {
            if (molaDurum)
            {
                molaDurum = false;
                MolaDevam.Text = "Mola";
            }
            else
            {
                molaDurum = true;
                MolaDevam.Text = "Devam";
            }

        }

        private void Bitir_Click(object sender, EventArgs e)
        {


            sure.Stop();

            DateTime gun = DateTime.Now;

            string gunn = gun.ToString().Substring(0, 2);
            string ayy = gun.ToString().Substring(3, 2);
            string yıll = gun.ToString().Substring(6, 4);
            

            string Ders_Adı = DersAd.Text;
            MySqlConnection baglantı = new MySqlConnection("server='localhost';Database='DersKayit';Uid='root';Pwd='1234';");
            MySqlCommand komut = new MySqlCommand($"insert into Durum(Gun,DersAdı,CalısılanZaman) values('{yıll}-{ayy}-{gunn}','{Ders_Adı}','{saat}:{dakika}:{saniye}');", baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();


            saat = 0;
            dakika = 0;
            saniye = 0;
            Saat.Text = saat.ToString();
            Dakika.Text = dakika.ToString();
            Saniye.Text = saniye.ToString();

            DersAd.Text = "";
            DersAd.Enabled = true;
            MolaDevam.Enabled = false;
            Bitir.Enabled = false;
            Basla.Enabled = false;
        }

        private void DersAd_TextChanged(object sender, EventArgs e)
        {
            Basla.Enabled = true;
        }

        private void Gecmis_Click(object sender, EventArgs e)
        {
            GecmısSayfa.ShowDialog();
        }
    }
}
