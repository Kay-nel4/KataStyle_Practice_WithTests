using Encoder.App;
using Xunit;

namespace Encoder.Tests;

public class SearcherTests
{
    [Theory]
    [InlineData("Sammee is the best", "the", 10)]
    [InlineData("Buzzard is kind of rude", "is", 8)]
    [InlineData("Grady is chubby and tailless", "Grady", 0)]
    [InlineData("Roobee is a pitbull", "pitbull", 12)]
    [InlineData("Beanie is a silly girl", "hello", -1)]
    public void FindIndexOf_ReturnTheIndex(string source, string target, int expected)
    {
        int result = Searcher.FindIndexOf(source, target);
        Assert.Equal(expected, result);
    }
}