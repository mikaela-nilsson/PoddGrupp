using System.Text.RegularExpressions;

namespace Models
{
    public class Poddcast
    {
        public string Kategori { get; set; }
        public string Namn { get; set; }
        public string RSS { get; set; }
        public List <string> AvsnittBeskrivning { get; set; }
        public List<string> Avsnitt { get; set; } = new List<string>();

    }
}
