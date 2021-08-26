using System;
using Xunit;
using FizzBuzzLibrary;

namespace FizzBuzzTest
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(0, "Zero")]

        public void DivisibleBy3(int input,string output)
        {       
            Assert.Equal(output, new FizzBuzzLib().fizzbuzzer(input));
        }


        [Theory]
        [InlineData(5,"Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(20, "Buzz")]
        [InlineData(0, "Zero")]
        public void DivisibleBy5(int input, string output)
        {
            Assert.Equal(output, new FizzBuzzLib().fizzbuzzer(input));
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(45, "FizzBuzz")]
        [InlineData(0, "Zero")]
        public void DivisibleBy3and5(int input, string output)
        {           
            Assert.Equal(output, new FizzBuzzLib().fizzbuzzer(input));
        }

    }
}
