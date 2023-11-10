namespace ClassesTrainingFromW3School
{
    
    internal class Program
    {
        class Car
        {
            public string model;
            public string color;
            public int year;

            public Car(string modelName, string modelColor, int modelYear)
            {
                model = modelName;
                color = modelColor;
                year = modelYear;
            }

            public void isRealiable(string opinion)
            {
                if (opinion == "Yes")
                {
                    Console.WriteLine($"My opinion is that the {model} is realible!");
                }
                else if (opinion == "No")
                {
                    Console.WriteLine($"My opinion is that the {model} is NOT realible!");
                }
                else
                {
                    Console.WriteLine("The input must be Yes or No!");
                }
            }
        }
        static void Main(string[] args)
        {
            Car audi = new Car("A3", "Dark blue", 1997);
                

            Car pegeuot = new Car("407", "silver", 2007);
                
                

            audi.isRealiable("Yes");
            pegeuot.isRealiable("No");

            Console.WriteLine(pegeuot.color);
            Console.WriteLine(audi.color);
        }
        
    }
}