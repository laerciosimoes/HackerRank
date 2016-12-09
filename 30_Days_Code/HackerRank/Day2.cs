using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public  class Day2
    {
        public static void Main(string[] args)
        {
            var mealCost = Convert.ToDouble(Console.ReadLine());
            var tipPercent = Convert.ToDouble(Console.ReadLine());
            var taxPercent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(getTotalCost(mealCost, tipPercent, taxPercent));
        }

        static string getTotalCost(double mealCost, double tipPercent, double taxPercent)
        {
            double tip = mealCost * (tipPercent / 100);
            double tax = mealCost * (taxPercent / 100);
            var totalCost = Math.Round(mealCost + tip + tax, 0);

            return $"The total meal cost is {totalCost} dollars.";
        }
    }
}
