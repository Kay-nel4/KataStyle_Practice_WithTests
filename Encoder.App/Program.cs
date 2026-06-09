using Encoder.App;
//----Encoder----
Console.WriteLine("----Encoder----");
Thread.Sleep(4000);
Console.Write("Enter a Word Please: ");
string inputWord = Console.ReadLine() ?? string.Empty;

string encoded = Encoder.App.Encoder.Encode(inputWord);

Console.WriteLine($"The word in it's encoded format = {encoded}");

//----Searcher----
Console.WriteLine("----Searcher----");
Thread.Sleep(4000);
Console.WriteLine("Enter a Sentence: ");
string sentence = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Enter Text to Search For: ");
string target = Console.ReadLine() ?? string.Empty;

int index = Searcher.FindIndexOf(sentence, target);

if (index == -1)
{
    Console.WriteLine("Not Found");
}
else
{
    Console.WriteLine($"Found at index: {index}");
}
//----TwoSum----
 Console.WriteLine("----TwoSum----");
 Thread.Sleep(4000);
 Console.WriteLine("Enter numbers Seperated By Commas Please...");
 string input = Console.ReadLine();

 int[] nums = input.Split(',').Select(n => int.Parse(n.Trim())).ToArray();

 Console.WriteLine("Enter target number...");
 int target1 = int.Parse(Console.ReadLine());

 var (i, j) = TwoSum.FindTwoSum(nums, target1);
 if (i == -1)
{
    Console.WriteLine("No match found");
}
else
{
    Console.WriteLine($"Indices found: {i} and {j} (values {nums[i]} + {nums[j]})");
}