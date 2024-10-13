using System;
namespace DocumentNS;
public class Sale
{
	public string Location { get; set; }
	public double TargetSales { get; set; }
	public double ActualSales { get; set; }
	public double Difference { get; set; }

	public Sale(string location = "", double targetSales = 0.0, double actualSales = 0.0, double difference = 0.0)
	{
		Location = location;
		TargetSales = targetSales;
		ActualSales = actualSales;
		Difference = difference;
	}
}

