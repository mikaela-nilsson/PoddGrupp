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
        public List<Poddcast> HamtaAllaPoddcast()
        {
            return poddRepository.HamtaAlla();
        }
        


        //Hämtar och sparar poddcast från RSS-flöde till repository 
        public void HamtaPoddcastInformation(string rssLank)
        {
            HamtaPoddcastInformation(rssLank);
        }

        //!!!!OBS!!! DETTA ÄR ETT EXEMPEL PÅ EN METODÖVERLAGRING(FYLLER INGEN FUNKTION-- BARA EXEMPEL :D)
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


        //Här valideras om angivna RSS-länken och/eller flödets namn redan finns
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

            //Om valideringen lyckades
            return (true, string.Empty);
        }

        public void LaggTillFlode(string rssLank, string namn, string kategori)
        {
            if (string.IsNullOrWhiteSpace(rssLank)) throw new ArgumentException("Vänligen fyll i fältet för RSS-länk.");
            if (string.IsNullOrWhiteSpace(namn)) throw new ArgumentException("Vänligen fyll i fältet för Namn.");

            var resultat = ValideraNyFlode(rssLank, namn);
            if (!resultat.isValid) throw new ArgumentException(resultat.meddelande);

            List<string> avsnitt = HamtaPoddcastAvsnitt(rssLank);

            var nyttFlode = new Poddcast
            {
                RSS = rssLank,
                Namn = namn,
                Kategori = kategori,
                Avsnitt = avsnitt
            };

            poddRepository.LaggTill(nyttFlode);
        }

        public void TaBortFlode (string namn)
        {
            poddRepository.TaBort(namn);
        }

    }
}