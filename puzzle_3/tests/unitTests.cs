using System;
using Xunit;
using puzzle_3;

namespace puzzle_3.Tests
{
    public class DistanceTests
    {
        [Fact]
        public void Example1()
        {
            var result = Utils.findDistanceToOne(1);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Example2()
        {
            var result = Utils.findDistanceToOne(12);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Example3()
        {
            var result = Utils.findDistanceToOne(23);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Example4()
        {
            var result = Utils.findDistanceToOne(1024);
            Assert.Equal(31, result);
        }

        [Fact]
        public void EvenSize()
        {
            var result = Utils.squareSize(16);
            Assert.Equal(5, result);
        }

        [Fact]
        public void OddSize()
        {
            var result = Utils.squareSize(49);
            Assert.Equal(7, result);
        }
    }
}