using System;
using iText.Kernel.Pdf;
using System.Windows.Forms;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using System.Text;

namespace PdfExtractor
{
    public partial class PdfExtractor : Form
    {
        PdfDocument _pdfDocument;

        public PdfExtractor()
        {
            InitializeComponent();
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            var caminhoArquivo = openFileDialog.FileName;
            lblArquivoSelecionado.Text = caminhoArquivo;

            _pdfDocument = new PdfDocument(new PdfReader(caminhoArquivo));

            LocationTextExtractionStrategy strategy = new LocationTextExtractionStrategy();

            var numberOfPages = _pdfDocument.GetNumberOfPages();

            for (var i = 1; i <= numberOfPages; i++)
            {
                PdfCanvasProcessor parser = new PdfCanvasProcessor(strategy);
                parser.ProcessPageContent(_pdfDocument.GetPage(i));

                byte[] array = Encoding.Default.GetBytes(strategy.GetResultantText());


                var str = Encoding.Default.GetString(array);
            }

            _pdfDocument.Close();
        }
    }
}
