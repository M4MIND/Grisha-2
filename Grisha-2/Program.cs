using System;

namespace Grisha_2
{
    class Program
    {
        private static Ticket[] collection = new Ticket[] {
            new Air("S7", "Бизнес", 3000, "Москва", new DateTime(2021, 6, 1)),
            new Air("Победа", "Не бизнес", 1500, "Москва", new DateTime(2021, 7, 11)),
            new Train("Бизнес", 12, 32, 2000, "Пермь", new DateTime(2021, 6, 9)),
            new Train("Не бизнес", 23, 15, 1800, "Пермь", new DateTime(2021, 6, 11)),
            new Bus(12, 120, "Кукуштан", new DateTime(2021, 6, 10)),
            new Bus(16, 120, "Кукуштан", new DateTime(2021, 6, 11)),
            new Bus(8, 120, "Кукуштан", new DateTime(2021, 6, 12)),
            new Bus(3, 120, "Кукуштан", new DateTime(2021, 6, 10))
        };
        static void Main(string[] args)
        {
            printAllTickets();

            while (true)
            {
                Console.WriteLine("Поиск билета. Введите значение место отбытия:");
                
                string place = Console.ReadLine();

                Console.WriteLine("Поиск билета. Введите дату отбытия: YYYY.MM.DD");

                string [] dateInput = Console.ReadLine().Split(".");

                DateTime date = new DateTime(int.Parse(dateInput[0]), int.Parse(dateInput[1]), int.Parse(dateInput[2]));

                Console.WriteLine(date.ToString());

                foreach(Ticket ticket in collection)
                {
                    if (ticket.searchEq(place, date))
                    {
                        Console.WriteLine("===================================");
                        ticket.printInfo();
                        Console.WriteLine("===================================");
                    }
                }
            }
        }

        private static void printAllTickets()
        {
            Array.Sort(collection, (a, b) =>
            {
                return a.Price - b.Price;
            });

            foreach (Ticket ticket in collection)
            {
                ticket.printInfo();

                Console.WriteLine();
                Console.WriteLine("================================");
                Console.WriteLine();
            }
        }
    }
}
