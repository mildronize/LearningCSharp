using Xunit;

namespace LearningCSharp;

public class SolutionTest
{
    private readonly Solution _solution;

    public SolutionTest()
    {
        _solution = new Solution();
    } 
    
    [Theory]
    [InlineData(new int[] {2, 7, 11, 15}, 9, new int[] {0, 1})]
    [InlineData(new int[] {3, 2, 4}, 6, new int[] {1, 2})]
    [InlineData(new int[] {3, 3}, 6, new int[] {0, 1})]
    public void TwoSumTestCase(int[] nums, int target, int[] expected)
    {
        // Act
        var result = _solution.TwoSum(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
    
}