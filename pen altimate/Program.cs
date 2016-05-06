using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pen_altimate
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "This is for Code Eval";
            string[] inputWords = line.Split();
            int lenOfArray = inputWords.Length;
            Console.WriteLine(inputWords[lenOfArray -2] ); 

        }
    }
}
