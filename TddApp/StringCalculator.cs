using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddApp
{
    // https://brendoneus.com/katas/string-calc
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            int result = 0;
            var numArray = IsDelim(numbers) ? numbers[3..].Split(numbers.ToCharArray()[2]) : numbers.Split(",");
            foreach(var val in numArray)
            {
                if (val.Contains("\n"))
                {
                    var valuesNewLine = val.Split("\n");
                    foreach(var val1 in valuesNewLine)
                    {
                        result += int.TryParse(val1, out int numVal1) == true ? numVal1 : 0;
                    }  
                }
                else
                {
                    result += int.TryParse(val, out int numVal) == true ? numVal : 0;
                }
            }
            return result;
        }

        private bool IsDelim(string numbers)
        {
            
            return numbers.Length > 3 && numbers[..2] == "//";
        }
    }
}
