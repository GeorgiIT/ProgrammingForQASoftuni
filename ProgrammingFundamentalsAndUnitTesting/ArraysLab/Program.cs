

int n = int.Parse(Console.ReadLine());

string[] weekDays =
    {
    "Monday","Tuesday", "Wednesday","Thursday","Friday","Saturday", "Sunday"
    };

if (n > 7 || n < 1)
{
    Console.WriteLine("Invalid day!");
}
else
{
    Console.WriteLine(weekDays[n - 1]);
}
