namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-prefix/
    /// </summary>
    public class _14_Solution
    {
        public string LongestCommonPrefix(string[] strs)
		{
			if (strs.Length == 1)
				return strs[0];

			strs = strs.ToList().OrderBy(x => x.Length).ToArray();
			var arrayLength = strs.Length;
			var shortestStringLength = strs[0].Length;
			var result = "";

			for (int i = 1; i <= shortestStringLength; i++)
			{
				result = strs[0].Substring(0, i);
				for (int j = 1; j < arrayLength; j++)
				{
					if (!strs[j].StartsWith(result))
					{
						return result.Substring(0, result.Length - 1);
					}
				}
			}

			return strs[0];
		}
    }
}
