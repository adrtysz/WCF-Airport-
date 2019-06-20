using System;
using System.ServiceModel;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            AirportClient client = new AirportClient();

            string fromCity;
            string destinationCity;
            string departureTime;
            string arrivalTime;
            string odp;
            TimeSpan dT;
            TimeSpan aT;


            Console.WriteLine("WSZYSTKIE POLACZENIA - W, KONKRETNE POLACZENIE - K");
            odp = Console.ReadLine();

            if (odp.ToLower() == "k")
            {

                Console.WriteLine("Witaj, podaj miasta miedzy ktorymi chcesz znalezc polaczenie, oraz przedzial czasowy w formie HH:mm");
                Console.WriteLine();

                Console.WriteLine("Miasto startowe: ");
                fromCity = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Miasto docelowe: ");
                destinationCity = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Godzina odlotu: ");
                departureTime = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Godzina przylotu na miejsce: ");
                arrivalTime = Console.ReadLine();
                Console.WriteLine();

                dT = TimeSpan.Parse(departureTime);
                aT = TimeSpan.Parse(arrivalTime);

                try
                {
                    Timetable timetable = new Timetable();
                    timetable.AddConnections(client.GetConnections(fromCity, destinationCity, dT, aT));
                    timetable.Show();
                }
                catch (FaultException<ConnectionNotFoundFault> fault)
                {
                    Console.WriteLine(fault.Detail.Message);
                }


                Console.ReadKey();
                client.Close();
            } else if(odp.ToLower() == "w")
            {
                Console.WriteLine("Miasto startowe: ");
                fromCity = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Miasto docelowe: ");
                destinationCity = Console.ReadLine();
                Console.WriteLine();

            
                dT = TimeSpan.Parse("00:00");
                aT = TimeSpan.Parse("23:59");

                try
                {
                    Timetable timetable = new Timetable();
                    timetable.AddConnections(client.GetConnections(fromCity, destinationCity, dT, aT));
                    timetable.Show();
                }
                catch (FaultException<ConnectionNotFoundFault> fault)
                {
                    Console.WriteLine(fault.Detail.Message);
                }


                Console.ReadKey();
                client.Close();

            }
        } 
    }
}
