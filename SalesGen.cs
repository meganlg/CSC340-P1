/********************************************************************
*** NAME : Group 4	                                              ***
*** CLASS : SE 340                                                ***
*** ASSIGNMENT : Project 1                                        ***
*** DUE DATE : 10-16-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : The SalesGen class inherits from the         ***
***				  Generation class and implements SetHeaders,     ***
***               PrintTitle, PrintHeaders, and PrintFields.      ***
********************************************************************/
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using System.IO;
using System.Globalization;
namespace DocumentNS;

public class SalesGen : Generation<Sale>
{
    /********************************************************************
    *** METHOD SalesGen (constructor)                              ***
    *********************************************************************
    *** DESCRIPTION : sends the title, size, and object to the base class
    *** INPUT ARGS : List<Inventory> inventoryData                    ***
    *** OUTPUT ARGS :                                                 ***
    *** IN/OUT ARGS :                                                 ***
    *** RETURN :                                                      ***
    ********************************************************************/
    public SalesGen(List<Sale> saleData) : base("Sales Report", 4, saleData)
    {
    }
    /********************************************************************
    *** METHOD SetHeaders                                             ***
    *********************************************************************
    *** DESCRIPTION : Adds the headers to the list                    ***
    *** INPUT ARGS :                                                  ***
    *** OUTPUT ARGS :                                                 ***
    *** IN/OUT ARGS :                                                 ***
    *** RETURN :    void                                              ***
    ********************************************************************/
    public override void SetHeaders()
    {
        headers.Add("Location");
        headers.Add("Target Sales");
        headers.Add("Actual Sales");
        headers.Add("Difference");
    }

    /********************************************************************
    *** METHOD PrintTitle                                             ***
    *********************************************************************
    *** DESCRIPTION : prints the title to the pdf                     ***
    *** INPUT ARGS :                                                  ***
    *** OUTPUT ARGS :                                                 ***
    *** IN/OUT ARGS :                                                 ***
    *** RETURN :       void                                           ***
    ********************************************************************/
    public override void PrintTitle()
    {
        XFont font = new XFont("Verdana", 20, XFontStyle.Bold); //sets the font beforehand 
        gfx.DrawString(title, font, XBrushes.DarkOliveGreen, new XRect(0, 50, pdfPage.Width, pdfPage.Height), XStringFormats.TopCenter);
    }

    /********************************************************************
    *** METHOD PrintHeaders                                           ***
    *********************************************************************
    *** DESCRIPTION : Prints the headers to the pdf with an even spacing
    *** INPUT ARGS :                                                  ***
    *** OUTPUT ARGS :                                                 ***
    *** IN/OUT ARGS :                                                 ***
    *** RETURN :    void                                              ***
    ********************************************************************/
    public override void PrintHeaders()
    {
        XFont font = new XFont("Verdana", 10, XFontStyle.Bold); //set the font beforehand
        double yOffset = 100;  //set the starting y position
        double widthBetweenColumns = 120;  //set the width between columns
        double xOffset = 90;  //x offset start

        for (int i = 0; i < headers.Count; i++)
        {
            gfx.DrawString(headers[i], font, XBrushes.Black, new XRect(xOffset + i * widthBetweenColumns, yOffset, widthBetweenColumns, 20), XStringFormats.TopLeft); 
        }
    }

    /********************************************************************
    *** METHOD PrintFields                                            ***
    *********************************************************************
    *** DESCRIPTION : prints each row of fields to the pdf            ***
    *** INPUT ARGS :                                                  ***
    *** OUTPUT ARGS :                                                 ***
    *** IN/OUT ARGS :                                                 ***
    *** RETURN :      void                                            ***
    ********************************************************************/
    public override void PrintFields()
    {
        XFont font = new XFont("Verdana", 10, XFontStyle.Regular);
        double yOffset = 120; //set the starting y position
        double lineWidth = 20; //Width between rows
        double widthBetweenColumns = 120; //set the width between columns
        double xOffset = 90; // X offset to shift everything to the right

        foreach (var saleItem in fields)
        {
            // Incorporate xOffset into the X position for each field
            gfx.DrawString(saleItem.Location, font, XBrushes.Black, new XRect(xOffset + 0 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);

            gfx.DrawString(saleItem.TargetSales.ToString("C", CultureInfo.CurrentCulture), font, XBrushes.Black, new XRect(xOffset + 1 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);

            gfx.DrawString(saleItem.ActualSales.ToString("C", CultureInfo.CurrentCulture), font, XBrushes.Black, new XRect(xOffset + 2 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);

            string temp = saleItem.Difference.ToString().Substring(0, 1);
            if(temp == "-")
            {
                gfx.DrawString(saleItem.Difference.ToString("C", CultureInfo.CurrentCulture), font, XBrushes.Red, new XRect(xOffset + 3 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);    
            }  
            else
            {
                gfx.DrawString(saleItem.Difference.ToString("C", CultureInfo.CurrentCulture), font, XBrushes.Black, new XRect(xOffset + 3 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);    
            }
                  
            yOffset += lineWidth; //add line width to the vertical offset
        }
    }
}