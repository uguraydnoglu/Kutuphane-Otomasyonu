using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.OleDb;

namespace Proje
{
    public partial class KitapKiralama : Form
    {
        public KitapKiralama()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;

        void KiralananKitapListesi()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_Kütüphane.accdb");
            baglanti.Open();
            da = new OleDbDataAdapter("SELECT *FROM tbl_Kitaplar", baglanti);
            da = new OleDbDataAdapter("SELECT *FROM tbl_Ogrenci", baglanti);
            da = new OleDbDataAdapter("SELECT *FROM tbl_Kiralama", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KitapKiralama_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void exit_Click_1(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Öğrenciİşlemleri göster = new Öğrenciİşlemleri();
            göster.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Kitapİslemleri göster = new Kitapİslemleri();
            göster.Show();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbKitapAdi.SelectedIndex > -1)
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_Kütüphane.accdb");
                string query = "SELECT [KitapID] FROM tbl_Kitaplar WHERE [Kitap İsmi]='" + cmbKitapAdi.Text+"'";
                komut = new OleDbCommand(query, baglanti);
                baglanti.Open();
                OleDbDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    txtKitapID.Text = reader[0].ToString();
                }
                baglanti.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtKitapID.Text != "" && txtOgrenciID.Text != "" && dateTimePicker1.Value.ToString() != "" && dateTimePicker2.Value.ToString() != "" && cmbKitapAdi.Text != "" && cmbOgrenciAdi.Text != "")
            {
                string sorgu = "INSERT INTO tbl_Kiralama (KitapID,OgrenciID,dateTimePicker1,dateTimePicker2,cmbKitapAdi,cmbOgrenciAdi) values ('" + txtKitapID.Text + "','" + txtOgrenciID.Text + "','" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "','" + cmbKitapAdi.Text + "','" + cmbOgrenciAdi.Text + "')";
                komut = new OleDbCommand(sorgu, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                KiralananKitapListesi();
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtKitapID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_Kütüphane.accdb");
                string query = "SELECT [Kitap İsmi] FROM tbl_Kitaplar WHERE KitapID="+txtKitapID.Text;
                komut = new OleDbCommand(query, baglanti);
                baglanti.Open();
                OleDbDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    cmbKitapAdi.Text = reader[0].ToString();
                }
                baglanti.Close();
            }
        }

        private void KitapKiralama_Load_1(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_Kütüphane.accdb");
            string query = "SELECT [Kitap İsmi] FROM tbl_Kitaplar";
            string queryy = "SELECT [İsim-Soyisim] FROM tbl_Ogrenci";
            komut = new OleDbCommand(query, baglanti);
            komut = new OleDbCommand(queryy, baglanti);
            baglanti.Open();
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                cmbKitapAdi.Items.Add(reader[0].ToString());
                cmbOgrenciAdi.Items.Add(reader[0].ToString());
            }
            baglanti.Close();
        }

        private void txtKitapID_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOgrenciAdi.SelectedIndex > -1)
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_Kütüphane.accdb");
                string queryy = "SELECT [ÖğrenciID] FROM tbl_Ogrenci WHERE [İsim-Soyisim]='" + cmbOgrenciAdi.Text + "'";
                komut = new OleDbCommand(queryy, baglanti);
                baglanti.Open();
                OleDbDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    txtOgrenciID.Text = reader[0].ToString();
                }
                baglanti.Close();
            }
        }

        private void txtOgrenciID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOgrenciID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_Kütüphane.accdb");
                string queryy = "SELECT [İsim-Soyisim] FROM tbl_Ogrenci WHERE ÖğrenciID=" + txtOgrenciID.Text;
                komut = new OleDbCommand(queryy, baglanti);
                baglanti.Open();
                OleDbDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    cmbOgrenciAdi.Text = reader[0].ToString();
                }
                baglanti.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu kaydı silmek istiyor musunuz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sorgu = "Delete From tbl_Kiralama Where KiralamaID=" + dataGridView1.CurrentRow.Cells[0].Value;
                komut = new OleDbCommand(sorgu, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                KiralananKitapListesi();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtKitapID.Text != "" && txtOgrenciID.Text != "" && dateTimePicker1.Value.ToString() != "" && dateTimePicker2.Value.ToString() != "" && cmbKitapAdi.Text != "" && cmbOgrenciAdi.Text != "")
            {
                string sorgu = "UPDATE tbl_Kiralama SET KitapID='" + txtKitapID.Text + "', OgrenciID='" + txtOgrenciID.Text + "', [Alım Tarihi]='" + dateTimePicker1.Value.ToString() + "', [Teslim Tarihi]='" + dateTimePicker2.Value.ToString() + "', [Kitap Adı]='" + cmbKitapAdi.Text + "', [Öğrenci Adı]='" + cmbOgrenciAdi.Text + "' WHERE KiralamaID=";
                komut = new OleDbCommand(sorgu, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                KiralananKitapListesi();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKitapID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtOgrenciID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbKitapAdi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbOgrenciAdi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int KiralamaID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                baglanti.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("SELECT *FROM tbl_Kiralama WHERE KiralamaID=" + KiralamaID, baglanti);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtKitapID.Text = reader[0].ToString();
                    txtOgrenciID.Text = reader[1].ToString();
                    dateTimePicker1.Text = reader[2].ToString();
                    dateTimePicker2.Text = reader[3].ToString();
                    cmbKitapAdi.Text = reader[4].ToString();
                    cmbOgrenciAdi.Text = reader[5].ToString();
                }
                baglanti.Close();
            }
        }

        private void panelmenü_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
