// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет


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
void CheckPosition(int[,] martix, int lines, int columns)
{
   if (lines > martix.GetLength(0) - 1  || columns > martix.GetLength(1) - 1)
   {
      Console.WriteLine("Элемента c такой позицией в массиве нет");
   }
   else Console.WriteLine(martix[lines, columns]);
}

int lines = GetValidValueFromUser("Введите количество строк двумерного массива: ");
int columns = GetValidValueFromUser("Введите количество столбцов двумерного массива: ");
int[,] matrix = CreateMatrix(lines, columns);
PrintMatrix(matrix);

int horizontal = GetValidValueFromUser("Введите номер строки матрицы, где находится искомый элемент: ");
int vertical = GetValidValueFromUser("Введите номер столбца матрицы, где находится искомый элемент: ");
CheckPosition(matrix, horizontal, vertical);
