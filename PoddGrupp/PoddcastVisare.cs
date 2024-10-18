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
            poddcastController = new PoddcastController(); //Initiera controller
        }
        private void PoddcastVisare_Load(object sender, EventArgs e)
        {
            //Fyller listan på flöden när man öppnar appen
            FyllFlodeLista();
        }

        private void FyllFlodeLista()
        {
            listaFloden.Items.Clear(); //Rensar listan innan den fylls på nytt

            var allaFloden = poddcastController.HämtaAllaPoddcast(); //Hämtar alla befintliga flöden

            //LINQ används för att skapa en lista med alla flödens namn och sätta in de i vår form
            listaFloden.Items.AddRange(allaFloden.Select(p => p.Namn).ToArray());
        }

        private void btnLaggTill_Click(object sender, EventArgs e)
        {
            //Lagrar den inmatade informationen i olika variabler
            string rssUrl = tbRSS.Text;
            string kategori = cbKategori.SelectedItem.ToString();
            string namn = tbNamn.Text;

            try
            {
                poddcastController.LaggTillFlode(rssUrl, namn, kategori);
                MessageBox.Show("Flödet har lagts till!");
            } catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Töm fälten för RSS och Namn
            tbRSS.Text = "";
            tbNamn.Text = "";
            //Uppdatera listan
            FyllFlodeLista();
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
