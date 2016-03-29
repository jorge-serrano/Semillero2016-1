using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonotonicPair
{
	class Program
	{
		static void Main(string[] args)
		{

            int[] A = {5, 3, 6, 3, 4, 2};
            int max = 0;
            string parMax = "";
            for (int i = 0; i < A.Length; i++)
            {
                int p = A[i];
                for (int j = 0; j < A.Length; j++)
                {
                    int q = A[j];
                    if ( i <= j && p <= q)
                    {
                        Console.WriteLine("(" + i + "," + j + ")" + " " + "Distance: " + Convert.ToString(j - i) + "\n");
                        if ((j - i) > max)
                        {
                            parMax = "(" + i + "," + j + ")";
                            max = j - i;
                        }
                    }
                }
            }

            Console.WriteLine("The pair is: " + parMax);
            Console.WriteLine("The furthest apart monotonic pair is: " + max);
            Console.ReadLine();
        }
    }
}
