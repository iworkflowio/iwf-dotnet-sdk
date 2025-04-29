using IwfDotnetSdk.ApiClients.Model;
using System;

namespace IwfDotnetSdk;

public class HelloWorld
{
    public string Hello()
    {
        return $"Hello, World! Timer status can be: {TimerStatus.SCHEDULED} or {TimerStatus.FIRED}";
    }

    public static void Main(string[] args)
    {
        // Create an instance of HelloWorld
        var app = new HelloWorld();
        
        // Call the Hello method and print the result
        Console.WriteLine(app.Hello());
        
        // Print all possible timer status values
        Console.WriteLine("\nAll TimerStatus values:");
        foreach (TimerStatus status in Enum.GetValues(typeof(TimerStatus)))
        {
            Console.WriteLine($"- {status}");
        }
    }
}