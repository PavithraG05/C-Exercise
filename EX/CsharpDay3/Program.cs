// See https://aka.ms/new-console-template for more information
using CsharpDay3.Day3;
using System.Diagnostics;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

List<InventoryItem> inventoryItems = new List<InventoryItem>();
//string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inventory.txt");

using (StreamReader reader = new StreamReader("D:\\Users\\pavithra\\source\\repos\\CsharpDay3\\inventory.txt"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        string[] parts = line.Split(',');

        int id = int.Parse(parts[0]);
        string type = parts[1];
        string name = parts[2];
        string description = parts[3];
        double price = double.Parse(parts[4]);
        int quantity = int.Parse(parts[5]);

        InventoryItem item = null;


        switch (type)
        {
            case "Food":
                item = new FoodItem
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    Price = price,
                    Quantity = quantity,
                    Brand = parts[6],
                    food = (FoodType)Enum.Parse(typeof(FoodType), parts[7]),
                    animal = (AnimalType)Enum.Parse(typeof(AnimalType), parts[8]),
                };
                break;
            case "Accessory":
                item = new AccessoryItem
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    Price = price,
                    Quantity = quantity,
                    Size = parts[6],
                    Color = parts[7]
                };
                break;
            case "Cage":
                item = new CageItem
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    Price = price,
                    Quantity = quantity,
                    Dimensions = parts[6],
                    Material = parts[7]
                };
                break;
            case "Aquarium":
                item = new AquariumItem
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    Price = price,
                    Quantity = quantity,
                    Capacity = parts[6],
                    Shape = parts[7]
                };
                break;
            case "Toy":
                item = new ToyItem
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    Price = price,
                    Quantity = quantity,
                    Material = parts[6],
                    RecommendedAge = parts[7]
                };
                break;
        }

       inventoryItems.Add(item);

    }
}


bool exit = false;
while (!exit)
{
    
    Console.WriteLine("Menu:");
    Console.WriteLine("1- Show all items");
    Console.WriteLine("2- Show an item's details");

    Console.Write("Select an option: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            ShowAllItems(inventoryItems);
            break;
        case "2":
            ShowItemDetails(inventoryItems);
            break;


        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}


static void ShowAllItems(List<InventoryItem> inventory)
{
    Console.WriteLine("ID\tName\t\tType");
    foreach (var item in inventory)
    {
        //Console.WriteLine(item);
        string itemType = item.GetType().Name;
        Console.WriteLine($"{item.Id}\t{item.Name}\t\t{itemType}");
    }
}
static void ShowItemDetails(List<InventoryItem> inventory)
{
    Console.Write("Enter the item ID: ");
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        InventoryItem item = inventory.Find(i => i.Id == id);
        //Console.WriteLine(item);
        if (item != null)
        {
            Console.WriteLine($"Id: {item.Id}\n Name: {item.Name}\n Description: {item.Description}\n Price: {item.Price}\n Quantity: {item.Quantity}\n");
            if (item is FoodItem food)
            {
                Console.WriteLine($"Brand: {food.Brand}");
                Console.WriteLine($"Food Type: {food.food}");
                Console.WriteLine($"Animal Type: {food.animal}");
            }
            else if (item is AccessoryItem accessory)
            {
                Console.WriteLine($"Size: {accessory.Size}");
                Console.WriteLine($"Color: {accessory.Color}");
            }
            else if (item is AquariumItem aquarium)
            {
                Console.WriteLine($"Capacity: {aquarium.Capacity}");
                Console.WriteLine($"Shape: {aquarium.Shape}");
            }
            else if (item is CageItem cage)
            {
                Console.WriteLine($"Dimensions: {cage.Dimensions}");
                Console.WriteLine($"Material: {cage.Material}");
            }
            else if (item is ToyItem toy)
            {
                Console.WriteLine($"Material: {toy.Material}");
                Console.WriteLine($"RecommendedAge: {toy.RecommendedAge}");
            }
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }
    else
    {
        Console.WriteLine("Invalid ID.");
    }
}