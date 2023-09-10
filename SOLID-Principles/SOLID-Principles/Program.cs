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
    }
}