using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRoutes
{
     class BusRoutes
    {
        public int Number { get;}
        public string Origin { get;}
        public string Destination { get;}
        public BusRoutes(int number, string orgin, string destination)
        {
            this.Number = number;
            this.Origin = orgin;
            this.Destination = destination;

        }
        public override string ToString()
        {
            return $"{Number}: {Origin} -> {Destination}";
        }
    }
}
