namespace PrimeNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Program");
           
            int n, i, flag = 0;
            int min, max;
            Console.WriteLine("Find the Prime Number within a given range");

            Console.WriteLine("Input starting number of range:");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Ending number of range");
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime Numbers are: ");

            if (min >= 2)
            {
                for (n = min; n <= max; n++)
                {
                    i = 2;
                    flag = 0;
                    while (i <= n / 2)
                    {
                        if (n % i == 0)
                        {
                            flag = 1;
                            break;
                        }
                        i = i + 1;
                    }
                    if (flag == 0)
                    {
                        Console.WriteLine("{0} ", n);
                       
                    }
                }
            }
        }
    }
}