namespace Garage;

public class Cessna : Vehicle // Propellor light aircraft
{
    public double FuelCapacity { get; set; }
    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"Zoooooooom! The {this.MainColor} Cessna crosses the sky.");
    }
    public override void Turn()
    {
        Console.WriteLine("It makes a gentle right arc through the air");
    }
    public override void Stop()
    {
        Console.WriteLine("before gracefully dropping to the tarmak.");
    }
}