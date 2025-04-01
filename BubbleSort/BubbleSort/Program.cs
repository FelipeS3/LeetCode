
namespace BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = { 4, 1, 3, 2, 5, 10, 9, 8, 7, 6, 5, 4, 3, 2 ,2 ,1 };
            int[] test2 = { 5, 2, 8 };
            int[] test3 = { 1 };
            int[] test4 = { 3, 3, 1, 5, 7, 6 };

            Console.WriteLine(string.Join(", ", BubbleSort(test1))); // 1, 2, 3, 4
            Console.WriteLine(string.Join(", ", BubbleSort(test2))); // 2, 5, 8
            Console.WriteLine(string.Join(", ", BubbleSort(test3))); // 1
            Console.WriteLine(string.Join(", ", BubbleSort(test4))); // 1, 3, 3, 5
            Console.WriteLine(string.Join(", ", BubbleSortInverse(test1)));
            Console.WriteLine(string.Join(", ", SelectionSort(test4)));

            int[] test7 = { 4, 1, 3, 2 };
            Console.WriteLine(string.Join(", ", SelectionSort(test7))); // 1, 2, 3, 4

            int[] testSort = [3, 1, 2, 4];
            Console.WriteLine(string.Join(", ", SortArrayByParity(testSort)));
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

        private static int[] BubbleSortInverse(int[] numbers)
        {
            int[] array = new int[numbers.Length];
            Array.Copy(numbers, array, numbers.Length);

            for (int i = 0; i < array.Length - 1; i++) 
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    }
                }
            }

            return array;
        }

        private static int[] SelectionSort(int[] numbers)
        {
            int[] array = new int[numbers.Length];
            Array.Copy(numbers, array, numbers.Length);

            for (int i = 0; i < array.Length - 1; i++)
            {
                var minIndex = i;
                for (int j = 1 + i; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                (array[i], array[minIndex]) = (array[minIndex], array[i]);
            }

            return array;
        }

        public static int[] SortArrayByParity(int[] nums)
        {
            int[] array = new int[nums.Length];
            Array.Copy(nums, array, nums.Length);

            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        array[i] = j;
                    }
                }
            }

            return array;
        }
    }
}
   