namespace Garage;

public class Zero : Vehicle // Electric motorcycle
{
	public double BatteryKWh { get; set; }
	public void ChargeBattery()
	{
		// method definition omitted
	}
    public override void Drive()
    {
		Console.WriteLine($"VurrrrrhummmmROOM! The {this.MainColor} Zero accelerates past the intersection.");
    }
}