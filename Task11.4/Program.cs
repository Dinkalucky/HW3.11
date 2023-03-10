using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArrayList myArrayList = new MyArrayList();

            myArrayList.AddElement("Element 1");
            myArrayList.AddElement("Element 2");
            myArrayList.AddElement("Element 3");
            myArrayList.AddElement("Element 4");
            myArrayList.AddElement("Element 5");
            myArrayList.AddElement("Element 6");

            Console.WriteLine(myArrayList[2]);
            Console.WriteLine(myArrayList.NumberOfElements);

            foreach (var element in myArrayList.arrayList)
            {
                Console.Write(element);
                Console.Write("\n");
            }

            Console.WriteLine("\nRemove element");
            myArrayList.RemoveElement(4);

            foreach (var element in myArrayList.arrayList)
            {
                Console.Write(element);
                Console.Write(" ");
            }

            Console.WriteLine("\nClean");
            myArrayList.ClearCollection();

            foreach (var element in myArrayList.arrayList)
            {
                Console.Write(element);
                Console.Write(" ");
            }

            Console.ReadLine();
        }
    }
}
