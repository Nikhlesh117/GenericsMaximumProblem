using System;
using System.Runtime.InteropServices;

namespace FindMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Maximum Problem Using Generics");

            int[] arr = { 100,200,300,500,400 };
            ExtendMethod<int> generic = new ExtendMethod<int>(arr);
            Console.WriteLine("Maximum value amongst the provided numbers is : {0}", generic.MaxValue(arr));
        }
    }
}
    
