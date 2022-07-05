using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;
using Performance.Testing;

BenchmarkRunner.Run<Benchy>();

// new ProcessingCollections().CalculateSmallestWorthwhileChangeCollection(new DataProvider().GetDataAsCollection());

[MemoryDiagnoser]
public class Benchy
{
    [Benchmark]
    public void CalculateSmallestWorthwhileChangeCollection()
    {
        var dataCollection = new DataProvider().GetDataAsCollection();

        var processing = new ProcessingCollections();
        processing.CalculateSmallestWorthwhileChangeCollection(dataCollection);
    }

    [Benchmark]
    public void CalculateSmallestWorthwhileChangeStream()
    {
        var dataCollection = new DataProvider().GetDataAsCollection();

        var processing = new ProcessingCollections();
        processing.CalculateSmallestWorthwhileChangeStream(dataCollection);
    }
}