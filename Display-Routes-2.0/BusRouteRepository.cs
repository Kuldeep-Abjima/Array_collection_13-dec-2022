using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Routes_2._0
{
    public class BusRouteRepository
    {

        public static BusRoutes2[] IntializeRoute()
        {
            return new BusRoutes2[] { 
                new BusRoutes2(40, new string[]{"jaipur","dudu","kishangarh","ajmer"}),
                new BusRoutes2(41, new string [] {"jaipur", "gujrat", "pune","goa"}),
                new BusRoutes2(42, new string[] {"alwar","jodhpur","bikaner"}),
                new BusRoutes2(43, new string[]{"alwar","jaipur","ajmer","agra"})
        };
        }
    }
}
