// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
// суммой элементов: 0 строка


int GetByteValueFromUser(string message)
{
   Console.Write(message);
   string userInput = Console.ReadLine()!;
   bool valid = byte.TryParse(userInput, out byte value);
   if (valid == true) return value;
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
int LineMinSumm(int[,] matrix)
{
   int rows = matrix.GetLength(0);
   int columns = matrix.GetLength(1);
   int currentMin = columns * 100;
   int result = 0;
   for (int i = 0; i < rows; i++)
   {
      int summa = 0;
      for (int j = 0; j < columns; j++)
      {
         summa += matrix[i, j];
      }
      if (currentMin > summa)
      {
         result = i;
         currentMin = summa;
      }
   }
   return result;
}

int lines = GetByteValueFromUser("Введите количество строк двумерного массива: ");
int columns = GetByteValueFromUser("Введите количество столбцов двумерного массива: ");
int[,] mass = CreateMatrix(lines, columns);

Console.Write(PrintMatrix(mass));
Console.WriteLine($"{LineMinSumm(mass)} строка");
