using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace FinConnectWinFormsTest.Sorters
{
    internal class SorterXlsFormat : ISorterForXls
    {
        public string Sort(string inputFile)
        {
            string outputFile = $@"{inputFile}result.xls";

            _Application excel = new _Excel.Application();

            Workbook workbook = excel.Workbooks.Open(inputFile);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            var sortRange = worksheet.UsedRange;

            sortRange.Sort(sortRange.Columns[1, Type.Missing], XlSortOrder.xlAscending);

            workbook.SaveAs(outputFile);

            workbook.Close();

            excel.Application.Quit();

            return outputFile;
        }
    }
}
