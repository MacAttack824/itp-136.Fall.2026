using System;
using System.Collections.Generic;
using System.Text;

namespace ITP._136.FinalProject
{
    public class Vet : Person            //Inherited Class Person
    {
        public Vet(string fn, string ln, string address, int empId) :base (fn, ln, address) 
        {
            EmpId = empId;
        }
        public int EmpId { get; set; }

    }
}
