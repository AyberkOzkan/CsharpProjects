string[] names = { "Rowena", "Robin", "Bao" };
int[] inventory = { 200, 450, 700, 175, 250 }; //1775
int sum = 0;
int bin = 0;

foreach (string name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine("--------------------------------------");

foreach (int items in inventory)
{
   sum += items;
   bin++;
   Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");

}
Console.WriteLine("--------------------------------------");


Console.WriteLine($"We have {sum} items in inventory.");


string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" }; // Sadece B ile başlayanları yazdır.

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}