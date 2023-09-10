using System.Diagnostics;
// using SOLID_Principles.Single_Responsibility;
using Scenario = SOLID_Principles.Open_Closed.Scenario;
using Solution = SOLID_Principles.Open_Closed.Solution;

namespace SOLID_Principles;

public abstract class Program
{
    public static void Main(string[] args)
    {
        /* Single Responsibility Principle */
        /*
        var j = new Solution.Journal();
        j.AddEntry("Entry One");
        j.AddEntry("Entry Two");
        Console.WriteLine(j);

        var p = new Solution.Persistence();
        //change to fit local directory structure
        var filename =
            @"C:\Users\Dylan\Documents\Coding\C#\SOLID-Principles\SOLID-Principles\SOLID-Principles\SOLID-Principles\Single-Responsibility\text.txt";
        p.SaveToFile(j, filename, true);
        Process.Start(filename);
        */
        
        /* Open-Closed Principle */
        // Scenario
        /*
        var apple = new Scenario.Product("Apple", Scenario.Colour.Green, Scenario.Size.Small);
        var tree = new Scenario.Product("Tree", Scenario.Colour.Green, Scenario.Size.Large);
        var house = new Scenario.Product("House", Scenario.Colour.Red, Scenario.Size.Large);

        Scenario.Product[] products = { apple, tree, house };

        var pf = new Scenario.ProductFilter();
        Console.WriteLine("Green Products (Scenario):");
        foreach (var p in pf.FilterByColour(products, Scenario.Colour.Green))
        {
            Console.WriteLine($" - {p.Name} is green");
        }
        */
        
        //Solution
        /*
        var apple = new Solution.Product("Apple", Solution.Colour.Green, Solution.Size.Small);
        var tree = new Solution.Product("Tree", Solution.Colour.Green, Solution.Size.Large);
        var house = new Solution.Product("House", Solution.Colour.Red, Solution.Size.Large);

        Solution.Product[] products = { apple, tree, house };
        
        var bf = new Solution.BetterFilter();
        Console.WriteLine("Green Products (Solution):");
        foreach (var p in bf.Filter(products, new Solution.ColourSpecification(Solution.Colour.Green)))
        {
            Console.WriteLine($" - {p.Name} is green");
        }
        Console.WriteLine("Large, Red Products");
        foreach (var p in bf.Filter(products, new Solution.AndSpecification<Solution.Product>(
                     new Solution.SizeSpecification(Solution.Size.Large),
                     new Solution.ColourSpecification(Solution.Colour.Red)
                     )))
        {
            Console.WriteLine($" - {p.Name} is Large and Red");
        }
        */
        
        /* Liskov Substitution Principle */
        // scenario
        static int Area(Liskov_Substitution.Scenario.Rectangle r) => r.Height * r.Width; 
        
        Liskov_Substitution.Scenario.Rectangle rc = new Liskov_Substitution.Scenario.Rectangle(2,3);
        Liskov_Substitution.Scenario.Square sq = new Liskov_Substitution.Scenario.Square();
        sq.Width = 4;
        Liskov_Substitution.Scenario.Rectangle sq2 = new Liskov_Substitution.Scenario.Square();
        sq2.Width = 4;
        Console.WriteLine($"{rc} Has Area: {Area(rc)}");
        Console.WriteLine($"{sq} Has Area: {Area(sq)}");
        Console.WriteLine($"{sq2} Has Area: {Area(sq2)}");
        
        //solution
        static int AreaSol(Liskov_Substitution.Solution.Rectangle r) => r.Height * r.Width; 
        
        Liskov_Substitution.Solution.Rectangle sq3 = new Liskov_Substitution.Solution.Square();
        sq3.Width = 4;
        Console.WriteLine($"{sq3} Has Area: {AreaSol(sq3)}");
    }
}