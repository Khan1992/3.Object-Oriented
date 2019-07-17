using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_构造函数
{
    class Program
    {
        public int age;
        public Program(int a)
        {
            age = a;
            Console.WriteLine("执行有参构造函数");
        }
        static void Main(string[] args)
        {
            Program p = new Program(10);
            Console.WriteLine("p的age值为" + p.age);
            Console.ReadLine();
        }
    }
}
