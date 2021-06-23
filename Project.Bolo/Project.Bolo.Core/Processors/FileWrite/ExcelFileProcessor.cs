using Bytescout.Spreadsheet;
using Project.BoloSemanal.Core.DataUtility;
using System.Collections.Generic;

namespace Project.BoloSemanal.Core.Processors.FileWrite
{
    public class ExcelFileProcessor 
    {
        public void GenerateLocalXlsxFile(List<string> fileContent)
        {
            var spreadsheet = new Spreadsheet();
            var sheets = spreadsheet.Workbook.Worksheets.Add("Bolinho");

            var Datas = FindDates.GetDatas();
            var ListNames = fileContent;

            sheets.Cell(0, 0).Value = "Nomes:";
            sheets.Cell(0, 1).Value = "Datas:";

            sheets.Columns[0].Width = 200;
            sheets.Columns[1].Width = 150;

            var line = 0;
            var indexList = 0;

            foreach (var dates in Datas)
            {
                if (indexList == ListNames.Count)
                    break;

                sheets.Cell(line + 1, 1).Value = dates;
                sheets.Cell(line + 1, 0).Value = ListNames[indexList];

                line++;
                indexList++;
            }

            spreadsheet.SaveAs("ProximoBolo.xlsx");
            spreadsheet.Close();

        }
    }
}
