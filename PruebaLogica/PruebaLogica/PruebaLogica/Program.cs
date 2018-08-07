using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            var length=int.Parse( Console.ReadLine());
            var testCases = new int[length, 2];
            for(var i = 0; i < length; i++)
            {
                var line = Console.ReadLine();
                var result = line.Split(' ').Select(x => int.Parse(x)).ToArray();
                testCases[i, 0] = result[0];
                testCases[i, 1] = result[1];
            }

            var results = new List<char>();
            for (var i = 0; i < length; i++)
            {
                results.Add(CalculateDirection(testCases[i, 0], testCases[i, 1]));
            }
            foreach(var result in results)
            {
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Doing a quick analisys I found that 
        /// if N <= M and N is odd then the result is R
        /// if N <= M and N is even then the result is L
        /// if N > M and M is odd then the result is D
        /// if N > M and M is even then the result is U
        /// </summary>
        /// <param name="N">rows</param>
        /// <param name="M">columns</param>
        /// <returns></returns>
        static char CalculateDirection(int N, int M)
        {
            if (N <= M)
            {
                if (N % 2 != 0)
                {
                    return 'R';
                }
                else
                {
                    return 'L';
                }
            }
            else
            {
                if (M % 2 != 0)
                {
                    return 'D';
                }
                else
                {
                    return 'U';
                }
            }
        }
    }
}
