using ClosedXML.Excel;

namespace FinConnectWinFormsTest.Sorters
{
    internal class SorterForNewFormats : ISorterForNewFormats
    {
        public string Sort(string inputFile)
        {
            using (var workbook = new XLWorkbook(inputFile))
            {
                var worksheet = workbook.Worksheet(1);

                var dataRange = worksheet.RangeUsed();

                dataRange.Sort("1 ASC");

                string outputFile = $@"{inputFile}result.xlsx";

                workbook.SaveAs(outputFile);

                return outputFile;
            }
        }
    }
}
