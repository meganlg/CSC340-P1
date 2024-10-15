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
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using System.IO;

namespace DocumentNS;

public abstract class Generation<T>
{
    protected string title;
    protected List<string> headers;
    protected List<T> fields;
    protected PdfDocument pdfDocument;
    protected PdfPage pdfPage;
    protected XGraphics gfx;

    public Generation(string Title, int headersLength, int fieldsLength)
    {
        this.title = Title;
        headers = new List<string>(headersLength);
        fields = new List<T>(fieldsLength);
        pdfDocument = new PdfDocument();
        pdfDocument.Info.Title = title;
        pdfPage = pdfDocument.AddPage();
        gfx = XGraphics.FromPdfPage(pdfPage);
    }

    public void Start()
    {
        string pdfFileName = $"{title.Replace(" ", "_")}.pdf";
        SetTitle();
        SetHeaders();
        SetFields();
        PrintTitle();
        PrintHeaders();
        PrintFields();
        SavePdf(pdfFileName);
    }

protected void SavePdf(string fileName)
{
    using (var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
    {
        pdfDocument.Save(stream);
    }

    Console.WriteLine($"PDF saved as {fileName}");
}

    public abstract void SetTitle();
    public abstract void SetHeaders();
    public abstract void SetFields();
    public abstract void PrintTitle();
    public abstract void PrintHeaders();
    public abstract void PrintFields();
}