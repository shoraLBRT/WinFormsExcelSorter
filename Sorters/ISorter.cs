namespace FinConnectWinFormsTest.Sorters
{
    public interface ISorter
    {
        string Sort(string inputFile);
    }
    public interface ISorterForXls : ISorter { }
    public interface ISorterForNewFormats : ISorter { }
}
