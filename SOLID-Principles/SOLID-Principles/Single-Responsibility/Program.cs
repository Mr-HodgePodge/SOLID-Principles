using System.Diagnostics;

namespace SOLID_Principles.Single_Responsibility;

public abstract class Program
{
    public static void Main(string[] args)
    {
        var j = new Solution.Journal();
        j.AddEntry("Entry One");
        j.AddEntry("Entry Two");
        Console.WriteLine(j);

        var p = new Solution.Persistence();
        var filename =
            @"C:\Users\Dylan\Documents\Coding\C#\SOLID-Principles\SOLID-Principles\SOLID-Principles\SOLID-Principles\Single-Responsibility\text.txt";
        p.SaveToFile(j, filename, true);
        Process.Start(filename);
    }
}