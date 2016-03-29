using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyingWithoutAsterisks
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1, number2, result = 0;

            number1 = Convert.ToInt16(Console.ReadLine());
            number2 = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < Math.Abs(number1); i++)
                result = result + number2;

            if (number1 < 0 && number2 < 0)
                result = Math.Abs(result);

            if (number1 < 0 && number2 > 0)
                result = result - result - result;

            Console.WriteLine("The Result Is: " + result);
            Console.ReadLine();
        }
    }
}
