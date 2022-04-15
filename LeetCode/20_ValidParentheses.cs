namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/valid-parentheses/submissions/
	/// </summary>
	public class _20_Solution
    {
        public bool IsValid(string s)
		{
			var stack = new Stack<char>();

			foreach (char c in s)
			{
				if (c == '(')
				{
					stack.Push(')');
					continue;
				}

				if (c == '[')
				{
					stack.Push(']');
					continue;
				}

				if (c == '{')
				{
					stack.Push('}');
					continue;
				}

				if (stack.Count == 0 || stack.Pop() != c)
				{
					return false;
				}
			}

			return !stack.Any();
		}
    }
}
