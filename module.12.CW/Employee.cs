using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace module._12.CW
{
    public class Employee
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
            lname = ln;
            fname = fn;
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
