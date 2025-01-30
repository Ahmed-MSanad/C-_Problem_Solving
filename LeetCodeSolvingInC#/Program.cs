namespace LeetCodeSolvingInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2)}"); // answer: 5 remaining numbers than the Val = 2
        }

        public static int RemoveElement(int[] nums, int val)
        {
            List<int> notValNumbers = new List<int>();
            foreach (int num in nums)
                if (num != val)
                    notValNumbers.Add(num);
            for (int i = 0; i < notValNumbers.Count; i++)
            {
                nums[i] = notValNumbers[i];
            }

            return notValNumbers.Count;
        }

    }
}
