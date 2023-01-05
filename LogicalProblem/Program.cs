namespace LogicalProblem
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Diaplaying Logical Programming");
            Console.WriteLine("------------------------------");
            //UC_1
            PerfectNumber.DisplayPerfectnumber();
            Console.WriteLine("------------------------------");
            //UC_2
            PrimeNumber.Prime();
            Console.WriteLine("------------------------------");
            //UC_3
            FibonacciSeries series  = new FibonacciSeries();
            series.DisplayFibbonacci();
            Console.WriteLine("------------------------------");
        }
    }
}