using System;
using System.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string newline = "";
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int start = Math.Max(a - 1, 0);
            int end = Math.Min(b - 1, line.Length - 1);
            newline = line.Remove(start, end - start + 1);
            Console.WriteLine(newline);
        }
    }
}
