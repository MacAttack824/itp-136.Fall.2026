using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace module._12.CW
{
    internal class Employee
    {
        // variables
        int employeeNum;
        double salary;
        string lname, fname, position;

        // constructor
        public Employee(int empNum, double s, string ln, string fn, string pos)
        {
            employeeNum = empNum;
            salary = s;
            lastName = ln;
            firstname = fn;
            position = pos;
        }



        // properties
        public int EmployeeNumber
        {
            get { return employeeNum; }
            set { employeeNum = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }
        public string FirstName
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}
