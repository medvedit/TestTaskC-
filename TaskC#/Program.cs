﻿// // See https://aka.ms/new-console-template for more information
// {
//     Console.WriteLine("Hello, World!");
//     Console.WriteLine("Hello1 'A'");
// }

// Console.WriteLine("Введите ваше имя");
// Console.WriteLine($"Ваше имя ::: {Console.ReadLine()}");

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
// Console.WriteLine(Convert.ToString(161, 2)); //Вывод на экран (с 10-ой в 2-ую): 10100001
// Console.WriteLine(Convert.ToString(0b10100001, 8)); //Вывод на экран (с 2-ой в 8-ую): 241
// Console.WriteLine(Convert.ToString(161, 16)); //Вывод на экран(с 10-ой в 16-ую): a1
// Console.WriteLine(Convert.ToString(0xa1, 10)); //Вывод на экран(с 16-ой в 10-ую): 161
// //=========================================================================
// string name = "Vasya";
// int a = 25;
// int b = 10;
// Console.WriteLine(name + a + b);// выводит Vasya2510
// Console.WriteLine(a + b); // выводит 35
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
// //===========================================================================

// //Консольный ввод:
// Console.Write("Введите свое имя: ");
// string? name4 = Console.ReadLine(); //string? - (?) означает что значение string может хранить значение null.
// Console.WriteLine($"Привет {name4}");
// // ОТВЕТ Введите свое имя: robert
// //       Привет robert
// //Однако, может возникнуть вопрос, как нам быть, если, допустим, мы хотим ввести возраст в переменную типа int
// //или другую информацию в переменные типа double или decimal?
// //По умолчанию платформа .NET предоставляет ряд методов,
// //которые позволяют преобразовать различные значения к типам int, double и т.д. Некоторые из этих методов:

// //Convert.ToInt32() (преобразует к типу int)
// //Convert.ToDouble() (преобразует к типу double)
// //Convert.ToDecimal() (преобразует к типу decimal)

// Console.Write("Введите имя: ");
// string? name5 = Console.ReadLine();

// Console.Write("Введите возраст: ");
// int age3 = Convert.ToInt32(Console.ReadLine()); // считывание с консоли и конвертация в тип int.

// Console.Write("Введите рост: ");
// double height3 = Convert.ToDouble(Console.ReadLine()); // ...

// Console.Write("Введите размер зарплаты: ");
// decimal salary = Convert.ToDecimal(Console.ReadLine()); // ...

// Console.WriteLine($"Имя: {name5}  Возраст: {age3}  Рост: {height3}м  Зарплата: {salary}$");
// // ОТВЕТ:  Введите имя: Robert
// //         Введите возраст: 18
// // .       Введите рост: 184,35
// // .       Введите размер зарплаты: 5385,43
// // .       Имя: Robert  Возраст: 18  Рост: 184,35м  Зарплата: 5385,43$

// //Ведь если ввести туда символ или строку - появляется ошибка, как обезопасить программу чтобы пользователь мог только вводить числа,
// //а при введении любых других символов выводилось сообщение о некорректном формате или что-то типа того?
// string? Str1;
// decimal Value1 = 0;
// bool IsError = true;
// char Separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
// char NoSeparator = Separator == '.' ? ',' : '.';
// do // Цикл до корректного ввода или отказа (пустая строка)
// {
//     Console.WriteLine("Введите число : ");
//     Str1 = Console.ReadLine();
//     if (Str1 == null || Str1 == "")
//     {
//         Console.WriteLine("Не хотите - как хототите.");
//         return;
//     }
//     // Замена на нужный разделитель десятичной части
//     if (Str1.Contains(NoSeparator))
//         Str1 = Str1.Replace(NoSeparator, Separator);

//     // Попытка преобразования
//     try
//     {
//         Value1 = Convert.ToDecimal(Str1);
//         IsError = false;
//     }
//     catch (System.FormatException) { Console.WriteLine("Неверный формат.\n"); }
//     catch (System.OverflowException) { Console.WriteLine($"Введено слишком большое, либо слишком малое число для типа {Value1.GetType()}.\n"); }

// } while (IsError);
// Console.WriteLine($"Введено число: {Value1}");

// //=====================================================================================
// //Инкремент бывает префиксным:===
// int x1 = 5;

