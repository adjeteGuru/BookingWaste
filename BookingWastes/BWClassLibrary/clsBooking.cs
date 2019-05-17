using System;

namespace BWClassLibrary
{
    public class clsBooking
    {
        public DateTime CollectionDate { get; set; }
        public string Electrical { get; set; }
        public string Household { get; set; }
        public int Rubbish { get; set; }
        public string TimeSlot { get; set; }

        public string Valid(string electrical, string household, int rubbish, DateTime collectionDate, string timeSlot)
        {
            throw new NotImplementedException();
        }
    }
}