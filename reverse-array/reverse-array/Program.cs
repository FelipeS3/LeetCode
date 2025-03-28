namespace reverse_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = [1, 2, 3, 4, 5, 6, 7];
            var reverseArray = ReverseArray(array);

            Console.WriteLine("Array: " + string.Join(",", reverseArray));
        }

        private static int[] ReverseArray(int[] numbers)
        {
            var newArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                newArray[i] = numbers[numbers.Length - 1 - i];
            }

            return newArray;
        }
    }
}
