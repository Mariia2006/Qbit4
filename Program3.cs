using System;
using System.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int[] ints = new int[data.Length];
            int ints_x = 0;
            char ch = ' ';
            for (int i = 0; i < data.Length; i++)
            {
                ch = char.Parse(data[i]);
                ints_x = (int)ch;
                ints[i] = ints_x;
            }
            Array.Sort(ints);
            foreach (int c in ints)
            {
                Console.Write((char)c + " ");
            }
        }
    }
}
