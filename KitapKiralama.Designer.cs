
namespace Proje
{
    partial class KitapKiralama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapKiralama));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOgrenciID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Kullanıcı = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panelmenü = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.ımageList6 = new System.Windows.Forms.ImageList(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.ımageList4 = new System.Windows.Forms.ImageList(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKitapAdi = new System.Windows.Forms.ComboBox();
            this.cmbOgrenciAdi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ımageList5 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.panelmenü.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(287, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 389);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Teal;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(655, 251);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(308, 51);
            this.button9.TabIndex = 50;
            this.button9.Text = "GÜNCELLE";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Teal;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(287, 251);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(308, 51);
            this.button8.TabIndex = 49;
            this.button8.Text = "EKLE";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Teal;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(1014, 251);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(308, 51);
            this.button10.TabIndex = 48;
            this.button10.Text = "SİL";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(351, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 7);
            this.panel2.TabIndex = 41;
            // 
            // txtOgrenciID
            // 
            this.txtOgrenciID.BackColor = System.Drawing.SystemColors.Control;
            this.txtOgrenciID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOgrenciID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOgrenciID.Location = new System.Drawing.Point(351, 175);
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.PlaceholderText = "Öğrenci ID";
            this.txtOgrenciID.Size = new System.Drawing.Size(178, 22);
            this.txtOgrenciID.TabIndex = 40;
            this.txtOgrenciID.TextChanged += new System.EventHandler(this.txtOgrenciID_TextChanged);
            this.txtOgrenciID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOgrenciID_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(351, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 7);
            this.panel1.TabIndex = 39;
            // 
            // txtKitapID
            // 
            this.txtKitapID.BackColor = System.Drawing.SystemColors.Control;
            this.txtKitapID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKitapID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKitapID.Location = new System.Drawing.Point(351, 96);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.PlaceholderText = "Kitap ID";
            this.txtKitapID.Size = new System.Drawing.Size(178, 22);
            this.txtKitapID.TabIndex = 38;
            this.txtKitapID.TextChanged += new System.EventHandler(this.txtKitapID_TextChanged);
            this.txtKitapID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapID_KeyPress);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.exit);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.Kullanıcı);
            this.panelLogo.Controls.Add(this.button3);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1372, 77);
            this.panelLogo.TabIndex = 37;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.exit.Location = new System.Drawing.Point(1295, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(65, 52);
            this.exit.TabIndex = 4;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = " Yetkili";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Kullanıcı
            // 
            this.Kullanıcı.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Kullanıcı.ForeColor = System.Drawing.Color.White;
            this.Kullanıcı.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Kullanıcı.Location = new System.Drawing.Point(101, 9);
            this.Kullanıcı.Name = "Kullanıcı";
            this.Kullanıcı.Size = new System.Drawing.Size(197, 25);
            this.Kullanıcı.TabIndex = 2;
            this.Kullanıcı.Text = "Atatürk Kütüphanesi";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(23, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 58);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panelmenü
            // 
            this.panelmenü.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelmenü.Controls.Add(this.pictureBox1);
            this.panelmenü.Controls.Add(this.button7);
            this.panelmenü.Controls.Add(this.button4);
            this.panelmenü.Controls.Add(this.button1);
            this.panelmenü.Controls.Add(this.button2);
            this.panelmenü.Controls.Add(this.button5);
            this.panelmenü.Location = new System.Drawing.Point(0, 77);
            this.panelmenü.Name = "panelmenü";
            this.panelmenü.Size = new System.Drawing.Size(233, 666);
            this.panelmenü.TabIndex = 36;
            this.panelmenü.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmenü_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.Gainsboro;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.ImageKey = "power-off.png";
            this.button7.ImageList = this.ımageList6;
            this.button7.Location = new System.Drawing.Point(0, 510);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(230, 65);
            this.button7.TabIndex = 68;
            this.button7.Text = "             Çıkış Yap";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ımageList6
            // 
            this.ımageList6.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList6.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList6.ImageStream")));
            this.ımageList6.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList6.Images.SetKeyName(0, "power-off.png");
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageKey = "book.png";
            this.button4.ImageList = this.ımageList3;
            this.button4.Location = new System.Drawing.Point(0, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 65);
            this.button4.TabIndex = 66;
            this.button4.Text = "            Kitap İşlemleri";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ımageList3
            // 
            this.ımageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "book.png");
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "monitor.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(0, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 65);
            this.button1.TabIndex = 64;
            this.button1.Text = "            Anasayfa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "monitor.png");
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "student.png";
            this.button2.ImageList = this.ımageList2;
            this.button2.Location = new System.Drawing.Point(0, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 65);
            this.button2.TabIndex = 65;
            this.button2.Text = "   Öğrenci İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "student.png");
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageKey = "shopping-basket (1).png";
            this.button5.ImageList = this.ımageList4;
            this.button5.Location = new System.Drawing.Point(0, 439);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 65);
            this.button5.TabIndex = 67;
            this.button5.Text = "           Kitap Kiralama İşlemi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ımageList4
            // 
            this.ımageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList4.ImageStream")));
            this.ımageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList4.Images.SetKeyName(0, "shopping-basket (1).png");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(707, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 23);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(707, 203);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(189, 23);
            this.dateTimePicker2.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(743, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 58;
            this.label1.Text = "Alım Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(743, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 59;
            this.label3.Text = "Teslim Tarihi";
            // 
            // cmbKitapAdi
            // 
            this.cmbKitapAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitapAdi.DropDownWidth = 204;
            this.cmbKitapAdi.FormattingEnabled = true;
            this.cmbKitapAdi.Location = new System.Drawing.Point(1070, 126);
            this.cmbKitapAdi.Name = "cmbKitapAdi";
            this.cmbKitapAdi.Size = new System.Drawing.Size(204, 23);
            this.cmbKitapAdi.TabIndex = 60;
            this.cmbKitapAdi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbOgrenciAdi
            // 
            this.cmbOgrenciAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrenciAdi.FormattingEnabled = true;
            this.cmbOgrenciAdi.Location = new System.Drawing.Point(1070, 203);
            this.cmbOgrenciAdi.Name = "cmbOgrenciAdi";
            this.cmbOgrenciAdi.Size = new System.Drawing.Size(204, 23);
            this.cmbOgrenciAdi.TabIndex = 61;
            this.cmbOgrenciAdi.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1123, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 62;
            this.label4.Text = "Kitap Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1123, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 63;
            this.label5.Text = "Öğrenci Adı";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // ımageList5
            // 
            this.ımageList5.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList5.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList5.ImageStream")));
            this.ımageList5.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList5.Images.SetKeyName(0, "user.png");
            // 
            // KitapKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 743);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOgrenciAdi);
            this.Controls.Add(this.cmbKitapAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtOgrenciID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtKitapID);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelmenü);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapKiralama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapKiralama";
            this.Load += new System.EventHandler(this.KitapKiralama_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelmenü.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtOgrenciID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Kullanıcı;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelmenü;
        private System.Windows.Forms.ImageList ımageList6;
        private System.Windows.Forms.ImageList ımageList4;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKitapAdi;
        private System.Windows.Forms.ComboBox cmbOgrenciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ImageList ımageList5;
    }
}