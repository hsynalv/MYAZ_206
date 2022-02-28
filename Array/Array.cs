namespace DataStructers.Arrays
{
    public class Array : ICloneable
    {
        private Object[] innerArray { get; set; }
        public int Lenght => innerArray.Length;

        public Array(int index=16)
        {
            innerArray = new Object[index];
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
    }
}