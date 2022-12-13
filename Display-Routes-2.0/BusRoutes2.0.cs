using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Routes_2._0
{
    public class BusRoutes2
    {
        public int Number { get; }
        public string Origin => PlaceServed[0];
        public string Destination => PlaceServed[^1];

        public string[] PlaceServed { get; }
        public BusRoutes2(int number, string [] placeServed)
        {
            this.Number = number;
            this.PlaceServed = placeServed;

        }
        public override string ToString()
        {
            return $"{Number}: {Origin} -> {Destination}";
        }
        public bool Serves(string destination)
        {
            return Array.Exists(PlaceServed, place => place == destination);
            //foreach(string place in PlaceServed)
            //{
            //    if(place == destination) 
            //        return true ;
            //}
            //return false ;
        }
    }
}
