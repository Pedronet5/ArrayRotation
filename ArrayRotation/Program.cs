using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Number of rotation!");
                var value = Console.ReadLine();

                Console.WriteLine("Array numbers, example: [3, 4, 5], input to enter: 345");
                var arrayString = Console.ReadLine();

                int[] array = arrayString.Select(c => int.Parse(c.ToString())).ToArray();

                var x = RightRotate(array, Convert.ToInt32(value));

                Console.WriteLine($"Result: {x}");

                Console.ReadKey();
                Console.Clear();
            }

        }

        public static string RightRotate(int[] a, int times)
        {
            for (int i = 0; i < times; i++)
            {
                RightRotateByOne(a);
            }

            return string.Join("", a);
        }

        private static void RightRotateByOne(int[] a)
        {
            int last = a[a.Length - 1];

            for (int i = a.Length - 2; i >= 0; i--)
            {
                a[i + 1] = a[i];
            }
            a[0] = last;
        }
    }
}
