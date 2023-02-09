// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void SearchElement(int[,] arr, int num)
{
  string result = "Такого элемента нет";
  int count = 0;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (arr[i, j] == num)
      {
        Console.WriteLine($"Элемент находится в {i + 1} строке в {j + 1} cтолбце");
        count++;
        result = $"Таких элементов {count}";
      }
    }
  }
  Console.WriteLine(result);
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
int element = GetNum("Какое число хотете найти?: ");
SearchElement(array, element);
