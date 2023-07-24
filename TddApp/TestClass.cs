using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TddApp
{
    //FizzBuzz explanation: https://brendoneus.com/katas/fizz-buzz
    public class TestClass
    {
        [Theory]
        [InlineData("Mark", "Finta", "Mark - Finta")]
        [InlineData("Cheesy", "Burrito", "Cheesy - Burrito")]
        public void Can_Create_Name(string first, string last, string expected)
        {
            var methodClass = new FizzBuzz();

            var result = methodClass.CreateName(first, last);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(15,"FizzBuzz")]
        public void Can_Fizz_Buzz(int data, string expected)
        {
            var methodClass = new FizzBuzz();

            var result = methodClass.GenerateFizzBuzz(data);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("",0)]
        [InlineData("1", 1)]
        [InlineData("1,2", 3)]
        [InlineData("1,5,2,8,4,5,1,6", 32)]
        [InlineData("4\n5,6", 15)]
        [InlineData("//;\n1;2", 3)]
        public void Can_Add_Calc(string numbers, int expected)
        {
            var calc = new StringCalculator();

            var result = calc.Add(numbers);

            Assert.Equal(expected, result);
        }
    }
}
