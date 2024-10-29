using DL;
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

        public void TaBortKategori(string kategoriNamn)
        {
            //Repository och namnet skickas i anropet av en metod i valideringsklassen
            Validering.ValideraTaBortKategori(kategoriRepository, kategoriNamn);

            //Om valideringen gick bra tas kategorin bort genom metoden i KategoriRepository klassen
            kategoriRepository.TaBort(kategoriNamn);
        }
    }
}
