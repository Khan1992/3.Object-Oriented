using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_静态构造参数
{
    class Program
    {
        static Program()                    //静态构造函数值执行一次
        {
            Console.WriteLine("static");
        }

        private Program()
        {
            Console.WriteLine("实例构造参数");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Program p2 = new Program();
            Program p3 = new Program();
            Console.ReadLine();
        }
    }
}
