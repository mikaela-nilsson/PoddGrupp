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
            throw new NotImplementedException();
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
}
}

