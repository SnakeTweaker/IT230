/*
 *Assignment: Coding Activity Module 2
 *Class: IT-230
 *Author: CJ Busca
 *Date: 21136
 * Instructor: Dr. Wetsch
 */


using System;
using System.Linq;


namespace _2_2_coding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring the array and the integers within
            int[] arrNums = new int[] { 13, 55, 123, 325 };
            int sum = arrNums.Sum();
            int product = arrNums.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);


            //Print functions
            Console.WriteLine("The sum of 13, 55, 123, and 325 = " + sum);
            Console.WriteLine("The product of 13, 55, 123, and 325 = " + product);

        }
    }
}
