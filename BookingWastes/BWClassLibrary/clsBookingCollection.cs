using System.Collections.Generic;

namespace BWClassLibrary
{
    public class clsBookingCollection
    {

        //
        // create private member data for the AllBooking list
        private List<clsBooking> mAllBooking = new List<clsBooking>();

        //


        public List<clsBooking> AllBooking
        {//getter send data to requesting code
            get { return mAllBooking; }

            //setter accepts datafrom other objects
            set { value = mAllBooking; }
        }

        public int Count
        {//return the count property of the private list
            get { return mAllBooking.Count; }

            set { }
        }
    }
}