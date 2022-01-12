
public class Solution
{
    public bool IsValid(string input)
    {
        Stack<char> stack = new();

        if (input.Length == 1)
        {
            return false;
        }

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                stack.Push(')');
                continue;
            }

            if (input[i] == '{')
            {
                stack.Push('}');
                continue;
            }

            if (input[i] == '[')
            {
                stack.Push(']');
                continue;
            }

            if (stack.Count == 0)
            {
                return false;
            }

            var pop = stack.Pop();

            if (pop != input[i])
            {
                return false;
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}