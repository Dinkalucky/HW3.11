using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._7
{
    public static class MyClass
    {
        public static T FactoryMethod<T>() where T : new()
        {
                T tElement = new T();
                return tElement;
        }
    }
}
