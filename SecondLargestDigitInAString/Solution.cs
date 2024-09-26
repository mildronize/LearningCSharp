Console.WriteLine("Start Coding!" + Math.Pow(10, 9));

/// <summary>
/// Given an alphanumeric string s, return the second largest numerical digit that appears in s, or -1 if it does not exist.
/// An alphanumeric string is a string consisting of lowercase English letters and digits.
///
/// Ref: https://leetcode.com/problems/second-largest-digit-in-a-string/
/// </summary>
public class Solution {

    public int SecondHighest(string s) {
        int first = -1;
        int second = -1;
        
        foreach (var c in s) {
            if (char.IsDigit(c)) {
                int digit = c - '0';
                if (digit > first) {
                    second = first;
                    first = digit;
                } else if (digit < first && digit > second) {
                    second = digit;
                }
            }
        }
        
        return second;
        
    }
}