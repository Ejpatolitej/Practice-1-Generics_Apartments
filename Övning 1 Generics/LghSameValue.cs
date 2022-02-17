using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_1_Generics
{
    public class LghSameValue : EqualityComparer<Lägenhet>
    {
        public override bool Equals(Lägenhet L1, Lägenhet L2)
        {
            if (L1.ID == L2.ID && L1.LghNummer == L2.LghNummer && L1.AntalPersoner == L2.AntalPersoner)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Lägenhet lägenhet)
        {
            var hCode = lägenhet.ID ^ lägenhet.LghNummer ^ lägenhet.AntalPersoner;
            Console.WriteLine("HC: {0}", hCode.GetHashCode());
            return hCode.GetHashCode();
        }
    }
}
