using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceApp
{
    class ProductionWorker :Employee
    {
        public int Shift {get; set;}
        public double HourlyPayRate {get; set;}
    }
}
