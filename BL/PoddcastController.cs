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


        //Hämtar och sparar poddcast från RSS-flöde till repository 
        public void HämtaPoddcastInformation(string rssLank)
        {
            XmlReader minXMLlasare = XmlReader.Create(rssLank);
            SyndicationFeed poddcastFlode = SyndicationFeed.Load(minXMLlasare);

            foreach (SyndicationItem item in poddcastFlode.Items)
            {
                var avsnittTitel = item.Title.Text;  // Avsnittets titel
                Poddcast enPoddcast = new Poddcast
                {
                    Id = item.Id.ToString(),
                    Namn = item.Authors.FirstOrDefault()?.Name ?? item.Title.Text,  // Använd titeln om författaren saknas
                    Titel = item.Title.Text,
                    Kategori = item.Categories.FirstOrDefault()?.Label ?? "Okänd kategori",
                    AntalAvsnitt = poddcastFlode.Items.Count(),  // Räkna antal objekt i RSS-flödet
                    RSS = rssLank,
                    Avsnitt = poddcastFlode.Items.Select(i => i.Title.Text).ToList()  // Lägger till alla avsnittstitlar
                };
               
                poddRepository.LäggTillPoddcast(enPoddcast);  // Spara podcasten
            } 
        }


        // Denna metod hämtar titlar på podcastavsnitt från ett angivet RSS-flöde och returnerar dem som en lista, eller kastar ett undantag vid fel.
        public List<string> HämtaPoddcastAvsnitt(string rssLank)
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse };

                using (XmlReader minXMLlasare = XmlReader.Create(rssLank, settings))
                {
                    SyndicationFeed poddcastFlode = SyndicationFeed.Load(minXMLlasare);

                    if (poddcastFlode == null || !poddcastFlode.Items.Any())
                    {
                        throw new Exception("RSS-flödet är ogiltigt eller innehåller inga avsnitt.");
                    }

                    List<string> avsnittTitlar = poddcastFlode.Items.Select(item => item.Title.Text).ToList();

                    return avsnittTitlar;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Fel vid hämtning av RSS-flöde: {ex.Message}");
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

        public void LaggTillFlode(string rssLank, string namn, string kategori)
        {
            if (string.IsNullOrWhiteSpace(rssLank)) throw new ArgumentException("Vänligen fyll i fältet för RSS-länk.");
            if (string.IsNullOrWhiteSpace(namn)) throw new ArgumentException("Vänligen fyll i fältet för Namn.");

            var resultat = ValideraNyFlode(rssLank, namn);
            if (!resultat.isValid) throw new ArgumentException(resultat.meddelande);

            List<string> avsnitt = HämtaPoddcastAvsnitt(rssLank); 

            var nyttFlode = new Poddcast
            {
                RSS = rssLank,
                Namn = namn,
                Kategori = kategori,
                Avsnitt = avsnitt 
            };

            poddRepository.LäggTillPoddcast(nyttFlode);
        }

        public void TaBortFlode (string namn)
        {
            poddRepository.TaBortPodd(namn);
        }

    }
}