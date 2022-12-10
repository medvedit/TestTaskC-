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

// //S2.2. Дана сторона квадрата. Найти его периметр.
// Console.Write($"Введите длину одной из сторон кадрата:  ");
// string sideLength = Console.ReadLine()!;
// Console.WriteLine();
// Perimetr(sideLength);
// void Perimetr(string length)
// {
//     if (double.TryParse(sideLength, out double sideLengthTrue))
//     {
//         double perimetr = sideLengthTrue;
//         if (perimetr < 0)
//         {
//             Console.WriteLine($"Введите положительное число.");
//         }
//         else
//         {
//             double perimetr1 = sideLengthTrue * 4;
//             Console.WriteLine($"Перимерт кватрата,\n" +
//                             $"при условии длинны одной из сторон" +
//                             $" равной {sideLengthTrue} ==> {perimetr1}");
//         }
//     }
//     else Console.WriteLine($"{sideLength} является строкой.");
// }

// // S2.3. Дан радиус окружности. Найти ее диаметр.
// Console.Write($"Введите радиус окружности: ");
// string radius = Console.ReadLine()!;
// Console.WriteLine();
// DiameterCircumference(radius);
// void DiameterCircumference(string lineSegment)
// {
//     if (double.TryParse(radius, out double radiusTrue))
//     {
//         double diamert = radiusTrue;
//         if (diamert < 0)
//         {
//             Console.WriteLine($"Введите положительное число.");
//         }
//         else
//         {
//             double diamert1 = radiusTrue + radiusTrue;
//             Console.WriteLine($"Диаметр окружности, при условии" +
//                             $"длины радиуса {radius} ==> {diamert1}");
//         }
//     }
//     else Console.WriteLine($"{radius} является строкой.");
// }

// // S2.4. Считая, что Земля — идеальная сфера с радиусом R=6350 км,
// // определить расстояние до линии горизонта от точки В с заданной высотой h=AB над Землей.
// Console.Write($"Введите высоту над уровнем горизонта: ");
// string heightAboveHorizon = Console.ReadLine()!;
// RightTriangleCathetus(heightAboveHorizon);
// void RightTriangleCathetus(string length) // в методе "волшебное число" - диаметр земли
// {
//     if (double.TryParse(length, out double height))
//     {
//         double heightTrue = height;
//         if (heightTrue < 0)
//         {
//             Console.WriteLine($"Высота не может быть значением < 0.");
//         }
//         else
//         {
//             double earthRadius = 6350;
//             double hypotenuse = earthRadius + heightTrue;
//             double cathetus = Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(earthRadius, 2));
//             Console.WriteLine($"При заданной высоте над уровнем горизонта {heightTrue} " +
//                             $"растояние до линии горизонта будет ровно {cathetus}");
//         }
//     }
//     else Console.WriteLine($"Введенные Вами данные {length} являются строкой");
// }

// // S2.5. Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности.
// // Формула нахождения объёма куба: V = a^3, где а - ребро куба.
// // Формула нахождения площади поверхности куба: S = 6a^2, где а - ребро куба.
// Console.Write("Введите длину ребра куба в см.: ");
// double sideLength5 = Convert.ToDouble(Console.ReadLine());
// double volumeCube = Math.Pow(sideLength5, 3);
// double sideSurfaceArea = 6 * Math.Pow(sideLength5, 2);
// Console.WriteLine($"Объем куба равен {volumeCube}см.^3, " +
//                 $"площадь боковой поверхности равна {sideSurfaceArea}см.^2");

// // S2.6. Дан радиус окружности. Найти длину окружности и площадь круга.
// // формула длины окружности C = 2π • r
// // формула площяди круга S = π * r^2
// Console.Write($"Введите радиус окружности: ");
// string radius6 = Console.ReadLine()!;
// LengthAreaCircle(radius6);
// void LengthAreaCircle(string length)
// {
//     if (double.TryParse(radius6, out double radiusTrue))
//     {
//         if (radiusTrue > 0)
//         {
//             double circleLength = 0;
//             double squareCircle = 0;
//             Console.WriteLine($"Длина окружности равна  => {circleLength = 2 * Math.PI * radiusTrue} \n" +
//                             $"Площaдь круга равна     => {squareCircle = Math.PI * radiusTrue * radiusTrue}");
//         }
//         else Console.WriteLine($"Введите положительное число.");
//     }
//     else Console.WriteLine($"{radius6} является строкой.");
// }

// // S2.7. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
// int a7 = 5;
// int b7 = 28;
// Console.WriteLine($"Среднее арифметическое  {ArithmeticMean(a7, b7)}");
// Console.WriteLine($"Среднее геометрическое  {GeometricMean(a7, b7)}");

