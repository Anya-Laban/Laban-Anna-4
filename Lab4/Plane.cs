using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Plane : Vantazhoperevisnyk
    {
        public Plane(double weight_cargo)
        {
            if (weight_cargo <= Max_Weight_cargo)
            {
                Weight_cargo = weight_cargo;//тони
            }
            else Weight_cargo = Max_Weight_cargo;
        }
        public override int Max_Weight_cargo { get; } = 150;//ton
        public override double Speed { get; } = 800;//km/god
        public override double Distance_of_transportation { get; protected set; }
        public override double fuel_price { get; } = 1400;
        public override double fuel_ponsumption { get; } = 10000;
        public override List<City> Cities { get; } = new List<City>()  { new City("Київ", "Харків", 350), new City("Київ", "Львів", 500), new City("Львів", "Івано-Франківськ", 100) };

        public override void ShowCities()
        {
            Console.WriteLine("Мiста, в якi здiйснюється перевезення літаком: ");
            base.ShowCities();
        }
        public override void Choose_Distance(int num, ref bool corectNum)
        {

            if (num - 1 < Cities.Count)
            {
                for (int i = 0; i < Cities.Count; i++)
                {
                    if (num - 1 == i)
                    {
                        Distance_of_transportation = Cities[i].Distance;
                        corectNum = false;
                    }
                }
            }
            else corectNum = true;
        }

    }
}
