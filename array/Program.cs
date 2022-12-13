using System;
namespace DisplayRoutes
{
    public class program
    {
        static void Main(string[] args)
        {
            BusRoutes Route40 = new BusRoutes(40, "Sanaganeri gate", "Mansorover");
            BusRoutes Routes41 = new BusRoutes(41, "Ajmer gate", "amer");


            Console.WriteLine("enter the number of routes you want to enter : ");
            int size = Convert.ToInt32(Console.ReadLine());
            BusRoutes[] routes = new BusRoutes[size];
            int r; string origin, destination;
            for(int i = 0; i < routes.Length; i++)
            {
                Console.WriteLine("enter the route number");
                r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the origin");
                origin = Console.ReadLine();
                Console.WriteLine("enter the destination");
                destination = Console.ReadLine();

                routes[i] = new BusRoutes(r, origin, destination);



                if (i == routes.Length - 1)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("enter new route");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("All Routes are :");
            Console.ForegroundColor = ConsoleColor.White;

            for(int i = 0; i < routes.Length; i++)
            {
                Console.WriteLine($"{i} : {routes[i]}");
            }
            //foreach(var route in routes)
            //{
            //    Console.WriteLine(route);
            //}

            //Console.WriteLine(routes[3]);
        }
    }
}