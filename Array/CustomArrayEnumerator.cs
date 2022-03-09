using System.Collections;

namespace DataStructers.Arrays
{
    public class CustomArrayEnumerator : IEnumerator
    {
     
        private Object[] _array;
        private int _index;

        public object Current => throw new NotImplementedException();

        public CustomArrayEnumerator(Object[] sourcesArray)
        {
            _array = sourcesArray;
            _index = -1;
        }

        public bool MoveNext()
        {
            if (_index<_array.Length-1)
            {
                _index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}