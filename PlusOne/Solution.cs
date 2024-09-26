Console.WriteLine("Start Coding!");

/// <summary>
///  Given a non-empty array of decimal digits representing a non-negative integer, increment one to the integer.
///  Ref: https://leetcode.com/problems/plus-one
/// </summary>
public class Solution {

    public int[] AppendFirstElement(int[] array, int digit)
    {
        // New array with one extra space for the 0
        var newArray = new int[array.Length + 1];

        // Insert digit at the beginning
        newArray[0] = digit;

        // Copy the original array into the new array, starting at index 1
        Array.Copy(array, 0, newArray, 1, array.Length );
        return newArray;
    }
    public int[] PlusOne(int[] digits)
    {
        if (digits.Length == 0)
        {
            return new[] { 1 };
        }
        digits[^1] += 1;
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] != 10) continue;
            digits[i] = 0;
            if (i == 0)
            {
                return AppendFirstElement(digits, 1);
            }
            digits[i - 1] += 1;
        }

        return digits;
    }
}