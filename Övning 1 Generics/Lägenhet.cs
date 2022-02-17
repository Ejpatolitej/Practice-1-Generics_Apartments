using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_1_Generics
{
    public class Lägenhet : IEquatable<Lägenhet>
    {
        public int ID { get; set; }
        public int LghNummer { get; set; }
        public int AntalPersoner { get; set; }

        public Lägenhet(int id, int lghNummer, int antalPersoner)
        {
            this.ID = id;
            this.LghNummer = lghNummer;
            this.AntalPersoner = antalPersoner;
        }

        public bool Equals(Lägenhet? other)
        {
            if (new LghSameProp().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
