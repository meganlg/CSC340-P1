using System;
namespace DocumentNS;

public class InventoryParse : Parse<Inventory>
{
    public override List<Inventory> Data { get; set; } = new List<Inventory>();

    public InventoryParse(List<Inventory> data) {
        Data = data;
    }

    public override void parseData() {
        using (var reader = new StreamReader(FilePath))
        {
        // try{
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Inventory>();
                foreach (var record in records)
                {
                    Data.Add(record);
                }
            }
            /*}
            catch (CsvHelper.HeaderValidationException)
            {
                Console.WriteLine("File must contain the following headers: ID, Quantity, Price, Category, Weight");
            }
            */
        }
    }
}