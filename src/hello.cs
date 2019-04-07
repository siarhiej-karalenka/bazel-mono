using System;
using Greetings;
 
public class HelloWorld
{
    public static void Main(string[] args)
    {
        var greeter = new Greeter();
        Console.WriteLine (greeter.GetGreeting());
    }
}
