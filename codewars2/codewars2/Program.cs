using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = "the";
            
            Console.WriteLine(AlphabetPos(str));
        }
        static string AlphabetPos(string text)
        {
            return string.Join(" ", text.ToLower().Where(c => char.IsLetter(c)).Select(x => x - 'a' + 1));
            
        }
    }
}
