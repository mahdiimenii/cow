using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cow
{
    public class Cow : animal, IComparable, IEnumerable
    {
        public DateTime BirthDate { get; init; }
        public static readonly int MaxLife;
        public List<Environment> CowList;
        public static int Number;
        public List<Cowparameter> cowparameters;

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
