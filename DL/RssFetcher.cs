using System.Net.Http;
using System.Threading.Tasks;

namespace DL // Använd ditt projekts namespace om det inte är DL
{
    public class RssFetcher
    {
        private readonly HttpClient httpClient = new HttpClient();

        // Asynkron metod för att hämta RSS-innehåll från en URL
        public async Task<string> HamtaRssInnehallAsync(string rssUrl)
        {
            // Hämta RSS-data asynkront
            HttpResponseMessage response = await httpClient.GetAsync(rssUrl);

            // Kontrollera om svaret lyckades
            response.EnsureSuccessStatusCode();

            // Returnera innehållet som en sträng
            return await response.Content.ReadAsStringAsync();
        }
    }
}

