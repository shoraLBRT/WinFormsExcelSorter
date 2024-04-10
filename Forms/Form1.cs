using FinConnectWinFormsTest.Sorters;

namespace FinConnectWinFormsTest
{
    public partial class Form1 : Form
    {
        private readonly ISorterForXls _sorterForXls;
        private readonly ISorterForNewFormats _sorterForNewFormats;

        string inputFile;
        public Form1(ISorterForXls sorterForXls, ISorterForNewFormats sorterForNewFormats)
        {
            InitializeComponent();

            _sorterForXls = sorterForXls;
            _sorterForNewFormats = sorterForNewFormats;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFile = openFileDialog1.FileName;

                try
                {
                    if (File.Exists(inputFile))
                    {
                        ISorter sorter = ChooseSorterForCurrentExtension(inputFile);

                        string outputFile = sorter.Sort(inputFile);

                        MessageBox.Show($"Сортировка завершена. Результат сохранен в файле '{outputFile}'.");
                        ClearFields();
                    }
                    else throw new Exception("Файл не найден");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            inputFile = null;
            openFileDialog1.FileName = null;
        }
        private ISorter ChooseSorterForCurrentExtension(string inputFile)
        {
            var fileExtension = Path.GetExtension(inputFile).ToLower();

            if (fileExtension == ".xls")
                return _sorterForXls;

            else if (fileExtension == ".xlsx" || fileExtension == ".xlsm" || fileExtension == ".xltx" || fileExtension == ".xltm")
                return _sorterForNewFormats;

            else
                throw new FormatException("Неверный формат файла. Поддерживаются только файлы .xls, .xlsx, .xltx, .xltm, .xlsm");
        }
    }
}
