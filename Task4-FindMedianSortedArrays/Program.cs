namespace Task4_FindMedianSortedArrays
{
    public static class Solution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] arr = new int[nums1.Length + nums2.Length];
            double result = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                arr[i] = nums1[i];
            }

            for (int j = nums1.Length, i = 0; i < nums2.Length; j++, i++)
            {
                arr[j] = nums2[i];
            }

            Array.Sort(arr);

            if ((arr.Length % 2) == 0)
            {
                result = (double)(arr[arr.Length / 2 - 1] + arr[arr.Length / 2]) / 2;
            }
            else
            {
                result = arr[(arr.Length - 1) / 2];
            }

            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 3 };
            int[] nums2 = new int[] { 2 };

            double result = Solution.FindMedianSortedArrays(nums1, nums2);

            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
