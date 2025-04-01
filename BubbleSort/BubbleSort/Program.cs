using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.JavaScript;

namespace BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = { 4, 1, 3, 2,5,10,9,8,7,6,5,4,3,2,2,1 };
            int[] test2 = { 5, 2, 8 };
            int[] test3 = { 1 };
            int[] test4 = { 3, 3, 1, 5 };

            Console.WriteLine(string.Join(", ", BubbleSort(test1))); // 1, 2, 3, 4
            Console.WriteLine(string.Join(", ", BubbleSort(test2))); // 2, 5, 8
            Console.WriteLine(string.Join(", ", BubbleSort(test3))); // 1
            Console.WriteLine(string.Join(", ", BubbleSort(test4))); // 1, 3, 3, 5
        }

        private static int[] BubbleSort(int[] numbers)
        {
            var array = new int[numbers.Length];
            Array.Copy(numbers, array, numbers.Length);

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }

            return array;
        }

        
    }
}
   