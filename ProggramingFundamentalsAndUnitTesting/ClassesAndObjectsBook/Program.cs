namespace ClassesAndObjectsBook
{
    internal class Program
    {
        public class cat
        {
            //Field name
            private string name;
            //Field color
            private string color;
            private bool sleeping;
            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }
            public string Color
            {
                // Getter of the property "Color"
                get
                {
                    return this.color;
                }
                // Setter of the property "Color"
                set
                {
                    this.color = value;
                }
            }
            public bool Sleeping
            {
                get 
                {
                    return this.sleeping;
                }
                set 
                {
                    this.sleeping = value; 
                }
            }
            //Default constructors
            public cat()
            {
                this.name = "Unnamed";
                this.color = "No given color";
                this.sleeping = false;
            }
            //Constructor with parameters
            public cat(string name, string color, bool sleeping)
            {
                this.name = name;
                this.color = color;
                this.sleeping = false;
            }
            // Method SayMiau
            public void SayMiau()
            {
                Console.WriteLine("Cat {0} said: Miauuuuuuuuuu!", name);
            }
            
            

            static void Main(string[] args)
            {

                
                cat eva = new cat("Eva", "white", false);
                Console.WriteLine(eva.name, eva.Color);
                
                
                
            }
        }
        public class Dog()
        {
            //Field name
            private string name;
            //Field color
            private string color;
        }
    }
}