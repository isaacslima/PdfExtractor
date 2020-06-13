using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Windows.Forms;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using System.Text;

namespace PdfExtractor
{
    public partial class PdfExtractor : Form
    {
        PdfDocument _pdfDocument;
        public static readonly String DEST = "czech.txt";

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

            PdfCanvasProcessor parser = new PdfCanvasProcessor(strategy);
            parser.ProcessPageContent(_pdfDocument.GetFirstPage());

            byte[] array = Encoding.UTF8.GetBytes(strategy.GetResultantText());
            using (FileStream stream = new FileStream(DEST, FileMode.Create))
            {
                stream.Write(array, 0, array.Length);
            }

            _pdfDocument.Close();
        }
    }
}
