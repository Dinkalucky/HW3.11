using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._4
{
    public class MyArrayList
    {
        public ArrayList arrayList = new ArrayList();
        public void AddElement(string newElement)
        {
            arrayList.Add(newElement);
        }

        public string this[int index]
        {
            get => (string)arrayList[index];
        }

        public int NumberOfElements
        {
            get { return arrayList.Count; }
        }

        public void ClearCollection()
        {
            arrayList.Clear();
        }

        public void RemoveElement(int index)
        {
            arrayList.RemoveAt(index);
        }
    }
}