// int ArithmeticMean(int a, int b)
// {
//     int arithmeticMean = a + b / 2;
//     return arithmeticMean;
// }

// double GeometricMean(int a, int b)
// {
//     double geometricMean = Convert.ToDouble(Math.Sqrt(a * b));
//     return geometricMean;
// }

// // S2.8. Известны объем и масса тела. Определить плотность материала этого тела.
// // Сама формула выглядит подобным образом: p = m/V.
// // Где p - это плотность, выражается в кг/м^3; m = масса, в килограммах; V = объем, в м^3.
// Console.Write($"Введите объём тела (м.^3): ");
// double bodyVolume = Convert.ToDouble(Console.ReadLine());
// Console.Write($"Введите массу тела (кг.): ");
// double bodyMass = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Плотность материала этого тела равна = {BodyDensity(bodyVolume, bodyMass)}");

// double BodyDensity(double namberVol, double namberMas)
// {
//     double bodyDensity = namberMas / namberVol;
//     return bodyDensity;
// }

// // S2.9. Известны количество жителей в государстве и площадь его территории.
// // Определить плотность населения в этом государстве.
// Console.Write($"Введите колличество жителей в государстве(чел.): ");
// double inhabitantState = Convert.ToDouble(Console.ReadLine());
// Console.Write($"Введите площядь территории государства(км.^2): ");
// double spaceState = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Плотность населения этого государства равна" +
//                 $"{PopulationDensity(inhabitantState, spaceState)} человек на 1 км^2");

// double PopulationDensity(double namberInhabitan, double namberSpace)
// {
//     double populationDensity = namberInhabitan / namberSpace;
//     return populationDensity;
// }

// // S2.10. Составить программу решения линейного уравнения ax+b=0 (a ≠ 0).
// Console.WriteLine(new string('≈', 80));
// Console.WriteLine("Для решения уровнения ax+b=0 (a ≠ 0) введи значение a и b");
// Console.Write($"Значение a = ");
// double a10 = double.Parse(Console.ReadLine()!);
// Console.Write($"Значение b = ");
// double b10 = double.Parse(Console.ReadLine()!);

// LinearEquation(a10, b10);

// void LinearEquation(double firstNamber, double secondNamber)
// {
//     if (a10 == 0 || b10 == 0)
//     {
//         Console.WriteLine("у уровнения нет корней");
//     }
//     else
//     {
//         double x10 = -b10 / a10;
//         Console.WriteLine($"корень x = {x10}");
//     }
// }
// Console.WriteLine(new string('≈', 80));

// // S2.11. Даны катеты прямоугольного треугольника. Найти его гипотенузу.
// Console.WriteLine(new string('≈', 80));
// Console.WriteLine("Ведите катеты прямоугольного треугольника");
// Console.Write("Катет №1 : ");
// double triangleLegOne = Convert.ToDouble(Console.ReadLine());
// if (Math.Sign(triangleLegOne) == -1)
// {
//    while (Math.Sign(triangleLegOne) == -1)
//    {
//       Console.Write("Катет не может быть отрицательный.\nВведите другое число: ");
//       triangleLegOne = Convert.ToDouble(Console.ReadLine());
//    }
// }
// Console.Write("Катет №2 : ");
// double triangleLegTwo = Convert.ToDouble(Console.ReadLine());
// if (Math.Sign(triangleLegTwo) == -1)
// {
//    while (Math.Sign(triangleLegTwo) == -1)
//    {
//        Console.Write("Катет не может быть отрицательный.\nВведите другое число: ");
//        triangleLegTwo = Convert.ToDouble(Console.ReadLine());
//    }
// }
// double hypotenuse = Math.Sqrt( triangleLegOne * triangleLegOne + triangleLegTwo * triangleLegTwo);
// Console.WriteLine("Гипотенуза равна : {0:0.000}",hypotenuse);
// Console.WriteLine(new string('≈', 80));

// // S2.13А. Даны два числа. Найти среднее арифметическое и среднее геометрическое их  модулей.
// Console.WriteLine(new string('≈', 80));
// Console.Write($"Введите число №1: ");
// double namberOne = int.Parse(Console.ReadLine()!);
// Console.Write($"Введите число №2: ");
// double namberTwo = int.Parse(Console.ReadLine()!);
// if (namberOne < 0) namberOne = -namberOne;
// if (namberTwo < 0) namberTwo = -namberTwo;
// Console.WriteLine("Среднее арифметическое модулей числа a и b: {0:F}", (namberOne + namberTwo) / 2);
// Console.WriteLine("Среднее геометрическое модулей числа a и b: {0:F}", Math.Sqrt(namberOne * namberTwo));
// Console.WriteLine(new string('≈', 80));

