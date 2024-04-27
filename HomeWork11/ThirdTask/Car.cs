
namespace HomeWork11.ThirdTask
{
    public class Car
    {
        private string _model;
        private DateTime _yearOfRelease;
        public Engine Engine { get; set; }

        public Car(string model, DateTime yearOfRelease, Engine engine)
        {
            _model = model;
            _yearOfRelease = yearOfRelease;
            Engine = engine;
        }

        public void Move(double distance)
        {
            if (!Engine.UseFuel(distance))
            {
                Console.WriteLine("The car can't move");
            }

            Console.WriteLine($"Lets move");
        }
    }
}







/*
Реализовать класс машина у который будет поле обобщенное двигатель. Создать
иерархию наследования для двигателей (абстрактный, дизельный, бензиновый,
електро). Сделать так чтобы создать автомобиль можно было только передавая
туда один из типов двигателя. Реализовать методы для движения автомобиля.*/