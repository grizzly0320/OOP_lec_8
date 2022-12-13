using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lec_8
{
    public class FullCollection : ICollection
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
        public int Count { get;}
        public bool IsSynchronized => false;
        public object SyncRoot => null;
    }
    public class RoCollection : IReadOnlyCollection<int>
    {
        public int Count { get; }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}