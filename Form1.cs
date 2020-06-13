﻿using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Windows.Forms;

namespace PdfExtractor
{
    public partial class Form1 : Form
    {
        PdfDocument _pdfDocument;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            var caminhoArquivo = openFileDialog.FileName;
            lblArquivoSelecionado.Text = caminhoArquivo;

            _pdfDocument = new PdfDocument(new PdfWriter(new FileStream(caminhoArquivo, FileMode.Open, FileAccess.ReadWrite)));
            Document document = new Document(_pdfDocument);
        }
    }
}
