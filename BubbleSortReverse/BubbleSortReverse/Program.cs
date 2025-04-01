namespace BubbleSortReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = new[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(string.Join(",", BubbleSortReverse(test)));
        }

        private static int[] BubbleSortReverse(int[] numbers)
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
    }
}
