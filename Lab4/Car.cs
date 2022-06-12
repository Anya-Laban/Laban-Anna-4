using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Car : Vantazhoperevisnyk
    {
        public Car(double weight_cargo)
        {
            if (weight_cargo <= Max_Weight_cargo)
            {
                Weight_cargo = weight_cargo;//тони
            }
            else Weight_cargo = Max_Weight_cargo;
        }
        public override int Max_Weight_cargo { get; } = 15;//ton
        public override double Distance_of_transportation { get; protected set; }
        public override double Speed { get; } = 80;//km/god
        public override double fuel_price { get; } = 50;
        public override double fuel_ponsumption { get; } = 20;
        public override List<City> Cities { get; } = new List<City>() { new City("Київ", "Харків", 479), new City("Київ", "Львів", 541), new City("Львів", "Івано-Франківськ", 134), new City("Запоріжжя", "Харків", 320) };

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
        public override void ShowCities()
        {
            Console.WriteLine("Мiста, в якi здiйснюється перевезення автомобілем: ");
            base.ShowCities();
        }


    }
}
