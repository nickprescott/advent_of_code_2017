using System;
using Xunit;
using puzzle1;

namespace puzzle_1.Tests
{
    public class SumStringUnitTest
    {
        [Fact]
        public void NoMatches()
        {
            var result = Utils.sumString("1234");
            Assert.Equal(0, result);
        }

        [Fact]
        public void AllTheSameValues()
        {
            var result = Utils.sumString("1111");
            Assert.Equal(4, result);
        }

        [Fact]
        public void CircularList()
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

    public class HalfSumStringUnitTest
    {
        [Fact]
        public void example1()
        {
            var result = Utils.halfSumString("1212");
            Assert.Equal(6, result);
        }

        [Fact]
        public void example2()
        {
            var result = Utils.halfSumString("1221");
            Assert.Equal(0, result);
        }

        [Fact]
        public void example3()
        {
            var result = Utils.halfSumString("123425");
            Assert.Equal(4, result);
        }

        [Fact]
        public void example4()
        {
            var result = Utils.halfSumString("123123");
            Assert.Equal(12, result);
        }

        [Fact]
        public void example5()
        {
            var result = Utils.halfSumString("12131415");
            Assert.Equal(4, result);
        }
    }
}
