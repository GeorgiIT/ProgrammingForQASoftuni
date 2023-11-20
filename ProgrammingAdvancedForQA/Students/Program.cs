namespace Students
{
    class Students
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Students(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (input[0] == "end")
                {
                    break;
                }
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string homeTown = input[3];
                students.Add(new Students(firstName, lastName, age, homeTown));

            }

            string city = Console.ReadLine();

            foreach (Students student in students)
            {
                if(student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
            
        }
    }
}