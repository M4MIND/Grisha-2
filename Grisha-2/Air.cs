using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grisha_2
{
    class Air : Ticket
    {
        private string company;
        private string serviceClass;

        public Air(string company, string serviceClass, int price, string departurePoint, DateTime departureTime)
        {
            this.company = company;
            this.serviceClass = serviceClass;
            this.price = price;
            this.departurePoint = departurePoint;
            this.departureTime = departureTime;
        }

        public override void printInfo()
        {
            Console.WriteLine("Авиакомпания: {0}", this.company);
            Console.WriteLine("Класс обслуживания: {0}", this.serviceClass);

            this.printBaseInfo();
        }

        public void Search(string place, DateTime date)
        {

        }
    }
}
