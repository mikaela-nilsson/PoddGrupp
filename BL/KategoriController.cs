using BL;
using DL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class KategoriController
    {
        private KategoriRepository kategoriRepository;

        public KategoriController()
        {
            kategoriRepository = new KategoriRepository();
        }
        public IEnumerable<Kategori> HamtaAllaKategorier()
        {
            return kategoriRepository.HamtaAlla();
        }

        public void TaBortKategori(string kategoriNamn)
        {
            //Repository och namnet skickas i anropet av en metod i valideringsklassen
            Validering.ValideraTaBortKategori(kategoriRepository, kategoriNamn);

            //Om valideringen gick bra tas kategorin bort genom metoden i KategoriRepository klassen
            kategoriRepository.TaBort(kategoriNamn);
        }
        // Lägg till en ny kategori
        public void LaggTillKategori(string kategoriNamn)
        {
            if (string.IsNullOrWhiteSpace(kategoriNamn))
            {
                throw new ArgumentException("Kategorinamn kan inte vara tomt.");
            }

            // Kontrollera om kategorin redan finns
            if (kategoriRepository.HamtaAlla().Any(k => k.Namn.Equals(kategoriNamn, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("Kategorin finns redan.");
            }

            // Lägg till kategorin om den inte finns
            Kategori nyKategori = new Kategori { Namn = kategoriNamn };
            kategoriRepository.LaggTill(nyKategori);
        }

        public void RedigeraKategori(string gammaltNamn, string nyttNamn)
    {
       

        // Ändra kategorin via repository
        kategoriRepository.Redigera(gammaltNamn, nyttNamn);
    }
}

}
  
