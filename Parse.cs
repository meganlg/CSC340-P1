/********************************************************************
*** NAME : Group 4	                                              ***
*** CLASS : SE 340                                                ***
*** ASSIGNMENT : Project 1                                        ***
*** DUE DATE : 10-16-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Parse is an abstract class that provides the 	  ***
***               needed components for extracting and converting ***
***               csv formatted data into class-based data types. ***
***               A default implementation of getting a file name ***
***               is provided. Child classes must provide         ***
***               implementation for parsing the csv data and the ***
***               datatype to convert to.                         ***
***															      ***
********************************************************************/
using System;
namespace DocumentNS;

public abstract class Parse<T>
{
    required public string FilePath { get; set; }
    public abstract List<T> Data{ get; set; }

    /********************************************************************
    *** METHOD parseCsvFile                                           ***
    *********************************************************************
    *** DESCRIPTION : Calls the csv parsing algorithm in order        ***
    ***               (template method)                               ***
    *** INPUT ARGS : fileName                                         ***
    *** OUTPUT ARGS : None                                            ***
    *** IN/OUT ARGS : FilePath, Data                                  ***
    *** RETURN : void                                                 ***
    ********************************************************************/
    public void parseCsvFile(string? fileName)
    {
        getFile(fileName);
        if(FilePath != "")
        {
            parseData();
        }
    }

    /********************************************************************
    *** METHOD getFile                                                ***
    *********************************************************************
    *** DESCRIPTION : Sets the FileName property to the passed string ***
    ***               argument or "" if null; ensures the file is     ***
    ***               valid by checking that it exists and is of the  ***
    ***               csv file type.                                  ***
    ***               (template method)                               ***
    *** INPUT ARGS : fileName                                         ***
    *** OUTPUT ARGS : None                                            ***
    *** IN/OUT ARGS : FilePath                                        ***
    *** RETURN : void                                                 ***
    ********************************************************************/
    protected virtual void getFile(string? fileName)
    {
        bool valid = false;
        string path = "";
            // if user enters nothing, change to empty string instead of null
            fileName ??= "";
            path = fileName; //temporary
            valid = File.Exists(path);
            if (!fileName.EndsWith(".csv", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("File type must be .csv");
                valid = false;
            }
        FilePath = fileName;
    }

    protected abstract void parseData();
}