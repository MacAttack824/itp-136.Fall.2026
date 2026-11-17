using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace module._12.HW.classArraysObjects
{
    public class Part
    {
        //1.Create a Parts class
        // variables
        string partNumber; // most parts contain numbers and letter. GM (current employee) uses all numbers in their part numbers
        string partName; // Field
        string partDes;
        decimal partCost; // decimal to account for part cost 

        // constructor
        public Part(string number /* Constructor parameter */ , string name, string des, decimal cost) // whole thing is the constructor of the class
        {
            partNumber = number;  // Assignment to a field
            partName = name;
            partDes = des;
            partCost = cost;
        }

        // properties ... a.Properties for PartNum, Part Name, Part Description, and Cost
        public string PartNumber   // Property
        {
            get { return partNumber; }
            set { partNumber = value; }
        }
        public string PartName   // Property
        {
            get { return partName; }
            set { partName = value; }
        }
        public string PartDescription
        {
            get { return partDes; }
            set { partDes = value; }
        }
        public decimal PartCost
        {
            get { return partCost; }
            set { partCost = value; }
        }
    }
}
