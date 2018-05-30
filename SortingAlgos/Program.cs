using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 5, 6, 7, 2, 1, 9 };
            int[] sorted = CountingSort(data);

            foreach (int n in sorted)
                Console.WriteLine(n);
        }

        static int[] CountingSort(int[] data)
        {
            int[] sorted = new int[data.Length];
            int max = data.Max();
            int[] c = new int[max + 1];

            for (int j = 0; j < data.Length; j++)
                c[data[j]] = c[data[j]] + 1;

            for (int i = 1; i < c.Length; i++)
                c[i] = c[i] + c[i - 1];

            for (int j = data.Length - 1; j >= 0; j--)
            {
                sorted[sorted.Length - c[data[j]]] = data[j];
                c[data[j]] = c[data[j]] - 1;
            }

            return sorted;
        }
    }
}
