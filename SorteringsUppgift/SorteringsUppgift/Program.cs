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

        static void Selectionsort(List<int> myList)
        {
            int temp, smallest;
            for (int i = 0; i < myList.Count - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < myList.Count; j++)
                {
                    if (myList[j] < myList[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = myList[smallest];
                myList[smallest] = myList[i];
                myList[i] = temp;
            }
        }
    }

    static void SkapaSlumpLista(List<int> myList, int size)
    {
        Random slump = new Random();
        for (int i = 0; i < size; i++) //skapar ett stort antal slumptal i listan
        {
            myList.Add(slump.Next(100000));
        }
    }    
        static void Main(string[] args)
        {
            List<int> tallista10 = new List<int>();
            SkapaSlumpLista(tallista10, 10);
            Stopwatch stopwatch10 = new Stopwatch();
            stopwatch10.Start();
            Bubblesort(tallista10);
            stopwatch10.Stop();
            TimeSpan ts10 = stopwatch10.Elapsed;
            string elapsedTime10 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts10.Hours, ts10.Minutes, ts10.Seconds,
            ts10.Milliseconds / 10);

            List<int> tallista1000 = new List<int>();
            SkapaSlumpLista(tallista1000, 1000);
            Stopwatch stopwatch1000 = new Stopwatch();
            stopwatch1000.Start();
            Bubblesort(tallista1000);
            stopwatch1000.Stop();
            TimeSpan ts1000 = stopwatch1000.Elapsed;
            string elapsedTime1000 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts1000.Hours, ts1000.Minutes, ts1000.Seconds,
            ts1000.Milliseconds / 10);

            List<int> tallista10000 = new List<int>();
            SkapaSlumpLista(tallista10000, 10000);
            Stopwatch stopwatch10000 = new Stopwatch();
            stopwatch10000.Start();
            Bubblesort(tallista10000);
            stopwatch10000.Stop();
            TimeSpan ts10000 = stopwatch10000.Elapsed;
            string elapsedTime10000 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts10000.Hours, ts10000.Minutes, ts10000.Seconds,
            ts10000.Milliseconds / 10);

            List<int> tallista20000 = new List<int>();
            SkapaSlumpLista(tallista20000, 20000);
            Stopwatch stopwatch20000 = new Stopwatch();
            stopwatch20000.Start();
            Bubblesort(tallista20000);
            stopwatch20000.Stop();
            TimeSpan ts20000 = stopwatch20000.Elapsed;
            string elapsedTime20000 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts20000.Hours, ts20000.Minutes, ts20000.Seconds,
            ts20000.Milliseconds / 10);

            List<int> tallista100000 = new List<int>();
            SkapaSlumpLista(tallista100000, 100000);
            Stopwatch stopwatch100000 = new Stopwatch();
            stopwatch100000.Start();
            Bubblesort(tallista100000);
            stopwatch100000.Stop();
            TimeSpan ts100000 = stopwatch100000.Elapsed;
            string elapsedTime100000 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts100000.Hours, ts100000.Minutes, ts100000.Seconds,
            ts100000.Milliseconds / 10);

            List<int> tallista40000 = new List<int>();
            SkapaSlumpLista(tallista40000, 40000);
            Stopwatch stopwatch40000 = new Stopwatch();
            stopwatch40000.Start();
            Bubblesort(tallista40000);
            stopwatch40000.Stop();
            TimeSpan ts40000 = stopwatch40000.Elapsed;
            string elapsedTime40000 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts40000.Hours, ts40000.Minutes, ts40000.Seconds,
            ts40000.Milliseconds / 10);

            Console.WriteLine("Listan är sorterad" + "\nTiden för 10 var: " + elapsedTime10 + "\nTiden för 1000 var: " + elapsedTime1000 + "\nTiden för 10000 var: " + elapsedTime10000 + "\nTiden för 20000 var: " + elapsedTime20000 + "\nTiden för 40000 var: " + elapsedTime40000 + "\nTiden för 100000 var: " + elapsedTime100000);
        }
    }
}
