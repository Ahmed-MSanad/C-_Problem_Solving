using System.Runtime.CompilerServices;

namespace LeetCodeSolvingInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test cases:
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            foreach (int x in nums)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
            Console.WriteLine($"{RemoveDuplicates_2(nums)}");
            foreach (int x in nums)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();


            nums = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            foreach (int x in nums)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
            Console.WriteLine($"{RemoveDuplicates_2(nums)}");
            foreach (int x in nums)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();


            nums = new int[] { 0, 1, 2, 3 };
            foreach (int x in nums)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
            Console.WriteLine($"{RemoveDuplicates_2(nums)}");
            foreach (int x in nums)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();


            nums = new int[] { 1, 1, 1 };
            foreach (int x in nums)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
            Console.WriteLine($"{RemoveDuplicates_2(nums)}");
            foreach (int x in nums)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();

            nums = new int[] { 1, 1, 1, 2, 2, 2, 3, 3 };
            foreach (int x in nums)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
            Console.WriteLine($"{RemoveDuplicates_2(nums)}");
            foreach (int x in nums)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int p1 = 0, p2 = 1, cnt = 1;
            while (p1 < nums.Length && p2 < nums.Length)
            {
                if (nums[p1] == nums[p2])
                {
                    if(cnt == 1 && p2 - p1 == 1)
                    {
                        p1++;
                        cnt++;
                        p2++;
                    }
                    else if(cnt == 1){
                        p1++;
                        (nums[p1], nums[p2]) = (nums[p2], nums[p1]);
                        p2++;
                        cnt++;
                    }
                    else 
                    {
                        int temp = nums[p1];
                        while (p1 < p2 && nums[p2] == nums[p1]) p1++;
                        while (p2 < nums.Length && nums[p2] == temp) p2++;
                        if(p2 < nums.Length)(nums[p1], nums[p2]) = (nums[p2], nums[p1]);
                        p2++;
                        cnt = 1;
                    }
                }
                else
                {
                    p1++;
                    (nums[p1], nums[p2]) = (nums[p2], nums[p1]);
                    p2++;
                    cnt = 1;
                }
            }
            if(p2 > nums.Length)
                return p1;
            else 
                return p1 + 1;
        }

        public static int RemoveDuplicates_2(int[] nums) // NOTE: remove the _2 from the function name to be Accepted.
        {
            int p1 = 1, p2 = 1, cnt = 1;
            while(p2 < nums.Length)
            {
                if (nums[p2] == nums[p1-1] && cnt < 2)
                {
                    nums[p1] = nums[p2];
                    p1++;
                    p2++;
                    cnt++;
                }
                else if (nums[p2] == nums[p1 - 1])
                {
                    p2++;
                    cnt++;
                }
                else
                {
                    nums[p1] = nums[p2];
                    p2++;
                    p1++;
                    cnt = 1;
                }
            }
            return p1;
        }

    }
}
