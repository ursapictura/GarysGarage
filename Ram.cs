namespace Garage;

public class Ram : Vehicle  // Gas powered truck
{
    public double FuelCapacity { get; set; }
    public void RefuelTank()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"BurrrrRROOOM goes the big {this.MainColor} Ram.");
    }
    public override void Turn()
    {
        Console.WriteLine("It lumbers through a wide right turn");
    }
    public override void Stop()
    {
        Console.WriteLine("before sharply braking at a red light.");
    }
}