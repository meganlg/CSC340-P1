using System;
namespace DocumentNS;
public class Employee
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int ID { get; set; }
	public double Pay { get; set; }
	public string Position { get; set; }
	public string PhoneNumber { get; set; }

	public Employee(string firstName = "", string lastName = "", int id = 0, double pay = 0.0, string position = "", string phoneNumber = "")
	{
		FirstName = firstName;
		LastName = lastName;
		ID = id;
		Pay = pay;
		Position = position;
		PhoneNumber = phoneNumber;
	}
}

