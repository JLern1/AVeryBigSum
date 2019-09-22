using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVeryBigSum
{
    class Program
    {
        static long aVeryBigSum(long[] ar)
        {
            long toReturn = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                toReturn += ar[i];
            }

            return toReturn;
        }
        static void Main(string[] args)
        {
            long[] ar = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            long sol = aVeryBigSum(ar);
            Debug.Print(sol.ToString());
        }
    }
}
