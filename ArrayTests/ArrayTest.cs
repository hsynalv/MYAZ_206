using System;
using Xunit;
using Array = DataStructers.Arrays.Array;

namespace ArrayTests
{
    public class ArrayTest
    {
        [Fact]
        public void SetValue()
        {
            var array = new Array(10);

            array.SetValue(10, 1);
            Assert.Equal(10, array.GetValue(1));
        }


        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(4)]
        public void check_DefaultSizeFeature(int size)
        {
            var array = new Array(size);

            Assert.Equal(size,array.Lenght);
        }

        [Fact]
        public void Check_Cloneable_Test()
        {
            var arr = new Array(4);

            arr.SetValue(1, 0);
            arr.SetValue(7, 1);
            arr.SetValue(3, 2);
            arr.SetValue(5, 3);

            var clonedArr = arr.Clone();

            Assert.IsType<Array>(clonedArr);
        }

        [Fact]
        public void IndexOf_Test()
        {
            Array array = new(4);

            array.SetValue(1, 0);
            array.SetValue(2, 1);
            array.SetValue(3, 2);
            array.SetValue(4, 3);

            var returnValue = array.IndexOf(67);
            Assert.Equal(returnValue, -1);

        }
    }
}