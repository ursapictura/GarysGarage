namespace Garage;

public class Vehicle
{
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }
    public virtual void Turn()
    {
        Console.WriteLine("It makes a right turn ");
    }
    public virtual void Stop()
    {
        Console.WriteLine("before rolling to an expert stop.");
    }
}