namespace Garage;

public class Tesla : Vehicle // Electric car
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {this.MainColor} Tesla makes a subtle vrrrrrrr... while driving");
    }
    public override void Turn()
    {
        Console.WriteLine("It careens into an erratic spin");
    }
    public override void Stop()
    {
        Console.WriteLine("before crashing into a stop sign.");
    }
}