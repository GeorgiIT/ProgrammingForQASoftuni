using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsBook
{
    public class cat
    {
        //Field name
        private string name;
        //Field color
        private string color;
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
        //Default constructors
        public cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }
        //Constructor with parameters
        public cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        // Method SayMiau
        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said: Miauuuuuuuuuu!", name);
        }


    }
}
