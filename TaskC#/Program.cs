﻿// // See https://aka.ms/new-console-template for more information
// {
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Hello1 'A'");
// }

// Console.WriteLine("Введите ваше имя");
// Console.WriteLine ($"Ваше имя ::: {Console.ReadLine()}");

// Console.WriteLine(true); // Да
// Console.WriteLine(false); //Нет

// //Целочисленные литералы:==================================
// // Вывод числа из двоичной системы в десятичную.
// Console.WriteLine(0b100001);    // 33

// //Вывод числа из шестнадцатеричной системы в десятичную.
// Console.WriteLine(0xFF);    // 255

// //Вещественные литералы:===================================
// //Вещественные литералы могут определяться в экспоненциальной форме MEp, 
// //где M — мантисса, E - экспонента, которая фактически означает 
// //"*10^" (умножить на десять в степени), а p — порядок. Например:

// Console.WriteLine(3.2e3);   // по сути равно 3.2 * 10<sup>3</sup> = 3200
// // Или
// Console.WriteLine(1.2E-1);  // равно 1.2 * 10<sup>-1</sup> = 0.12
// //========================================================================
// // Для вывода на экран целочисленного литерала в необходимой системе счисления можно пользоваться 
// // методом ToString(value, base) класса Сonvert, где value - число в 2-ой, 10-ой, 16-ой системе счисления, 
// // base - основание системы счисления в которой нужно вывести число на экран (2, 8, 10, 16). Примеры:
// Console.WriteLine(Convert.ToString(161,2)); //Вывод на экран (с 10-ой в 2-ую): 10100001
// Console.WriteLine(Convert.ToString(0b10100001,8)); //Вывод на экран (с 2-ой в 8-ую): 241
// Console.WriteLine(Convert.ToString(161,16)); //Вывод на экран(с 10-ой в 16-ую): a1
// Console.WriteLine(Convert.ToString(0xa1,10)); //Вывод на экран(с 16-ой в 10-ую): 161
// //=========================================================================
// string name = "Vasya";
// int a = 25;
// int b = 10;
// Console.WriteLine(name + a + b);// выводит Vasya2510
// Console.WriteLine(a+b); // выводит 35
// Console.WriteLine(name + (a + b)); // Vasya35
// // Если в выражении используются числовые типы вместе со строковыми с помощью операции "+" - то 
// //она работает не как сложение, а как конкатенация строк и 
// //компилятор преобразует числовые переменные в строки.
// //============================================================================
// string name1 = "Tom";
// int age = 34;
// double height = 1.7;
// Console.WriteLine($"Имя: {name1}  Возраст: {age}  Рост: {height}м"); //Имя: Tom  Возраст: 34  Рост: 1,7м
// //Здесь мы видим, что строка в Console.WriteLine содержит некие числа в фигурных скобках: {0}, {1}, {2}. 
// //Это плейсхолдеры, вместо которых при выводе строки на консоль будут подставляться некоторые значения. 
// //Подставляемые значения указываются после строки через запятую.

// // ИЛИ 

// string name2 = "Tom";
// int age2 = 34;
// double height2 = 1.7;                //                  {0}    {1}     {2}  
// Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name2, height2, age2); //Имя: Tom  Возраст: 34  Рост: 1,7м
// //При этом важен порядок подобных плейсхолдеров. 
// //Например, в данном случае после строки первой указана переменная name, потом height и потом age. 
// //Поэтому значение переменной name будет всавляться вместо первого плейсхолдера - {0} (нумерация начинается с нуля), 
// //height - вместо {1}, а age - вместо {2}. Поэтому в итоге пи выводе на консоль строка.
// //============================================================