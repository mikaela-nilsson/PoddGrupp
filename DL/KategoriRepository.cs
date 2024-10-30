using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class KategoriRepository: IRepository<Kategori>
         
    {
        private List<Kategori> kategoriLista = new List<Kategori>();

        public KategoriRepository()
        {
            //Ser till så att "Okategoriserad" finns med som kategori
            if (!KategoriFinns("Okategoriserad"))
            {
                kategoriLista.Add(new Kategori { Namn = "Okategoriserad" });
            }
        }

        public void AndraUppgifter(Kategori item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Kategori> HamtaAlla()
        {
            return kategoriLista;
        }

        public void LaggTill(Kategori item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Kategori kan inte vara null.");
            }

            // Här kan vi kolla om kategorin redan finns om det är viktigt
            if (kategoriLista.Any(k => k.Namn == item.Namn))
            {
                throw new InvalidOperationException("Kategorin finns redan.");
            }

            // Lägger till kategorin i listan
            kategoriLista.Add(item);
        }


        public void TaBort(string kategoriNamn)
        {
            //Sparar kategori objektet med namnet man har valt
            var kategori = kategoriLista.FirstOrDefault(k => k.Namn == kategoriNamn);

            if (kategori != null)
            {
                kategoriLista.Remove(kategori);
            }

        }

        //Kontrollerar om en viss kategori redan finns i listan
        public bool KategoriFinns(string kategoriNamn)
        {
            return kategoriLista.Any(k => k.Namn == kategoriNamn);
        }

        public void Uppdatera(Kategori uppdateradKategori)
        {
            var kategori = kategoriLista.FirstOrDefault(k => k.Namn == uppdateradKategori.Namn);
            if (kategori != null)
            {
                kategori.Beskrivning = uppdateradKategori.Beskrivning; // Uppdaterar beskrivning
            }
            else
            {
                throw new ArgumentException("Kategorin hittades inte.");
            }
        }



        public void Redigera(string gammaltNamn, string nyttNamn)
    {
        Kategori kategori = kategoriLista.FirstOrDefault(k => k.Namn == gammaltNamn);
        if (kategori == null)
        {
            throw new ArgumentException("Kategorin finns inte.");
        }

        // Kontrollera att den nya kategorin inte redan finns
        if (KategoriFinns(nyttNamn))
        {
            throw new ArgumentException("Den nya kategorin finns redan.");
        }

        kategori.Namn = nyttNamn;
        // Lägg till logik för att spara ändringar i databas eller fil
    }
        public void SparaKategorierTillFil(string filnamn)
        {
            using (var writer = new StreamWriter(filnamn))
            {
                foreach (var kategori in kategoriLista)
                {
                    writer.WriteLine($"{kategori.Namn}|{kategori.Beskrivning}");
                }
            }
        }
        public void LasInKategorierFranFil(string filnamn)
        {
            if (!File.Exists(filnamn))
            {
                return; // Om filen inte finns, hoppa över att läsa in
            }

            using (var reader = new StreamReader(filnamn))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var delar = line.Split('|');
                    if (delar.Length == 2)
                    {
                        string namn = delar[0];
                        string beskrivning = delar[1];

                        if (!KategoriFinns(namn))
                        {
                            kategoriLista.Add(new Kategori { Namn = namn, Beskrivning = beskrivning });
                        }
                    }
                }
            }
        }

    }
}

