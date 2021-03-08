using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;


namespace SorteringsUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsorted = new List<int>();
            List<int> sorted;

            Random random = new Random();

            for (int i = 0; i < 40000; i++)
            {
                unsorted.Add(random.Next(0, 1000000));
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sorted = QuickSort(unsorted);

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            //foreach (int x in sorted)
            //{
                //Console.Write(x + " ");
            //}

                Console.WriteLine("Listan är sorterad" + "\nTiden var " + elapsedTime);
        }

        static List<int> QuickSort(List<int> lst)
        {
            if (lst.Count <= 1)
                return lst;
            int pivotIndex = lst.Count / 2;
            int pivot = lst[pivotIndex];
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < lst.Count; i++)
            {
                if (i == pivotIndex) continue;

                if (lst[i] <= pivot)
                {
                    left.Add(lst[i]);
                }
                else
                {
                    right.Add(lst[i]);
                }
            }

            List<int> sorted = QuickSort(left);
            sorted.Add(pivot);
            sorted.AddRange(QuickSort(right));
            return sorted;
        }
    }
}
