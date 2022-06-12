using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Train : Vantazhoperevisnyk
    {
        public Train(double weight_cargo)
        {
            if (weight_cargo > Max_Weight_cargo) weight_cargo = Max_Weight_cargo;

            if (weight_cargo <= TrainCar.Max_Car_Weight) trainCars.Add(new TrainCar(weight_cargo));
            else AddTrainCar(weight_cargo);
        }

        public override int Max_Weight_cargo { get; } = 1360;//ton
        public override double Speed { get; } = 50;//km/god
        public override double Distance_of_transportation { get; protected set; }
        public override double fuel_price { get; } = 8000;
        public override double fuel_ponsumption { get; } = 9000;
        public override List<City> Cities { get; } = new List<City>() { new City("Київ", "Харків", 488), new City("Запоріжжя", "Харків", 357), new City("Київ", "Львів", 713), new City("Львів", "Івано-Франківськ", 130) };

        private List<TrainCar> trainCars = new List<TrainCar>();
        
        public void AddTrainCar(double weight_cargo)
        {
            while (weight_cargo >= 0)
            {
                trainCars.Add(new TrainCar(weight_cargo));
                weight_cargo -= TrainCar.Max_Car_Weight;
            }
        }
        public void ShowAllTrainCars()
        {
            //foreach (TrainCar trainCar in trainCars)
            //{
            //    Console.Write(trainCar.Weight_cargo + " - ");
            //}
            Console.WriteLine($"Кількість вагонів, які використовуються - {trainCars.Count}");
        }
        public override void ShowCities()
        {
            Console.WriteLine("\nМiста, в якi здiйснюється перевезення потягом: ");
            base.ShowCities();
        }
        public override void Choose_Distance(int num, ref bool corectNum)
        {

            if (num - 1 < Cities.Count)
            {
                for (int i = 0; i < Cities.Count; i++)
                {
                   if(num - 1 == i)
                    {
                        Distance_of_transportation = Cities[i].Distance;
                        corectNum = false;
                    }
                }
            }
            else corectNum = true;
        }
        private class TrainCar//вагон
        {
            public TrainCar(double weight_cargo)
            {
                if (weight_cargo > Max_Car_Weight) Weight_cargo = Max_Car_Weight;
                else Weight_cargo = weight_cargo;
            }
            public const double Max_Car_Weight = 68;
            public double Weight_cargo { get; set; }

        }
    }
}
