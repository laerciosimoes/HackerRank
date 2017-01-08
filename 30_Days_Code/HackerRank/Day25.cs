using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
   public static class Day25
   {
       private static List<int> lstPrimes = new List<int>();

        // Build a Sieve of Eratosthenes.
        private static bool[] MakeSieve(int max)
        {
            // Make an array indicating whether numbers are prime.
            bool[] is_prime = new bool[max + 1];
            for (int i = 2; i <= max; i++) is_prime[i] = true;

            // Cross out multiples.
            for (int i = 2; i <= max; i++)
            {
                // See if i is prime.
                if (is_prime[i])
                {
                    // Knock out multiples of i.
                    for (int j = i * 2; j <= max; j += i)
                        is_prime[j] = false;
                }
            }
            return is_prime;
        }

       

        public static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            var lstNumbers = new List<int>();
            //int T = Int32.Parse(Console.ReadLine());
            //int maxNumber = Int32.MinValue;

            //while (T-- > 0)
            //{
            //    int data = Int32.Parse(Console.ReadLine());
            //    lstNumbers.Add(data);
            //    maxNumber = Math.Max(data, maxNumber);
            //}

            lstNumbers.Add(1);
            lstNumbers.Add(4);
            lstNumbers.Add(9);
            lstNumbers.Add(16);
            lstNumbers.Add(25);
            lstNumbers.Add(36);
            lstNumbers.Add(49);
            lstNumbers.Add(64);
            lstNumbers.Add(81);
            lstNumbers.Add(100);
            lstNumbers.Add(121);
            lstNumbers.Add(144);
            lstNumbers.Add(169);
            lstNumbers.Add(196);
            lstNumbers.Add(225);
            lstNumbers.Add(256);
            lstNumbers.Add(289);
            lstNumbers.Add(324);
            lstNumbers.Add(361);
            lstNumbers.Add(400);
            lstNumbers.Add(441);
            lstNumbers.Add(484);
            lstNumbers.Add(529);
            lstNumbers.Add(576);
            lstNumbers.Add(625);
            lstNumbers.Add(676);
            lstNumbers.Add(729);
            lstNumbers.Add(784);
            lstNumbers.Add(841);
            lstNumbers.Add(907);

            var maxNumber = 907;

            var sqrt = Convert.ToInt32(Math.Sqrt(maxNumber) + 1);

            var is_prime = MakeSieve(sqrt);

            for (int i = 2; i <= sqrt; i++)
                if (is_prime[i]) lstPrimes.Add(i);

            foreach (var item in lstNumbers)
            {
                var isPrime = true;
                foreach (var prime in lstPrimes)
                {
                    if (item % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine(isPrime ? "Prime" : "Not Prime");
            }
        }
    }
}
