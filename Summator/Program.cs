using System;
namespace Summator 
{
    public class Program
    {
        static void Main(string[] args)
        {
            int result = Summator.Sum(new int[] {1, 1});
            if (result == 2)
            {
                Console.WriteLine("Test PASS");
            } else
            {
                Console.WriteLine("Test FAIL");
            }

        }
    }
}

