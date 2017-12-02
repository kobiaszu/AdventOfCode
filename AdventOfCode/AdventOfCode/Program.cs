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
            //Console.Write(input);

            int[] ia = input.Split(';').Select(n => Convert.ToInt32(n)).ToArray();

            int CalculatedCaptcha = 0;
            int tray1 = ia[1], tray2 = ia[0];

            if (tray1 == tray2 )
            {
                CalculatedCaptcha += tray1;

            }

            for ( int i = 0; i < ia.Length; i++)
            {
                if (tray1 == ia[i]) { 
                    if (tray2 != tray1)
                    {
                        CalculatedCaptcha += tray1;
                    }
                    else
                    {
                        CalculatedCaptcha += tray1;
                    }
                }

                tray2 = tray1;
                tray1 = ia[i];
            }

            if (ia[0] == ia[ia.Length-1])
            {
                CalculatedCaptcha += ia[0];

            }
            Console.Write(CalculatedCaptcha);
            Console.ReadLine();
        }
    }
}
