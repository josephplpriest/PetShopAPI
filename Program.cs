using System.Text.Json;
using Inventory;

string userResponse = "y";

while (userResponse.ToLower() != "quit")
{
    Console.WriteLine("Would you like to add an item? Type 'add' if so\tType 'quit' to quit");
    userResponse = Console.ReadLine();

    if (string.IsNullOrEmpty(userResponse))
    {
        Console.WriteLine("Can you try that again?");

    }
    else
    {
        if (userResponse.Trim().ToLower() == "add")
        {
            Console.WriteLine("Please input the item name, weight and price as a comma-separated list");
            List<string> inputData = [.. Console.ReadLine().Split(", ")];
            var product = new Product(
                    name: inputData[0],
                    weight: double.Parse(inputData[1]),
                    price: decimal.Parse(inputData[2])
            );

            string productJson = JsonSerializer.Serialize(product);
            Console.WriteLine(productJson);
        }
    }
}