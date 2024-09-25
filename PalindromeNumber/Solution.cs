Console.WriteLine("Start Coding!");

public class Solution
{
    public bool IsPalindrome(int x)
    {
        // convert the number to string
        var number = x.ToString();
        // Reverse the string
        var charArray = number.ToCharArray();
        Array.Reverse(charArray);
        var reversedNumber = new string(charArray);
        // Compare the original string with the reversed string
        return number == reversedNumber;
    }
}