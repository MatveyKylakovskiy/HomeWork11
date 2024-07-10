using HomeWork11.FirstTask;
using HomeWork11.SecondTask;
using HomeWork11.ThirdTask;
using HomeWork11.ThirdTask.Engines;

//First task
MyList<int> list = new MyList<int>() { 1, 2, 3, 4, 5, 1 };
list.Notify += Handler.DisplayMessage; 

list.Add(1);
list.Remove(2);
int count = list.Count;
var tmp = list[4];


//Second task

/*var tmp = new Point();
var tmp2 = new Point(4, 6);

var x = tmp.GetPoint("x");
var y = tmp2.GetPoint("y");

tmp.GetInfo();
tmp2.GetInfo();

Console.WriteLine(" ");*/

//Third task
/*
var dieselEngine = new DieselEngine("tdi3.4", 150, 100, 5.4);
var petrolEngine = new PetrolEngine("rb42", 240, 70, 10);
var electricEngine = new ElectricMotor("electro", 500, 40000, 400);

var ford = new Car("mondeo", new DateTime(2006, 05, 04), dieselEngine);
var nissan = new Car("sky", new DateTime(1999, 06, 05), petrolEngine);
var tesla = new Car("x", new DateTime(2023, 04, 04), electricEngine);

try
{
    ford.Move(100);
}

catch (EmptyTankException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    nissan.Move(100);
}

catch (EmptyTankException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    tesla.Move(100);
}

catch (EmptyTankException ex)
{
    Console.WriteLine(ex.Message);
}*/