using Xunit;

namespace LearningCSharp;

public class SolutionTest
{
    private readonly Solution _solution = new();

    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
    [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
    [InlineData(new int[] { 0 }, new int[] { 1 })]
    [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
    [InlineData(new int[] { 9, 9, 9 }, new int[] { 1, 0, 0, 0 })]
    public void TestCase(int[] digits, int[] expected)
    {
        // Act
        var result = _solution.PlusOne(digits);

        // Assert
        Assert.Equal(expected, result);
    }
}