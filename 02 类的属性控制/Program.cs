using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_类的属性控制
{
    class Program
    {
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0 && value < 70)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("输入数据不合理");
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            while (true)
            {
                Console.Write("请输入年龄");
                p.Age = Convert.ToInt16(Console.ReadLine());
            }
        }
    }
}
