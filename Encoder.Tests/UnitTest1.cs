using Encoder.App;
using Xunit;

namespace Encoder.Tests;

public class EncoderTests
{
    [Theory]
    [InlineData("holla", "##%%#")]
    [InlineData("sheesh", "%%%%%%")]
    [InlineData("Thumbsup", "##%###%#")]
    [InlineData("Hi", "##")]
    public void Encode_ReturnsExpectedResults(string input, string expected)
    {
        string result = Encoder.App.Encoder.Encode(input);
        Assert.Equal(expected, result);
    }
}