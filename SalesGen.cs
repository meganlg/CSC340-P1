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
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using System.IO;
using System.Globalization;
namespace DocumentNS;

public class SalesGen : Generation<Sale>
{
    private List<Sale> saleData;
    public SalesGen(List<Sale> saleData) : base("Sales Report", 4, saleData.Count)
    {
        this.saleData = saleData;
    }
        public override void SetTitle()
    {
        title = "Sales Report";
    }
    public override void SetHeaders()
    {
        headers.Add("Location");
        headers.Add("Target Sales");
        headers.Add("Actual Sales");
        headers.Add("Difference");
    }
    public override void SetFields()
    {
        foreach (var sale in saleData)
        {
            fields.Add(sale);
        }
    }
    public override void PrintTitle()
    {
        XFont font = new XFont("Verdana", 20, XFontStyle.Bold); //sets the font beforehand 
        gfx.DrawString(title, font, XBrushes.DarkOliveGreen, new XRect(0, 50, pdfPage.Width, pdfPage.Height), XStringFormats.TopCenter);
    }
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
            gfx.DrawString(saleItem.Difference.ToString("C", CultureInfo.CurrentCulture), font, XBrushes.Black, new XRect(xOffset + 3 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);      
                  
            yOffset += lineWidth; //add line width to the vertical offset
        }
    }
}