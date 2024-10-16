/********************************************************************
*** NAME : Group 4	                                              ***
*** CLASS : SE 340                                                ***
*** ASSIGNMENT : Project 1                                        ***
*** DUE DATE : 10-16-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : The EmployeeGen class inherits from the         ***
***				  Generation class and implements SetHeaders,     ***
***               PrintTitle, PrintHeaders, and PrintFields.      ***
********************************************************************/
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using System.IO;
using System.Globalization;
namespace DocumentNS;

public class EmployeeGen : Generation<Employee>
{
    /********************************************************************
    *** METHOD EmployeeGen (constructor)                              ***
    *********************************************************************
    *** DESCRIPTION : sends the title, size, and object to the base class
    *** INPUT ARGS : List<Employee> employeeData                      ***
    *** OUTPUT ARGS :                                                 ***
    *** IN/OUT ARGS :                                                 ***
    *** RETURN :                                                      ***
    ********************************************************************/
    public EmployeeGen(List<Employee> employeeData) : base("Employee Report", 6, employeeData)
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
        headers.Add("First Name");
        headers.Add("Last Name");
        headers.Add("Employee ID");
        headers.Add("Hourly Pay");
        headers.Add("Position");
        headers.Add("Phone Number");
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
        gfx.DrawString(title, font, XBrushes.DarkSlateGray, new XRect(0, 50, pdfPage.Width, pdfPage.Height), XStringFormats.TopCenter);
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
        double widthBetweenColumns = 90;  //set the width between columns
        double xOffset = 40;  //x offset start

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
        double widthBetweenColumns = 90; //set the width between columns
        double xOffset = 40; // X offset to shift everything to the right

        foreach (var employee in fields)
        {
            // Incorporate xOffset into the X position for each field
            gfx.DrawString(employee.FirstName, font, XBrushes.Black, new XRect(xOffset + 0 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);

            gfx.DrawString(employee.LastName, font, XBrushes.Black, new XRect(xOffset + 1 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);

            gfx.DrawString(employee.ID.ToString(), font, XBrushes.Black, new XRect(xOffset + 2 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);

            gfx.DrawString(employee.Pay.ToString("C", CultureInfo.CurrentCulture), font, XBrushes.Black, new XRect(xOffset + 3 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);

            gfx.DrawString(employee.Position, font, XBrushes.Black, new XRect(xOffset + 4 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);

            gfx.DrawString(employee.PhoneNumber, font, XBrushes.Black, new XRect(xOffset + 5 * widthBetweenColumns, yOffset, widthBetweenColumns, lineWidth), XStringFormats.TopLeft);

            yOffset += lineWidth; //add line width to the vertical offset
        }
    }

}