using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var yüklemebg = this.PointToScreen(panel1.Location);
            yüklemebg = pictureBox1.PointToClient(yüklemebg);
            panel1.Parent = pictureBox1;
            panel1.Location = yüklemebg;
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 10;
            if (panel2.Width >= 426)
            {
                timer1.Stop();
                Form3 yeni = new Form3();
                yeni.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
