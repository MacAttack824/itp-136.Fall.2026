using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module._13.HW.Inheritance
{
    public class Person 
        //For this assignment you are to do the following:
        // 1.Person Class
        // This class will have the following three properties: idNum, fullName, address
    {
        public Person(int idNum, string fullName, string address) 
        {
            IDNum = idNum;   // assignments
            FullName = fullName;
            Address = address;
        }
        public int IDNum { get; set; }  // properties
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}
