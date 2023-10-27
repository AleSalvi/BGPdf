using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.Core;
using UglyToad.PdfPig.Fonts.Standard14Fonts;
using UglyToad.PdfPig.Writer;

namespace WindowsFormsApp1
{
    internal class pdfManagment
    {
        public string ReadPageOnPdf(string path, int pageN) {
            string pageContent = string.Empty;

            using (PdfDocument document = PdfDocument.Open(path))
            {
                Page page = document.GetPage(pageN);

                pageContent  = page.Text;
            }

            return pageContent;
        }

        public int GetPdfPages(string path)
        {
            int pdfNumberOfPages = 0;

            using (PdfDocument document = PdfDocument.Open(path))
            {
                pdfNumberOfPages = document.GetPages().Count();
            }

            return pdfNumberOfPages;
        }

        public void ReadAllContentOnPdf(string path) {
            using (PdfDocument document = PdfDocument.Open(path))
            {
                foreach (Page page in document.GetPages())
                {
                    IReadOnlyList<Letter> letters = page.Letters;
                    string example = string.Join(string.Empty, letters.Select(x => x.Value));

                    IEnumerable<Word> words = page.GetWords();

                    IEnumerable<IPdfImage> images = page.GetImages();
                }
            }
        }

        public void WriteLineOnPdf(ref PdfPageBuilder page, string stringToWrite, int fontSize, double xValue, double yValue, PdfDocumentBuilder.AddedFont font)
        {
            PdfPoint position = new PdfPoint(xValue, yValue);

            page.SetTextRenderingMode(TextRenderingMode.Fill);

            page.AddText(stringToWrite, fontSize, position, font);
        }
    }
}