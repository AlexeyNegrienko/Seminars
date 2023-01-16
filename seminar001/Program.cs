//Сравнение чисел

// Console.Clear();
// Console.Write("Введите число: ");
// double n = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n>m)
//     Console.WriteLine(n);
// else if (n<m)
//      Console.WriteLine(m);   
// else
//      Console.WriteLine("="); 

//Квадрат числа

// Console.Clear();
// Console.Write("Введите число: ");
// double n = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Результат={n*n}");

//Равно ли первое число квадрату второго

// Console.Clear();
// Console.Write("Введите число: ");
// double n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (m*m==n)
//     Console.Write("yes");
// else
//     Console.Write("no");

//День недели
// Console.Clear();
// Console.Write("Введите день недели: ");
// int n = Convert.ToInt32(Console.ReadLine());
// // && - и(логическое умножение)
// // || - или(логическое сложение)
// // True - 1
// // False - 0
// // 1 + 0 = 1(True)
// while (n < 1 || n > 7)
// {
// Console.Write("Вы ошиблись!\nВведите день недели: ");
// n = Convert.ToInt32(Console.ReadLine());
// }
// if (n == 1)
// Console.WriteLine("Понедельник");
// else if (n == 2)
// Console.WriteLine("Вторник");
// else if (n == 3)
// Console.WriteLine("Среда");
// else if (n == 4)
// Console.WriteLine("Четверг");
// else if (n == 5)
// Console.WriteLine("Пятница");
// else if (n == 6)
// Console.WriteLine("Суббота");
// else
// Console.WriteLine("Воскресенье");

// Вывод чисел между положительным и отрицательным значением числа
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int m=n*(-1);
// while (m <= n)
// {
//     Console.Write($"{m} ");
//     m++;
// }

// Последнее число
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(n % 10);