using DocumentNS;
using System.Globalization;
using CsvHelper;

class ParseExample{

    static void parseTest(string path)
    {
        List<Employee> employees = new List<Employee>();
        using(var reader = new StreamReader(path))
        {
            try
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<Employee>();
                    foreach (var record in records)
                    {
                        employees.Add(record);
                    }
                }
            }
            catch (CsvHelper.HeaderValidationException)
            {
                Console.WriteLine("File must contain the following headers: FirstName, LastName, ID, Pay, Position, PhoneNumber");
            }
            catch (CsvHelper.MissingFieldException)
            {
                Console.WriteLine("One or more items is missing a field.");
                Console.WriteLine("Please ensure all fields are present.");
            }
        }
    }
}
    