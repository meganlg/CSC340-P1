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
namespace DocumentNS;

public abstract class Parse<T>
{
    required public string FilePath { get; set; }
    public abstract List<T> Data{ get; set; }
    public void parseCsvFile()
    {
        getFile();
        parseData();
    }

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
            path = fileName; //temporary
            //path = Get directory?
            // ^ Problem for me was that the file is not stored in the same location as the running program
            //   I'm not sure how it runs on other computers, though
            valid = File.Exists(path);
            if (!fileName.EndsWith(".csv", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("File type must be .csv");
                valid = false;
            }
            
        }
        FilePath = fileName;
    }
    public abstract void parseData();

}