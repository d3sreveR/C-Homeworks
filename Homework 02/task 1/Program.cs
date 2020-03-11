using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 6 numbers!");
            int[] a = new int[6];
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("You have entered: " + a[i]);
                if (a[i]%2==0)
                {
                    sum += a[i];
                }
            }

            Console.WriteLine("");
            Console.WriteLine("All even numbers summed equals: "+sum);
            Console.Read();
        }
    }
}
