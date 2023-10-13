static void RepeatString(string text, int repeat)
{
    string repeatedString = text;
    for (int i = 0; i < repeat; i++)
    {
        repeatedString +=  text;
    }
    Console.WriteLine(repeatedString) ;
}

string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
RepeatString(text, count);