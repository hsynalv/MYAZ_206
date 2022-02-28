using System;
using Xunit;

namespace TheLimitsOfDataTypes
{
    public class TheLimitOfDataTypeTests
    {
        [Fact]
        public void Byte_Data_Type_MinAndMaxValue_Test()
        {
            // Arrrange
            byte minValue;
            byte maxValue;

            // Act
            minValue = 0;
            maxValue = 255;

            // Assert
            Assert.Equal(minValue, byte.MinValue);

            Assert.Equal(maxValue, byte.MaxValue);

        }
    }
}
