using System;


namespace HackerRank
{
    public static class Day3
    {
        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            
            if(n%2 == 0)
            {
                if (n >= 2 && n <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if( n >= 6 && n <= 20)
                {
                    Console.WriteLine("Weird");
                } else
                {
                    Console.WriteLine("Not Weird");
                }
            }
            else
            {
                Console.WriteLine("Weird");
            }

        }
    }
}
