using System;
using System.Collections.Generic;
using System.Text;

namespace ITP._136.FinalProject
{
    public class Owner : Person             //Inherited Class Person
    {
        public Owner(string fn, string ln, string address, int ownerId) : base(fn, ln, address)
        {
            OwnerId = ownerId;
        }
        public int OwnerId { get; set; }
    }
}
