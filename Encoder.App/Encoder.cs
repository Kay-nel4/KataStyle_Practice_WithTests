using System.Linq;
namespace Encoder.App;

public static class Encoder
{
    public static string Encode(string word)
    {
        string lowerWord = word.ToLower();

        var counted = lowerWord.GroupBy(n => n).ToDictionary(m => m.Key, m => m.Count());
        return string.Concat(lowerWord.Select(n => counted[n] == 1 ? '#' : '%'));
    }
}