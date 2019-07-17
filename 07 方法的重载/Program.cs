using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_方法的重载
{
    class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public double Add(int x, double y)
        {
            return x + y;
        }
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        
        static void Main(string[] args)
        {
            Program program = new Program();
            int x = 3;
            int y = 5;
            int z = 7;
            double y2 = 5.5;
            //根据传入的参数类型及参数个数的不同调用不同的Add重载方法
            Console.WriteLine("第1种重载形式：" + x + "+" + y + "=" + Program.Add(x,y));
            Console.WriteLine("第2种重载形式：" + x + "+" + y2 + "=" + program.Add(x, y2));
            Console.WriteLine("第3种重载形式：" + x + "+" + y + "+" + z + "=" + program.Add(x, y, z));

            Console.ReadLine();
        }
    }
}
