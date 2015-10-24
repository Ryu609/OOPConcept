using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concept
{
    #region Encapsulation Example one
    public class Customer
    {

        public string CustomerCode = "";
        public string CustomerName = "";

        public void Add()
        {
            // Add to database
            Validate();
            CreateDBObjects();

            Console.WriteLine("if Validation and CreateDBObject is successful, the CustomerCode and CustomerName will be Inserted in the DB");
            Console.ReadLine();

        }

        //set as private [Encapsulation] to decrease complexity
        private bool Validate()
        {
            //Validation of Data goes here
            //return true or false
            return true;
        }
        //set as private [Encapsulation] to decrease complexity
        private bool CreateDBObjects()
        {
            //create db connections
            //return true or false
            return true;
        }
    }
    #endregion

    #region Encapsulation Example Two
    public class Reservation
    {
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public int Duration { get; set; }

        public void ReserverRoom()
        {
            //Reserve room depending on value of IsAvailable
           IsAvailable();
        }

        private bool IsAvailable()
        {
            //Verify if room is available
            return true;

        }
    }


    #endregion
}
