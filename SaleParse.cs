using System;
namespace DocumentNS;

public class SaleParse : Parse<Sale>
{
    public override List<Sale> Data { get; set; } = new List<Sale>();

    public SaleParse(List<Sale> data) {
        Data = data;
    }

    public override void parseData() {
        using (var reader = new StreamReader(FilePath))
        {
        //try{
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Sale>();
                foreach (var record in records)
                {
                    Data.Add(record);
                }
            }
        /*}
        catch (CsvHelper.HeaderValidationException)
        {
            Console.WriteLine("File must contain the following headers: Location, TargetSales, ActualSales, Difference");
        }
        */
        }
    }


}