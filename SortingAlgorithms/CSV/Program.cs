using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSV
{
    class CSVProgram
    {
        static void Main(string[] args)
        {
            string[] lines;
            var aList = new List<string>();
            var fileStream = new FileStream("C:/Users/Mark/Documents/Mark's Stuff/Unsorted_Numbers.csv", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    aList.Add(line);
                }
            }
            lines = aList.ToArray();
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }

            //List
            /*string Line;
                var Streamreader = new StreamReader(File.OpenRead(@"unsorted_numbers.csv"));
                while ((Line = Streamreader.ReadLine()) != null)
                {
                Console.WriteLine(Line);
                Line = Streamreader.ReadLine();
                }
             * But that’s no good
                Instead needed to create a list of integers:
                List<int> my list = new List<int>();
                And then instead of Streamreader.ReadLine() you needed to add and read the list instead with:
                my List.Add(read.ReadLine());*/

            //String
            /* string line;
            FileStream aFile = new FileStream("C:/Users/Mark/Documents/Mark's Stuff/Unsorted_Numbers.csv", FileMode.Open);
            StreamReader sr = new StreamReader(aFile);
            // read data in line by line
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            } */
            // sr.Close();

            Console.ReadKey();
        }
    }
}