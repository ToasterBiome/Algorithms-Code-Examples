using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCodeExamples
{
    class Searches
    {

         static int[] data;

        static Stopwatch watch;
        
        static void Main(string[] args)
        {
            watch = new Stopwatch();

            LoadScores();
            Console.WriteLine("Linear Search:");
            Console.WriteLine("Looking for the number 99");
            watch.Start();
            int linearResult = LinearSearch(99);
            watch.Stop();
            Console.WriteLine("Number found at index: " + linearResult + " Time Taken: " + watch.ElapsedMilliseconds + "ms");
            Console.WriteLine("Verify: " + data[linearResult]);

            Console.WriteLine("Binary Search:");
            Console.WriteLine("Looking for the number 99");
            watch.Restart();
            int binaryResult = BinarySearch(77);
            watch.Stop();
            Console.WriteLine("Number found at index: " + binaryResult + " Time Taken: " + watch.ElapsedMilliseconds + "ms");
            Console.WriteLine("Verify: " + data[binaryResult]);

            Console.WriteLine("Interpolation Search:");
            Console.WriteLine("Looking for the number 99");
            watch.Restart();
            int interpolationResult = InterpolationSearch(77);
            watch.Stop();
            Console.WriteLine("Number found at index: " + interpolationResult + " Time Taken: " + watch.ElapsedMilliseconds + "ms");
            Console.WriteLine("Verify: " + data[interpolationResult]);
            Console.ReadLine();

        }


        public static void LoadScores()
        {
            string[] lines = File.ReadAllLines("scores.txt");
            data = new int[lines.Length];
            for(int i = 0; i < lines.Length; i++)
            {
                data[i] = int.Parse(lines[i]);
            }
        }

        public static int LinearSearch(int target)
        {
            for(int i = 0; i < data.Length; i++)
            {
                if(data[i] == target)
                {
                    return i;
                }
            }
            //couldn't find it :(
            return -1;
        }

        public static int BinarySearch(int target)
        {
            

            int start = 0;
            int end = data.Length - 1;
            int index;

        //needs to be sorted first
        Array.Sort(data);

            while(start <= end)
            {
                index = (int)Math.Floor((double)(start + end) / 2); //stupid casting
                if(target == data[index])
                {
                    return index;
                }

                if(target - data[index] > 0)
                {
                    start = index;
                } else
                {
                    end = index;
                }
            }
            return -1;
        }

        public static int InterpolationSearch(int target)
        {


            int start = 0;
            int end = data.Length - 1;
            int index;

            //needs to be sorted first
            Array.Sort(data);

            while (start <= end)
            {
                
                index = start + ((target - data[start]) * (end - start) / (data[end] - data[start])); //this seems to be the only difference?????
                if (target == data[index])
                {
                    return index;
                }

                if (target - data[index] > 0)
                {
                    start = index;
                }
                else
                {
                    end = index;
                }
            }
            return -1;
        }
    }
}
