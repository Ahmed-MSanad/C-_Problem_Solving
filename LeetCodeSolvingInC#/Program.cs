namespace LeetCodeSolvingInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int[] nums2 = [2, 5, 6];

            int m = 3, n = 3;

            Console.WriteLine("Test The 1st Solution");

            Merge1(nums1, m, nums2, n);

            for (int i = 0; i < n+m; i++)
            {
                Console.Write($"{nums1[i]}, ");
            }

            Console.WriteLine("\nTest The 2nd Solution");

            nums1 = [1, 2, 3, 0, 0, 0];
            nums2 = [2, 5, 6];

            Merge(nums1, m, nums2, n);

            for (int i = 0; i < n + m; i++)
            {
                Console.Write($"{nums1[i]}, ");
            }
        }

        //Solution_1:
        public static void Merge1(int[] nums1, int m, int[] nums2, int n)
        {
            int[] nums3 = new int[n + m];
            int p1 = 0, p2 = 0;
            while (p1 < m && p2 < n)
            {
                if (nums1[p1] <= nums2[p2])
                {
                    nums3[p1 + p2] = nums1[p1];
                    p1++;
                }
                else
                {
                    nums3[p1 + p2] = nums2[p2];
                    p2++;
                }
            }
            while (p1 < m) { nums3[p1 + p2] = nums1[p1]; p1++; }
            while (p2 < n) { nums3[p1 + p2] = nums2[p2]; p2++; }

            for (int i = 0; i < (n + m); i++) { nums1[i] = nums3[i]; }
        }

        // Solution_2: -> Exploit the space in nums1 without creating additional space by adding nums3
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1, p2 = n - 1, p3 = n + m - 1;

            while (p1 >= 0 && p2 >= 0)
            {
                if (nums1[p1] >= nums2[p2])
                    nums1[p3--] = nums1[p1--];
                else
                    nums1[p3--] = nums2[p2--];
            }
            while (p1 >= 0) { nums1[p3--] = nums1[p1--]; }
            while (p2 >= 0) { nums1[p3--] = nums2[p2--]; }
        }
    }
}
