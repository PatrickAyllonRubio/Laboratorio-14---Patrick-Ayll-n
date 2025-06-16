using ClosedXML.Excel;

namespace Laboratorio_13___Patrick_Hugo_Ayllón_Rubio.Infrastructure.Services.Export

{
    public class ExcelExportService
    {
        public void FirstExample(string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Hoja1");

                worksheet.Cell(1, 1).Value = "Nombre";
                worksheet.Cell(1, 2).Value = "Edad";
                worksheet.Cell(2, 1).Value = "Patrick";
                worksheet.Cell(2, 2).Value = 21;

                workbook.SaveAs(filePath);
            }
        }

        public void SecondExample()
        {
            using (var workbook = new XLWorkbook("C:\\Users\\patri\\OneDrive\\Documentos\\Laboratorios\\" +
                                                 "Desarrollo de Aplicaciones Empresariales Avanzado\\Semana 13\\Excels\\excelcreado2.xlsx"))
            {
                var worksheet = workbook.Worksheet(position: 1);
        
                worksheet.Cell(row: 2, column: 2).Value = 30;

                workbook.Save();
            }
        }

        public void ThirdExample()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(sheetName: "Datos");

                worksheet.Cell(row: 1, column: 1).Value = "ID";
                worksheet.Cell(row: 1, column: 2).Value = "Nombre";
                worksheet.Cell(row: 1, column: 3).Value = "Edad";

                worksheet.Cell(row: 2, column: 1).Value = 1;
                worksheet.Cell(row: 2, column: 2).Value = "Juan";
                worksheet.Cell(row: 2, column: 3).Value = 28;

                worksheet.Cell(row: 3, column: 1).Value = 2;
                worksheet.Cell(row: 3, column: 2).Value = "María";
                worksheet.Cell(row: 3, column: 3).Value = 34;

                var range = worksheet.Range("A1:C3");
                range.CreateTable();

                workbook.SaveAs("C:\\Users\\patri\\OneDrive\\Documentos\\Laboratorios\\" +
                                "Desarrollo de Aplicaciones Empresariales Avanzado\\Semana 13\\Excels\\excelcreado2.xlsx");
            }
        }

        public void FourthExample()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(sheetName: "Estilos");

                var headerRow = worksheet.Row(1);
                headerRow.Style.Font.Bold = true;
                headerRow.Style.Fill.BackgroundColor = XLColor.Cyan;
                headerRow.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                worksheet.Cell(row: 1, column: 1).Value = "ID";
                worksheet.Cell(row: 1, column: 2).Value = "Nombre";
                worksheet.Cell(row: 1, column: 3).Value = "Edad";

                worksheet.Cell(row: 2, column: 1).Value = 1;
                worksheet.Cell(row: 2, column: 2).Value = "Juan";
                worksheet.Cell(row: 2, column: 3).Value = 28;

                workbook.SaveAs("C:\\Users\\patri\\OneDrive\\Documentos\\Laboratorios\\" +
                                "Desarrollo de Aplicaciones Empresariales Avanzado\\Semana 13\\Excels\\excelcreado2.xlsx");
            }
        }

    }
}