char startLetter = char.Parse(Console.ReadLine());
char endLetter = char.Parse(Console.ReadLine());
char excludeLetter = char.Parse(Console.ReadLine());
int counter = 0;

for (char first = startLetter; first <= endLetter; first++)
{
    for (char second = startLetter; second <= endLetter; second++)
    {
        for (char third = startLetter; third <= endLetter; third++)
        {
            if (first != excludeLetter && second != excludeLetter && third != excludeLetter)
            {
                Console.Write($"{first}{second}{third} ");
                counter++;
                
            }

        }

    }
}
Console.WriteLine();
Console.WriteLine(counter);