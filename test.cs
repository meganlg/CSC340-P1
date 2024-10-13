using System;
using System.Text; // Make sure to include this namespace for encoding
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace PdfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Register code pages encoding provider for encodings like Windows-1252
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Generated with PdfSharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font (Regular style)
            XFont font = new XFont("Verdana", 20, XFontStyle.Regular);

            // Draw the text in the center of the page
            gfx.DrawString("Hello, PdfSharp!", font, XBrushes.DarkGray,
              new XRect(0, -325, page.Width, page.Height),
              XStringFormats.Center);

            // Save the document to a file
            const string filename = "HelloWorld.pdf";
            document.Save(filename);

            // Output a confirmation message
            Console.WriteLine($"PDF generated successfully at {filename}");
        }
    }
}
