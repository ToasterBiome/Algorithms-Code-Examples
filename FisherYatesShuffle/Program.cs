using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYatesShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "A", "B", "C", "D", "E" };

            
            for(int i = 0; i < 50; i++)
            {
                strings.FisherYatesShuffle();
                //FisherYatesShuffler.FisherYatesShuffle(strings);
                foreach (string str in strings)
                {
                    Console.Write(str + " ");
                }
                Console.Write("\n");
            }
            
            Console.ReadLine();
        }
    }
}
