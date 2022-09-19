using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsClassProject
{
    internal class Employe
    {
        public string Name { set; get; }
        public int Age { set; get; }

        public decimal Salary { set; get; }

        public static bool operator >(Employe e1, Employe e2)
        {
            return e1.Salary > e2.Salary;
        }

        public static bool operator <(Employe e1, Employe e2)
        {
            return e1.Salary > e2.Salary;
        }
    }
}
