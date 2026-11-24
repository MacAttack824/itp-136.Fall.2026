using System;
using System.Collections.Generic;
using System.Text;

namespace ITP._136.FinalProject
{
    public class Person            //Parent Class : base
    {
        //Must have constructor (20 points)
        public Person(string fn, string ln, string address)
        {
            FirstName = fn;
            LastName = ln;
            Address = address;
        }

        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
