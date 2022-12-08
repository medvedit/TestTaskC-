// S2. Вычисления по известным формулам
// S2.1. Составить программу:
// а) вычисления значения функции y=7x^2+3x+6 при любом значении x.
Console.Write($"Ведите любое число x => ");
double x = Convert.ToDouble(Console.ReadLine());
double y = 7 * Math.Pow(x, 2) + 3 * x + 6;
Console.WriteLine($"Вы ввели число \"x\" = {x}" +
                $" \n тогда для функции y=7x^2+3x+6" +
                $"\n \"y\" будет равен -> {y}");

// б) вычисления значения функции x=12a^2+7a+12 при любом значении а.
Console.Write($"Введите любое число a => ");
double a = Convert.ToDouble(Console.ReadLine());
double x2 = 12 * Math.Pow(a, 2) + 7 * a + 12;
Console.WriteLine($"Вы ввели чило \"a\" = {a}" +
                $"\n тогда для функции x=12a^2+7a+12" +
                $"\n \"x\" будет равен -> {x2}");

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

// S2.4. Считая, что Земля — идеальная сфера с радиусом R=6350 км,
// определить расстояние до линии горизонта от точки В с заданной высотой h=AB над Землей.
Console.Write($"Введите высоту над уровнем горизонта: ");
string heightAboveHorizon = Console.ReadLine()!;
RightTriangleCathetus(heightAboveHorizon);
void RightTriangleCathetus(string length) // в методе "волшебное число" - диаметр земли
{
    if (double.TryParse(length, out double height))
    {
        double heightTrue = height;
        if (heightTrue < 0)
        {
            Console.WriteLine($"Высота не может быть значением < 0.");
        }
        else
        {
            double earthRadius = 6350;
            double hypotenuse = earthRadius + heightTrue;
            double cathetus = Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(earthRadius, 2));
            Console.WriteLine($"При заданной высоте над уровнем горизонта {heightTrue} " +
                            $"растояние до линии горизонта будет ровно {cathetus}");
        }
    }
    else Console.WriteLine($"Введенные Вами данные {length} являются строкой");
}

// S2.5. Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности.
// Формула нахождения объёма куба: V = a^3, где а - ребро куба.
// Формула нахождения площади поверхности куба: S = 6a^2, где а - ребро куба.
Console.Write("Введите длину ребра куба в см.: ");
double sideLength5 = Convert.ToDouble(Console.ReadLine());
double volumeCube = Math.Pow(sideLength5, 3);
double sideSurfaceArea = 6 * Math.Pow(sideLength5, 2);
Console.WriteLine($"Объем куба равен {volumeCube}см.^3, " +
                $"площадь боковой поверхности равна {sideSurfaceArea}см.^2");

// S2.6. Дан радиус окружности. Найти длину окружности и площадь круга.
// формула длины окружности C = 2π • r
// формула площяди круга S = π * r^2
Console.Write($"Введите радиус окружности: ");
string radius6 = Console.ReadLine()!;
LengthAreaCircle(radius6);
void LengthAreaCircle(string length)
{
    if (double.TryParse(radius6, out double radiusTrue))
    {
        if (radiusTrue > 0)
        {
            double circleLength = 0;
            double squareCircle = 0;
            Console.WriteLine($"Длина окружности равна  => {circleLength = 2 * Math.PI * radiusTrue} \n" +
                            $"Площaдь круга равна     => {squareCircle = Math.PI * radiusTrue * radiusTrue}");
        }
        else Console.WriteLine($"Введите положительное число.");
    }
    else Console.WriteLine($"{radius6} является строкой.");
}
