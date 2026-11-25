using System;
using System.Collections.Generic;
using System.Text;

namespace ITP._136.FinalProject
{
    public class Appointment
    {
        public Appointment( int apptID, DateTime apptDateTime, Pet apptPet, Vet apptVet, string reason)
        {
            ApptID = apptID;
            ApptDateTime = apptDateTime;
            ApptPet = apptPet;
            ApptVet = apptVet;
            Reason = reason;

        }
        public int ApptID { get; set; }
        public DateTime ApptDateTime { get; set; }
        public Pet ApptPet { get; set; }
        public Vet ApptVet { get; set; }
        public string Reason { get; set; }
    }
}
