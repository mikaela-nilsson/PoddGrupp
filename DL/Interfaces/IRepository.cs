using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public interface IRepository<T>
    {
        public void LaggTill(T item);
        public void TaBort(string item);
        public void AndraUppgifter(T item);
        IEnumerable<T> HamtaAlla();

    }
}
