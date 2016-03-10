using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1068. Сумма
            int num = 0, sum = 0;
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                sum = 1;
            }
            else if (num > 0)
            {
                sum = (1 + num) * num / 2;
            }
            else
                sum = (-1 + num) * (-num) / 2 + 1;
            Console.WriteLine(sum);
        }

    }
}
