using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10CW
{
    public class Employee
    {
        // property variables
        int empId;
        string fName, lName;

        // property
        public int EmployeeId
        {
            get {return empId; }  //get method
            set {empId = value; } //set method
        }
        public string LastName
        {
        get {return lName; }
        set {lName = value; }
        }
        public string FirstName
        {
        get {return fName; }
        set {fName = value; }            
        }   
    }    
}