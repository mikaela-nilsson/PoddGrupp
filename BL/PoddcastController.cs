using DL;
using BL;
using Models;
using System.Xml;
using System.ServiceModel.Syndication;

namespace BL
{
    public class PoddcastController
    {
        private PoddRepository poddRepository;

        private readonly RssFetcher rssFetcher;
        public PoddcastController()
        {
            poddRepository = new PoddRepository();
            LaddaPoddcastData();
            rssFetcher = new RssFetcher();
        }
        // Använder den asynkrona metoden för att hämta RSS-innehåll
        public async Task<string> HamtaRssInnehallAsync(string rssUrl)
        {
            return await rssFetcher.HamtaRssInnehallAsync(rssUrl);
        }

        public void SparaData()
        {
            poddRepository.SparaDataTillXml("data.xml");
        }

        public void LaddaPoddcastData()
        {
            poddRepository.LaddaDataFranXml("data.xml");
        }

        //Metod som ändrar ett visst poddcast objekts kategori
        public void AndraPoddcastKategori(string poddNamn, string nyttKategoriNamn)
        {
            Poddcast poddcast = poddRepository.HamtaPoddMedNamn(poddNamn);
            poddRepository.AndraPoddcastKategori(poddcast, nyttKategoriNamn);
        }

        //Metod som hämtar alla Poddcast objekt som tillhör en viss Kategori
        public List<Poddcast> HamtaAllaPoddcastMedKategori(string kategoriNamn)
        {
            return poddRepository.HamtaAlla().Where(p => p.Kategori == kategoriNamn).ToList();
        }
        public async Task LaggTillPoddcastMedRssAsync(string rssUrl, string namn, string kategori)
        {
            if (string.IsNullOrWhiteSpace(rssUrl)) throw new ArgumentException("Vänligen fyll i fältet för RSS-länk.");
            if (string.IsNullOrWhiteSpace(namn)) throw new ArgumentException("Vänligen fyll i fältet för Namn.");

            // Anropa valideringsmetoden för att kontrollera unika namn och RSS-länkar
            var resultat = ValideraNyFlode(rssUrl, namn);
            if (!resultat.isValid) throw new ArgumentException(resultat.meddelande);

            List<string> avsnitt = HamtaPoddcastAvsnitt(rssUrl);

            var nyttFlode = new Poddcast
            {
                RSS = rssUrl,
                Namn = namn,
                Kategori = kategori,
                Avsnitt = avsnitt
            };

            poddRepository.LaggTill(nyttFlode);
        }


        // Hämtar alla poddcast från repository
        public List<Poddcast> HamtaAllaPoddcast()
        {
            return poddRepository.HamtaAlla();
        }

        // Hämtar och sparar poddcast från RSS-flöde till repository 
        public void HamtaPoddcastInformation(string rssLank)
        {
            List<string> avsnitt = poddRepository.HamtaAvsnitt(rssLank);
            // Skapa eller uppdatera ett Poddcast-objekt med hämtade avsnitt, eller spara avsnitten till repository
            var podd = new Poddcast
            {
                RSS = rssLank,
                Avsnitt = avsnitt,
                Namn = "Namn på Poddcast" // Ange namn eller hämta från repository
            };
            poddRepository.LaggTill(podd); // Lägg till podd i repository om den är ny
        }

        //!!!!OBS!!! DETTA ÄR ETT EXEMPEL PÅ EN METODÖVERLAGRING (FYLLER INGEN FUNKTION-- BARA EXEMPEL :D)
        public void HamtaPoddcastInformation(string rssLank, string namn)
        {
            HamtaPoddcastInformation(rssLank);
            Console.Write(namn);
        }

        // Denna metod hämtar titlar på podcastavsnitt från ett angivet RSS-flöde och returnerar dem som en lista, eller kastar ett undantag vid fel.
        public List<string> HamtaPoddcastAvsnitt(string rssLank)
        {
            return poddRepository.HamtaAvsnitt(rssLank);
        }

        public List<string> HamtaAvsnittBeskrivning(string rssLank)
        {
            return poddRepository.HamtaAvsnittsBeskrivningar(rssLank);
        }

        // Här valideras om angivna RSS-länken och/eller flödets namn redan finns
        public (bool isValid, string meddelande) ValideraNyFlode(string rssLank, string namn)
        {
            if (poddRepository.HamtaAlla().Any(f => f.Namn == namn))
            {
                return (false, "Flöde med detta namn finns redan. Vänligen välj ett nytt namn.");
            }

            if (poddRepository.HamtaAlla().Any(f => f.RSS == rssLank))
            {
                return (false, "Flöde med denna RSS-länk finns redan. Vänligen välj ett nytt länk.");
            }

            // Om valideringen lyckades
            return (true, string.Empty);
        }

        public void TaBortFlode(string namn)
        {
            poddRepository.TaBort(namn);
        }

        // Ny metod för att redigera flödesnamn
        public void RedigeraFlodeNamn(string gammaltNamn, string nyttNamn)
        {
            if (string.IsNullOrWhiteSpace(gammaltNamn))
                throw new ArgumentException("Gammalt namn kan inte vara tomt.");
            if (string.IsNullOrWhiteSpace(nyttNamn))
                throw new ArgumentException("Nytt namn kan inte vara tomt.");

            poddRepository.RedigeraFlodeNamn(gammaltNamn, nyttNamn);
        }
    }
}
