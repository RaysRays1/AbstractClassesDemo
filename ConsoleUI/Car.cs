using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public override void DriveAbstract()
    {
        Console.WriteLine("HasTrunk");
    }
}