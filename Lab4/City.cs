using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class City
    {
        public City(string city_1, string city_2, int distance)
        {
            City_1 = city_1;
            City_2 = city_2;
            Distance = distance;
        }
        public string City_1 { get; init; }
        public string City_2 { get; init;}
        public int Distance { get; init; }
        
        
    }
}
