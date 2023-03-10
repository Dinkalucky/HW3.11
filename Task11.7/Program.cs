using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass.FactoryMethod<int>();
            //MyClass.FactoryMethod<string>();T повинен бути типом значення
        }
    }
}
