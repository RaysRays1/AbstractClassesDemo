using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }  
    
    // Abstract method (stubbed out methods)

    public abstract void DriveAbstract();
    
    // Virtual methods (non stubbed out method)

    public virtual void DriveVirtual()
    {
        Console.WriteLine("vehicle is fast..");
    }
}
