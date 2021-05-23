using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grisha_2
{
    class Train : Ticket
    {
        private string serviceClass;
        private int carriageNumber;
        private int placeNumber;

        public Train(string serviceClass, int carriageNumber, int placeNumber, int price, string departurePoint, DateTime departureTime)
        {
            this.serviceClass = serviceClass;
            this.carriageNumber = carriageNumber;
            this.placeNumber = placeNumber;

            this.price = price;
            this.departurePoint = departurePoint;
            this.departureTime = departureTime;
        }
        public override void printInfo()
        {
            Console.WriteLine("Класс обслуживания: {0}", this.serviceClass);
            Console.WriteLine("Номер вагона: {0}", this.carriageNumber);
            Console.WriteLine("Номер места: {0}", this.placeNumber);

            this.printBaseInfo();
        }
    }
}
