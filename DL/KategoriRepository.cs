using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class KategoriRepository: IRepository<Kategori>
         
    {
        private List<Kategori> kategoriLista = new List<Kategori>();

        public void AndraUppgifter(Kategori item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Kategori> HamtaAlla()
        {
            throw new NotImplementedException();
        }

        public void LaggTill(Kategori item)
        {
            throw new NotImplementedException();
        }

        public void TaBort(string item)
        {
            throw new NotImplementedException();
        }
    }
}
