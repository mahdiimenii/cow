using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cow
{
    public class Environment
    {
        public Healthparameter<int> TDS;
        public Healthparameter<int> Temp;
        public Healthparameter<int> Density;
        public Healthparameter<int> db;
        public Healthparameter<int> AQI;
        public Healthparameter<int> OX;
        public DateOnly Date;
    }
}