// int z1 = ++x1; //++x - сначала значение переменной x увеличивается на 1,
// //а потом ее значение возвращается в качестве результата операции.

// Console.WriteLine($"{x1} - {z1}");


// //постфиксный инкремент:===
// int x2 = 5;

// int z2 = x2++; // x++ - сначала значение переменной x возвращается в качестве результата операции,
// // а затем к нему прибавляется 1.

// Console.WriteLine($"{x2} - {z2}");
// // Созначением --х работает так же.

// // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// // Раз и навсегда запомнить, и не путать префиксный и постфиксный инкремент поможет такой пример:
// int x = 2;
//  x = x++ + ++x; //   или   х=(2+(2+1))+1  Почитать можно тут + комментарии! : https://metanit.com/sharp/tutorial/2.3.php
// Console.WriteLine($"x = {x}");  // x = 6
// // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

// Логические операции=======================================================================================================================

// //  &   (логическое умножение) если в обоих числах 1, то 1, иначе 0 -----------!!!!!!!!!!!!!!!!----------
// int x1 = 2; //010
// int y1 = 5; //101
// Console.WriteLine(x1 & y1); // выведет 0

// int x2 = 4; //100
// int y2 = 5; //101
// Console.WriteLine(x2 & y2); // выведет 4
// //В первом случае у нас два числа 2 и 5. 2 в двоичном виде представляет число 010, а 5 - 101.
// // Поразрядно умножим числа (0*1, 1*0, 0*1) и в итоге получим 000.
// //Во втором случае у нас вместо двойки число 4, у которого в первом разряде 1, так же как и у числа 5,
// // поэтому в итоге получим (1*1, 0*0, 0 *1) = 100, то есть число 4 в десятичном формате.


// //   |  (логическое сложение)  если в одном из числе 1, то 1 , иначе 0 -----------!!!!!!!!!!!!!!!!-------------
// int x1 = 2; //010
// int y1 = 5;//101
// Console.WriteLine(x1|y1); // выведет 7 - 111
// int x2 = 4; //100
// int y2 = 5;//101
// Console.WriteLine(x2 | y2); // выведет 5 - 101
// //Похоже на логическое умножение, операция также производится по двоичным разрядам,
// //но теперь возвращается единица, если хотя бы у одного числа в данном разряде имеется единица.


// //  ^ (логическое исключающее ИЛИ). Также эту операцию называют XOR. если числа разные, то 1, иначе 0 ------------!!!!!!!!!!!!!!!!------------
// int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
// int key = 102; //Пусть это будет ключ - в двоичной форме 1100110

// int encrypt = x ^ key; //Результатом будет число 1001011 или 75
// Console.WriteLine($"Зашифрованное число: {encrypt}") ;

// int decrypt = encrypt ^ key; // Результатом будет исходное число 45
// Console.WriteLine($"Расшифрованное число: {decrypt}");

// // Представление отрицательных чисел
// int x = 12;
// int y = ~x;
// y = y + 1;  //  -12
// Console.WriteLine(y);   // -12
// Console.WriteLine(Convert.ToString(y, 2)); // Выводит вконсоль y в двичной системе. //  11111111111111111111111111110100

// int[] integers = {
//     12, -13, 243, 4, 16, -7, -1, 13, 14
// };

// Array.Sort(integers);

// Console.WriteLine($"" +
//     $"{"i",4}\t" +
//     $"{"~i",4}\t" +
//     $"{"~i+1",4}\t" +
//     $"{"i (binary)",32}\t" +
//     $"{"~i (binary)",32}\t" +
//     $"{"~i+1 (binary)",32}\n");

// for (int i = 0; i < integers.Length; i++)
// {
//     Console.WriteLine($"" +
//         $"{integers[i],4}\t" +
//         $"{InverseCode(integers[i]),4}\t" +
//         $"{AdditionalCode(integers[i]),4}\t" +
//         $"{ConvertToBinaryFormatted(integers[i]),32}\t" +
//         $"{ConvertToBinaryFormatted(InverseCode(integers[i])),32}\t" +
//         $"{ConvertToBinaryFormatted(AdditionalCode(integers[i])),32}");
// }

// static bool isPositive(int number)
// {
//     return number >= 0;
// }

