using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Капралов324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, result, result2,result3,result4;
            double resultR,r,r2;
            Console.WriteLine("1 число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 число");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сложение");
            result = a + b;
            Console.WriteLine("Ответ: " + result);
            Console.WriteLine("Вычитание");
            result2 = a - b;
            Console.WriteLine("Ответ: " + result2);
            Console.WriteLine("Умножение");
            result3 = a * b;
            Console.WriteLine("Ответ: " + result3);

            Console.WriteLine("Введите радиус круга");
            r = Convert.ToDouble(Console.ReadLine());
            resultR = Math.PI*(r*2);
            Console.WriteLine("Ответ: " + resultR);
            resultR = r*r;
            Console.WriteLine("Ответ: " + resultR);
            Console.WriteLine("Вторую сторону");
            r2 = Convert.ToDouble(Console.ReadLine());
            resultR = Math.PI * (r2 * 2);
            Console.WriteLine("Ответ: " + resultR);




        }
    }
}
