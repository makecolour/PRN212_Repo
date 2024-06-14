//using System;

//public abstract class Car
//{
//    protected int basePrice = 0, onRoadPrice = 0;
//    public string ModelName { get; set; }
//    public int BasePrice
//    {
//        set => basePrice = value;
//        get => basePrice;
//    }
//    public int OnRoadPrice
//    {
//        set => onRoadPrice = value;
//        get => onRoadPrice;
//    }

//    public static int SetAdditionalPrice()
//    {
//        Random random = new Random();
//        int additionalPrice = random.Next(200_000, 500_000);
//        return additionalPrice;
//    }

//    public abstract Car Clone();
//}

//public class Mustang : Car
//{
//    public Mustang(string model) => (ModelName, BasePrice) = (model, 200_000);

//    public override Car Clone() => this.MemberwiseClone() as Mustang;
//}

//public class Bentley : Car
//{
//    public Bentley(string model) => (ModelName, BasePrice) = (model, 300_000);

//    public override Car Clone() => this.MemberwiseClone() as Bentley;
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("*** Prototype Pattern Demo ***\n");
//        // Base or Original Copy
//        Car mustang = new Mustang("Mustang EcoBoost");
//        Car bentley = new Bentley("Continental GT Mulliner");

//        Console.WriteLine($"Car is: {mustang.ModelName}, and its base price is Rs. {mustang.BasePrice}");
//        Console.WriteLine($"Car is: {bentley.ModelName}, and its base price is Rs. {bentley.BasePrice}");

//        Car clonedMustang = mustang.Clone();
//        clonedMustang.OnRoadPrice = clonedMustang.BasePrice + Car.SetAdditionalPrice();
//        Console.WriteLine($"Car is: {clonedMustang.ModelName}, and its price is Rs. {clonedMustang.OnRoadPrice}");

//        Car clonedBentley = bentley.Clone();
//        clonedBentley.OnRoadPrice = clonedBentley.BasePrice + Car.SetAdditionalPrice();
//        Console.WriteLine($"Car is: {clonedBentley.ModelName}, and its price is Rs. {clonedBentley.OnRoadPrice}");

//        Console.ReadLine();
//    }
//}
