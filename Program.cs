namespace Assignment_6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] nums = { 1, 0, 3, 0, 5, 0, 7, 0, 9, 0 };
            Console.WriteLine($"The array of numbers is: {string.Join(", ", nums)}");
            MoveZeros(nums);
            Console.WriteLine();
            Console.WriteLine($"The array with zeros moved is: {string.Join(", ", nums)}");
        }

        public static void MoveZeros(int[] nums)
        {
            int j = 0; // Pointer for non-zero elements
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    // Swap non-zero element with the element at index j
                    int temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                    j++;
                }
            }
        }
    }
}
