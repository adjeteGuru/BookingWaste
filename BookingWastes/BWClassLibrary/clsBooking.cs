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
        public int BookingId { get; set; }

        //attributes
        //private DateTime mCollectionDate; /*{ get; set; }*/
        //private string mElectrical; /*{ get; set; }*/
        //private string mHousehold; /*{ get; set; }*/
        //private int mRubbish; /*{ get; set; }*/
        //private string mTimeSlot; /*{ get; set; }*/
        //private int BookingId;/*{ get; set; }*/

        ////Encapsulation
        //public DateTime CollectionDate
        //{
        //    get
        //    {
        //        return mCollectionDate;
        //    }
        //    set
        //    {
        //        value = mCollectionDate;
        //    }
        //}


        //public string Electrical
        //{
        //    get
        //    {
        //        return mElectrical;
        //    }
        //    set
        //    {
        //        value = mElectrical;
        //    }
        //}

        //public string Household
        //{
        //    get
        //    {
        //        return mHousehold;
        //    }
        //    set
        //    {
        //        value = mHousehold;
        //    }
        //}

        //public Int32 Rubbish
        //{
        //    get
        //    {
        //        return mRubbish;
        //    }
        //    set
        //    {
        //        value = mRubbish;
        //    }
        //}

        //public string TimeSlot
        //{
        //    get
        //    {
        //        return mTimeSlot;
        //    }
        //    set
        //    {
        //        value = mTimeSlot;
        //    }
        //}







        //validation
        public string Valid(string electrical, string household, int rubbish, string collectionDate, string timeSlot)
        {//create a variable to store the error message
            string Error = "";

            //create a temporary variable to store date value
            DateTime tempDate;

           //if the new data is blank
            if (electrical.Length == 0)
            {
                //return an error message
                Error = Error + " name must not have Zero characters";
            }
            //if the new data is more than 50 characters
            if (electrical.Length > 50 )
            {
                //return an error message
                Error = Error + "Electrical name must not have more than 50 characters";
            }

            //if the new data is blank
            if (household.Length == 0)
            {
                //return an error message
                Error = Error + " name must not have Zero characters";
            }


            //if the new data is more than 50 characters
            if (household.Length > 50)
            {
                //return an error message
                Error = "household name must not have more than 50 characters";
            }

            
            //if the new data is more than 1 character
            if (rubbish > 5)
            {
                //return an error message
                Error = "Rubbish bags must not exceed 5 bags please";
            }

            //if the new data is more than 4 characters
            if (timeSlot.Length == 0)
            {
                //return an error message
                Error = "Time must be chosen please";
            }
            //if the new data is more than 4 characters
            if (timeSlot.Length > 4)
            {
                //return an error message
                Error = "Time Chosen name must not have more than 4 characters";
            }

            //execption handler
            try
            {
                //copy the collection date to the tempDate variable
                tempDate = Convert.ToDateTime(CollectionDate);

                //check to see if collection date is before current date
                if (tempDate > DateTime.Now.AddDays(-1))
             
                {
                    //record the error
                    Error = Error + "Collection date must be in the future";
                }

                //check to see if collection date is more than 2 months from current date
                if (tempDate > DateTime.Now.AddMonths(2))
                {
                    //record the error
                    Error = Error + "PLease date must be within two months from today";
                }

            }
            catch
            {
                //record the error
                Error = Error + "Please enter a valid date";
            }

            //return error
            return Error;
        }

        public bool Find(int bookingId)
        {
            return true;
        }
        
    }
}