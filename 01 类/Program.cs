using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_类
{
    class Program
    {
        static double r;
        const double PI = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("请输入圆的半径：");
            Program.r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("圆的面积为：" + PI * Math.Pow(r, 2));
            Console.ReadLine();
        }
    }
}
