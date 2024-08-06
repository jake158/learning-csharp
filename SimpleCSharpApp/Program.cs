using System;

// Class that defines Main() => Application Object
class Program
{
    // Even on void return type, 0 is implicitly returned
    static void Main(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("Arg: {0}", args[i]);
        }
        ShowEnvironmentDetails();
    }

    static void ShowEnvironmentDetails()
    {
        foreach (string drive in Environment.GetLogicalDrives())
        {
            Console.WriteLine("Drive: {0}", drive);
        }
        Console.WriteLine("OS: {0}", Environment.OSVersion);
        Console.WriteLine("Number of Processors: {0}", Environment.ProcessorCount);
        Console.WriteLine(".NET Core Version: {0}", Environment.Version);
    }
}


// Top level statments:

// Only one file in the application can use top-level statements
// The top-level statements cannot be enclosed in a namespace
// Top-level statements still access a string array of args
// Top-level statements return an application code by using a return
// Additional types can be declared after all top-level statements, but not before
// Args are still available
// Implicitly returns 0 on exit