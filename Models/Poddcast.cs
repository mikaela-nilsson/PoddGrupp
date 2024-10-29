using System.Text.RegularExpressions;
using System.Xml.Serialization;


namespace Models
{
    [XmlRoot("Poddcast")] // Sätter rot-elementet
    public class Poddcast
    {
        [XmlElement("Kategori")] // Specifik XML-element för Kategori
        public string Kategori { get; set; }

        [XmlElement("Namn")] // Specifik XML-element för Namn
        public string Namn { get; set; }

        [XmlElement("RSS")] // Specifik XML-element för RSS
        public string RSS { get; set; }

        [XmlArray("AvsnittBeskrivningar")] // Namnet på array-elementet
        [XmlArrayItem("Beskrivning")] // Namnet på varje beskrivning
        public List<string> AvsnittBeskrivning { get; set; } = new List<string>();

        [XmlArray("Avsnitt")] // Namnet på array-elementet
        [XmlArrayItem("AvsnittNamn")] // Namnet på varje avsnitt
        public List<string> Avsnitt { get; set; } = new List<string>();
    }
}
