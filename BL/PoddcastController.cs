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
                    Frekvens = item.ElementExtensions.FirstOrDefault(ext => ext.OuterName == "frekvens")?.GetObject<string>() ?? "Okänd frekvens"

                };
                poddRepository.LäggTillPoddcast(enPoddcast); //sparar podcasten

            }
        }

    }
}