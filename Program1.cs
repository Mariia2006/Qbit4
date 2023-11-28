using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char element = char.Parse(Console.ReadLine());
            if ((int)element >= 65 && (int)element <= 90)
            {
                Console.WriteLine(element.ToString().ToLower());
            }
            if ((int)element >= 97 && (int)element <= 122)
            {
                Console.WriteLine(element.ToString().ToUpper());
            }
        }
    }
}