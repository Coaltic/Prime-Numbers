using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static public bool prime = true;
        static void Main(string[] args)
        {
            for (int i = 1000000001; i < 2000000001; i = i + 2)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
                
            Console.ReadKey(true);
        }

        static public bool IsPrime(int num)
        {
            if (num % 2 == 0)
            {
                //is not prime number
                return false;
            }

            for (int k = 3; k < num / 5; k = k + 2)
            {
                
                if (num % k == 0)
                {
                    //is not prime number
                    return false;
                }
            }

            return true;
        }
    }

}