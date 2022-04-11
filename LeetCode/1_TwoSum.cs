namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class _1_Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dicValue = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (dicValue.ContainsKey(diff))
                {
                    return new int[] { dicValue[diff], i };
                }

                dicValue[nums[i]] = i;
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}
