using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SlijterijSjonnieLoper_version2.ITextSharpPdfCreator
{
    public static class GenerateMailForCustomer
    {
        public static string GeneratePdfFileForCustomer()
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("host.pdf", FileMode.Create));
            doc.Open();
            string storestring1 = "Dear Sir/Ma'am @ thank you heartilly for de purchase at Sjonnie's liquor store @ we will keep you up to date with the latest news";
            string addnewlines1 = storestring1.Replace("@", Environment.NewLine);
            Paragraph paragraph = new Paragraph(addnewlines1);
            paragraph.IndentationRight = 100;
            paragraph.IndentationLeft = 100;
            doc.Add(paragraph);
            doc.Close();
            var pathpdffile = Path.GetFullPath("host.pdf");
            return pathpdffile;
        }
    }
}