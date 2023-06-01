using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobelDijakClass
{
    class NobelDij
    {
        int ev;
        string tipus;
        string keresztnev;
        string vezeteknev;

        public NobelDij(int ev, string tipus, string keresztnev, string vezeteknev)
        {
            this.ev = ev;
            this.tipus = tipus;
            this.keresztnev = keresztnev;
            this.vezeteknev = vezeteknev;
        }

        public NobelDij(int ev, string tipus)
        {
            this.ev = ev;
            this.tipus = tipus;
        }

        public int Ev { get => ev; }
        public string Tipus { get => tipus; }
        public string Keresztnev { get => keresztnev; }
        public string Vezeteknev { get => vezeteknev; }
    }
}
