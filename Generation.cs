using System.Security;

namespace DocumentNS;

public abstract class Generation
{
    protected string title;
    protected List<string> headers;
    protected List<string> fields;

    public Generation(int headersLength, int fieldsLength)
    {
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