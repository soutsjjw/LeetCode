namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public class _9_Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            var str = x.ToString();
            var start = 0;
            var end = str.Length - 1;
            for (; ; )
            {
                Console.WriteLine($"start: {start}, end: {end}");
                if (str[start] != str[end])
                    return false;

                if (start == end || start > end)
                    return true;

                start += 1;
                end -= 1;
            }
        }
    }
}
