Console.WriteLine("Start Coding!");

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
            if (digits[i] == 10)
            {
                digits[i] = 0;
                if (i == 0)
                {
                    return AppendFirstElement(digits, 1);
                }
                else
                {
                    digits[i - 1] += 1;
                }
            }
        }

        return digits;
    }
}