using System;
namespace DocumentNS;

public abstract class Parse<T>
{
    required public string FilePath { get; set; }
    public abstract List<T> Data{ get; set; }

    public virtual void getFile()
    {
        bool valid = false;
        string fileName = "";
        string path = "";
        while (valid is not true)
        {
            Console.Write("Enter the name of the data file: ");
            // if user enters nothing, change to empty string instead of null
            string? nullableString = Console.ReadLine();           
            fileName = nullableString == null ? "" : nullableString;
            // path = Get directory?
            valid = File.Exists(path);
            if (!fileName.EndsWith(".csv", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("File type must be .csv");
                valid = false;
            }
            
        }
        FilePath = fileName;
    }
    public abstract void parseData(string path);

}