using System.Text.RegularExpressions;

namespace Models
{
    public class Poddcast
    {
        public string Id { get; set; }
        public string Titel { get; set; }
        public string Kategori { get; set; }
        public int AntalAvsnitt { get; set; }
        public string Namn { get; set; }
        public string RSS { get; set; }
        public List<string> Avsnitt { get; set; } = new List<string>();

    }
}
