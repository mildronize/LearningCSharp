using Xunit;

namespace LearningCSharp;

public class SolutionTest
{
    private readonly Solution _solution = new();

    [Theory]
    [InlineData("dfa12321afd", 2)] 
    [InlineData("abc1111", -1)]
    public void TestCase(string s, int expected)
    {
        // Act
        var result = _solution.SecondHighest(s);

        // Assert
        Assert.Equal(expected, result);
    }
}