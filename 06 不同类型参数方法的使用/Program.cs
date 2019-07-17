using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_不同类型参数方法的使用
{
    class Program
    {
        private int Add(int x, int y)
        {
            x = x + y;
            return x;
        }
        private int Add(ref int x, int y)
        {
            x = x + y;
            return x;
        }
        private int Add(int x, int y, out int z)
        {
            z = x + y;
            return z;
        }
        private int Add(params int[] x)
        {
            int result = 0;
            for (int i = 0; i < x.Length; i++)
            {
                result += x[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Program pro = new Program();
            int x = 30;
            int y = 40;
            int z;
            Console.WriteLine("值参数的使用:" + pro.Add(x, y));
            Console.WriteLine("值参数中实参X的值:" + x);
            Console.WriteLine("ref参数的使用:" + pro.Add(ref x,y));
            Console.WriteLine("ref参数中实参x的值:" + x);
            Console.WriteLine("out参数的使用:" + pro.Add(x,y,out z));
            Console.WriteLine("param参数的使用:" + pro.Add(20, 30, 40, 50, 60));
            Console.ReadLine();
        }
    }
}