// static int InverseCode(int number)
// {
//     if (isPositive(number))
//         return number;

//     return ~number;
// }

// static int AdditionalCode(int number)
// {
//     if (isPositive(number))
//         return number;

//     return InverseCode(number) + 1;
// }

// static string ConvertToBinaryFormatted(int number)
// {
//     return Convert.ToString(number, 2).PadLeft(32, '0');
// }

// // Тема глубокая. Стоит вернуться снова  https://metanit.com/sharp/tutorial/2.22.php

// =================================================================================================================
// Циклы являются управляющими конструкциями, позволяя в зависимости от определенных условий выполнять некоторое действие множество раз. В C# имеются следующие виды циклов:

// for============
// Цикл for
// Цикл for имеет следующее формальное определение:
// for ([действия_до_выполнения_цикла]; [условие]; [действия_после_выполнения])
// {
//     // действия
// }
// Нам необязательно указывать все условия при объявлении цикла. Например, мы можем написать так:

// int i = 1;
// for (; ;)
// {
//     Console.WriteLine($"i = {i}");
//     i++;
// }
// Формально определение цикла осталось тем же, только теперь блоки в определении у нас пустые: for (; ;).
// У нас нет инициализированной переменной, нет условия, поэтому цикл будет работать вечно - бесконечный цикл.
// Также стоит отметить, что можно определять несколько переменных в объявлении цикла:

// for (int i = 1, j = 1; i < 10; i++, j++)
//     Console.WriteLine($"{i * j}");

// for (int i = 1; i < 4; i++)
// {
//     Console.WriteLine(i);
// }

// foreach==================
// Цикл foreach предназначен для перебора набора или коллекции элементов. Его общее определение:

// foreach(тип_данных переменная in коллекция)
// {
//     // действия цикла
// }
// После оператора foreach в скобках сначала идет определение переменной.
// Затем ключевое слово in и далее коллекция, элементы которой надо перебрать.

// При выполнении цикл последовательно перебирает элементы коллекции и помещает их в переменную,
// и таким образом в блоке цикла мы можем выполнить с ними некоторые действия.



// while====================
// В отличие от цикла do цикл while сразу проверяет истинность некоторого условия, и если условие истинно, то код цикла выполняется:

// while (условие)
// {
//     действия цикла
// }


// do...while======================
// В цикле do сначала выполняется код цикла, а потом происходит проверка условия в инструкции while.
// И пока это условие истинно, цикл повторяется.

// do
// {
//     действия цикла
// }
// while (условие)

// Операторы continue и break==================

// Иногда возникает ситуация, когда требуется выйти из цикла, не дожидаясь его завершения.
// В этом случае мы можем воспользоваться оператором break.
// for (int i = 0; i < 9; i++)
// {
//     if (i == 5)
//         break;
//     Console.WriteLine(i);
// }
// Хотя в условии цикла сказано, что цикл будет выполняться, пока счетчик i не достигнет значения 9,
// в реальности цикл сработает 5 раз. Так как при достижении счетчиком i значения 5, сработает оператор break,
// и цикл завершится.

// Tеперь поставим себе другую задачу. А что если мы хотим, чтобы при проверке цикл не завершался,
// а просто пропускал текущую итерацию. Для этого мы можем воспользоваться оператором continue:

// for (int i = 0; i < 9; i++)
// {
//     if (i == 5)
//         continue;
//     Console.WriteLine(i);
// }
// В этом случае цикл, когда дойдет до числа 5, которое не удовлетворяет условию проверки,
// просто пропустит это число и перейдет к следующей итерации:

// Вложенные циклы=================================

// Одни циклы могут быть вложенными в другие. Например:

// for (int i = 1; i < 10; i++)
// {
//     for (int j = 1; j < 10; j++)
//     {
//         Console.Write($"{i * j} \t");
//     }
//     Console.WriteLine();
// }
// В данном случае цикл for (int i = 1; i < 10; i++) выполняется 9 раз, то есть имеет 9 итераций.
// Но в рамках каждой итерации выполняется девять раз вложенный цикл for (int j = 1; j < 10; j++).
// В итоге данная программа выведет таблицу умножения.

// //МАССИВЫ ===================================================================
// //Перебор элементов массива.
// int[,] numbers = { { 1, 2 }, { 4, 5 }, { 6, 7 } };

