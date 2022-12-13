using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lec_8
{
    class YCollection : IEnumerable
    {
        public enum Type
        {
            Odd, Even
        }
        private Type _type;

        private int[] _all = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public IEnumerator GetEnumerator()
        {
            for(int i = (_type == Type.Odd) ? 0 : 1; i < _all.Length; i += 2)
            {
                yield return _all[i];
            }
        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
        public YCollection(Type type = Type.Odd)
        {
            _type = type;
        }
    }
}
