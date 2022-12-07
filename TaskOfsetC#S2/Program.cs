// // S2. Вычисления по известным формулам
// // S2.1. Составить программу:
// // а) вычисления значения функции y=7x^2+3x+6 при любом значении x.
// Console.Write($"Ведите любое число x => ");
// double x = Convert.ToDouble(Console.ReadLine());
// double y = 7 * Math.Pow(x, 2) + 3 * x + 6;
// Console.WriteLine($"Вы ввели число \"x\" = {x}" +
//                 $" \n тогда для функции y=7x^2+3x+6" +
//                 $"\n \"y\" будет равен -> {y}");

// // б) вычисления значения функции x=12a^2+7a+12 при любом значении а.
// Console.Write($"Введите любое число a => ");
// double a = Convert.ToDouble(Console.ReadLine());
// double x2 = 12 * Math.Pow(a, 2) + 7 * a + 12;
// Console.WriteLine($"Вы ввели чило \"a\" = {a}" +
//                 $"\n тогда для функции x=12a^2+7a+12" +
//                 $"\n \"x\" будет равен -> {x2}");

//S2.2. Дана сторона квадрата. Найти его периметр.
Console.Write($"Введите длину одной из сторон кадрата:  ");
string sideLength = Console.ReadLine()!;
Console.WriteLine();
Perimetr(sideLength);
void Perimetr(string length)
{
    if (double.TryParse(sideLength, out double sideLengthTrue))
    {
        double perimetr = sideLengthTrue;
        if (perimetr < 0)
        {
            Console.WriteLine($"Введите положительное число.");
        }
        else
        {
            double perimetr1 = sideLengthTrue * 4;
            Console.WriteLine($"Перимерт кватрата,\n" +
                            $"при условии длинны одной из сторон" +
                            $" равной {sideLengthTrue} ==> {perimetr1}");
        }
    }
    else Console.WriteLine($"{sideLength} является строкой.");
}

// S2.3. Дан радиус окружности. Найти ее диаметр.
Console.Write($"Введите радиус окружности: ");
string radius = Console.ReadLine()!;
Console.WriteLine();
DiameterCircumference(radius);
void DiameterCircumference(string lineSegment)
{
    if (double.TryParse(radius, out double radiusTrue))
    {
        double diamert = radiusTrue;
        if (diamert < 0)
        {
            Console.WriteLine($"Введите положительное число.");
        }
        else
        {
            double diamert1 = radiusTrue + radiusTrue;
            Console.WriteLine($"Диаметр окружности, при условии" +
                            $"длины радиуса {radius} ==> {diamert1}");
        }
    }
    else Console.WriteLine($"{radius} является строкой.");
}
