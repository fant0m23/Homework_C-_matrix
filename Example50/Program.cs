// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет


int GetByteValueFromUser(string message)
{
   Console.Write(message);
   string value = Console.ReadLine()!;
   bool valid = byte.TryParse(value, out byte f);
   if (valid == true) return Convert.ToByte(value);
   else return GetByteValueFromUser(message);
}
int[,] CreateMatrix(int size0, int size1, int from = 1, int to = 10)
{
   int[,] newArray = new int[size0, size1];
   for (int i = 0; i < size0; i++)
   {
      for (int j = 0; j < size1; j++)
      {
         newArray[i, j] = new Random().Next(from, to);
      }
   }
   return newArray;
}
string PrintMatrix(int[,] matrix)
{
   int rows = matrix.GetLength(0);
   int columns = matrix.GetLength(1);
   string result = String.Empty;
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
      {
         result += $"{matrix[i, j]}  ";
      }
      result += "\n";
   }
   return result;
}
string CheckPosition(int[,] martix, int lines, int columns)
{
   if (lines > martix.GetLength(0) - 1 || columns > martix.GetLength(1) - 1)
   {
      return "Элемента c такой позицией в массиве нет";
   }
   else return $"{martix[lines, columns]}";
}

int lines = GetByteValueFromUser("Введите количество строк двумерного массива: ");
int columns = GetByteValueFromUser("Введите количество столбцов двумерного массива: ");
int[,] matrix = CreateMatrix(lines, columns);

Console.Write(PrintMatrix(matrix));

int horizontal = GetByteValueFromUser("Введите номер строки матрицы, где находится искомый элемент: ");
int vertical = GetByteValueFromUser("Введите номер столбца матрицы, где находится искомый элемент: ");

Console.Write(CheckPosition(matrix, horizontal, vertical));
