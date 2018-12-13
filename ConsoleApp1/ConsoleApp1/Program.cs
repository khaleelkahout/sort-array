using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ConsoleApp1
{
    class Array
    {
        public static void SelectionSort(int[] array)
        {
            Stopwatch time = new Stopwatch();

            time.Start();

            for (var i = 0; i < array.Length - 1; i++)
            {
                var minKey = i;
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minKey])
                    {
                        minKey = j;
                    }
                }

                var temp = array[i];
                array[i] = array[minKey];
                array[minKey] = temp;

            }

            time.Stop();

            Console.WriteLine("      \t     The time taken for selection sort process :" + time.Elapsed);

        }


       public static void HeapSort(int[] src)
        {
            Stopwatch time = new Stopwatch();

            time.Start();
            for (int i = src.Length / 2 - 1; i >= 0; i--)
                Heapify(i, src.Length);
            for (int i = src.Length - 1; i > 0; i--)
            {
                Swap(ref src[i], ref src[0]);
                Heapify(0, i);
            }
            void Heapify(int from, int offset)
            {
                int l = from << 1;
                int r = l + 1;
                int largest = ((l < offset) && src[l] > src[from]) ? l : from;
                if ((r < offset) && (src[r] > src[largest]))
                    largest = r;
                if (largest != from)
                {
                    Swap(ref src[from], ref src[largest]);
                    Heapify(largest, offset);
                }
            }
            void Swap(ref int left, ref int right)
            {
                left ^= right;
                right ^= left;
                left ^= right;
            }

            time.Stop();

            Console.WriteLine("      \t     The time taken for heap sort process :" + time.Elapsed);
        }

        public static void bublesort(int[]array)
        {
            Stopwatch time = new Stopwatch();

            time.Start();

            int swap;
            for (int i=0;i<array.Length;i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        swap = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = swap;

                    }

                }

               

            }


            time.Stop();
            Console.WriteLine("      \t     The time taken for Bubble sort process :" + time.Elapsed);
        }




    }



    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];

            Random rnd = new Random();

            for(int i=0;i<a.Length;i++)
            a[i] = rnd.Next(0,100);

            //for (int i = 0; i < a.Length; i++)
              //  Console.Write("|"+a[i]);

            Console.WriteLine();
            Console.WriteLine();
            
            Array.bublesort(a);
           
            Array.SelectionSort(a);
           

           
            Array.HeapSort(a);
          
            //for (int i = 0; i < a.Length; i++)
            //Console.Write("[" + a[i]+"]");
            Console.ReadLine();
        }
    }
}
