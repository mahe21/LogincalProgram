namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FibnacciSeries fibnacciSeries = new FibnacciSeries();
            fibnacciSeries.FibonacciSeries(10);

            PerfectNumber perfectNumbers = new PerfectNumber();
            perfectNumbers.perfectNumber();

        }
    }
}