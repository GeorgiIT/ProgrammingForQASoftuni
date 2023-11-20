namespace StoreBoxes
{
    class Boxes
    {
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Boxes(string serialNumber, string itemName, int quantity, decimal price)
        {
            SerialNumber = serialNumber;
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Boxes> boxes = new List<Boxes>();
            while (true)
            {
                string[] command = Console.ReadLine().Split(" ");
                if (command[0] == "end")
                {
                    break;
                }
                string serialNumber = command[0];
                string itemName = command[1];
                int quantity = int.Parse(command[2]);
                decimal price = decimal.Parse(command[3]);
                boxes.Add(new Boxes(serialNumber, itemName, quantity, price));
            }

            SortedBoxes(boxes);
        }

        public static void SortedBoxes(List<Boxes> boxes)
        {
            List<Boxes> sortedBoxes = boxes.OrderByDescending(box => box.Price * box.Quantity).ToList();

            foreach (Boxes box in sortedBoxes) 
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.ItemName} - ${box.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.Price * box.Quantity:f2}");
            }
        }
    }
}