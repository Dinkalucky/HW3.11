using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._2
{
    public class CarCollection<T>
    {
        public List<string> carCollection = new List<string>();
        public void AddCar(string name, int year)
        {
            carCollection.Add($"{name} - {year}");
        }

        public string this[int index]
        {
            get => carCollection[index];
        }

        public int NumberOfElements
        {
            get { return carCollection.Count; }
        }

        public void ClearCollection()
        {
            carCollection.Clear();
        }
    }
}
