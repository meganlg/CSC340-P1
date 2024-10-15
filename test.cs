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
using System;
using System.Text; // Required for encoding
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;

namespace PdfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fix: Register the encoding provider for encodings like Windows-1252
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Employee Details";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Set the font (You may need to provide your own font files if default system fonts aren't available)
            XFont fontTitle = new XFont("Verdana", 14, XFontStyle.Bold);
            XFont fontHeader = new XFont("Verdana", 12, XFontStyle.Bold);
            XFont fontBody = new XFont("Verdana", 10, XFontStyle.Regular);

            // Title
            gfx.DrawString("Employee Details", fontTitle, XBrushes.Yellow,
                new XRect(0, 20, page.Width, page.Height),
                XStringFormats.TopCenter);

            // Table headers
            double yOffset = 60; // Starting Y position for the table
            double lineHeight = 20; // Space between rows
            double columnWidth = 100;

            gfx.DrawString("First Name", fontHeader, XBrushes.Black, new XRect(20, yOffset, columnWidth, lineHeight), XStringFormats.TopLeft);
            gfx.DrawString("Last Name", fontHeader, XBrushes.Black, new XRect(120, yOffset, columnWidth, lineHeight), XStringFormats.TopLeft);
            gfx.DrawString("Employee ID", fontHeader, XBrushes.Black, new XRect(220, yOffset, columnWidth, lineHeight), XStringFormats.TopLeft);
            gfx.DrawString("Hourly Pay", fontHeader, XBrushes.Black, new XRect(320, yOffset, columnWidth, lineHeight), XStringFormats.TopLeft);
            gfx.DrawString("Position", fontHeader, XBrushes.Black, new XRect(420, yOffset, columnWidth, lineHeight), XStringFormats.TopLeft);
            gfx.DrawString("Phone Number", fontHeader, XBrushes.Black, new XRect(520, yOffset, columnWidth, lineHeight), XStringFormats.TopLeft);

            // Example employee data (can be loaded from a database, file, or another source)
            string[,] employees = new string[,]
            {
                {"John", "Johnson", "E000", "15.6", "Customer Service", "555-012-3456"},
                {"Jane", "Smith", "E001", "20.5", "Manager", "555-045-6789"},
                {"Robert", "Johnson", "E002", "18.75", "Developer", "555-078-9123"},
                {"James", "Brown", "E003", "22", "Designer", "555-111-2345"},
                {"William", "Davis", "E004", "19", "Analyst", "555-131-5678"},
                // Add the rest of the employees here
            };

            // Draw employee data
            for (int i = 0; i < employees.GetLength(0); i++)
            {
                yOffset += lineHeight;
                gfx.DrawString(employees[i, 0], fontBody, XBrushes.Black, new XRect(20, yOffset, columnWidth, lineHeight), XStringFormats.TopLeft);  // First Name
                gfx.DrawString(employees[i, 1], fontBody, XBrushes.Black, new XRect(120, yOffset, columnWidth, lineHeight), XStringFormats.TopLeft); // Last Name
                gfx.DrawString(employees[i, 2], fontBody, XBrushes.Black, new XRect(220, yOffset, columnWidth, lineHeight), XStringFormats.TopLeft); // Employee ID
                gfx.DrawString(employees[i, 3], fontBody, XBrushes.Black, new XRect(320, yOffset, columnWidth, lineHeight), XStringFormats.TopLeft); // Hourly Pay
                gfx.DrawString(employees[i, 4], fontBody, XBrushes.Black, new XRect(420, yOffset, columnWidth, lineHeight), XStringFormats.TopLeft); // Position
                gfx.DrawString(employees[i, 5], fontBody, XBrushes.Black, new XRect(520, yOffset, columnWidth, lineHeight), XStringFormats.TopLeft); // Phone Number
            }

            // Save the document
            const string filename = "EmployeeDetails.pdf";
            document.Save(filename);

            // Output confirmation message
            Console.WriteLine($"PDF saved at {filename}");
        }
    }
}
