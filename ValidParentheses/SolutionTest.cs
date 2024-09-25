using Xunit;

namespace LearningCSharp;

public class SolutionTest
{
    private readonly Solution _solution = new();

    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    public void TestCase(string s, bool expected)
    {
        // Act
        var result = _solution.IsValid(s);

        // Assert
        Assert.Equal(expected, result);
    }
}