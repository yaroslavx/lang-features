using oop;

// Character c = new Character();
// c.Hit(1);

// Console.WriteLine(c.Health);

// Calculator.GetTriangleSquare(b: 2, h: 5);
// Console.WriteLine(calc.Average(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

// bool isSuccess = int.TryParse("17", out int result);
// Console.WriteLine(result);

// Calculator.TryDivide(15, 17, out double result);
// Console.WriteLine(result);

// Character c1 = new Character();
// Character c2 = new Character();

// c2.IncreaseSpeed();
// c1.PrintSpeed();

// PointVal a;
// a.X = 3;
// a.Y = 4;
//
// PointVal b = a;
// b.X = 7;
// b.Y = 8;

// a.LogValues();
// b.LogValues();

// PointRef c = new PointRef();
// c.X = 3;
// c.Y = 4;
//
// PointRef d = c;
// d.X = 7;
// d.Y = 8;

// c.LogValues();
// d.LogValues();

// EvilStruct ev1 = new EvilStruct();
// ev1.PointRef = new PointRef() { X = 3, Y = 4 };
//
// EvilStruct ev2 = ev1;
// ev2.PointRef.X = 5;
// ev2.PointRef.Y = 6;

// ev1.PointRef.LogValues();
// ev2.PointRef.LogValues();

// List<int> list = new List<int>();
// AddNumbers(list);
//
// foreach (var item in list)
// {
//     Console.WriteLine(item);
// }

int a = 1;
int b = 2;

Swap(ref a, ref b);

Console.WriteLine(a);
Console.WriteLine(b);

static void Swap(ref int a, ref int b) 
{
    Console.WriteLine($"Original: a = {a}, b = {b}");

    (a, b) = (b, a);

    Console.WriteLine($"Swap: a = {a}, b = {b}");
}

static void AddNumbers(List<int> numbers)
{
    numbers.Add(1);
    numbers.Add(2);
    numbers.Add(3);
}