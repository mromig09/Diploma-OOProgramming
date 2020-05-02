using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Insertion_Sort
{
    class InsertionSort
    {
        void sort(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }

        static void printArray(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.Write("\n");
        }

        public static void Main()
        {
            List<int> arr;
            List<int> aList = new List<int>();

            var fileStream = new FileStream("C:/Users/Mark/Documents/Mark's Stuff/Unsorted_Numbers.csv", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream))
            {
                int line;
                while ((line = Convert.ToInt32(streamReader.ReadLine())) != 0)
                {
                    aList.Add(line);
                }
            }

            arr = aList.ToList();
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }

            InsertionSort ob = new InsertionSort();
            ob.sort(arr);

            Console.WriteLine("Sorted Numbers");
            printArray(arr);

            Console.ReadKey();

            //old code
            //File.OpenRead("C:/Users/Mark/Documents/Mark's Stuff/Unsorted_Numbers.csv");
            //List<int> my list = new List<int>();
            //List<int> arr

            /*int[] arr = { 100, 12, 51, 19, 5, 68, 27, 1, 2 };
            Console.Write("Array Before Sorting \n");
            printArray(arr);
            Console.WriteLine();
            InsertionSort ob = new InsertionSort();
            ob.sort(arr);
            Console.Write("Array After Sorting \n");*/

        }
    }
}