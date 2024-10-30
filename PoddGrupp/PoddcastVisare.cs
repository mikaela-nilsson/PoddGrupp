using BL;
using DL;
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
        private KategoriController kategoriController;
        private List<Kategori> kategoriLista = new List<Kategori>();
        private PoddRepository poddRepository = new PoddRepository();

        public PoddcastVisare()
        {
            InitializeComponent();
            poddcastController = new PoddcastController();
            kategoriController = new KategoriController();
            btnAndra.Click += btnAndra_Click;
            btnAterstall.Click += btnAterstall_Click;
            this.FormClosing += new FormClosingEventHandler(PoddcastVisare_FormClosing);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);


        }

        //Metod som körs när formuläret laddas. Den anropar en annan metod (FyllFlodeLista) för att fylla 
        //en lista med poddcastflöden när formuläret visas för användaren
        private void PoddcastVisare_Load(object sender, EventArgs e)
        {
            poddcastLista.Clear(); //Rensar poddcastListan
            poddcastLista = poddcastController.HamtaAllaPoddcast(); //Fyller poddcastLista med Poddcast objekt
            FyllFlodeLista();
            FyllComboBoxMedKategorier(); // Fyller kategorier i comboboxen

            cbAndra.Items.Add("Ändra namn");
            cbAndra.Items.Add("Ändra kategori");
            cbAndra.SelectedIndex = 0; // Sätt standardval

            listaAvsnitt.SelectedIndexChanged += listaAvsnitt_SelectedIndexChanged;
            FyllKategoriComboBoxOchLista();
            cbKategori.SelectedIndex = 0; //Sätter standardvalet för kategori
        }
        private void FyllKategoriComboBoxOchLista()
        {
            cbKategori.Items.Clear();
            listaKategorier.Items.Clear();
            comboBox1.Items.Clear();
            var allaKategorier = kategoriController.HamtaAllaKategorier().Select(k => k.Namn).ToArray();
            cbKategori.Items.AddRange(allaKategorier);
            listaKategorier.Items.AddRange(allaKategorier);
            comboBox1.Items.AddRange(allaKategorier);
            
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

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            //Kontroller att man har valt en kategori i listan
            if (listaKategorier.SelectedItem == null)
            {
                MessageBox.Show("Vänligen välj en kategori från listan till höger");
                return;
            }

            string kategoriNamn = listaKategorier.SelectedItem.ToString();

            DialogResult result = MessageBox.Show("Är du säker på att du vill ta bort " + kategoriNamn + "?", "Bekräftelse", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    kategoriController.TaBortKategori(kategoriNamn);
                    var poddarAttUppdatera = poddcastController.HamtaAllaPoddcastMedKategori(kategoriNamn);

                    //Uppdatera flödena till att få kategorin "Okategoriserad"
                    foreach (var podd in poddarAttUppdatera)
                    {
                        poddcastController.AndraPoddcastKategori(podd.Namn, "Okategoriserad");
                    }

                    MessageBox.Show("Kategorin har tagits bort och flödena har uppdaterats till 'Okategoriserad'");

                    FyllKategoriComboBoxOchLista();
                    FyllFlodeLista();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // Rensa textfältet
                tbNamnKategori.Text = "";
            }
        }

        private void btnAndra_Click(object sender, EventArgs e)

        {
            // Kontrollera att en poddcast är vald
            if (listViewPodd.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vänligen välj en poddcast från listan.");
                return;
            }

            string val = cbAndra.SelectedItem.ToString();

            if (val == "Ändra kategori")
            {
                string gammaltKategoriNamn = listViewPodd.SelectedItems[0].SubItems[1].Text; // Kategori är på index 1

                string nyKategori = cbKategori.SelectedItem.ToString();

                string valtPoddNamn = listViewPodd.SelectedItems[0].Text;

                try
                {
                    poddcastController.AndraPoddcastKategori(valtPoddNamn, nyKategori);

                    // Uppdatera listan för att visa den nya kategorin
                    FyllFlodeLista();

                    MessageBox.Show("Kategorin har ändrats.");

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ett fel inträffade: {ex.Message}");
                }
            }
            else if (val == "Ändra namn")

            {            // Hämta det gamla namnet från den valda poddcasten
                string gammaltNamn = listViewPodd.SelectedItems[0].SubItems[0].Text;
                string nyttNamn = tbNamn.Text; // Använd textboxen för det nya namnet

                if (string.IsNullOrWhiteSpace(nyttNamn))
                {
                    MessageBox.Show("Nytt namn kan inte vara tomt.");
                    return;
                }

                try
                {
                    // Kalla på metoden för att ändra namnet
                    poddcastController.RedigeraFlodeNamn(gammaltNamn, nyttNamn);
                    MessageBox.Show("Poddcastnamn har ändrats.");

                    // Uppdatera listan för att visa det nya namnet
                    FyllFlodeLista();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ett fel inträffade: {ex.Message}");
                }
            }
        }



        private void PoddcastVisare_FormClosing(object sender, FormClosingEventArgs e)
        {
            poddcastController.SparaData(); // Spara podcasts
            kategoriController.SparaKategorier(); // Spara kategorier
        }


        private void btnLaggTillKategori_Click_1(object sender, EventArgs e)
        {
            FyllKategoriComboBoxOchLista();
            string nyKategori = tbNamnKategori.Text.Trim();

            if (!string.IsNullOrWhiteSpace(nyKategori))
            {
                try
                {
                    kategoriController.LaggTillKategori(nyKategori); // Här anropas metoden
                    FyllKategoriComboBoxOchLista(); // Uppdaterar listan
                    tbNamnKategori.Clear(); // Rensar fältet
                    MessageBox.Show("Kategorin har lagts till.");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message); // Visa felmeddelande om något går fel
                }
            }
            else
            {
                MessageBox.Show("Kategorinamn kan inte vara tomt."); // Kontrollera om textfältet är tomt
            }
        }

        private void btnAndraKategori_Click(object sender, EventArgs e)
        {
            // Kontrollera att en kategori är vald
            if (listaKategorier.SelectedItem == null)
            {
                MessageBox.Show("Vänligen välj en kategori från listan.");
                return;
            }

            // Hämta den valda kategorin
            string gammaltKategoriNamn = listaKategorier.SelectedItem.ToString();

            //Kontrollerar om man försöker ändra kategorin "Okategoriserad"
            if (gammaltKategoriNamn == "Okategoriserad")
            {
                MessageBox.Show("Kategorin 'Okategoriserad' kan inte ändras.");
                return;
            }

            // Hämta det nya namnet från en TextBox
            string nyttKategoriNamn = tbNamnKategori.Text.Trim(); 

            if (string.IsNullOrWhiteSpace(nyttKategoriNamn))
            {
                MessageBox.Show("Nytt namn kan inte vara tomt.");
                return;
            }

            try
            {
                // Anropa metoden för att ändra namnet
                kategoriController.RedigeraKategori(gammaltKategoriNamn, nyttKategoriNamn);

                //Hämtar alla Poddcast objekt med den ändrade kategorin
                var poddarAttUppdatera = poddcastController.HamtaAllaPoddcastMedKategori(gammaltKategoriNamn);
                //Ändrar varje hämtad Poddcast och ändrar dess kategori
                foreach (var podd in poddarAttUppdatera)
                {
                    poddcastController.AndraPoddcastKategori(podd.Namn, nyttKategoriNamn);
                }

                // Uppdatera listorna för att visa det nya namnet
                FyllKategoriComboBoxOchLista();
                FyllFlodeLista();

                MessageBox.Show("Kategorin har ändrats.");

                // Rensa TextBoxen
                tbNamnKategori.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel inträffade: {ex.Message}");
            }
        }

        private void FyllComboBoxMedKategorier()
        {
            // Töm comboboxen först för att undvika dubbletter
            comboBox1.Items.Clear();

            // Hämta alla kategorier från kategoriController
            var kategorier = kategoriController.HamtaAllaKategorier();

            // Lägg till varje kategori i comboboxen
            foreach (var kategori in kategorier)
            {
                comboBox1.Items.Add(kategori.Namn);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kontrollera att något är valt
            if (comboBox1.SelectedItem != null)
            {
                // Hämta vald kategori
                string valdKategori = comboBox1.SelectedItem.ToString();

                // Hämta alla poddar och filtrera dem efter den valda kategorin
                var filtreradePoddar = poddcastController.HamtaAllaPoddcast()
                    .Where(podd => podd.Kategori == valdKategori).ToList();

                // Töm listan som visar poddar
                listViewPodd.Items.Clear();

                // Lägg till filtrerade poddar till listView
                foreach (var podd in filtreradePoddar)
                {
                    ListViewItem item = new ListViewItem(podd.Namn);
                    item.SubItems.Add(podd.Kategori);
                    listViewPodd.Items.Add(item);
                }


            }

        }
        private void btnAterstall_Click(object sender, EventArgs e)
        {
            try
            {
                string filnamn = "data.xml"; // Sätt namnet på din sparade XML-fil här

                // Ladda poddar från XML-filen
                poddRepository.LaddaDataFranXml(filnamn);

                // Anropa metoden för att fylla listan efter återställning
                FyllFlodeLista();

                MessageBox.Show("Poddarna har återställts till det senaste sparade tillståndet.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel inträffade vid återställning: {ex.Message}");
            }
        }
    }
}




















