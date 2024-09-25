Console.WriteLine("Start Coding!");

public class Solution
{
    public bool IsValid(string s)
    {
        // Define available opening brackets
        var openingBrackets = new char[] { '(', '[', '{' };
        // Define available closing brackets
        var closingBrackets = new char[] { ')', ']', '}' };
        // Create a stack to store the opening brackets
        var stack = new Stack<char>();
        // Iterate through each character in the string
        foreach (var c in s)
        {
            // If the character is an opening bracket, push it to the stack
            if (openingBrackets.Contains(c))
            {
                stack.Push(c);
            }
            // If the character is a closing bracket
            else if (closingBrackets.Contains(c))
            {
                // If the stack is empty, return false
                if (stack.Count == 0)
                {
                    return false;
                }

                // Get the top element from the stack
                var top = stack.Pop();
                // Check if the top element matches the corresponding opening bracket

                for (int i = 0; i < openingBrackets.Length; i++)
                {
                    if (c == closingBrackets[i] && top != openingBrackets[i])
                    {
                        return false;
                    }
                }
            }
        }

        // If the stack is empty, return true
        return stack.Count == 0;
    }
}