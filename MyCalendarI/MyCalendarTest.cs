using Xunit;

namespace LearningCSharp;


/// <summary>
/// Or we can you with `InlineData` attribute with Jagged array
/// Ref: https://stackoverflow.com/questions/45937278/how-to-test-a-method-parameter-type-jagged-array-with-xunit
/// </summary>
public class MyCalendarTest
{
    private readonly MyCalendar _myCalendar = new();
    
    [Theory]
    [ClassData(typeof(MyCalendarTestData))]
    public void TestCase(int[][] bookings, bool[] expected)
    {
        // Act
        var result = bookings.Select(booking => _myCalendar.Book(booking[0], booking[1])).ToList();
        // Assert
        Assert.Equal(expected, result);
    }
}

// Create a custom class to hold test data
public class MyCalendarTestData : TheoryData<int[][], bool[]>
{
    public MyCalendarTestData()
    {
        Add(
            [
                [10, 20], [15, 25], [20, 30]
            ],
            [true, false, true]
        );
    }
}