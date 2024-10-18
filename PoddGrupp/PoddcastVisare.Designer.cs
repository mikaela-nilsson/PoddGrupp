namespace PoddGrupp
{
    partial class PoddcastVisare
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
            lblPoddcast = new Label();
            tbNamn = new TextBox();
            lblNamnPaFlodet = new Label();
            lblRSSLank = new Label();
            tbRSS = new TextBox();
            cbKategori = new ComboBox();
            lblKategori = new Label();
            btnLaggTill = new Button();
            btnAndra = new Button();
            btnTaBort = new Button();
            listaFloden = new ListBox();
            lblKategorier = new Label();
            listaKategorier = new ListBox();
            btnTaBortKategori = new Button();
            btnAndraKategori = new Button();
            btnLaggTillKategori = new Button();
            tbAndraKategori = new TextBox();
            tbLaggTillKategori = new TextBox();
            lblAvsnitt = new Label();
            beskrivningAvsnitt = new RichTextBox();
            listaAvsnitt = new ListBox();
            btnAterstall = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // lblPoddcast
            // 
            lblPoddcast.AutoSize = true;
            lblPoddcast.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPoddcast.ForeColor = Color.Sienna;
            lblPoddcast.Location = new Point(373, 17);
            lblPoddcast.Name = "lblPoddcast";
            lblPoddcast.Size = new Size(143, 44);
            lblPoddcast.TabIndex = 0;
            lblPoddcast.Text = "Poddcast";
            // 
            // tbNamn
            // 
            tbNamn.Location = new Point(222, 799);
            tbNamn.Margin = new Padding(3, 4, 3, 4);
            tbNamn.Name = "tbNamn";
            tbNamn.Size = new Size(179, 31);
            tbNamn.TabIndex = 2;
            // 
            // lblNamnPaFlodet
            // 
            lblNamnPaFlodet.AutoSize = true;
            lblNamnPaFlodet.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNamnPaFlodet.Location = new Point(50, 799);
            lblNamnPaFlodet.Name = "lblNamnPaFlodet";
            lblNamnPaFlodet.Size = new Size(153, 28);
            lblNamnPaFlodet.TabIndex = 3;
            lblNamnPaFlodet.Text = "Namn på flödet:";
            // 
            // lblRSSLank
            // 
            lblRSSLank.AutoSize = true;
            lblRSSLank.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRSSLank.Location = new Point(50, 736);
            lblRSSLank.Name = "lblRSSLank";
            lblRSSLank.Size = new Size(105, 28);
            lblRSSLank.TabIndex = 5;
            lblRSSLank.Text = "RSS Länk:";
            lblRSSLank.Click += label1_Click;
            // 
            // tbRSS
            // 
            tbRSS.Location = new Point(222, 736);
            tbRSS.Margin = new Padding(3, 4, 3, 4);
            tbRSS.Name = "tbRSS";
            tbRSS.Size = new Size(392, 31);
            tbRSS.TabIndex = 4;
            tbRSS.TextChanged += textBox2_TextChanged;
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(222, 845);
            cbKategori.Margin = new Padding(3, 4, 3, 4);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(179, 33);
            cbKategori.TabIndex = 6;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKategori.Location = new Point(50, 845);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(93, 28);
            lblKategori.TabIndex = 7;
            lblKategori.Text = "Kategori:";
            lblKategori.Click += lblKategori_Click;
            // 
            // btnLaggTill
            // 
            btnLaggTill.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLaggTill.Location = new Point(57, 920);
            btnLaggTill.Margin = new Padding(3, 4, 3, 4);
            btnLaggTill.Name = "btnLaggTill";
            btnLaggTill.Size = new Size(108, 48);
            btnLaggTill.TabIndex = 8;
            btnLaggTill.Text = "Lägg Till";
            btnLaggTill.UseVisualStyleBackColor = true;
            btnLaggTill.Click += btnLaggTill_Click;
            // 
            // btnAndra
            // 
            btnAndra.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAndra.Location = new Point(373, 920);
            btnAndra.Margin = new Padding(3, 4, 3, 4);
            btnAndra.Name = "btnAndra";
            btnAndra.Size = new Size(90, 48);
            btnAndra.TabIndex = 9;
            btnAndra.Text = "Ändra";
            btnAndra.UseVisualStyleBackColor = true;
            // 
            // btnTaBort
            // 
            btnTaBort.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTaBort.Location = new Point(222, 920);
            btnTaBort.Margin = new Padding(3, 4, 3, 4);
            btnTaBort.Name = "btnTaBort";
            btnTaBort.Size = new Size(90, 48);
            btnTaBort.TabIndex = 10;
            btnTaBort.Text = "Ta Bort";
            btnTaBort.UseVisualStyleBackColor = true;
            btnTaBort.Click += btnTaBort_Click;
            // 
            // listaFloden
            // 
            listaFloden.BackColor = SystemColors.Window;
            listaFloden.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listaFloden.FormattingEnabled = true;
            listaFloden.ItemHeight = 28;
            listaFloden.Location = new Point(55, 75);
            listaFloden.Margin = new Padding(3, 4, 3, 4);
            listaFloden.Name = "listaFloden";
            listaFloden.Size = new Size(851, 592);
            listaFloden.TabIndex = 11;
            // 
            // lblKategorier
            // 
            lblKategorier.AutoSize = true;
            lblKategorier.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKategorier.ForeColor = Color.Sienna;
            lblKategorier.Location = new Point(1374, 726);
            lblKategorier.Name = "lblKategorier";
            lblKategorier.Size = new Size(163, 44);
            lblKategorier.TabIndex = 15;
            lblKategorier.Text = "Kategorier";
            // 
            // listaKategorier
            // 
            listaKategorier.BackColor = SystemColors.Window;
            listaKategorier.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listaKategorier.FormattingEnabled = true;
            listaKategorier.ItemHeight = 28;
            listaKategorier.Location = new Point(1497, 789);
            listaKategorier.Margin = new Padding(3, 4, 3, 4);
            listaKategorier.Name = "listaKategorier";
            listaKategorier.Size = new Size(254, 228);
            listaKategorier.TabIndex = 14;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTaBortKategori.Location = new Point(1194, 898);
            btnTaBortKategori.Margin = new Padding(3, 4, 3, 4);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(84, 32);
            btnTaBortKategori.TabIndex = 18;
            btnTaBortKategori.Text = "Ta Bort";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            btnTaBortKategori.Click += btnTaBortKategori_Click;
            // 
            // btnAndraKategori
            // 
            btnAndraKategori.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAndraKategori.Location = new Point(1193, 789);
            btnAndraKategori.Margin = new Padding(3, 4, 3, 4);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.Size = new Size(85, 37);
            btnAndraKategori.TabIndex = 17;
            btnAndraKategori.Text = "Ändra";
            btnAndraKategori.UseVisualStyleBackColor = true;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLaggTillKategori.Location = new Point(1189, 847);
            btnLaggTillKategori.Margin = new Padding(3, 4, 3, 4);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(89, 32);
            btnLaggTillKategori.TabIndex = 16;
            btnLaggTillKategori.Text = "Lägg Till";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click;
            // 
            // tbAndraKategori
            // 
            tbAndraKategori.Location = new Point(1294, 790);
            tbAndraKategori.Margin = new Padding(3, 4, 3, 4);
            tbAndraKategori.Name = "tbAndraKategori";
            tbAndraKategori.Size = new Size(162, 31);
            tbAndraKategori.TabIndex = 19;
            tbAndraKategori.TextChanged += tbKategori_TextChanged;
            // 
            // tbLaggTillKategori
            // 
            tbLaggTillKategori.Location = new Point(1294, 848);
            tbLaggTillKategori.Margin = new Padding(3, 4, 3, 4);
            tbLaggTillKategori.Name = "tbLaggTillKategori";
            tbLaggTillKategori.Size = new Size(162, 31);
            tbLaggTillKategori.TabIndex = 20;
            tbLaggTillKategori.TextChanged += textBox3_TextChanged;
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAvsnitt.ForeColor = Color.Sienna;
            lblAvsnitt.Location = new Point(1397, 17);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(126, 44);
            lblAvsnitt.TabIndex = 23;
            lblAvsnitt.Text = "Avsnitt";
            // 
            // beskrivningAvsnitt
            // 
            beskrivningAvsnitt.Location = new Point(1497, 75);
            beskrivningAvsnitt.Margin = new Padding(3, 4, 3, 4);
            beskrivningAvsnitt.Name = "beskrivningAvsnitt";
            beskrivningAvsnitt.Size = new Size(262, 592);
            beskrivningAvsnitt.TabIndex = 22;
            beskrivningAvsnitt.Text = "";
            beskrivningAvsnitt.TextChanged += beskrivningAvsnitt_TextChanged;
            // 
            // listaAvsnitt
            // 
            listaAvsnitt.BackColor = SystemColors.Window;
            listaAvsnitt.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listaAvsnitt.FormattingEnabled = true;
            listaAvsnitt.ItemHeight = 28;
            listaAvsnitt.Location = new Point(1167, 75);
            listaAvsnitt.Margin = new Padding(3, 4, 3, 4);
            listaAvsnitt.Name = "listaAvsnitt";
            listaAvsnitt.Size = new Size(262, 592);
            listaAvsnitt.TabIndex = 21;
            listaAvsnitt.SelectedIndexChanged += listaAvsnitt_SelectedIndexChanged;
            // 
            // btnAterstall
            // 
            btnAterstall.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAterstall.Location = new Point(650, 809);
            btnAterstall.Margin = new Padding(3, 4, 3, 4);
            btnAterstall.Name = "btnAterstall";
            btnAterstall.Size = new Size(155, 48);
            btnAterstall.TabIndex = 24;
            btnAterstall.Text = "Återställ Filter";
            btnAterstall.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(650, 736);
            comboBox1.Margin = new Padding(5, 6, 5, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(256, 33);
            comboBox1.TabIndex = 25;
            comboBox1.Text = "Filtrera utifrån kategori...";
            // 
            // PoddcastVisare
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1846, 1050);
            Controls.Add(comboBox1);
            Controls.Add(btnAterstall);
            Controls.Add(lblAvsnitt);
            Controls.Add(beskrivningAvsnitt);
            Controls.Add(listaAvsnitt);
            Controls.Add(tbLaggTillKategori);
            Controls.Add(tbAndraKategori);
            Controls.Add(btnTaBortKategori);
            Controls.Add(btnAndraKategori);
            Controls.Add(btnLaggTillKategori);
            Controls.Add(lblKategorier);
            Controls.Add(listaKategorier);
            Controls.Add(listaFloden);
            Controls.Add(btnTaBort);
            Controls.Add(btnAndra);
            Controls.Add(btnLaggTill);
            Controls.Add(lblKategori);
            Controls.Add(cbKategori);
            Controls.Add(lblRSSLank);
            Controls.Add(tbRSS);
            Controls.Add(lblNamnPaFlodet);
            Controls.Add(tbNamn);
            Controls.Add(lblPoddcast);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PoddcastVisare";
            Text = "Poddcast";
            Load += PoddcastVisare_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPoddcast;
        private System.Windows.Forms.TextBox tbNamn;
        private System.Windows.Forms.Label lblNamnPaFlodet;
        private System.Windows.Forms.Label lblRSSLank;
        private System.Windows.Forms.TextBox tbRSS;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnLaggTill;
        private System.Windows.Forms.Button btnAndra;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.ListBox listaFloden;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.ListBox listaKategorier;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Button btnAndraKategori;
        private System.Windows.Forms.Button btnLaggTillKategori;
        private System.Windows.Forms.TextBox tbAndraKategori;
        private System.Windows.Forms.TextBox tbLaggTillKategori;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.RichTextBox beskrivningAvsnitt;
        private System.Windows.Forms.ListBox listaAvsnitt;
        private System.Windows.Forms.Button btnAterstall;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

