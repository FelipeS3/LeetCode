namespace ReverseEvenNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = { 1, 2, 3, 4 };
            int[] test2 = { 2, 4, 6 };
            int[] test3 = { 1, 3, 5 };
            int[] test4 = { 1, 2, 3, 4, 5 };

            Console.WriteLine(string.Join(", ", ReverseEvenNumbers(test1)));
            Console.WriteLine(string.Join(", ", ReverseEvenNumbers(test2))); 
            Console.WriteLine(string.Join(", ", ReverseEvenNumbers(test3)));
            Console.WriteLine(string.Join(", ", ReverseEvenNumbers(test4))); 
        }

        private static int[] ReverseEvenNumbers(int[] numbers)
        {
            var array = new int[numbers.Length];
            Array.Copy(numbers, array, numbers.Length);

            var left = 0;
            var right = array.Length - 1;

            while (left < right)
            {
                while (left < right && array[left] % 2 != 0 )
                {
                    left++;
                }

                while (right > left && array[right] % 2 != 0)
                {
                    right--;
                }

                if (left < right)
                {
                    int temp = 
                }
            }

            return array;
        }
    }
}
