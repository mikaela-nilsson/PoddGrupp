using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Xml.Serialization;
using System.IO;


namespace DL
{
    public class PoddRepository : IRepository<Poddcast>
    {
        private List<Poddcast> poddcastLista = new List<Poddcast>();

        public void LaggTill(Poddcast poddcast)
        {
            poddcastLista.Add(poddcast);
            FyllAvsnittBeskrivningar(poddcast);
        }


        public List<Poddcast> HamtaAlla()
        {
            return poddcastLista;
        }

        public void TaBort(string namn)
        {
            //LINQ för att hitta podden/flödet med namnet som angivits
            var poddcast = poddcastLista.FirstOrDefault(f => f.Namn == namn);
            if (poddcast != null)
            {
                poddcastLista.Remove(poddcast);
            }
        }

        public void SparaDataTillXml(string filnamn)
        {
            var serializer = new XmlSerializer(typeof(List<Poddcast>));
            using (var writer = new StreamWriter(filnamn))
            {
                serializer.Serialize(writer, poddcastLista);
            }
        }

        public void LaddaDataFranXml(string filnamn)
        {
            if (File.Exists(filnamn))
            {
                var serializer = new XmlSerializer(typeof(List<Poddcast>));
                using (var reader = new StreamReader(filnamn))
                {
                    var loadedPoddcasts = (List<Poddcast>)serializer.Deserialize(reader);
                    foreach (var poddcast in loadedPoddcasts)
                    {
                        
                        if (!poddcastLista.Any(p => p.Namn == poddcast.Namn))
                        {
                            poddcastLista.Add(poddcast);
                        }
                    }
                }
            }
        }



        public void AndraUppgifter(Poddcast uppdateradPodd)
        {
            // Hitta podden med det gamla namnet
            var befintligPodd = poddcastLista.FirstOrDefault(f => f.Namn == uppdateradPodd.Namn);

            // Om podden hittas, uppdatera dess information
            if (befintligPodd != null)
            {
                befintligPodd.Namn = uppdateradPodd.Namn;  // Uppdaterar namnet

            }
            else
            {
                Console.WriteLine("Poddcast med detta namn hittades inte.");
            }
        }

        IEnumerable<Poddcast> IRepository<Poddcast>.HamtaAlla()
        {
            throw new NotImplementedException();

        }


        //Denna hämtar avsnitt som tillhör specifik poddcast
        public List<string> HamtaAvsnitt(string rssLank)
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


        public List<string> HamtaAvsnittsBeskrivningar(string rssLank)
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

                    // Skapa en lista för beskrivningar
                    List<string> avsnittBeskrivningar = new List<string>();

                    foreach (var item in poddcastFlode.Items)
                    {
                        // Hämta beskrivningen från olika källor utan purl
                        string beskrivning = item.Summary?.Text
                                             ?? (item.Content is TextSyndicationContent textContent ? textContent.Text : null)
                                             ?? "Ingen beskrivning tillgänglig";

                        // Lägg till beskrivningen i listan
                        avsnittBeskrivningar.Add(beskrivning);
                    }

                    return avsnittBeskrivningar;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Fel vid hämtning av RSS-flöde: {ex.Message}");
            }
        }
    
        public void RedigeraFlodeNamn(string gammaltNamn, string nyttNamn)
        {
            var befintligPodd = poddcastLista.FirstOrDefault(f => f.Namn == gammaltNamn);
            if (befintligPodd != null)
            {
                befintligPodd.Namn = nyttNamn;
            }
            else
            {
                throw new ArgumentException("Poddcast med det angivna namnet hittades inte.");
            }

        }
        
        //Hämtar ett visst Poddcast objekt med dess namn
        public Poddcast HamtaPoddMedNamn(string poddNamn)
        {
            return poddcastLista.FirstOrDefault(p => p.Namn == poddNamn);
        }

        //Ändrar ett visst Poddcast objekts Kategori
        public void AndraPoddcastKategori(Poddcast poddcast, string nyttKategoriNamn)
        {
            poddcast.Kategori = nyttKategoriNamn;
        }

        //Fyller listan med AvsnittsBeskrivningar
        public void FyllAvsnittBeskrivningar(Poddcast poddcast)
        {
            var beskrivningar = HamtaAvsnittsBeskrivningar(poddcast.RSS);
            poddcast.AvsnittBeskrivning.Clear(); 
            poddcast.AvsnittBeskrivning.AddRange(beskrivningar); 
        }
    }
}





