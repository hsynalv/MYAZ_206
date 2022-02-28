using System;
using ValueAndReferenceTypes;
using Xunit;

namespace ValueAndReferenceTypesTests
{
    public class ValAndRefTypesTests
    {
        [Fact]
        public void ReferenceTypeTest()
        {
            // Arrange
            var p1 = new ReferenceType(3, 4);
            var p2 = p1;

            // Act
            p2.X = 10;

            // Assert
            Assert.Equal(p1.X, p2.X);
        }

        [Fact]
        public void ValueTypeTest()
        {
            // Arrange
            var p1 = new ValueAndReferenceTypes.ValueType(3, 4);
            var p2 = p1;

            // Act
            p2.X = 10;

            // Assert
            Assert.NotEqual(p1.X, p2.X);
        }

        [Fact]
        public void SwapTestByTest()
        {
            var reftType = new ReferenceType(3, 4);
            int a = 23, b = 55;

            reftType.SwapByRef(ref a, ref b);

            Assert.Equal(55,a);
            Assert.Equal(23,b);

        }

        [Fact]
        public void SwapTestByValue()
        {
            var reftType = new ReferenceType(3, 4);
            int a = 23, b = 55;

            reftType.SwapByValue(a, b);

            Assert.Equal(23, a);
            Assert.Equal(55, b);

        }
    }
}
