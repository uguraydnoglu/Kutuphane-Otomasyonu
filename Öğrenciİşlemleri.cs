using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proje
{
    public partial class Öğrenciİşlemleri : Form
    {
        public Öğrenciİşlemleri()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;

        void ÖğrenciListele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_Kütüphane.accdb");
            baglanti.Open();
            da = new OleDbDataAdapter("SELECT *FROM tbl_Ogrenci", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }


        private void Öğrenciİşlemleri_Load(object sender, EventArgs e)
        {
            ÖğrenciListele();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtOgrenciID.Text != "" && txtİsim.Text != "" && txtEmail.Text != "" && txtKiralananKitap.Text != "" && txtTelefon.Text != "")
            { 
                string sorgu = "UPDATE tbl_Ogrenci SET [İsim-Soyisim]='"+txtİsim.Text+"', Email='"+txtEmail.Text+"', [Telefon Numarası]='"+txtTelefon.Text+"', [Kiralanan Kitap Sayısı]='"+txtKiralananKitap.Text+"' WHERE [ÖğrenciID]="+txtOgrenciID.Text;
                komut = new OleDbCommand(sorgu, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                ÖğrenciListele();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(txtİsim.Text != "" && txtEmail.Text != "" && txtKiralananKitap.Text != "" && txtTelefon.Text != "")
            {
                string sorgu = "INSERT INTO tbl_Ogrenci ([İsim-Soyisim],Email,[Telefon Numarası],[Kiralanan Kitap Sayısı]) values ('" + txtİsim.Text + "','" + txtEmail.Text + "','" + txtTelefon.Text + "','" + txtKiralananKitap.Text + "')";
                komut = new OleDbCommand(sorgu, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                ÖğrenciListele();
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları doldurun.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bu kaydı silmek istiyor musunuz?","Question",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sorgu = "Delete From tbl_Ogrenci Where ÖğrenciID=" + dataGridView1.CurrentRow.Cells[0].Value;
                komut = new OleDbCommand(sorgu, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                ÖğrenciListele();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Anasayfa göster = new Anasayfa();
            göster.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Hide();
            Kitapİslemleri göster = new Kitapİslemleri();
            göster.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Hide();
            KitapKiralama göster = new KitapKiralama();
            göster.Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int ÖğrenciID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                baglanti.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("SELECT *FROM tbl_Ogrenci WHERE ÖğrenciID=" + ÖğrenciID, baglanti);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtOgrenciID.Text = reader[0].ToString();
                    txtİsim.Text = reader[1].ToString();
                    txtEmail.Text = reader[2].ToString();
                    txtTelefon.Text = reader[3].ToString();
                    txtKiralananKitap.Text = reader[4].ToString();
                }
                baglanti.Close();
            }
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelmenü_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
