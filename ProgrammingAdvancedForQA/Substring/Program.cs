string wordToRemove = Console.ReadLine();
string text = Console.ReadLine();

while (text.Contains(wordToRemove))
{
    text = text.Replace(wordToRemove, "");
}
Console.WriteLine(text);