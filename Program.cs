using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoav_Faran_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert a number (1-15)");
            int stars = Convert.ToInt32(Console.ReadLine());
            while (stars < 1 || stars > 15)
            {
                Console.WriteLine("try again");
                stars = Convert.ToInt32(Console.ReadLine());
            }
            int space = stars - 1;
            int aster = 1;
            for (int i = space; i >= 0; i--)
            {
                for (int j = space; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= aster; k++)
                {
                        Console.Write("*");
                }
                Console.WriteLine();
                aster = aster + 2;
                space--;
            }
        }
    }
}
