using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_析构函数
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();             // 创建类的实例
            Console.ReadLine();
        }

        class A                         // 基类First
        {
            ~A()                        // 析构函数
            {
                Console.WriteLine("~A()析构函数");
            }
            public A()
            {                            // 构造函数
                Console.WriteLine("A()构造函数");
            }
        }
        class B : A                     // B类从A类派生
        {
            ~B()                        // 析构函数
            {
                Console.WriteLine("~B()析构函数");
            }
            public B()                   // 构造函数
            {
                Console.WriteLine("B()构造函数");
            }
        }
        class C : B                     // C类从B类派生
        {
            ~C()                        // 析构函数
            {
                Console.WriteLine("~C()析构函数");
            }
            public C()                  // 构造函数
            {
                Console.WriteLine("C()构造函数");
            }
        }
    }
}
