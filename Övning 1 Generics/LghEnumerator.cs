using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_1_Generics
{
    public class LghEnumerator : IEnumerator<Lägenhet>
    {
        private LghCollection _lägenheter;
        private int _curIndex;
        private Lägenhet _curLägenhet;

        public LghEnumerator(LghCollection lägenhet)
        {
            this._lägenheter = lägenhet;
            _curIndex = -1;
            _curLägenhet = default(Lägenhet);
        }

        public Lägenhet Current
        {
            get { return _curLägenhet; }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            _curIndex++;
            return (_curIndex < _lägenheter.Count());
        }

        public void Reset()
        {
            _curIndex = -1;
        }
        public void Dispose()
        {
        }
    }
}
