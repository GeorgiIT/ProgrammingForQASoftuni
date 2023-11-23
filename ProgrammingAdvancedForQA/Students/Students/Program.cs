namespace Students
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);
                Student newStudent = new Student(firstName, lastName, grade);
                students.Add(newStudent);

            }
            List<Student> sortedList = students.OrderByDescending(s => s.Grade).ToList();
            foreach (Student student in sortedList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
