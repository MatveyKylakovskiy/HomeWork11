
using HomeWork11.ThirdTask.Engines;

namespace HomeWork11.ThirdTask
{
    public abstract class Engine
    {
        private string _model;
        private int _horsepower;
        private double _amountOfFuel;
        private double _fuelConsumption;

        public Engine(string model, int horsepower, double amountOfFuel, double fuelConsumption)
        {
            _model = model;
            _horsepower = horsepower;
            _amountOfFuel = amountOfFuel;
            _fuelConsumption = fuelConsumption;
        }

        public bool UseFuel(double distance)
        {
            if (_amountOfFuel < 0)
            {
                throw new EmptyTankException("The tank is empty");
            }

            if (_fuelConsumption * distance > _amountOfFuel)
            {
                throw new EmptyTankException("The amount of fuel is not enough");
            }

            _amountOfFuel -= _amountOfFuel * distance;
            return true;
        }
    }
}





/*
Реализовать класс машина у который будет поле обобщенное двигатель. Создать
иерархию наследования для двигателей (абстрактный, дизельный, бензиновый,
електро). Сделать так чтобы создать автомобиль можно было только передавая
туда один из типов двигателя. Реализовать методы для движения автомобиля.*/