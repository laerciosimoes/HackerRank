using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
   public class Day21
    {

        static void printArray<T>(T[] p)
        {
            var sb = new System.Text.StringBuilder();
            for (var i = 0; i < p.Length; i++)
            {
                if(i > 0)
                {
                    sb.Append(" ");
                }
                sb.Append(p[i]);
            }
            Console.WriteLine(sb.ToString());
        }

        public static void Main(String[] args)
        {
            int[] vInt = new int[] { 1, 2, 3 };
            string[] vString = new string[] { "Hello", "World" };

            printArray<int>(vInt);
            printArray<string>(vString);
        }
    }
}
