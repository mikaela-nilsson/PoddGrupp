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
            this.lblPoddcast = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNamnPaFlodet = new System.Windows.Forms.Label();
            this.lblRSSLank = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnLaggTill = new System.Windows.Forms.Button();
            this.btnAndra = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.listaFloden = new System.Windows.Forms.ListBox();
            this.lblKategorier = new System.Windows.Forms.Label();
            this.listaKategorier = new System.Windows.Forms.ListBox();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.btnAndraKategori = new System.Windows.Forms.Button();
            this.btnLaggTillKategori = new System.Windows.Forms.Button();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.beskrivningAvsnitt = new System.Windows.Forms.RichTextBox();
            this.listaAvsnitt = new System.Windows.Forms.ListBox();
            this.btnAterstall = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPoddcast
            // 
            this.lblPoddcast.AutoSize = true;
            this.lblPoddcast.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoddcast.ForeColor = System.Drawing.Color.Sienna;
            this.lblPoddcast.Location = new System.Drawing.Point(169, 9);
            this.lblPoddcast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoddcast.Name = "lblPoddcast";
            this.lblPoddcast.Size = new System.Drawing.Size(99, 28);
            this.lblPoddcast.TabIndex = 0;
            this.lblPoddcast.Text = "Poddcast";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 399);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblNamnPaFlodet
            // 
            this.lblNamnPaFlodet.AutoSize = true;
            this.lblNamnPaFlodet.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamnPaFlodet.Location = new System.Drawing.Point(30, 399);
            this.lblNamnPaFlodet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamnPaFlodet.Name = "lblNamnPaFlodet";
            this.lblNamnPaFlodet.Size = new System.Drawing.Size(101, 18);
            this.lblNamnPaFlodet.TabIndex = 3;
            this.lblNamnPaFlodet.Text = "Namn på flödet:";
            // 
            // lblRSSLank
            // 
            this.lblRSSLank.AutoSize = true;
            this.lblRSSLank.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSSLank.Location = new System.Drawing.Point(30, 366);
            this.lblRSSLank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRSSLank.Name = "lblRSSLank";
            this.lblRSSLank.Size = new System.Drawing.Size(69, 18);
            this.lblRSSLank.TabIndex = 5;
            this.lblRSSLank.Text = "RSS Länk:";
            this.lblRSSLank.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 366);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(133, 423);
            this.cbKategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(109, 21);
            this.cbKategori.TabIndex = 6;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(30, 423);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(61, 18);
            this.lblKategori.TabIndex = 7;
            this.lblKategori.Text = "Kategori:";
            this.lblKategori.Click += new System.EventHandler(this.lblKategori_Click);
            // 
            // btnLaggTill
            // 
            this.btnLaggTill.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaggTill.Location = new System.Drawing.Point(34, 462);
            this.btnLaggTill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLaggTill.Name = "btnLaggTill";
            this.btnLaggTill.Size = new System.Drawing.Size(65, 25);
            this.btnLaggTill.TabIndex = 8;
            this.btnLaggTill.Text = "Lägg Till";
            this.btnLaggTill.UseVisualStyleBackColor = true;
            this.btnLaggTill.Click += new System.EventHandler(this.btnLaggTill_Click);
            // 
            // btnAndra
            // 
            this.btnAndra.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndra.Location = new System.Drawing.Point(224, 462);
            this.btnAndra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAndra.Name = "btnAndra";
            this.btnAndra.Size = new System.Drawing.Size(54, 25);
            this.btnAndra.TabIndex = 9;
            this.btnAndra.Text = "Ändra";
            this.btnAndra.UseVisualStyleBackColor = true;
            // 
            // btnTaBort
            // 
            this.btnTaBort.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBort.Location = new System.Drawing.Point(133, 462);
            this.btnTaBort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(54, 25);
            this.btnTaBort.TabIndex = 10;
            this.btnTaBort.Text = "Ta Bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // listaFloden
            // 
            this.listaFloden.BackColor = System.Drawing.SystemColors.Window;
            this.listaFloden.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaFloden.FormattingEnabled = true;
            this.listaFloden.ItemHeight = 18;
            this.listaFloden.Location = new System.Drawing.Point(33, 39);
            this.listaFloden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaFloden.Name = "listaFloden";
            this.listaFloden.Size = new System.Drawing.Size(512, 292);
            this.listaFloden.TabIndex = 11;
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.ForeColor = System.Drawing.Color.Sienna;
            this.lblKategorier.Location = new System.Drawing.Point(812, 399);
            this.lblKategorier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(112, 28);
            this.lblKategorier.TabIndex = 15;
            this.lblKategorier.Text = "Kategorier";
            // 
            // listaKategorier
            // 
            this.listaKategorier.BackColor = System.Drawing.SystemColors.Window;
            this.listaKategorier.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaKategorier.FormattingEnabled = true;
            this.listaKategorier.ItemHeight = 18;
            this.listaKategorier.Location = new System.Drawing.Point(700, 429);
            this.listaKategorier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaKategorier.Name = "listaKategorier";
            this.listaKategorier.Size = new System.Drawing.Size(352, 130);
            this.listaKategorier.TabIndex = 14;
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBortKategori.Location = new System.Drawing.Point(700, 658);
            this.btnTaBortKategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(54, 25);
            this.btnTaBortKategori.TabIndex = 18;
            this.btnTaBortKategori.Text = "Ta Bort";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
            // 
            // btnAndraKategori
            // 
            this.btnAndraKategori.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndraKategori.Location = new System.Drawing.Point(700, 578);
            this.btnAndraKategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAndraKategori.Name = "btnAndraKategori";
            this.btnAndraKategori.Size = new System.Drawing.Size(54, 25);
            this.btnAndraKategori.TabIndex = 17;
            this.btnAndraKategori.Text = "Ändra";
            this.btnAndraKategori.UseVisualStyleBackColor = true;
            // 
            // btnLaggTillKategori
            // 
            this.btnLaggTillKategori.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaggTillKategori.Location = new System.Drawing.Point(700, 616);
            this.btnLaggTillKategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLaggTillKategori.Name = "btnLaggTillKategori";
            this.btnLaggTillKategori.Size = new System.Drawing.Size(65, 25);
            this.btnLaggTillKategori.TabIndex = 16;
            this.btnLaggTillKategori.Text = "Lägg Till";
            this.btnLaggTillKategori.UseVisualStyleBackColor = true;
            this.btnLaggTillKategori.Click += new System.EventHandler(this.btnLaggTillKategori_Click);
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(779, 581);
            this.tbKategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(99, 20);
            this.tbKategori.TabIndex = 19;
            this.tbKategori.TextChanged += new System.EventHandler(this.tbKategori_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(779, 619);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 20);
            this.textBox3.TabIndex = 20;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnitt.ForeColor = System.Drawing.Color.Sienna;
            this.lblAvsnitt.Location = new System.Drawing.Point(838, 9);
            this.lblAvsnitt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(86, 28);
            this.lblAvsnitt.TabIndex = 23;
            this.lblAvsnitt.Text = "Avsnitt";
            // 
            // beskrivningAvsnitt
            // 
            this.beskrivningAvsnitt.Location = new System.Drawing.Point(898, 39);
            this.beskrivningAvsnitt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.beskrivningAvsnitt.Name = "beskrivningAvsnitt";
            this.beskrivningAvsnitt.Size = new System.Drawing.Size(159, 329);
            this.beskrivningAvsnitt.TabIndex = 22;
            this.beskrivningAvsnitt.Text = "";
            this.beskrivningAvsnitt.TextChanged += new System.EventHandler(this.beskrivningAvsnitt_TextChanged);
            // 
            // listaAvsnitt
            // 
            this.listaAvsnitt.BackColor = System.Drawing.SystemColors.Window;
            this.listaAvsnitt.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaAvsnitt.FormattingEnabled = true;
            this.listaAvsnitt.ItemHeight = 18;
            this.listaAvsnitt.Location = new System.Drawing.Point(700, 39);
            this.listaAvsnitt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaAvsnitt.Name = "listaAvsnitt";
            this.listaAvsnitt.Size = new System.Drawing.Size(159, 328);
            this.listaAvsnitt.TabIndex = 21;
            this.listaAvsnitt.SelectedIndexChanged += new System.EventHandler(this.listaAvsnitt_SelectedIndexChanged);
            // 
            // btnAterstall
            // 
            this.btnAterstall.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAterstall.Location = new System.Drawing.Point(390, 404);
            this.btnAterstall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAterstall.Name = "btnAterstall";
            this.btnAterstall.Size = new System.Drawing.Size(93, 25);
            this.btnAterstall.TabIndex = 24;
            this.btnAterstall.Text = "Återställ Filter";
            this.btnAterstall.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(390, 366);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.Text = "Filtrera utifrån kategori...";
            // 
            // PoddcastVisare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1090, 721);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAterstall);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.beskrivningAvsnitt);
            this.Controls.Add(this.listaAvsnitt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnAndraKategori);
            this.Controls.Add(this.btnLaggTillKategori);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.listaKategorier);
            this.Controls.Add(this.listaFloden);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnAndra);
            this.Controls.Add(this.btnLaggTill);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.lblRSSLank);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNamnPaFlodet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPoddcast);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PoddcastVisare";
            this.Text = "Poddcast";
            this.Load += new System.EventHandler(this.PoddcastVisare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoddcast;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNamnPaFlodet;
        private System.Windows.Forms.Label lblRSSLank;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.RichTextBox beskrivningAvsnitt;
        private System.Windows.Forms.ListBox listaAvsnitt;
        private System.Windows.Forms.Button btnAterstall;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

