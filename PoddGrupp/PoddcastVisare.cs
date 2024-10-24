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
        private List<Poddcast> poddcastLista = new List<Poddcast>(); // Lista som håller alla poddavsnitt

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
            listaAvsnitt.SelectedIndexChanged += listaAvsnitt_SelectedIndexChanged;
        }

        //Hämtar och visar namnen på alla podcast i en lista i användargränssnittet
        private void FyllFlodeLista()
        {
            listViewPodd.Items.Clear();

            var allaFloden = poddcastController.HamtaAllaPoddcast();

            listViewPodd.Items.AddRange(allaFloden.Select(podd =>
            {
                var item = new ListViewItem(podd.Namn);
                item.SubItems.Add(podd.Kategori);
                return item;
            })
                .ToArray());
        }

        

        private void listaAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kontrollera att ett avsnitt är valt och att det finns poddcastobjekt
            if (listaAvsnitt.SelectedIndex >= 0 && listViewPodd.SelectedItems.Count > 0)
            {
                // Hämta den valda poddcasten
                int valtPoddcastIndex = listViewPodd.SelectedItems[0].Index;
                Poddcast valdPoddcast = poddcastLista[valtPoddcastIndex];

                // Hämta det valda avsnittets index
                int valtAvsnittsIndex = listaAvsnitt.SelectedIndex;

                // Visa rätt beskrivning för det valda avsnittet
                beskrivningAvsnitt.Clear();
                beskrivningAvsnitt.AppendText(valdPoddcast.AvsnittBeskrivning[valtAvsnittsIndex]);
            }
        }

        //Denna metod lägger till poddcast i listan, hämtar avsnitt som tillhör den podcast du klickar på och hämtar beskrivning för det avsnitt som användaren klickar på. 
        private void btnLaggTill_Click(object sender, EventArgs e)
        {
            string rssUrl = tbRSS.Text;
            string kategori = cbKategori.SelectedItem.ToString();
            string namn = tbNamn.Text;

            try
            {
                // Lägg till poddcasten i systemet
                poddcastController.LaggTillFlode(rssUrl, namn, kategori);

                // Hämta avsnitt och deras beskrivningar
                List<string> avsnittTitlar = poddcastController.HamtaPoddcastAvsnitt(rssUrl);
                List<string> avsnittBeskrivningar = poddcastController.HamtaAvsnittBeskrivning(rssUrl);

                // Skapa ett nytt Poddcast-objekt och lägg till det i listan
                Poddcast nyPoddcast = new Poddcast
                {
                    Namn = namn,
                    Kategori = kategori,
                    RSS = rssUrl,
                    Avsnitt = avsnittTitlar,
                    AvsnittBeskrivning = avsnittBeskrivningar
                };

                poddcastLista.Add(nyPoddcast); // Lägg till poddcast i listan

                // Lägg till poddcastens namn i ListViewPodd
                ListViewItem item = new ListViewItem(nyPoddcast.Namn);
                item.SubItems.Add(nyPoddcast.Kategori);
                item.SubItems.Add(nyPoddcast.RSS);
                listViewPodd.Items.Add(item);

                MessageBox.Show("Poddcasten har lagts till!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel inträffade: {ex.Message}");
            }

            // Rensa textfälten
            tbRSS.Text = "";
            tbNamn.Text = "";
        }



        private void btnTaBort_Click(object sender, EventArgs e)
        {
            //Kontrollera att man har valt ett flöde från listan
            if (listViewPodd.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vänligen välj ett flöde att ta bort från listan ovan");
                return;
            }

            string flodeNamn = listViewPodd.SelectedItems[0].SubItems[0].Text;

            //Bekräfta raderingen
            DialogResult result = MessageBox.Show("Är du säker på att du vill ta bort " + flodeNamn + "?", "Bekräftelse", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    poddcastController.TaBortFlode(flodeNamn);

                    //Uppdatera listan
                    FyllFlodeLista();
                    listaAvsnitt.Items.Clear();
                    MessageBox.Show("Flödet har tagits bort.");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        //Metoden hanterar när man väljer ett poddcastflöde i listan. Den söker efter podcasten med 
        //det valda namnet och om den hittas visas dess avsnitt i en annan lista. 
        //Gör den inte det, då visas ett felmeddelande. 
        //private void listViewPodd_SelectedIndexChanged(object sender, EventArgs e)
        private void listViewPodd_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewPodd.SelectedItems.Count > 0)
            {
                string selectedFeedName = listViewPodd.SelectedItems[0].SubItems[0].Text;

                var selectedFeed = poddcastController.HamtaAllaPoddcast().FirstOrDefault(f => f.Namn == selectedFeedName);

                if (selectedFeed != null)
                {
                    listaAvsnitt.Items.Clear();
                    listaAvsnitt.Items.AddRange(selectedFeed.Avsnitt.Select(avsnitt => (object)avsnitt).ToArray());
                }
                else
                {
                    MessageBox.Show("Kunde inte hitta den valda podcasten.");
                }
            }
        }
    }
}
