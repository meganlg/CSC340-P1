using System;
namespace DocumentNS;

public abstract class Parse 
{
    abstract List<T> { get; set; }

    public virtual string getFile()
    {
        bool valid = false;
        string path = "";
        string fileName = "";
        while (valid is not true)
        {
            Console.Write("Enter the name of the data file: ");
            fileName = Console.ReadLine();
            // path = Get directory?
            if (fileName.EndsWith(".csv", StringComparison.CurrentCultureIgnoreCase))
            {
                valid = true;
            }
            else
            {
                Console.WriteLine("File type must be .csv");
            }
            valid = File.Exists(path);
        }
        return path;
    }
    public abstract void parseData(string path) { }

}