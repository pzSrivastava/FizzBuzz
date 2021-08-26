using System;

namespace FizzBuzzLibrary
{
    public class FizzBuzzLib
    {

        public string fizzbuzzer(int num)
        {
            string output = string.Empty;
            if (num % 3 == 0)
            {
                output += "Fizz";
            }
            if (num % 5 == 0)
            {
                output += "Buzz";
            }
            if(output.Equals(string.Empty) )
            {
                output += num.ToString();
            }
            return output;
        }

    }
}
