using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class SumArray
    {
        public int[] Array { get; set; }

        public SumArray(int[] a)
        {
            Array = a;
        }

        public static SumArray operator +(SumArray a, SumArray b)
        {
            int[] result = new int[a.Array.Length];

            for (int i = 0; i < a.Array.Length; i++)
            {
                result[i] = a.Array[i] + b.Array[i];
            }
            return new SumArray(result);

        }

        public void PrintArray(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"  ");
            }
        }

    }
}
