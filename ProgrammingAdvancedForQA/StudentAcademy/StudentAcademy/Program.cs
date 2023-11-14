

Dictionary<string, List<double>> database = new();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    
    string student = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());
    

    if (!database.ContainsKey(student))
    {
        database.Add(student, new List<double>());

    }
    database[student].Add(grade);

}

var execellent = database.Where(st => st.Value.Average() >= 4.50);

foreach(var student in execellent)
{
    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
}
