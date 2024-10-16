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
        //tabort poddcast metod
        //återställ metod

    }
}
