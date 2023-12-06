using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cow
{
    public class Cowparameter
    {
        public int  TimeToStand { get; set; }
        public Healthparameter<int> TimeToDeal { get; set; }
        public Healthparameter<int> TimeToRelax { get; set; }
        public Healthparameter<int> NumberOfMeal { get; set; }
        public Healthparameter<int> NumberOfMilkProduction { get; set; }
        public DateTime Date { get; set; }
    }
}
