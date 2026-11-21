using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module._13.CW
{
    public class Salary : Employee
    {
        public Salary(int num, string fn, double sal) : base (num, fn)
        {
            SalaryAmount = sal;
        }

        public double SalaryAmount { get; set; }
    }
}
