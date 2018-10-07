using NUnit.Framework;
using FizzBuzzExercise;

namespace FizzBuzzExercise.Tests
{
    public class FizzBuzzTests
    {
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void Setup()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void ItReturnsFizzForTheNumber3()
        {
            Assert.Equals("Fizz", fizzBuzz.ProcessNumber(3));
        }
    }
}