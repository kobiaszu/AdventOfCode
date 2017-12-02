using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {

            char ch;
            int Tchar = 0;
            StreamReader reader;
            string input = "";
            //int i = 0;
            reader = new StreamReader(@"C:\Users\RENT\Source\Repos\AdventOfCode\AdventOfCode\input.txt");
            do
            {
                char letter = (char)reader.Read();
                input += letter;
                input += ";";
                //Console.Write(letter);
                //i++;

            } while (!reader.EndOfStream);
            reader.Close();
            reader.Dispose();
            input = input.Remove(input.Length - 1);
            Console.Write(input);

           
            int[] ia = input.Split(';').Select(n => Convert.ToInt32(n)).ToArray();


            foreach (int item in ia)
            {
                Console.Write(item);
            }

            //Console.WriteLine(" ");
            //Console.WriteLine(Tchar.ToString() + " characters");
            Console.ReadLine();
        }
    }
}
