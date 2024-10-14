using System;
using CsvHelper;

namespace DocumentNS;

public class EmployeeParse : Parse<Employee>
{
    public override List<Employee> Data { get; set; } = new List<Employee>();

    public EmployeeParse(List<Employee> data) {
        Data = data;
    }

    public override void parseData() {
        using (var reader = new StreamReader(FilePath))
        {
        // ERROR HANDLING
        // Disabled temporarily for debugging
        // try
        // {
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Employee>();
                foreach (var record in records)
                {
                    Data.Add(record);
                }
            }
        /*}
        catch (CsvHelper.HeaderValidationException)
        {
            Console.WriteLine("File must contain the following headers: FirstName, LastName, ID, Pay, Position, PhoneNumber");
        }*/
        }
        /* For testing purposes 
         * Remove when done
        foreach (var employee in Data)
        {
            Console.WriteLine($"NAME: {employee.FirstName} {employee.LastName}");
            Console.WriteLine($"ID: {employee.ID}");
            Console.WriteLine($"POSITION: {employee.Position}");
            Console.WriteLine($"SALARY: {employee.Pay}");
            Console.WriteLine($"CONTACT: {employee.PhoneNumber}");
            Console.WriteLine();
        }
        */
    }
}