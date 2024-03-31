namespace Inventory;

public class DogProduct : Product {
    
    public bool GrainFree = false;
    
    public DogProduct(string name, double weight, decimal price, bool grainfree) : base(name, weight, price)
    {
        GrainFree = grainfree;
    }
}