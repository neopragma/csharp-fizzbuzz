using System;
using Xunit;
using FizzBuzz;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private FizzBuzz fizzBuzz;

        public FizzBuzzTests()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Fact]
        public void ItReturnsFizzForTheNumber3()
        {
            Assert.Equal("Fizz", fizzBuzz.ProcessNumber(3));
        }
    }
}
