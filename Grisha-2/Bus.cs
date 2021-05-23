using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grisha_2
{
    class Bus : Ticket
    {
        private int placeNumber;
        public Bus(int placeNumber, int price, string departurePoint, DateTime departureTime)
        {
            this.placeNumber = placeNumber;
            this.price = price;
            this.departurePoint = departurePoint;
            this.departureTime = departureTime;

            
        }
        public override void printInfo()
        {
            Console.WriteLine("Номер места: {0}", this.placeNumber);

            this.printBaseInfo();
        }
    }
}
