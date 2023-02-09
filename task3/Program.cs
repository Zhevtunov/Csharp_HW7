// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

void SredneeArithmetic(int[,] arr)
{
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    double result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      result += arr[i, j];
    }
    double res = result / arr.GetLength(0);
    Console.Write(Math.Round(res, 1) + "\t");
  }
}

void ShowArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

int[,] GenerateArray(int rows, int columns, int lowerBound, int upperBound)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(lowerBound, upperBound + 1);
    }
  }
  return array;
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int m = GetNum("Введите количество строк: ");
int n = GetNum("Введите количество столбцов: ");

int[,] array = GenerateArray(m, n, 0, 10);
ShowArray(array);
Console.WriteLine("Среднее арифметическое чисел столбцов по порядку:");
SredneeArithmetic(array);