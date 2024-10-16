/********************************************************************
*** NAME : Group 4	                                              ***
*** CLASS : SE 340                                                ***
*** ASSIGNMENT : Project 1                                        ***
*** DUE DATE : 10-16-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : SaleParse is a concrete implementation of	the   ***
***               Parse class. It provides the required           ***
***               implementation for extracting csv formatted     ***
***               employee data and converting it into a list of  ***
***               the respective data type.                       ***
***															      ***
********************************************************************/
using System;
using System.Globalization;
using CsvHelper;
namespace DocumentNS;

public class SaleParse : Parse<Sale>
{
    public override List<Sale> Data { get; set; } = new List<Sale>();

    /********************************************************************
    *** METHOD SaleParse (constructor)                                ***
    *********************************************************************
    *** DESCRIPTION : Sets the Data property equal to a pre-existing  ***
    ***               list                                            ***
    *** INPUT ARGS : data                                             ***
    *** OUTPUT ARGS : None                                            ***
    *** IN/OUT ARGS : Data                                            ***
    *** RETURN : None                                                 ***
    ********************************************************************/
    public SaleParse(List<Sale> data) {
        Data = data;
    }

    /********************************************************************
    *** METHOD parseData                                              ***
    *********************************************************************
    *** DESCRIPTION : Opens the file associated with the FilePath     ***
    ***               property and extracts each line of data,        ***
    ***               converting each line into its respective data   ***
    ***               type counterpart; all entries are added to a    ***
    ***               standard, strongly-typed list                   ***                            
    ***               (template method)                               ***
    *** INPUT ARGS : filePath                                         ***
    *** OUTPUT ARGS : None                                            ***
    *** IN/OUT ARGS : Data                                            ***
    *** RETURN : void                                                 ***
    ********************************************************************/
    protected override void parseData() {
        using (var reader = new StreamReader(FilePath))
        {
            try{
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<Sale>();
                    foreach (var record in records)
                    {
                        Data.Add(record);
                    }
                }
            }
            catch (CsvHelper.HeaderValidationException)
            {
                Console.WriteLine("File must contain the following headers: Location, TargetSales, ActualSales, Difference");
            }
        }
    }
}