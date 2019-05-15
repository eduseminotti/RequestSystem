using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace Request_System
{
    public class GeradorDePDFGrid
    {
        LOG log = new LOG();
        /// <summary>
        /// Solicita geração de PDFs para relatorios
        /// </summary>
        /// <param name="dataGrid">recebe o DataGrid como parametro para gerar o PDF</param>
        /// <param name="tpRelatorio">String do tipo de relatorio</param>
        public void gerarPDF(DataGridView dataGrid, string tpRelatorio)
        {
            log.logador("Iniciando processo de geração de PDF para relatorio de: " + tpRelatorio);

            PdfPTable pdfTable = new PdfPTable(dataGrid.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGrid.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(250, 250, 250);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                        pdfTable.AddCell(cell.Value.ToString());
                    else
                        pdfTable.AddCell("");
                }
            }

            String dataRelatorio = Convert.ToString(DateTime.Now);
            dataRelatorio = dataRelatorio.Replace("/", "-").Replace(":", "-");

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Arquivo|*.pdf";
            saveFileDialog1.Title = "Selecione o local para salvar";
            saveFileDialog1.FileName = "Relatorio " + tpRelatorio + "-" + dataRelatorio + ".pdf";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                fs.Close();
            }

            String folderPath = Convert.ToString(saveFileDialog1.FileName);

            using (FileStream stream = new FileStream(folderPath, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A3, 30f, 30f, 30f, 30f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();

                log.logador("PDF de relatorio de: "+ tpRelatorio +" gerado com sucesso no diretorio: " + folderPath);
            }
        }
    }
}
