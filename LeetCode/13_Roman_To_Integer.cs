using System.Collections.Generic;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/
    /// </summary>
    public class _13_Solution
    {
        Dictionary<char, int> dicValues = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        public int RomanToInt(string s)
        {
            var chars = s.ToCharArray();
            int value = 0, curr = 0, prev = 0;
            for (var i = chars.Length - 1; i >= 0; i--)
            {
                curr = dicValues[chars[i]];

                if (prev > curr)
                {
                    value -= curr;
                }
                else
                {
                    value += curr;
                }

                prev = curr;
            }

            return value;
        }
    }
}
