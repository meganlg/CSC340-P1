/********************************************************************
*** NAME : Group 4	                                              ***
*** CLASS : SE 340                                                ***
*** ASSIGNMENT : Project 1                                        ***
*** DUE DATE : 10-16-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION :											      ***
***															      ***
********************************************************************/
using System;
using System.Globalization;
using CsvHelper;
namespace DocumentNS;

public class SaleParse : Parse<Sale>
{
    public override List<Sale> Data { get; set; } = new List<Sale>();

    public SaleParse(List<Sale> data) {
        Data = data;
    }

    protected override void parseData() {
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