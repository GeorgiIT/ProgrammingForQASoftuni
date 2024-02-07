namespace GetGreeting
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingProvider greetingProvider = new GreetingProvider(new TimeProvider());
            string greeting = greetingProvider.GetGreeting();
            Console.WriteLine(greeting);
        }
    }

} 