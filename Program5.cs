using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int counter = 0;
            foreach (char c in line)
            {
                counter++;
                if (c == ' ')
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
