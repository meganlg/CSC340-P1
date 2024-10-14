using System;
namespace DocumentNS;

public abstract class Parse 
{
    public string filePath{ get; set };
    public abstract List<T> Data{ get; set; }

    public virtual void getFile()
    {
        bool valid = false;
        string fileName = "";
        string path = "";
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
        filePath = filePath;
    }
    public abstract void parseData(string path) {}

}