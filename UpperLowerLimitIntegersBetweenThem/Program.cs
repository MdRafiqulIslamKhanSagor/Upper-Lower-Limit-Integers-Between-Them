using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperLowerLimitIntegersBetweenThem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please insert the Upper Limit :");
            int upperLimit = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(" Please insert the Lower Limit :");
            int lowerLimit = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(" All Integers between them including them are given below :");


            for (int i=upperLimit;i>=lowerLimit;i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();   

        }
    }
}
