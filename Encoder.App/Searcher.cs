namespace Encoder.App;

public static class Searcher
{
    public static int FindIndexOf(string source, string target)
    {
        if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty (target))
        {
            return -1;
        }
        int index = source.IndexOf(target, StringComparison.OrdinalIgnoreCase);
        {
            return index;
        }
    }
}


