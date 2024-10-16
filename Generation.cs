/********************************************************************
*** NAME : Group 4	                                              ***
*** CLASS : SE 340                                                ***
*** ASSIGNMENT : Project 1                                        ***
*** DUE DATE : 10-16-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Generation is an abstract class of type <T>     ***
***														      ***
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

    /********************************************************************
    *** METHOD Generation                                             ***
    *********************************************************************
    *** DESCRIPTION :  sets the title, creates the list of headers,   ***
    ***                sets the fields, creates a new PDF, sets the   ***
    ***                PDF title, and sets gfx                        ***
    *** INPUT ARGS :                                                  ***
    *** OUTPUT ARGS :                                                 ***
    *** IN/OUT ARGS :                                                 ***
    *** RETURN :                                                      ***
    ********************************************************************/
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

    /********************************************************************
    *** METHOD Start                                                  ***
    *********************************************************************
    *** DESCRIPTION : calls the setting and printing methods in order ***
    *** INPUT ARGS :                                                  ***
    *** OUTPUT ARGS :                                                 ***
    *** IN/OUT ARGS :                                                 ***
    *** RETURN :      void                                            ***
    ********************************************************************/
    public void Start()
    {
        SetHeaders();
        PrintTitle();
        PrintHeaders();
        PrintFields();
        SavePdf();
    }

    /********************************************************************
    *** METHOD SavePdf                                                ***
    *********************************************************************
    *** DESCRIPTION : saves the PDF with _ replacing whitespace       ***
    *** INPUT ARGS :                                                  ***
    *** OUTPUT ARGS :                                                 ***
    *** IN/OUT ARGS :                                                 ***
    *** RETURN :      void                                            ***
    ********************************************************************/
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