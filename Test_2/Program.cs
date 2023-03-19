namespace Test_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Function function = new Function();

            for (int i = 1; i <= 100; i++)
            {
                if (function.IsPrime(i))
                {
                    Console.WriteLine(i + " >> Prime ");
                }
              

            }

            Console.ReadKey();
        }
    }
}