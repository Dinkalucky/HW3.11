using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection<int> myList = new CarCollection<int>();

            myList.AddCar("BMW",1990);
            myList.AddCar("Audi", 1900);
            myList.AddCar("Lanos", 2013);
            myList.AddCar("Jeep",2020);
            myList.AddCar("Opel", 2023);
            myList.AddCar("Lada", 1963);

            Console.WriteLine(myList[2]);
            Console.WriteLine(myList.NumberOfElements);

            foreach (var element in myList.carCollection)
            {
                Console.Write(element);
                Console.Write("\n");
            }

            Console.WriteLine("\nClean");
            myList.ClearCollection();

            foreach (var element in myList.carCollection)
            {
                Console.Write(element);
                Console.Write(" ");
            }

            Console.ReadLine();
        }
    }
}