// int rows = numbers.GetUpperBound(0) + 1;    // количество строк GetUpperBound-возвращает индекс последнего элемента в определенной размерности
// int columns = numbers.Length / rows;        // количество столбцов
// // или так
// // int columns = numbers.GetUpperBound(1) + 1;

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         Console.Write($"{numbers[i, j]} \t");
//     }
//     Console.WriteLine();
// }
// // ИЛИ ===
// Console.WriteLine(); // для пропуска видимой строки межды выведенными в терминал массивами.
//
// int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

// for (int i = 0; i < mas.GetLength(0); i++)
// {
//     for (int j = 0; j < mas.GetLength(1); j++)
//     {
//         Console.Write($"{mas[i, j]} \t");
//     }
//     Console.WriteLine();
// }

// // Разворот массива через инверсию ============================
// int[] nums = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
// for (int i = 0; i < nums.Length / 2; i++)
// {
//     nums[i] += nums[nums.Length - i - 1];
//     nums[nums.Length - i - 1] = nums[i] - nums[nums.Length - i - 1];
//     nums[i] -= nums[nums.Length - i - 1];
// }
// foreach (int i in nums)
// {
//     Console.Write($"{i} \t");
// }
// Console.WriteLine();

// //ИЛИ разворот с сохранением в новый ================================

// int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 }; //инвертируемый массив
// int b = numbers.Length; //считаем колво элементов, переменная счетчик для 1 массива
// int[] numbers1 = new int[b]; //создаем 2 массив с тем же числом элементов что и первый
// int c = 0; //переменная-счетчик элементов для 2 массива
// foreach (int number in numbers)
// {
//     numbers1[c++] = numbers[--b]; //присваиваем последний элемент первого массива к первому элементу второго
// }
// Console.WriteLine("Супермассив:"); //выводим
// foreach (int i in numbers1)
// {
//     Console.Write($"{i} \t");
// }Console.WriteLine();

// // Количество положительных чисел =========================================================================

// // Найдем количество положительных чисел в массиве:

// int[] num = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
// Console.WriteLine($"начальный массив {String.Join(",  ", num)} ");

// int result = 0;
// foreach (int number in num)
// {
//     if (number > 0)
//     {
//         result++;
//     }
// }
// Console.WriteLine($"Число элементов больше нуля: {result}");
// // Здесь создаем вспомогательную переменную result, которая будет содержать количество положительных чисел.
// // В цикле прохожим по массиву и, если его элемент больше нуля, добавляем к переменной result единицу.

// // Инверсия массива ==================================================

// // Вторая задача - инверсия массива, то есть переворот его в обратном порядке:

// int[] num1 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

// int n = num.Length; // длина массива
// int k = n / 2;          // середина массива
// int temp;               // вспомогательный элемент для обмена значениями
// for (int i = 0; i < k; i++)
// {
//     temp = num[i];
//     num[i] = num[n - i - 1];
//     num[n - i - 1] = temp;
// }
// Console.WriteLine($"Перевернутый массив");
// foreach (int i in num)
// {
//     Console.Write($"{i} \t");
// }
// Console.WriteLine();
// // Поскольку нам надо изменять элементы массива, то для этого используется цикл for.
// // Алгоритм решения задачи подразумевает перебор элементов до середины массива,
// // которая в программе представлена переменной k, и обмен значений элемента, который имеет индекс i,
// // и элемента с индексом n-i-1.

// // Программа сортировки массива =======================================

// // Теперь возьмем задачу посложнее - простейшую сортировку массива:

// int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
// Console.WriteLine($"Текущее состояние массива: {String.Join(",  ", nums)}");

// // сортировка
// int temp1;
// for (int i = 0; i < nums.Length - 1; i++)
// {
//     for (int j = i + 1; j < nums.Length; j++)
//     {
//         if (nums[i] > nums[j])
//         {
//             temp1 = nums[i];
//             nums[i] = nums[j];
//             nums[j] = temp1;
//         }
//     }
// }

