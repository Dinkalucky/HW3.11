using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._6
{
    public class MyClass
    {
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            MyClass myClass = new MyClass();

            myArrayList.Add(1);
            myArrayList.Add("Element 2");
            myArrayList.Add(3);
            myArrayList.Add(myClass);
            myArrayList.Add(5);
            myArrayList.Add("Element 6");
            
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }

            Console.ReadLine();
        }
    }
}
