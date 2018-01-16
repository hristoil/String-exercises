using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new char[]{' ',',','.','!','?'},StringSplitOptions.RemoveEmptyEntries);

            List<string> result = new List<string>();

            foreach (var word in words)
            {
                char[] letters = word.ToCharArray();

                if (letters.Length==1)
                {
                    if (result.Contains(word))
                    {
                        continue;
                    }
                    result.Add(word);
                }

                for (int i = 0; i < letters.Length/2; i++)
                {
                    if (letters[i]== letters.Last()-i)
                    {
                        if (result.Contains(word))
                        {
                            continue;
                        }
                        result.Add(word);
                    }
                }

            }
        
            result.Sort();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
