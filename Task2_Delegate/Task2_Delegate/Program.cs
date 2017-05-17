using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Delegate
{
    public delegate string PrintDelegate(string s, int b);
    class Sample
    {
        public string MyFunction(string s, int b)
        {
            string str = "";
            for (int i = 0; i < b; i++)
                str += s;
            return str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample h = new Sample();
            PrintDelegate d = h.MyFunction;
            Console.WriteLine(d.Invoke("Test", 10));
            Console.ReadKey();
        }
    }
}
