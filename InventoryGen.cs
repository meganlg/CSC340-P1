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

public class InventoryGen : Generation<Inventory>
{
    private List<Inventory> inventoryData;
    public InventoryGen(List<Inventory> inventoryData) : base("Inventory Report", 5, inventoryData.Count)
    {
        this.inventoryData = inventoryData;
    }
    public override void SetTitle()
    {
        title = "Inventory Report";
    }
    public override void SetHeaders()
    {
        headers.Add("Product ID");
        headers.Add("Quantity");
        headers.Add("Price Per");
        headers.Add("Category");
        headers.Add("Weight (lbs)");
    }
    public override void SetFields()
    {
        foreach (var inventory in inventoryData)
        {
            fields.Add(inventory);
        }
    }
    public override void PrintTitle()
    {
        XFont font = new XFont("Verdana", 20, XFontStyle.Bold); //sets the font beforehand 
        gfx.DrawString(title, font, XBrushes.DarkRed, new XRect(0, 50, pdfPage.Width, pdfPage.Height), XStringFormats.TopCenter);
    }
    public override void PrintHeaders()
    {
        XFont font = new XFont("Verdana", 10, XFontStyle.Bold); //set the font beforehand
        double yOffset = 100;  //set the starting y position
        double widthBetweenColumns = 120;  //set the width between columns
        double xOffset = 40;  //x offset start

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
        double xOffset = 40; // X offset to shift everything to the right

        foreach (var inventoryItem in fields)
        {
            // Incorporate xOffset into the X position for each field
            gfx.DrawString(inventoryItem.ID.ToString(), font, XBrushes.Black, new XRect(xOffset + 0 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);

            gfx.DrawString(inventoryItem.Quantity.ToString(), font, XBrushes.Black, new XRect(xOffset + 1 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);

            gfx.DrawString(inventoryItem.Price.ToString("C", CultureInfo.CurrentCulture), font, XBrushes.Black, new XRect(xOffset + 2 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);

            gfx.DrawString(inventoryItem.Category, font, XBrushes.Black, new XRect(xOffset + 3 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);

            gfx.DrawString(inventoryItem.Weight.ToString(), font, XBrushes.Black, new XRect(xOffset + 4 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);


            yOffset += lineWidth; //add line width to the vertical offset
        }
    }
}