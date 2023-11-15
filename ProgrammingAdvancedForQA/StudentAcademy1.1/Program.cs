using System.Threading.Channels;

int n = int.Parse(Console.ReadLine());
Dictionary<string, List<double>> database = new();

for (int i = 0; i < n; i++)
{
    string studentName = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if(database.ContainsKey(studentName))
    {
        database[studentName].Add(grade);
    }
    else
    {
        database.Add(studentName, new List<double>() {  grade });
    }
}

var execellent = database.Where(st => st.Value.Average() >= 4.50);

foreach (var student  in execellent)
{
    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
}