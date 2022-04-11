using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/unique-morse-code-words/
    /// </summary>
    public class _804_Solution
    {
        string[] morseArray = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

        public int UniqueMorseRepresentations(string[] words)
        {
            HashSet<string> distinct = new HashSet<string>();

            foreach (var word in words)
            {
                StringBuilder value = new StringBuilder();
                foreach (var w in word)
                {
                    value.Append(morseArray[w - 'a']);
                }
                distinct.Add(value.ToString());
            }

            return distinct.Count;
        }
    }
}