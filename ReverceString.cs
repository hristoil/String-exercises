using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            var rev = str.Reverse();

            foreach (var letter in rev)
            {
                Console.Write(letter);
            }


        }
    }
}
