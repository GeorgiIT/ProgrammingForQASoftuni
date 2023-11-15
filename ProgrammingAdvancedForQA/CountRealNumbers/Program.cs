namespace CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();

            // Parse the input string into a list of integers
            List<int> numbers = input.Split(' ').Select(int.Parse).ToList();

            // Use a dictionary to count occurrences of each number
            Dictionary<int, int> occurrences = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                if (occurrences.ContainsKey(number))
                {
                    occurrences[number]++;
                }
                else
                {
                    occurrences[number] = 1;
                }
            }

            // Print the numbers in ascending order along with their occurrences
            
            foreach (var pair in occurrences.OrderBy(p => p.Key))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}