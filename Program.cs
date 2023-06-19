namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            FibnacciSeries fibnacciSeries = new FibnacciSeries();
            fibnacciSeries.FibonacciSeries(10);

            PerfectNumber perfectNumbers = new PerfectNumber();
            perfectNumbers.perfectNumber();

            PrimeNumber number = new PrimeNumber();
            number.PrimeNum();

        }
    }
}