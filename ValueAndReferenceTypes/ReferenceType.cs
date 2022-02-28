using System;

namespace ValueAndReferenceTypes
{
    public class ReferenceType
    {
        public ReferenceType(int x, int y)
        {
            X = x;
            Y = y;
        }

        public ReferenceType()
        {

        }

        public int X { get; set; }
        public int Y { get; set; }
        

        public void SwapByValue(int x, int y)
        {
            var temp = x;
            x= y;
            y= temp;
        }

    }
}
