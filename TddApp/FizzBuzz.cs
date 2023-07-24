using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddApp
{
    //FizzBuzz explanation: https://brendoneus.com/katas/fizz-buzz
    public class FizzBuzz
    {
        public string CreateName(string first, string last)
        {
            return $"{first} - {last}";
        }

        public string GenerateFizzBuzz(int data)
        {
            var result = String.Empty;
            if(data % 3 == 0)
            {
                result += "Fizz";
            }
            if(data % 5 == 0)
            {
                result += "Buzz";
            }
            return result == String.Empty ? data.ToString() : result;
        }
    }
}
