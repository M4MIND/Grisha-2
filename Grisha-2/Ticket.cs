using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grisha_2
{
    abstract class Ticket
    {
        protected int price;
        protected string departurePoint;
        protected DateTime departureTime;

        public int Price { get => price; }
        public string DeparturePoint { get => departurePoint; }

        public abstract void printInfo();

        public void printBaseInfo()
        {
            Console.WriteLine("Стоимость: {0}", this.Price);
            Console.WriteLine("Место отбытия: {0}", this.DeparturePoint);
            Console.WriteLine("Время отбытия: {0}", this.departureTime.ToString());
        }

        public bool searchEq(string place, DateTime date)
        {
            return this.departurePoint.Contains(place) && departureTime.CompareTo(date) == 0;
        }
    }
}
