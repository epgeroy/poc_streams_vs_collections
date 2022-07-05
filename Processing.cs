using BenchmarkDotNet.Attributes;

namespace Performance.Testing 
{
    public class ProcessingCollections
    {
        public void CalculateSmallestWorthwhileChangeCollection(IEnumerable<long> data)
        {
            var average = data.Where(number => number % 2 == 0).Average();
            var sumPow = data.Where(number => number % 2 == 0).Sum(number => Math.Pow(number, 2));
            var count = data.Where(number => number % 2 == 0).Count();

            var stdDev = Math.Sqrt(sumPow / (count - 1));
            var smallestWorthwhileChange = stdDev * .5;
        }

        private int count = 0;
        private long sumPow = 0;
        private long sum = 0;


        public void CalculateSmallestWorthwhileChangeStream(IEnumerable<long> data)
        {
            foreach(var number in data)
            {
                if (number % 2 == 0)
                {
                    count++;
                    sumPow += number * number;
                    sum += number;
                }
                
            }

            var average = sum / count;
            var stdDev = Math.Sqrt(sumPow / (count - 1));
            var smallestWorthwhileChange = stdDev * .5;
        }
    }

    public class DataProvider
    {
        private const int _veryLong = 100000;
        private readonly long[] _data = new long[_veryLong];

        public DataProvider()
        {
            for (int i = 0; i < _veryLong; i++)
            {
                _data[i] = i;
            }
        }

        public IEnumerable<long> GetDataAsCollection()
        {
            return _data;
        }

        public IEnumerable<long> GetDataAsStream()
        {
            foreach(var item in _data)
            {
                yield return item;
            }
        }
    }
}