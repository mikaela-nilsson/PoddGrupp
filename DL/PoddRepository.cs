using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DL
{
    public class PoddRepository
    {
        private List<Poddcast> poddcastLista = new List<Poddcast>();
        public void LäggTillPoddcast(Poddcast poddcast)
        {
            poddcastLista.Add(poddcast);
        }
        public List<Poddcast> HämtaAllaPoddcast()
        {
            return poddcastLista;
        }

        //ändra poddcast metod
        //återställ metod

        public void TaBortPodd(string namn)
        {
            //LINQ för att hitta podden/flödet med namnet som angivits
            var poddcast = poddcastLista.FirstOrDefault(f => f.Namn == namn);

            if (poddcast != null)
            {
                poddcastLista.Remove(poddcast);
            }
            else
            {
                throw new ArgumentException("Flödet kunde inte hittas");
            }
        }

    }
}
