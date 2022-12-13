using Display_Routes_2._0;
using System;
using static System.Collections.Specialized.BitVector32;

namespace Display_Routes_2
{
    public class busMain
    {
        static void Main(string[] args)
        {
            BusRoutes2[] allRoutes = BusRouteRepository.IntializeRoute();

            Console.WriteLine("where you want to go ? ");
            string loction = Console.ReadLine();

            BusRoutes2 route = FindBusTo(allRoutes, loction);
            if (route != null)
            {
                Console.WriteLine($"you can use that route {route}");

            }
            else
            {
                Console.WriteLine($"No route go to these {loction}");
            }

            BusRoutes2 [] route2 = FindBusesTo(allRoutes, loction);
            if(route2.Length > 0) {
                foreach (BusRoutes2 routee in route2)
                {
                    Console.WriteLine($"you can use route {routee}");
                }

            }
            else
            {
                Console.WriteLine($"No route go to these {loction}");
            }
        }
        public static BusRoutes2 FindBusTo( BusRoutes2 [] routes, string loction)
        {
            foreach(BusRoutes2 route in routes )
            {
                if(route.Origin == loction || route.Destination == loction)
                {
                    return route;
                }
         
            }

            return Array.Find(routes, route => route.Origin == loction || route.Destination == loction);
            //return null;

        }
        public static BusRoutes2[] FindBusesTo(BusRoutes2[] routes, string loction)
        {
            return Array.FindAll(routes, route => route.Serves(loction));
        } 
    }
}