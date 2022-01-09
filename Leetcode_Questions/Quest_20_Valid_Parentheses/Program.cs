
public class Solution
{
    public static void Main()
    {
        //var input = "";
        var input = "()[]{}[";
        //var input = "({[]})";

        Solution solution = new Solution();
        var result = solution.IsValid(input);
    }

    public bool IsValid(string input)
    {
        // Get ready initial state (enforce element type)
        var stack = new Stack<char>();

        // Evaluate each character for potential mismatch 
        foreach (char c in input)
        {
            // Push closing round bracket onto the stack
            if (c == '(')
            {
                stack.Push(')');
                continue;
            }
            // Push closing curly bracket onto the stack
            if (c == '{')
            {
                stack.Push('}');
                continue;
            }

            // Push closing square bracket onto the stack
            if (c == '[')
            {
                stack.Push(']');
                continue;
            }

            // Look out for imbalanced strings or mismatches
            if (c != stack.Pop())
            {
                return false;
            }
        }

        // Empty stack means string is valid and invalid otherwise
        return stack.Count == 0;
    }
}