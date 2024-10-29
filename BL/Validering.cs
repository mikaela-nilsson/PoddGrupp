using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    internal class Validering
    {
        public static void ValideraTaBortKategori(KategoriRepository kategoriRepository, string kategoriNamn)
        {
            if (!kategoriRepository.KategoriFinns(kategoriNamn))
            {
                throw new ArgumentException("Den valda kategorin finns inte.");
            }

            if (kategoriNamn == "Okategoriserad")
            {
                throw new InvalidOperationException("Du kan inte ta bort kategorin 'Okategoriserad'");
            }
        }

        public static void ValideraRSS(string rssLank)
        {
            //Kontrollerar om RSS-länken är ifylld
            if (string.IsNullOrEmpty(rssLank))
            {
                throw new ArgumentException("Vänligen ange en RSS-länk.");
            }

            //Kontrollerar om angivna RSS-länken är giltig
            if (!Uri.TryCreate(rssLank, UriKind.Absolute, out Uri uriResult) ||
                (uriResult.Scheme != Uri.UriSchemeHttp && uriResult.Scheme != Uri.UriSchemeHttps))
            {
                throw new ArgumentException("Vänligen ange en giltig RSS-länk som börjar med http eller https.");
            }
        }

        public static void ValideraNamn(string namn)
        {
            if (string.IsNullOrEmpty(namn))
            {
                throw new ArgumentException("Vänligen ange ett namn för flödet.");
            }
        }

        //Kontrollera om man har valt en kategori
        public static void ValideraKategori(string kategori)
        {
            if (string.IsNullOrEmpty(kategori))
            {
                throw new ArgumentException("Vänligen välj en kategori.");
            }
        }

        //Validering för om angivna RSS-länken och/eller flödets namn redan finns
        public static (bool isValid, string meddelande) ValideraNyFlode(PoddRepository poddRepository, string rssLank, string namn)
        {
            if (poddRepository.HamtaAlla().Any(f => f.Namn == namn))
            {
                return (false, "Flöde med detta namn finns redan. Vänligen välj ett nytt namn.");
            }

            if (poddRepository.HamtaAlla().Any(f => f.RSS == rssLank))
            {
                return (false, "Flöde med denna RSS-länk finns redan. Vänligen välj ett nytt länk.");
            }

            //Om valideringen lyckades
            return (true, string.Empty);
        }
    }
}
