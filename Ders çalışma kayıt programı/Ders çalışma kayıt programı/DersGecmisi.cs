using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_çalışma_kayıt_programı
{
    public partial class DersGecmisi : Form
    {
        public DersGecmisi()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                dateTimePicker1.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
            }
        }

        private void Arama_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked && checkBox2.Checked)
                {
                    string gunn = dateTimePicker1.Value.ToString().Substring(0, 2);
                    string ayy = dateTimePicker1.Value.ToString().Substring(3, 2);
                    string yıll = dateTimePicker1.Value.ToString().Substring(6, 4);

                    MySqlConnection baglantı = new MySqlConnection("server='localhost';Database='DersKayit';Uid='root';Pwd='1234';");
                    baglantı.Open();
                    MySqlDataAdapter veri = new MySqlDataAdapter($"select * from Durum where DersAdı='{textBox1.Text}'and Gun='{yıll}-{ayy}-{gunn}'; ", baglantı);
                    DataTable tablo = new DataTable();
                    veri.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    baglantı.Close();
                }
                else if (!checkBox2.Checked && checkBox1.Checked)
                {
                    string gunn = dateTimePicker1.Value.ToString().Substring(0, 2);
                    string ayy = dateTimePicker1.Value.ToString().Substring(3, 2);
                    string yıll = dateTimePicker1.Value.ToString().Substring(6, 4);

                    MySqlConnection baglantı = new MySqlConnection("server='localhost';Database='DersKayit';Uid='root';Pwd='1234';");
                    baglantı.Open();
                    MySqlDataAdapter veri = new MySqlDataAdapter($"select * from Durum where  Gun='{yıll}-{ayy}-{gunn}'; ", baglantı);
                    DataTable tablo = new DataTable();
                    veri.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    baglantı.Close();

                }
                else if (!checkBox1.Checked && checkBox2.Checked)
                {

                    MySqlConnection baglantı = new MySqlConnection("server='localhost';Database='DersKayit';Uid='root';Pwd='1234';");
                    baglantı.Open();
                    MySqlDataAdapter veri = new MySqlDataAdapter($"select * from Durum where DersAdı='{textBox1.Text}'; ", baglantı);
                    DataTable tablo = new DataTable();
                    veri.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    baglantı.Close();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Sonuç bulunamadı");
            }
            



        }
    }
}
