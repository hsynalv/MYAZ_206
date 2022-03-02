using System.Collections;

namespace DataStructers.Arrays
{
    public class Array : ICloneable, IEnumerable
    {
        private Object[] innerArray { get; set; }
        public int Lenght => innerArray.Length;


        public Array(int index=16)
        {
            innerArray = new Object[index];
        }

        public Array(params Object[] sourceArrays) : this(sourceArrays.Length)
        {
            System.Array.Copy(sourceArrays, innerArray, sourceArrays.Length);
        }

        public void SetValue(Object? value, int index)
        {
            if (!(index >= 0 && index < innerArray.Length))
                throw new ArgumentOutOfRangeException("index");
            if (value == null)
                throw new ArgumentNullException("value");

            innerArray[index] = value;
        }

        public Object GetValue(int index)
        {
            if (!(index >= 0 && index < innerArray.Length))
                throw new ArgumentOutOfRangeException("index");

            return innerArray[index];
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public IEnumerator GetEnumerator()
        {
            //return innerArray.GetEnumerator();

            return new CustomArrayEnumerator(innerArray);
        }
    }
    
}