// S2.14. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
// c = √ h^2 + d^2 => P = a + b + 2c , где a, b -- основания, а h -- высота.
Console.WriteLine(new string('≈', 80));
Console.Write($"Введите длину основания №1: ");
double baseLengthOne = Convert.ToDouble(Console.ReadLine()!);
if (Math.Sign(baseLengthOne) == -1)
{
    while (Math.Sign(baseLengthOne) == -1)
    {
        Console.Write("Длина основания №1 не может быть отрицательный.\nВведите другое число: ");
        baseLengthOne = Convert.ToDouble(Console.ReadLine());
    }
}
Console.Write($"Введите длину основания №2: ");
double baseLengthTwo = Convert.ToDouble(Console.ReadLine()!);
if (Math.Sign(baseLengthTwo) == -1)
{
    while (Math.Sign(baseLengthTwo) == -1)
    {
        Console.Write("Длина основания №2 не может быть отрицательный.\nВведите другое число: ");
        baseLengthTwo = Convert.ToDouble(Console.ReadLine());
    }
}
Console.Write($"Введите высоту трапции ");
double trapezoidHeight = Convert.ToDouble(Console.ReadLine()!);
if (Math.Sign(trapezoidHeight) == -1)
{
    while (Math.Sign(trapezoidHeight) == -1)
    {
        Console.Write("Высота трапеции не может быть отрицательный.\nВведите другое число: ");
        trapezoidHeight = Convert.ToDouble(Console.ReadLine());
    }
}
double differenceBase = Math.Sqrt(Math.Pow((baseLengthOne - baseLengthTwo) / 2, 2) + (trapezoidHeight * trapezoidHeight));
double trapeziumPerimeter = baseLengthOne + baseLengthTwo + (2 * differenceBase);
Console.WriteLine($"Преиметр трапеции равен {Math.Round(trapeziumPerimeter, 3)}");
Console.WriteLine(new string('≈', 80));

// S2.14А. Даны стороны прямоугольника. Найти его периметр и длину диагонали.
Console.WriteLine(new string('≈', 80));





















// class Program
// {
//    static double Vvod_Chisla()
//    {
//       double chislo;
//       string vvod;
//       vvod = Console.ReadLine()!;
//       while (!Double.TryParse(vvod, out chislo))
//       {
//          Console.WriteLine("Недопустимые символы в строке ввода.Ожидается число:");
//          vvod = Console.ReadLine()!;
//       }
//       return chislo;
//    }
//    static string Years(double a) // выбор «год», «года», «лет»
//    {
//       double drob = a - (int)a;
//       string num = Convert.ToString((int)a);
//       string num_2 = "", num_3 = "";
//       if (num.Length >= 3)
//          num_2 = num.Substring(num.Length - 2);
//       else
//          num_2 = num;
//       if (num.Length >= 2)
//          num_3 = num.Substring(num.Length - 1);
//       else
//          num_3 = num;
//       if (num_3 == "1" && num_2 != "11" && drob == 0)
//          return "год";
//       else if ((a < 5.0) || (num_3 == "2" & num_2 != "12") || (num_3 == "3" & num_2 != "13") ||
//            (num_3 == "4" & num_2 != "14"))
//          return "года";
//       else return "лет";
//    }
//    static void Main(string[] args)
//    {
//       double x, y, z, h;
//       Console.WriteLine("Решение 24 задания — Возраст Тани — X лет, а возраст Мити — Y лет. " +
//         "Найти их средний возраст, а также определить, на сколько отличается возраст каждого " +
//         "ребенка от среднего значения. :");
//       Console.WriteLine("Введите возраст Тани:");
//          x = Vvod_Chisla();
//       Console.WriteLine("Введите возраст Мити:");
//          y = Vvod_Chisla();
//       string bolsheT = "", bolsheM = "";
//       z = Math.Abs((x - y) / 2); // отклонение от среднего возраста
//       h = (x + y) / 2; // средний возраст
//       if (x < y)
//       {
//          bolsheT = "младше";
//          bolsheM = "старше";
//       }
//       else
//       {
//          bolsheT = "старше";
//          bolsheM = "младше";
//       }
//       if (x == y)
//          Console.WriteLine("Таня и Митя одного возраста. Обоим {0} {1}", x, Years(x));
//       else
//       {
//          Console.WriteLine("Средний возраст детей {0} {1}", h, Years(h));
//          Console.WriteLine("Таня {0} среднего возраста на {1} {2}", bolsheT, z, Years(z));
//          Console.WriteLine("Митя {0} среднего возраста на {1} {2}", bolsheM, z, Years(z));
//       }

//    }
// }