using Xunit;

namespace LearningCSharp;

public class SolutionTest
{
    private readonly Solution _solution = new();

    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void TestCase(int num, bool expected)
    {
        // Act
        var result = _solution.IsPalindrome(num);

        // Assert
        Assert.Equal(expected, result);
    }
}