using System;
using Xunit;
using puzzle1;

namespace puzzle_1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnZero()
        {
            var result = Utils.sumString("1234");
            Assert.Equal(0, result);
        }

        [Fact]
        public void ReturnFour()
        {
            var result = Utils.sumString("1111");
            Assert.Equal(4, result);
        }

        [Fact]
        public void ReturnNine()
        {
            var result = Utils.sumString("91212129");
            Assert.Equal(9, result);
        }

        [Fact]
        public void TwoPairs()
        {
            var result = Utils.sumString("1122");
            Assert.Equal(3, result);
        }

        [Fact]
        public void AllOneDigit()
        {
            var result = Utils.sumString("1111");
            Assert.NotEqual(5, result);
        }

        [Fact]
        public void OneCharacterString()
        {
            var result = Utils.sumString("9");
            Assert.Equal(0, result);
        }

        [Fact]
        public void EmptyString()
        {
            var result = Utils.sumString("");
            Assert.Equal(0, result);
        }
    }
}
