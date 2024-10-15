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
using System.Security;

namespace DocumentNS;

public abstract class Generation
{
    protected string title;
    protected List<string> headers;
    protected List<string> fields;

    public Generation(string Title, int headersLength, int fieldsLength)
    {
        this.title = Title;
        headers = new List<string>(headersLength);
        fields = new List<string>(fieldsLength);
    }

    public void Start()
    {
        SetTitle();
        SetHeaders();
        SetFields();
        PrintTitle();
        PrintHeaders();
        PrintFields();
    }

    public abstract void SetTitle();
    public abstract void SetHeaders();
    public abstract void SetFields();
    public abstract void PrintTitle();
    public abstract void PrintHeaders();
    public abstract void PrintFields();
}