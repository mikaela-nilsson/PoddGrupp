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

        public PoddcastController()
        {
            poddRepository = new PoddRepository();
        }

        //Hämtar alla poddcast från repository

        public List<Poddcast> HämtaAllaPoddcast()
        {

            return poddRepository.HämtaAllaPoddcast();
        }

        //Hämtar och sparar nyheter från RSS-flöde till repository 
        public void HämtaPoddcastFrånRss(string rssLank)
        {
            XmlReader minXMLlasare = XmlReader.Create(rssLank);
            SyndicationFeed poddcastFlode = SyndicationFeed.Load(minXMLlasare);

            foreach (SyndicationItem item in poddcastFlode.Items)
            {
                Poddcast enPoddcast = new Poddcast
                {
                    Id = item.Id.ToString(),
                    Namn = item.Authors.FirstOrDefault()?.Name ?? "Okänt namn",
                    Titel = item.Title.Text,
                    Kategori = item.Categories.FirstOrDefault()?.Label ?? "Okänd kategori",
                    AntalAvsnitt = item.ElementExtensions.FirstOrDefault(ext => ext.OuterName == "antalAvsnitt")?.GetObject<int>() ?? 0,
                    RSS = rssLank

                };
                poddRepository.LäggTillPoddcast(enPoddcast); //sparar podcasten

            }
        }

        //Här valideras om angivna RSS-länken och/eller flödets namn redan finns
        public (bool isValid, string meddelande) ValideraNyFlode(string rssLank, string namn)
        {
            if (poddRepository.HämtaAllaPoddcast().Any(f => f.Namn == namn))
            {
                return (false, "Flöde med detta namn finns redan. Vänligen välj ett nytt namn.");
            }

            if (poddRepository.HämtaAllaPoddcast().Any(f => f.RSS == rssLank))
            {
                return (false, "Flöde med denna RSS-länk finns redan. Vänligen välj ett nytt länk.");
            }

            //Om valideringen lyckades
            return (true, string.Empty);
        }

        //Anropas i PoddcastVisare för att kunna kopplas till PoddRepository
        public void LaggTillFlode(string rssLank, string namn, string kategori)
        {
            //Kontrollera att användaren har fyllt i alla fält
            if (string.IsNullOrWhiteSpace(rssLank))
            {
                throw new ArgumentException("Vänligen fyll i fältet för RSS-länk.");
                return;
            }

            if (string.IsNullOrWhiteSpace(namn))
            {
                throw new ArgumentException("Vänligen fyll i fältet för Namn.");
                return;
            }

            //Skickar länken och namnet till valideringsmetoden och sparar returvärdet i en variabel
            var resultat = ValideraNyFlode(rssLank, namn);

            if (!resultat.isValid)
            {
                throw new ArgumentException(resultat.meddelande);
                return;
            }

            //Om det gick igenom valideringen kommer nya flödet att läggas till
            var nyttFlode = new Poddcast { RSS = rssLank, Namn = namn, Kategori = kategori };
            poddRepository.LäggTillPoddcast(nyttFlode);
        }

        public void TaBortFlode (string namn)
        {
            poddRepository.TaBortPodd(namn);
        }

    }
}