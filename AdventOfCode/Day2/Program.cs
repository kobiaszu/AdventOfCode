using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {

            //char ch;
            //int Tchar = 0;
            StreamReader reader;
            //string input = "";
            int linesAmount = 0;
            string[] inputLines = new string[100];
            reader = new StreamReader(@"C:\Users\RENT\Source\Repos\AdventOfCode\AdventOfCode\Day2\input.txt");
            do
            {
                string line = (string)reader.ReadLine();
                inputLines[linesAmount] += line;
                //Console.Write(letter);
                linesAmount++;

            } while (!reader.EndOfStream);
            reader.Close();
            reader.Dispose();
            //Console.WriteLine("PRINT AGAIN!");

            string[] Arrays = new string[1000];
            int counter = 0;
            //int arraysAmount = 0;
            string tray = "";
            int CRC = 0;
            for (int i = 0; i < linesAmount; i++)
            {
                string line = inputLines[i];
                int y = 0;

                while (line[y] != null)
                {
                    string tray2 = $"{line[y]}";

                    if ((tray == "\t") && (tray2 != "\t"))
                    {
                        counter++;
                    }
                    if (tray2 != "\t")
                    {
                        Arrays[counter] += tray2;
                    }
                    tray = tray2;

                    y++;
                    if (y >= line.Length)
                    {
                        break;
                    }
                }
                counter++;
                tray = "";

                string array = Arrays[0];
                int smallest = 0;
                int.TryParse(array, out smallest);
                int biggest = smallest;
                for (int t = 0; t < counter; t++)
                {
                    array = Arrays[t];

                    int lowNumber = 0;
                    int.TryParse(array, out lowNumber);
                    if (lowNumber > biggest)
                        biggest = lowNumber;
                    if (lowNumber < smallest)
                        smallest = lowNumber;
                }
                Console.WriteLine($"diff = {Math.Abs(biggest - smallest)}");

                CRC += Math.Abs(biggest - smallest);
                
                for (int p = 0; p < counter; p++)
                {
                    Arrays[p] = "";
                }
                counter = 0;

            }

            //int CRC = 0;
            //string letter = "";
            //for ( int y = 0; y < counter; y++)
            //{
            //    string array = Arrays[y];

            //    letter = $"{array[0]}";
            //    int smallest = 0;
            //    int.TryParse(letter, out smallest);
            //    int biggest = smallest;
            //    foreach (var number in array)
            //    {
            //        letter = $"{number}";
            //        int lowNumber = 0;
            //        int.TryParse(letter, out lowNumber);
            //        if (lowNumber > biggest)
            //            biggest = lowNumber;
            //        if (lowNumber < smallest)
            //            smallest = lowNumber;

            //    }
            //    CRC += Math.Abs(biggest - smallest);
            //}

            Console.WriteLine($"CRC: {CRC}");

            Console.ReadKey();




        }
    }
}
