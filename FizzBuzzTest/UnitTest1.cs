using System;
using Xunit;
using FizzBuzzLibrary;

namespace FizzBuzzTest
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]

        
        public void DivisibleBy3(int input)
        {
            //int input = 3;
            
            Assert.Equal("Fizz", new FizzBuzzLib().fizzbuzzer(input));
        }


        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void DivisibleBy5(int input)
        {
            Assert.Equal("Buzz", new FizzBuzzLib().fizzbuzzer(input));
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void DivisibleBy3and5(int input)
        {           
            Assert.Equal("FizzBuzz", new FizzBuzzLib().fizzbuzzer(input));
        }

    }
}
