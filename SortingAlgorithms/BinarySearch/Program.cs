using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Binary_Search
{
    class BinaryProgram
    {
        int sort(List<int> arr)
        {
            int n = arr.Count;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        arr[j] = arr[j - gap];
                    arr[j] = temp;
                }
            }
            return 0;
        }

        static void printArray(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
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

            //previous unsorted numbers
            /*for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }*/

            BinaryProgram ob = new BinaryProgram();
            ob.sort(arr);

            //printed sorted numbers
            /*Console.Write("Sorted Numbers\n");
            printArray(arr);*/

            Console.WriteLine("Start a binary search for the values: \n575154, 182339, 17132, 773788, 296934, 991395, 303270, 45231, 580, 629822?");
            Console.WriteLine("\nyes / no");
            var userdecision = Console.ReadLine();
            if (userdecision == "yes")
            {
                int m = arr.BinarySearch(575154);
                Console.WriteLine("\n575154 is in position " + m + " of the list");

                m = arr.BinarySearch(182339);
                Console.WriteLine("182339 is in position " + m + " of the list");

                m = arr.BinarySearch(17132);
                Console.WriteLine("17132 is in position " + m + " of the list");

                m = arr.BinarySearch(773788);
                Console.WriteLine("773788 is in position " + m + " of the list");

                m = arr.BinarySearch(296934);
                Console.WriteLine("296934 is in position " + m + " of the list");

                m = arr.BinarySearch(991395);
                Console.WriteLine("991395 is in position " + m + " of the list");

                m = arr.BinarySearch(303270);
                Console.WriteLine("303270 is in position " + m + " of the list");

                m = arr.BinarySearch(45231);
                Console.WriteLine("45231 is in position " + m + " of the list");

                m = arr.BinarySearch(580);
                Console.WriteLine("580 is in position " + m + " of the list");

                m = arr.BinarySearch(629822);
                Console.WriteLine("629822 is in position " + m + " of the list");
            }
            else
            {
                Console.WriteLine("Goodbye. . .");
            }

            Console.ReadKey();
        }
    }
}