using System;

namespace arrayAssin
{
    public class ArrayAssin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size on an array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("enter the elements in the array ");
            for(int i =0; i< size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            int sum = 0;
            for(int i =0 ; i < size; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"Sum of these array are : {sum}");
        }
    }
}