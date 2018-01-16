using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();//.Split(new char[] {',', '.', ' ','(',')','!'},StringSplitOptions.RemoveEmptyEntries)
                ;

            string toSearch = Console.ReadLine();
            var count = 0;

            var index = input.IndexOf(toSearch);

            while (index!=-1)
            {
                count++;
                index = input.IndexOf(toSearch, index + 1);
            }

            Console.WriteLine(count);

            




        }
    }
}
