using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            var newCustomer = new Customer();

            newCustomer.CustomerCode = "123";
            newCustomer.CustomerName = "Mayur";
            //call only the add method instead of call Add(), Validate() and createdbobject
            //Code is simplified
            newCustomer.Add();

            //Example 2
            var newReservation = new Reservation();

            newReservation.RoomNumber = "23";
            newReservation.RoomType = "Suite";
            newReservation.Duration = 2;

            newReservation.ReserverRoom();

        }
    }
}
