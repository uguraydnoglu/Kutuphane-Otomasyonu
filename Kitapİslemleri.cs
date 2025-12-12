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
    public partial class Kitapİslemleri : Form
    {
        public Kitapİslemleri()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;

        void KitapListele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_Kütüphane.accdb");
            baglanti.Open();
            da = new OleDbDataAdapter("SELECT *FROM tbl_Kitaplar", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            KitapKiralama göster = new KitapKiralama();
            göster.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Anasayfa göster = new Anasayfa();
            göster.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Öğrenciİşlemleri göster = new Öğrenciİşlemleri();
            göster.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (txtKitapİsim.Text != "" && txtYazar.Text != "" && txtÜcret.Text != "" && txtAdet.Text != "")
            {
                string sorgu = "INSERT INTO tbl_Kitaplar ([Kitap İsmi],Yazar,Ücret,Adet) values ('" + txtKitapİsim.Text + "','" + txtYazar.Text + "','" + txtÜcret.Text + "','" + txtAdet.Text + "')";
                komut = new OleDbCommand(sorgu, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                KitapListele();
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Kitapİslemleri_Load(object sender, EventArgs e)
        {
            KitapListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKitapID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKitapİsim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtÜcret.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtKitapID.Text != "" && txtKitapİsim.Text != "" && txtYazar.Text != "" && txtÜcret.Text != "" && txtAdet.Text != "")
            {
                string sorgu = "UPDATE tbl_Kitaplar SET [Kitap İsmi]='" + txtKitapİsim.Text + "', Yazar='" + txtYazar.Text + "', Ücret='" + txtÜcret.Text + "', Adet='" + txtAdet.Text + "' WHERE KitapID=" + txtKitapID.Text;
                komut = new OleDbCommand(sorgu, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                KitapListele();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int KitapID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                baglanti.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("SELECT *FROM tbl_Kitaplar WHERE KitapID=" + KitapID, baglanti);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtKitapID.Text = reader[0].ToString();
                    txtKitapİsim.Text = reader[1].ToString();
                    txtYazar.Text = reader[2].ToString();
                    txtÜcret.Text = reader[3].ToString();
                    txtAdet.Text = reader[4].ToString();
                }
                baglanti.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu kaydı silmek istiyor musunuz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sorgu = "Delete From tbl_Kitaplar Where KitapID=" + dataGridView1.CurrentRow.Cells[0].Value;
                komut = new OleDbCommand(sorgu, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                KitapListele();
            }
        }
    }
}
