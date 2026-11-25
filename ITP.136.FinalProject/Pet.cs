using System;
using System.Collections.Generic;
using System.Text;

namespace ITP._136.FinalProject
{
    public class Pet : Owner
    {
        public Pet(string fn, string ln, string address, int ownerId, int petID, string petName, string petSpecies) : base(fn, ln, address, ownerId)
        {
            PetID = petID;
            PetName = petName;
            PetSpecies = petSpecies;
        }

        public int PetID { get; set; }
        public string PetName { get; set; }
        public string PetSpecies { get; set; }

    }
}
