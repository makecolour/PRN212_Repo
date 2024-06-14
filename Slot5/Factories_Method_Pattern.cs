//using System;
//using System.Collections.Generic;

//public interface IAnimal
//{
//    void AboutMe();
//}

//// Lion class
//public class Lion : IAnimal
//{
//    public void AboutMe() => Console.WriteLine("This is Lion.");
//}

//// Tiger class
//public class Tiger : IAnimal
//{
//    public void AboutMe() => Console.WriteLine("This is Tiger.");
//}

//// Abstract class for AnimalFactory
//public abstract class AnimalFactory
//{
//    // Factory method
//    public abstract IAnimal CreateAnimal();
//}

//// LionFactory is used to create Lions
//public class LionFactory : AnimalFactory
//{
//    public override IAnimal CreateAnimal() => new Lion();
//}

//// TigerFactory is used to create Tigers
//public class TigerFactory : AnimalFactory
//{
//    public override IAnimal CreateAnimal() => new Tiger();
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("*** Factory Method Pattern Demo. ***\n");

//        // Create a list of AnimalFactory included TigerFactory and LionFactory
//        List<AnimalFactory> animalFactoryList = new List<AnimalFactory>
//        {
//            new TigerFactory(),
//            new LionFactory()
//        };

//        foreach (var animalFactory in animalFactoryList)
//        {
//            animalFactory.CreateAnimal().AboutMe();
//        }

//        Console.ReadLine();
//    }
//}
