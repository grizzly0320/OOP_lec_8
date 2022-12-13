using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lec_8
{
    class Collection : IEnumerable
    {
        public enum Type
        {
            Odd, Even
        }
        private Type _type;
        private CollectionEnumerator _enumerator;
        private int[] _all = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public IEnumerator GetEnumerator() => _enumerator;

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
        public Collection(Type type = Type.Odd)
        {
            _type = type;
            _enumerator = new CollectionEnumerator(_all, (type == Type.Even) ? 0 : 1);
        }
    }
    class CollectionEnumerator : IEnumerator
    {
        private int _currentIndex = 0;
        private int _start;
        private int[] _coll;
        public CollectionEnumerator(int[] coll, int startFrom = 0)
        {
            _coll = coll;
            _start = startFrom;
            Reset();
        }

        public object Current {get => _coll[_currentIndex]; }

        public bool MoveNext()
        {
            _currentIndex += 2;
            return _currentIndex < _coll.Length;
        }

        public void Reset()
        {
            _currentIndex = _start - 2;
        }
    }
}
