using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cow
{
    public class Sheep
    {
        public DateTime BirthDate { get; init; }
        public static readonly int MaxLife;
        public List<Environment> CowList;
        public static int Number;
        public List<Cowparameter> cowparameters;
    }
}
