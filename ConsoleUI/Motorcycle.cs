using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    
    
    public override void DriveAbstract()
    {
        Console.WriteLine("HasSideCart");
    }
}