using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYatesShuffle
{
    public static class FisherYatesShuffler
    {
        static Random rand = new Random();

        //i like the extension so you can just call it on itself, so i will use that.
        public static void FisherYatesShuffle(this object[] objects)
        {
            for(int i = objects.Length - 1; i > 0; i--)
            {
                //get a random number between 0 and i, inclusive)
                int j = rand.Next(i + 1);
                //set a temporary variable to switch with
                object temp = objects[j];
                //do the switch
                objects[j] = objects[i];
                objects[i] = temp;
            }

        }
    }
}
