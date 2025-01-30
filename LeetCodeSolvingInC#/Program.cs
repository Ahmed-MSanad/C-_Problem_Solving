namespace LeetCodeSolvingInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4])}");
            Console.WriteLine($"{RemoveDuplicates([1, 1, 2])}");

            Console.WriteLine($"{RemoveDuplicates_solution_2([0, 0, 1, 1, 1, 2, 2, 3, 3, 4])}");
            Console.WriteLine($"{RemoveDuplicates_solution_2([1, 1, 2])}");

        }
        public static int RemoveDuplicates(int[] nums)
        {
            Dictionary<int, int> number_index = new Dictionary<int, int>();

            int current_idx = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                //if (!number_index.TryGetValue(nums[i], out int index))
                //{
                //    index = current_idx++;
                //    number_index[nums[i]] = index;
                //}

                // OR:

                //if (!number_index.ContainsKey(nums[i]))
                //{
                //    number_index[nums[i]] = current_idx++;
                //}

                // OR:

                number_index[nums[i]] = number_index.GetValueOrDefault(nums[i], current_idx++);
            }

            foreach (var pair in number_index)
            {
                nums[pair.Value] = pair.Key;
            }

            return number_index.Count;
        }

        public static int RemoveDuplicates_solution_2(int[] nums)
        {
            // solving using 2-pointers tech
            int p1 = 0, p2 = 1; // nums => [1, 1, 2, 3] => [1, 2, 1, 3] => [1, 2, 3, 1]
            while (p1 + 1 < nums.Length && p2 < nums.Length)
            {
                if (nums[p1] != nums[p2])
                {
                    (nums[p1 + 1], nums[p2]) = (nums[p2], nums[p1 + 1]);
                    p1++;
                    p2++;
                }
                else
                {
                    p2++;
                }
            }
            return p1 + 1;
        }

    }
}
