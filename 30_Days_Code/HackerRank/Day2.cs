using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Day2
    {
        public void Main(string[] args)
        {
            var mealCost = Convert.ToInt32(Console.ReadLine());
            var tipPercent = Convert.ToInt32(Console.ReadLine());
            var taxPercent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(getTotalCost(mealCost, tipPercent, taxPercent));
        }

        public string getTotalCost(int mealCost, int tipPercent, int taxPercent)
        {
            double tip = mealCost * (tipPercent / 100);
            double tax = mealCost * (taxPercent / 100);
            var totalCost = Math.Round(mealCost + tip + tax, 0);

            return $"The total meal cost is {totalCost} dollars.";
        }
    }
}