// // вывод
// Console.Write("Вывод отсортированного массива: ");
// for (int i = 0; i < nums.Length; i++)
// {
//     Console.Write($"{nums[i]},  ","");
// }
// Console.WriteLine();
// // Для сортировки массива выполняем проходы по массиву и сравниваем элементы.
// // Поскольку нам надо последовательно сравнивать каждый элемент массива с каждым (за исключением сравния с самим собой),
// // то здесь применятся вложенный цикл.
// // Во внешнем цикле мы берем элемент, который будем сравнивать:
// // for (int i = 0; i < nums.Length - 1; i++)
// // Далее запускаем вложенный цикл, который начинается, со следующего элемента, и из которого извлекаем элементы,
// // с которыми будем сравнивать тот элемент, которые берется из массива во внешнем цикле:
// // for (int j = i + 1; j < nums.Length; j++)
// // Если элемент с меньшим индексом больше элемента с большим индексом, то меняем элементы местами.
// // if (nums[i] > nums[j])
// // {
// //     temp = nums[i];
// //     nums[i] = nums[j];
// //     nums[j] = temp;
// // }
// // В конце выводим все элементы.

// // Для тех, кому не понятна сортировка, так программа сама расскажет, что делает в каждой итерации ========================================
// // ввод чисел
// int[] mas = { 5, 6, 3, 7, 1 };

// // сортировка
// int temp2;
// for (int i = 0; i < mas.Length-1; i++)
// {
// for (int j = i + 1; j < mas.Length; j++)
// {
// Console.WriteLine($"i = {i} и j = {j}");
// Console.WriteLine("Текущее состояние массива: "+ String.Join(",",mas));
// Console.WriteLine($"Сравниваем mas[i] = {mas[i]} и mas[j] = {mas[j]}");
// if (mas[i] > mas[j])
// {
// Console.WriteLine("mas[i] больше mas[j]");
// Console.WriteLine($"Работаем с : mas[i] = {mas[i]} и mas[j] = {mas[j]}");
// temp2 = mas[i];
// mas[i] = mas[j];
// mas[j] = temp2;
// Console.WriteLine($"Поменяли местами, теперь : mas[i] = {mas[i]} и mas[j] = {mas[j]} ");
// }
// else
// {
// Console.WriteLine("mas[i] меньше mas[j], продолжаем итерации");
// }
// }
// }

// // вывод
// Console.WriteLine("Вывод отсортированного массива");
// for (int i = 0; i < mas.Length; i++)
// {
// Console.Write($"{mas[i]} \t");
// }
// Console.WriteLine();

// // Инициализация массива с числами =======================================================================
// int[] array = { 3, 2, 1 };

// int temp;
// // array.Length здесь из-за того, что последний элемент необходимо исключить из проверки, так как его не с чем сравнивать ;)
// for (int i = 0; i < array.Length - 1; i++)
// {
// for (int j = i + 1; j < array.Length; j++)
// {
// Console.WriteLine("================================================================================");
// Console.WriteLine($"Новая итерация; i = {i}, j = {j}");
// Console.WriteLine($"Текущее состояние массива: {String.Join(",", array)}");
// Console.WriteLine($"Операция - сравнение {i}-го ({array[i]}) и {j}-го ({array[j]}) элементов массива");
// if (array[i] > array[j])
// {
// Console.WriteLine($"{array[i]} больше {array[j]}, сохраняем большее значение во временную переменную temp");
// temp = array[i]; // переменная temp была объявлена до цикла, предназначена для сохранения большего значения
// array[i] = array[j]; // присваиваем большему значению меньшее
// Console.WriteLine($"{i}-й элемент массива теперь имеет значение {j}-го; array[{i}] ({array[i]}) теперь равно array[{j}] ({array[j]})");
// array[j] = temp; // присваиваем меньшему значению большее, которое было сохранено нами в переменной temp
// Console.WriteLine($"{j}-й элемент массива теперь имеет значение {i}-го; array[{j}] ({array[j]}) теперь равно array[{i}] ({array[i]})");
// Console.WriteLine($"Состояние массива после смены мест: {String.Join(",", array)}");
// }
// else
// {
// Console.WriteLine($"{array[i]} не больше {array[j]}, переходим к следующей итерации");
// }
// }
// }

// // Вывод отсортированного массива
// Console.WriteLine("================================================================================");
// Console.WriteLine("Итоговый вариант отсортированного массива");
// foreach (int i in array)
// {
// Console.WriteLine(i);
// }
