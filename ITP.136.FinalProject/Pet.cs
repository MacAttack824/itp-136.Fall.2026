using System;
using System.Collections.Generic;
using System.Text;

namespace ITP._136.FinalProject
{
    public class Pet
    {
        public Pet(int petID, string petName, string petSpecies, Owner petOwnerID)
        {
            PetID = petID;
            PetName = petName;
            PetSpecies = petSpecies;
            PetOwnerID = petOwnerID;
        }

        public int PetID { get; set; }
        public string PetName { get; set; }
        public string PetSpecies { get; set; }
        public Owner PetOwnerID { get; set; }

    }
}
