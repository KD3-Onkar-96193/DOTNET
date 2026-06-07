using System;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("---- Product Details ----");
        Console.WriteLine("Product ID   : " + ProductId);
        Console.WriteLine("Product Name : " + ProductName);
        Console.WriteLine("Price        : " + Price);
    }
}

class ElectronicsProduct : Product
{
    public string Brand { get; set; }
    public int WarrantyInYears { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine("---- Electronics Product Details ----");
        Console.WriteLine("Product ID      : " + ProductId);
        Console.WriteLine("Product Name    : " + ProductName);
        Console.WriteLine("Price           : " + Price);
        Console.WriteLine("Brand           : " + Brand);
        Console.WriteLine("Warranty (Years): " + WarrantyInYears);
    }
}

class Program
{
    static void Main()
    {
        Product p = new Product
        {
            ProductId = 1,
            ProductName = "Basic Product",
            Price = 1000
        };

        p.DisplayInfo();

        Console.WriteLine("\n------------------------\n");

        ElectronicsProduct ep = new ElectronicsProduct
        {
            ProductId = 2,
            ProductName = "Laptop",
            Price = 55000,
            Brand = "Dell",
            WarrantyInYears = 3
        };

        ep.DisplayInfo();
    }
}
