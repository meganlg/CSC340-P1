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

    public Generation(string Title, int headersLength, List<T> fields)
    {
        this.title = Title;
        headers = new List<string>(headersLength);
        this.fields = fields;
        pdfDocument = new PdfDocument();
        pdfDocument.Info.Title = title;
        pdfPage = pdfDocument.AddPage();
        gfx = XGraphics.FromPdfPage(pdfPage);
    }

    public void Start()
    {
        SetHeaders();
        PrintTitle();
        PrintHeaders();
        PrintFields();
        SavePdf();
    }

    protected void SavePdf()
    {
        string pdfFileName = $"{title.Replace(" ", "_")}.pdf";
        using (var stream = new FileStream(pdfFileName, FileMode.Create, FileAccess.Write))
        {
            pdfDocument.Save(stream);
        }

        Console.WriteLine($"PDF saved as {pdfFileName}");
    }

    public abstract void SetHeaders();
    public abstract void PrintTitle();
    public abstract void PrintHeaders();
    public abstract void PrintFields();
}