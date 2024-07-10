
namespace HomeWork11.SecondTask
{
    public class Point
    {
        private double _x;
        private double _y;

        public Point()
        {
            _x = 1;
            _y = 1;
        }

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double GetPoint(string point)
        {
            if (point == "x")
            {
                return _x;
            }
            if (point == "y")
            {
                return _x;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"X: {_x}; Y: {_y}");
        }

    }
}







/*
Реализовать класс Point, который определяет точку на координатной плоскости.
В классе реализовать:
внутренние поля x, y;
конструктор с 2 параметрами;
свойства доступа к внутренним полям класса;
метод, выводящий значения внутренних полей класса.*/