using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzExercise;

namespace FizzBuzzExercise.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzz fizzBuzz;

        [TestInitialize()]
        public void Startup() 
        {
            fizzBuzz = new FizzBuzz();
        }

        [TestMethod]
        public void ItReturnsFizzForTheNumber3()
        {
            Assert.Equals("Fizz", fizzBuzz.ProcessNumber(3));
        }
    }
}
