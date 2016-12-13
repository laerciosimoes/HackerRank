using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Project to Call");
            var item = Convert.ToInt32(Console.ReadLine());
            switch(item)
            {
                case 2:
                    HackerRank.Day2.Main(null);
                    break;
                case 3:
                    HackerRank.Day3.Main(null);
                    break;
                case 4:
                    HackerRank.Day4.Main(null);
                    break;
                case 10:
                    HackerRank.Day10.Main(null);
                    break;
                default:
                    Console.WriteLine($"Wrong Opetion {item}");
                    break;
            }
        }
    }
}
