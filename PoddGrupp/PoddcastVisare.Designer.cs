using BL;
using Models;

namespace PoddGrupp
{
    public partial class PoddcastVisare
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("j");
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
            lblKategorier = new Label();
            listaKategorier = new ListBox();
            btnTaBortKategori = new Button();
            btnAndraKategori = new Button();
            btnLaggTillKategori = new Button();
            tbNamnKategori = new TextBox();
            lblAvsnitt = new Label();
            beskrivningAvsnitt = new RichTextBox();
            listaAvsnitt = new ListBox();
            btnAterstall = new Button();
            comboBox1 = new ComboBox();
            lblNamnPaKategori = new Label();
            listViewPodd = new ListView();
            columnNamn = new ColumnHeader();
            columnKategori = new ColumnHeader();
            SuspendLayout();
            // 
            // lblPoddcast
            // 
            lblPoddcast.AutoSize = true;
            lblPoddcast.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPoddcast.ForeColor = Color.Sienna;
            lblPoddcast.Location = new Point(294, 23);
            lblPoddcast.Name = "lblPoddcast";
            lblPoddcast.Size = new Size(143, 44);
            lblPoddcast.TabIndex = 0;
            lblPoddcast.Text = "Poddcast";
            // 
            // tbNamn
            // 
            tbNamn.Location = new Point(221, 798);
            tbNamn.Name = "tbNamn";
            tbNamn.Size = new Size(178, 31);
            tbNamn.TabIndex = 2;
            // 
            // lblNamnPaFlodet
            // 
            lblNamnPaFlodet.AutoSize = true;
            lblNamnPaFlodet.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNamnPaFlodet.Location = new Point(50, 798);
            lblNamnPaFlodet.Name = "lblNamnPaFlodet";
            lblNamnPaFlodet.Size = new Size(153, 28);
            lblNamnPaFlodet.TabIndex = 3;
            lblNamnPaFlodet.Text = "Namn på flödet:";
            // 
            // lblRSSLank
            // 
            lblRSSLank.AutoSize = true;
            lblRSSLank.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRSSLank.Location = new Point(50, 737);
            lblRSSLank.Name = "lblRSSLank";
            lblRSSLank.Size = new Size(105, 28);
            lblRSSLank.TabIndex = 5;
            lblRSSLank.Text = "RSS Länk:";
            // 
            // tbRSS
            // 
            tbRSS.Location = new Point(221, 737);
            tbRSS.Name = "tbRSS";
            tbRSS.Size = new Size(393, 31);
            tbRSS.TabIndex = 4;
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Items.AddRange(new object[] { "Okategoriserad" });
            cbKategori.Location = new Point(221, 845);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(178, 33);
            cbKategori.TabIndex = 6;
            cbKategori.Text = "Okategoriserad";
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
            // 
            // btnLaggTill
            // 
            btnLaggTill.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLaggTill.Location = new Point(57, 920);
            btnLaggTill.Name = "btnLaggTill";
            btnLaggTill.Size = new Size(109, 48);
            btnLaggTill.TabIndex = 8;
            btnLaggTill.Text = "Lägg Till";
            btnLaggTill.UseVisualStyleBackColor = true;
            btnLaggTill.Click += btnLaggTill_Click;
            // 
            // btnAndra
            // 
            btnAndra.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAndra.Location = new Point(373, 920);
            btnAndra.Name = "btnAndra";
            btnAndra.Size = new Size(90, 48);
            btnAndra.TabIndex = 9;
            btnAndra.Text = "Ändra";
            btnAndra.UseVisualStyleBackColor = true;
            // 
            // btnTaBort
            // 
            btnTaBort.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTaBort.Location = new Point(221, 920);
            btnTaBort.Name = "btnTaBort";
            btnTaBort.Size = new Size(90, 48);
            btnTaBort.TabIndex = 10;
            btnTaBort.Text = "Ta Bort";
            btnTaBort.UseVisualStyleBackColor = true;
            btnTaBort.Click += btnTaBort_Click;
            // 
            // lblKategorier
            // 
            lblKategorier.AutoSize = true;
            lblKategorier.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKategorier.ForeColor = Color.Sienna;
            lblKategorier.Location = new Point(1540, 725);
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
            listaKategorier.Location = new Point(1497, 788);
            listaKategorier.Name = "listaKategorier";
            listaKategorier.Size = new Size(254, 200);
            listaKategorier.TabIndex = 14;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTaBortKategori.Location = new Point(1193, 928);
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
            btnAndraKategori.Location = new Point(1346, 925);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.Size = new Size(86, 37);
            btnAndraKategori.TabIndex = 17;
            btnAndraKategori.Text = "Ändra";
            btnAndraKategori.UseVisualStyleBackColor = true;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLaggTillKategori.Location = new Point(1061, 928);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(89, 32);
            btnLaggTillKategori.TabIndex = 16;
            btnLaggTillKategori.Text = "Lägg Till";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            // 
            // tbNamnKategori
            // 
            tbNamnKategori.Location = new Point(1267, 818);
            tbNamnKategori.Name = "tbNamnKategori";
            tbNamnKategori.Size = new Size(163, 31);
            tbNamnKategori.TabIndex = 19;
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAvsnitt.ForeColor = Color.Sienna;
            lblAvsnitt.Location = new Point(1027, 23);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(126, 44);
            lblAvsnitt.TabIndex = 23;
            lblAvsnitt.Text = "Avsnitt";
            // 
            // beskrivningAvsnitt
            // 
            beskrivningAvsnitt.Location = new Point(1497, 75);
            beskrivningAvsnitt.Name = "beskrivningAvsnitt";
            beskrivningAvsnitt.Size = new Size(263, 592);
            beskrivningAvsnitt.TabIndex = 22;
            beskrivningAvsnitt.Text = "";
            // 
            // listaAvsnitt
            // 
            listaAvsnitt.BackColor = SystemColors.Window;
            listaAvsnitt.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listaAvsnitt.FormattingEnabled = true;
            listaAvsnitt.ItemHeight = 28;
            listaAvsnitt.Location = new Point(787, 75);
            listaAvsnitt.Name = "listaAvsnitt";
            listaAvsnitt.Size = new Size(643, 564);
            listaAvsnitt.TabIndex = 21;
            // 
            // btnAterstall
            // 
            btnAterstall.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAterstall.Location = new Point(650, 808);
            btnAterstall.Name = "btnAterstall";
            btnAterstall.Size = new Size(154, 48);
            btnAterstall.TabIndex = 24;
            btnAterstall.Text = "Återställ Filter";
            btnAterstall.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(650, 737);
            comboBox1.Margin = new Padding(6, 7, 6, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 33);
            comboBox1.TabIndex = 25;
            comboBox1.Text = "Filtrera utifrån kategori...";
            // 
            // lblNamnPaKategori
            // 
            lblNamnPaKategori.AutoSize = true;
            lblNamnPaKategori.Location = new Point(1079, 823);
            lblNamnPaKategori.Margin = new Padding(4, 0, 4, 0);
            lblNamnPaKategori.Name = "lblNamnPaKategori";
            lblNamnPaKategori.Size = new Size(155, 25);
            lblNamnPaKategori.TabIndex = 26;
            lblNamnPaKategori.Text = "Namn på kategori";
            // 
            // listViewPodd
            // 
            listViewPodd.Columns.AddRange(new ColumnHeader[] { columnNamn, columnKategori });
            listViewPodd.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listViewPodd.Location = new Point(221, 75);
            listViewPodd.Margin = new Padding(4, 5, 4, 5);
            listViewPodd.Name = "listViewPodd";
            listViewPodd.Size = new Size(280, 574);
            listViewPodd.TabIndex = 27;
            listViewPodd.UseCompatibleStateImageBehavior = false;
            listViewPodd.View = View.Details;
            listViewPodd.SelectedIndexChanged += listViewPodd_SelectedIndexChanged_1;
            // 
            // columnNamn
            // 
            columnNamn.Text = "Namn";
            columnNamn.Width = 100;
            // 
            // columnKategori
            // 
            columnKategori.Text = "Kategori";
            columnKategori.Width = 100;
            // 
            // PoddcastVisare
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1846, 1050);
            Controls.Add(listViewPodd);
            Controls.Add(lblNamnPaKategori);
            Controls.Add(comboBox1);
            Controls.Add(btnAterstall);
            Controls.Add(lblAvsnitt);
            Controls.Add(beskrivningAvsnitt);
            Controls.Add(listaAvsnitt);
            Controls.Add(tbNamnKategori);
            Controls.Add(btnTaBortKategori);
            Controls.Add(btnAndraKategori);
            Controls.Add(btnLaggTillKategori);
            Controls.Add(lblKategorier);
            Controls.Add(listaKategorier);
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
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.ListBox listaKategorier;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Button btnAndraKategori;
        private System.Windows.Forms.Button btnLaggTillKategori;
        private System.Windows.Forms.TextBox tbNamnKategori;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.RichTextBox beskrivningAvsnitt;
        private System.Windows.Forms.ListBox listaAvsnitt;
        private System.Windows.Forms.Button btnAterstall;
        private System.Windows.Forms.ComboBox comboBox1;
        private Label lblNamnPaKategori;
        private ListView listViewPodd;
        private ColumnHeader columnNamn;
        private ColumnHeader columnKategori;
    }
}

