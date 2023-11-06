static int CountVowels(string input)
{
    string vowels = "AEIOUaeiou"; // Define a string containing all the vowel characters.
    int count = 0;

    foreach (char c in input)
    {
        if (vowels.Contains(c))
        {
            count++;
        }
    }

    return count;
}
string input = Console.ReadLine();
int vowelCount = CountVowels(input);
Console.WriteLine(vowelCount);