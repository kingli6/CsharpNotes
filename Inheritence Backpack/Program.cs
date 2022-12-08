// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
// New knowledge! 
 */
BackPack myBackPack = new(5, 4, 4);
while (true)
{
    Console.WriteLine((myBackPack.currentVolume, myBackPack.currentWeight, myBackPack.currentCount));
    string choice = Console.ReadLine();
    InventoryItem item = choice switch   // Mistake here. Forgot that choice variable is needed. 
    {
        "1" => new Sword(), "2" => new shield(), "3" => new drink(),
    };
    if (!myBackPack.AddItem(item)) Console.WriteLine("Could not add this item");    // New knowledge! THis adds the item!
}

class BackPack
{
    private float maxWeight;
    private float maxVolume;
    private int maxCount;
    InventoryItem[] pack;

    public float currentWeight { get; private set; } = 0;
    public float currentVolume { get; private set; } = 0;
    public int currentCount { get; private set; } = 0;

    public BackPack(float maxWeight, float maxVolume, int maxCount)
    {
        this.maxWeight = maxWeight;
        this.maxVolume = maxVolume;
        this.maxCount = maxCount;

        pack = new InventoryItem[this.maxCount];
    }

    public bool AddItem(InventoryItem item)
    {
        if (currentWeight + item.weight > maxWeight) return false;
        if (currentVolume + item.volume > maxVolume) return false;
        if (currentCount  >= maxCount) return false;

        currentWeight += item.weight;
        currentVolume += item.volume;
        pack[currentCount++] = item;
        return true;
    }
}
public class InventoryItem
{
    //public float weight;    //Interfaces cannot contain instance fields 
    public float volume { get; set; }
    public float weight { get; set; }
    public InventoryItem(float volume, float weight) { this.volume = volume; this.weight = weight; }

}
public class Sword : InventoryItem { public Sword():base(2, 0.5f) { } }
public class shield : InventoryItem { public shield():base(3, 3.5f) { } }
public class drink : InventoryItem { public drink():base(0.5f, 0.5f) { } }