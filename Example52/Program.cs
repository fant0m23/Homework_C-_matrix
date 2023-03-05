// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int GetValidValueFromUser(string message)
{
   Console.Write(message);
   string value = Console.ReadLine()!;
   bool valid = int.TryParse(value, out int f);
   if (valid == true) return Convert.ToInt32(value);
   else return GetValidValueFromUser(message);
}
int[,] CreateMatrix(int size0, int size1)
{
   int[,] newArray = new int[size0, size1];
   for (int i = 0; i < size0; i++)
   {
      for (int j = 0; j < size1; j++)
      {
         newArray[i, j] = new Random().Next(1, 10);
      }
   }
   return newArray;
}
void PrintMatrix(int[,] matrix)
{
   Console.WriteLine("Матрица: ");
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write($"{matrix[i, j]} ");
      }
      Console.WriteLine();
   }
}
void ArithmeticMeanColumns(int[,] matrix)
{
   Console.Write("Среднее арифметическое каждого столбца: ");
   double summa = 0;
   int count = 0;
   for (int i = 0; i < matrix.GetLength(1); i++)
   {
      for (int j = 0; j < matrix.GetLength(0); j++)
      {
         summa += matrix[j, i];
         count++;
      }
      if (i == matrix.GetLength(1) - 1)
      {
         Console.Write($"{Math.Round((summa / count), 1)}.");
      }
      else
      {
         Console.Write($"{Math.Round((summa / count), 1)};  ");
         summa = 0;
         count = 0;
      }
   }
}

int lines = GetValidValueFromUser("Введите количество строк двумерного массива: ");
int columns = GetValidValueFromUser("Введите количество столбцов двумерного массива: ");
int[,] matrix = CreateMatrix(lines, columns);
PrintMatrix(matrix);
ArithmeticMeanColumns(matrix);