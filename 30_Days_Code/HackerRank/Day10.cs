using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
  public  class Day10
    {
     public   static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var binNumber = Convert.ToString(n, 2);
            var maxNum = 0;
            var actual = 0;
            for (var i = 0; i < binNumber.Length; i++)
            {
                if (binNumber[i] == '1')
                {
                    actual++;
                }
                else
                {
                    if (actual > maxNum)
                    {
                        maxNum = actual;
                    }
                    actual = 0;
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
