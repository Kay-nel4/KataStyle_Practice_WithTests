using Encoder.App;
using Xunit;

namespace Encoder.Tests;

public class TwoSumTests
{
    [Fact]
    public void FindCorrectIndices()
    {
        int[] nums = {2, 7, 11, 15};
        var result = TwoSum.FindTwoSum(nums, 9);
        Assert.Equal((0, 1), result);
    }

    [Fact]
    public void ReturnsMinusOneWhenNoMatch()
    {
        int[] nums = {1, 2, 3};
        var result = TwoSum.FindTwoSum(nums, 10);
        Assert.Equal((-1, -1), result);
    }

    [Fact]

    public void WorksWithDuplicates()
    {
        int[] nums = {3, 3};
        var result = TwoSum.FindTwoSum(nums, 6);
        Assert.Equal((0, 1), result);
    }
    
    [Fact]

    public void WorksWithNegativeNumbers()
    {
        int[] nums = {-4, 8, 5, 2 };
        var result = TwoSum.FindTwoSum(nums, 4);
        Assert.Equal((0, 1), result);
    }

    [Fact]

    public void WorksWhenPairIsLaterInArray()
    {
        int[] nums = {10, 20, 5, 7 };
        var result = TwoSum.FindTwoSum(nums, 12);
        Assert.Equal((2, 3), result);
    }
}