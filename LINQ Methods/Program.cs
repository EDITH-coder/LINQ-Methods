using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers= new int[7] {8,9,3,36,2,10,25};
            Console.WriteLine("The minimum number is:" + Numbers.Min());
            Console.WriteLine("The average is: " +Numbers.Average());
            Console.WriteLine("The maximum number is: " +Numbers.Max());
            Console.WriteLine("The sum is: " + Numbers.Sum());
            Console.WriteLine("The first number is: " +Numbers.First());
            Console.WriteLine("The last number is: " + Numbers.Last());
           

            Console.ReadLine();
        }
    }
}
