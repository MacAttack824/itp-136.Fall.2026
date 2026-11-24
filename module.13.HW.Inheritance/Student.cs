using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module._13.HW.Inheritance
{
    public class Student : Person  //declare class , Person as Parent class

        //For this assignment you are to do the following:
        // 2. Student Class
        // This class will extend the Person Class and have the following properties two
        // properties: major and advisor
        
        // visual from Person class  :  public Person(int idNum, string fullName, string address)  Inherited class
    {
        public Student( int idNum, string fullName, string address, string major, string advisor) : base(idNum, fullName, address) // : BASE    Calls the base class constructor
        
        {
            Major = major;   // assignments
            Advisor = advisor;
        }
        public string Major { get; set; } // properties
        public string Advisor { get; set; }
    }
}
