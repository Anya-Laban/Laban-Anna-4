using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Vantazhoperevisnyk
    {
        public abstract int Max_Weight_cargo { get; }//максимальна допустима масавантажу
        public  double Weight_cargo { get; protected set; }//маса вантажу для перевезення
       
        public abstract double Distance_of_transportation { get;protected set; } // відстань в кілометрах
        public abstract double Speed { get; }//середня швидкість транспорту який перевозить
     
        public abstract List<City> Cities  { get; }// міста, між якими можна здійснити доставку

        public abstract double fuel_price { get; }//ціна за 1 літр палива
        public abstract double fuel_ponsumption { get; }//розхід палива в літрах на 100км
        public double Amount_of_fuel { get; private set; }//витрачене паливо
        public double price { get; private set; }//ціна за витрачене паливо
       
        public double time_of_transportation { get; private set; }//приблизний час, що витрачений на дорогу

        public abstract void Choose_Distance(int num, ref bool corectNum);

        public virtual void ShowCities()
        {
            for (int i = 0; i < Cities.Count; i++)
            {
                Console.WriteLine(i + 1 + ") " + Cities[i].City_1 + " - " + Cities[i].City_2 + " -> " + Cities[i].Distance + " км.");
            }
        }
        public double AmountOfFuel()
        {
            Amount_of_fuel = Distance_of_transportation / 100 * fuel_ponsumption;
            return Amount_of_fuel;
        }
        public double PriceForFuel()
        {
            AmountOfFuel();
            price = Amount_of_fuel * fuel_price;
            return price;
        }
        public double Time_of_transportation()
        {
            time_of_transportation = Distance_of_transportation / Speed;
            return time_of_transportation;
        }
    }
}
