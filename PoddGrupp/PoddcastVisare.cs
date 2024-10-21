using BL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoddGrupp
{
    public partial class PoddcastVisare : Form
    {

        private PoddcastController poddcastController;

        public PoddcastVisare()
        {
            InitializeComponent();
            poddcastController = new PoddcastController(); 
        }

        //Metod som körs när formuläret laddas. Den anropar en annan metod (FyllFlodeLista) för att fylla 
        //en lista med med poddcastflöden när formuläret visas för användaren
        private void PoddcastVisare_Load(object sender, EventArgs e)
        {
            FyllFlodeLista();
        }

        //Hämtar och visar namnen på alla podcast i en lista i användargränssnittet
        private void FyllFlodeLista()
        {
            listaFloden.Items.Clear(); 

            var allaFloden = poddcastController.HämtaAllaPoddcast(); 

            listaFloden.Items.AddRange(allaFloden.Select(p => p.Namn).ToArray());
        }

         //Metoden lägger till en ny podcast genom att läsa den inmatade RSS-länken, namn och kategori
         //och lägger därefter till flödet via controller. Därefter hämtar den avsnitten från poddcastflödet
         //och visar dem i listan över avsnitt. Fungerar det så poppar meddelande upp. 
        private void btnLaggTill_Click(object sender, EventArgs e)
        {
            string rssUrl = tbRSS.Text;
            string kategori = cbKategori.SelectedItem.ToString();
            string namn = tbNamn.Text;

            try
            {
                poddcastController.LaggTillFlode(rssUrl, namn, kategori);

                FyllFlodeLista();  

                List<string> episodes = poddcastController.HämtaPoddcastAvsnitt(rssUrl);

                listaAvsnitt.Items.Clear(); 
                foreach (var episode in episodes)
                {
                    listaAvsnitt.Items.Add(episode); 
                }

                MessageBox.Show("Flödet har lagts till och avsnitten har hämtats!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            tbRSS.Text = "";
            tbNamn.Text = "";
        }

        //Metoden hanterar när man väljer ett poddcastflöde i listan. Den söker efter podcasten med 
        //det valda namnet och om den hittas visas dess avsnitt i en annan lista. 
        //Gör den inte det, då visas ett felmeddelande. 
        private void listaFloden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaFloden.SelectedItem != null)
            {
                string selectedFeedName = listaFloden.SelectedItem.ToString();

                var selectedFeed = poddcastController.HämtaAllaPoddcast().FirstOrDefault(f => f.Namn == selectedFeedName);

                if (selectedFeed != null)
                {
                    listaAvsnitt.Items.Clear();

                    foreach (var episode in selectedFeed.Avsnitt)
                    {
                        listaAvsnitt.Items.Add(episode);
                    }
                }
                else
                {
                    MessageBox.Show("Could not find the selected podcast.");
                }
            }
        }


        private void btnTaBort_Click(object sender, EventArgs e)
        {
            //Kontrollera att man har valt ett flöde från listan
            if (listaFloden.SelectedItem == null)
            {
                MessageBox.Show("Vänligen välj ett flöde att ta bort från listan ovan");
                return;
            }

            string flodeNamn = listaFloden.SelectedItem.ToString();

            //Bekräfta raderingen
            DialogResult result = MessageBox.Show("Är du säker på att du vill ta bort " + flodeNamn + "?", "Bekräftelse", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    poddcastController.TaBortFlode(flodeNamn);

                    //Uppdatera listan
                    FyllFlodeLista();
                    MessageBox.Show("Flödet har tagits bort.");
                } 
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKategori_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLaggTillKategori_Click(object sender, EventArgs e)
        {

        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {

        }

        private void beskrivningAvsnitt_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
