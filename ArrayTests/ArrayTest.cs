using DataStructers.Arrays;
using Xunit;

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
    }
}