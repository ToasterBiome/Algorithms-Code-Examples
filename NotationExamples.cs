using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCodeExamples
{
    class NotationExamples
    {
        static void Main(string[] args)
        {

        }

        //Constant O(1)
        int ConstantExample(int[] input, int value)
        {
            //should check if it's null or not...
            if(input.Length > value)
            {
                return 0; ;
            }

            return input[value]; //just return the element at index "value" no matter the size
        }



        //Linear O(n)
        int LinearExample(int[] input, int value)
        {
            for (int i = 0; i < input.Length; i++) //loop 1, making it O(n)
            {
                if(input[i] == value) //this can be done with O(1), just showing a terrible example of O(n).
                {
                    return i;
                }
            }
            return 0;
        }

        //Quadratic (n^2)

        int QuadraticExample(int[] input1, int[] input2)
        {
            for(int i = 0; i < input1.Length; i++) //loop 1, making it O(n)
            {
                for (int j = 0; j < input2.Length; j++) //loop 2, making it O(n^2)
                {
                    if(input1[i] == (input2[j]))
                    {
                        return i; //loops over the 2nd list input1.length times, return doesn't really matter
                    }
                }
            }
            return 0;
        }



    }
}
