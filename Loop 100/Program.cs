namespace Loop_100;

internal class Program
{
    static void Main(string[] args)
    {
        {
            int sum = 0;

            for (var idx = 1; idx < 100; idx++)
            {
                if (idx % 5 == 0 || idx % 7 == 0)
                {
                    sum = sum + idx;
                }
            }
           
            Console.WriteLine(sum);
        }
    }
}
