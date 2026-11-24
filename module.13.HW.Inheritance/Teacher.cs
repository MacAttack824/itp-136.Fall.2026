using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module._13.HW.Inheritance
{
    public class Teacher : Person //  x : Person brings in parent Class   // declare class

        //For this assignment you are to do the following:
        // 3. Teacher Class
        // This class will extend the Person Class and have the following properties two
        // properties: salary and years of service

        // visual from Person class  :  public Person(int idNum, string fullName, string address) Inherited class
    {
        public Teacher(int idNum, string fullName, string address, int salary, int yearsOfService) : base(idNum, fullName, address) // base brings in Parent class , constructor

        {
            Salary = salary; //Assignments
            YearsOfService = yearsOfService;
        }
        public int Salary { get; set; }   //Properties
        public int YearsOfService { get; set; }
    }
}
