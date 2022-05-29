using System;

namespace PL06.StoreBoxes
{
    class Item
    {

        public Item(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Box(string SerialNumber, string Item, int ItemQuantity, double PriceForBox)
        {
            this.SerialNumber = SerialNumber;
            this.Item = Item;   
            this.ItemQuantity = ItemQuantity;   
            this.PriceForBox = PriceForBox; 
        }
        public string SerialNumber { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForBox { get; set; }

    }
     
    //"{Serial Number} {Item Name} {Item Quantity} {itemPrice}"

    class Program
    {
        static void Main(string[] args)
        {
           string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string serialNumber = input[0]; 
                string itemName = input[1]; 
                int itemQuantity = int.Parse(input[2]); 
                double itemPrice = double.Parse(input[3]);  
                


                
                command = Console.ReadLine();
            }
        }
    }
}
