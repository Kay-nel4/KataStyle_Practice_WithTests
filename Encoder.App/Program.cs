using Encoder.App;

Console.Write("Enter a Word Please: ");
string inputWord = Console.ReadLine() ?? string.Empty;

string encoded = Encoder.App.Encoder.Encode(inputWord);

Console.WriteLine($"The word in it's encoded format = {encoded}");
