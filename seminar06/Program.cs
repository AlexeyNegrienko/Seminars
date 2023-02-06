// // сдвиг массива
// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arrayFirst = new int[n];
// int[] arrayResult = new int[n];
// for (int i = 0; i < arrayFirst.Length; i++)
// {
// arrayFirst[i] = new Random().Next(1, 11); // [1, 10]
// }
// Console.WriteLine($"[{string.Join(", ", arrayFirst)}]");
// int k = Convert.ToInt32(Console.ReadLine());
// k = k % n;
// if (k > 0)
// {
// for (int i = 0; i < k; i++)
// arrayResult[i] = arrayFirst[n - k + i];
// for (int i = 0; i < n - k; i++)
// arrayResult[k + i] = arrayFirst[i];
// Console.WriteLine($"[{string.Join(", ", arrayResult)}]");
// }
// else
// {
// k = (-1) * k;
// for (int i = 0; i < k; i++)
// arrayResult[n - k + i] = arrayFirst[i];
// for (int i = 0; i < n - k; i++)
// arrayResult[i] = arrayFirst[k + i];
// Console.WriteLine($"[{string.Join(", ", arrayResult)}]");
// }

// // Теория Гольдбаха

// int n = Convert.ToInt32(Console.ReadLine());
// int countDel = 0, i, j, k, m;
// for (i = 2; i <= n / 2; i++)
// {
// countDel = 0;
// for (j = 2; j <= i / 2; j++)
// {
// if (i % j == 0)
// countDel++;
// }
// if (countDel == 0)
// {
// m = n - i; // 992 - 73 = 919
// for (k = 2; k <= (m + 1) / 2; k++)
// {
// if (m % k == 0)
// countDel++;
// }
// if (countDel == 0)
// {
// Console.WriteLine($"{i} {m}");
// return;
// }
// }
// }

// // статистка
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

// int countEven = 0, countOdd = 0;
// foreach (int element in array)
// {
// if (element % 2 == 1)
// {
// Console.Write($"{element} ");
// countEven++;
// }
// }
// Console.WriteLine();
// foreach (int element in array)
// {
// if (element % 2 == 0)
// {
// Console.Write($"{element} ");
// countOdd++;
// }
// }
// Console.WriteLine();
// if (countOdd >= countEven)
// Console.WriteLine("YES");
// else
// Console.WriteLine("NO");


// //  Переворот массива
//  void InputArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// array[i] = new Random().Next(1, 11); // [1, 10]
// }


// void ReplaceElement(int[] array)
// {
// for (int i = 0; i < array.Length / 2; i++)
// {
// int temp = array[i];// заводим временную переменную
// array[i] = array[array.Length - i - 1]; //начинаем с последнего элемента
// array[array.Length - i - 1] = temp;
// }
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный масссив: [{string.Join(", ", array)}]");
// ReplaceElement(array);
// Console.WriteLine($"Конечный масссив: [{string.Join(", ", array)}]");

// // Введите 3 числа и проверьте могут ли они составить треугольник теорема о неравенсте:
// //  каждая сторона треугольника меньше суммы двух других
// Console.Clear();
// Console.Write("Введите 1-ую сторону треугольника: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ую сторону треугольника: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 3-ю сторону треугольника: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a + b > c && b + c > a && a + c > b)
// Console.WriteLine("yes");
// else
// Console.WriteLine("no");

// // Перевод числа в двоичную систему
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string result = String.Empty;//Создание пустой строки
// while (n > 0)
// {
// result = Convert.ToString(n % 2) + result;
// n = n / 2;
// }
// Console.WriteLine(result);

// // //числа фибонначи
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a0 = 0, a1 = 1, x;
// for (int i = 0; i < n; i++)
// {
// Console.Write($"{a0} ");
// x = a0 + a1;
// a0 = a1;
// a1 = x;
// }

// // Копирование массива
// nt[] a = {1, 2, 3, 4, 5};
// int[] b = new int[a.Length];

// for (int i = 0; i < a.Length; i++)
// b[i] = a[i];

// b[0] = 100;
// Console.WriteLine(string.Join(" ", a));
// Console.WriteLine(string.Join(" ", b));