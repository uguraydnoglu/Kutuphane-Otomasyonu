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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_Kütüphane.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var yüklemebg = this.PointToScreen(panel1.Location);
            yüklemebg = pictureBox1.PointToClient(yüklemebg);
            panel1.Parent = pictureBox1;
            panel1.Location = yüklemebg;
            panel1.BackColor = Color.FromArgb(170, 0, 0, 0);
            label1.BackColor = Color.Transparent;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullanıcıAdı.Text == "" && txtSifre.Text == "" && txtTekrarSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve Şifre alanlarını doldurun.", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSifre.Text == txtTekrarSifre.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txtKullanıcıAdı.Text + "','" + txtSifre.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtKullanıcıAdı.Text = "";
                txtSifre.Text = "";
                txtTekrarSifre.Text = "";

                MessageBox.Show("Hesabınız başarıyla oluşturuldu", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Şifre eşleşmiyor, Lütfen tekrar girin", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifre.Text = "";
                txtTekrarSifre.Text = "";
                txtSifre.Focus();
            }
        }


    private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSifre.PasswordChar = '\0';
                txtTekrarSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '●';
                txtTekrarSifre.PasswordChar = '●';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
