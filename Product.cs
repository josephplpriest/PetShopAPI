using System.Diagnostics.Contracts;

namespace Inventory;

public class Product {
    public string Name { get; set; }
    public ulong Id { get; set; }
    public double WeightOz { get; set; }
    public decimal Price { get; set; }
    public static ulong ProductCount = 1;

    public Product(string name, double weight, decimal price)
    {
        
        Contract.Requires(Name != null);
        Contract.Requires(Price >= 0);
        Contract.Requires(WeightOz >= 0);

        Name = name;
 
        // assign Id based off existing product count, then increment count
        Id = ProductCount;
         ProductCount += 1;
 
        WeightOz = weight;
        Price = price;
    }
}