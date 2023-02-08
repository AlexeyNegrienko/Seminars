// домашнее 71
// void InputMatrix(double[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = Math.Round(new Random().NextDouble() * (20 + 20) - 20, 2);
// Console.Write($"{matrix[i, j]} \t");
// }
// Console.WriteLine();
// }
// }


// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// double[,] matrix = new double[size[0], size[1]];
// InputMatrix(matrix);

// // домашнее 73
// void InputMatrix(double[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = Math.Round(new Random().NextDouble() * (20 + 20) - 20, 2);
// Console.Write($"{matrix[i, j]} \t");
// }
// Console.WriteLine();
// }
// }


// void ReleaseMatrix(double[,] matrix)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// double summa = 0;
// for(int i = 0; i < matrix.GetLength(0); i++)
// {
// summa += matrix[i, j];
// }
// Console.WriteLine($"Результат ср. ариф. {j + 1} = {summa / matrix.GetLength(0)}");
// }
// }


// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// double[,] matrix = new double[size[0], size[1]];
// InputMatrix(matrix);
// ReleaseMatrix(matrix);


// // перестановка местами первой и последне строки
// void FillMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = new Random().Next(1, 11);
// }
// }
// }

// void ScreenMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// Console.Write($"{matrix[i, j]} \t");
// }
// Console.WriteLine();
// }
// }


// void ReleaseMatrix(int[,] matrix)
// {
// int temp = 0;
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// temp = matrix[0, j];
// matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
// matrix[matrix.GetLength(0) - 1, j] = temp;
// }
// }


// Console.Clear();
// Console.Write("Ведите размеры массива: ");
// int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// FillMatrix(matrix);
// ScreenMatrix(matrix);
// Console.WriteLine();
// ReleaseMatrix(matrix);
// ScreenMatrix(matrix);