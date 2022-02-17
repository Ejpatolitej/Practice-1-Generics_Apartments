using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_1_Generics
{
    public class LghCollection : ICollection<Lägenhet>
    {
        public IEnumerator<Lägenhet> GetEnumerator()
        {
            return new LghEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LghEnumerator(this);
        }

        private List<Lägenhet> innerCol;
        public LghCollection()
        {
            innerCol = new List<Lägenhet>();
        }

        public Lägenhet this[int index]
        {
            get { return (Lägenhet)innerCol[index]; }
            set { innerCol[index] = value;}
        }

        public bool Contains(Lägenhet item, EqualityComparer<Lägenhet> comparer)
        {
            bool found = false;

            foreach (Lägenhet lägenhet in innerCol)
            {
                if (comparer.Equals(lägenhet, item))
                {
                    found = true;
                }
            }
            return found;
        }
        public bool Contains(Lägenhet item)
        {
            bool found = false;

            foreach (Lägenhet lägenhet in innerCol)
            {
                if (lägenhet.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }
        public void Add(Lägenhet item)
        {
            if (!Contains(item))
            {
                innerCol.Add(item);
            }
            else
            {
                Console.WriteLine("En lägenhet med ID {0}, nummer {1}, och antal personer {2} finns redan i listan.", item.ID, item.LghNummer, item.AntalPersoner);
            }
        }

        public int Count => innerCol.Count();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Clear()
        {
            innerCol.Clear();
        }

        public void CopyTo(Lägenhet[] array, int arrayIndex)
        {
            innerCol.CopyTo(array, arrayIndex);
        }

        public bool Remove(Lägenhet item)
        {
            if (innerCol.Remove(item))
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
