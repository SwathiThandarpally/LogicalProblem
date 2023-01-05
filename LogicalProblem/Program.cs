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
            FibonacciSeries series = new FibonacciSeries();
            series.DisplayFibbonacci();
            Console.WriteLine("------------------------------");
            //UC_4
            CouponsNumber.Coupon(5);
            Console.WriteLine("------------------------------");
            //UC_5
            ReverseNumber number = new ReverseNumber();
            number.DisplayReverse();
            Console.WriteLine("------------------------------");
            //UC_6
            StopWatch watch = new StopWatch();
            watch.Dispaly();


        }
    }
}