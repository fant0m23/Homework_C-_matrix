// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int GetIntValueFromUser(string message)
{
   Console.Write(message);
   string value = Console.ReadLine()!;
   bool valid = int.TryParse(value, out int f);
   if (valid == true) return Convert.ToInt32(value);
   else return GetIntValueFromUser(message);
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
string ArithmeticMeanColumns(int[,] matrix)
{
   string result = "Среднее арифметическое каждого столбца: ";
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
         result += $"{Math.Round((summa / count), 2)}.";
      }
      else
      {
         result += $"{Math.Round((summa / count), 2)}; ";
         summa = 0;
         count = 0;
      }
   }
   return result;
}

int lines = GetIntValueFromUser("Введите количество строк двумерного массива: ");
int columns = GetIntValueFromUser("Введите количество столбцов двумерного массива: ");
int[,] matrix = CreateMatrix(lines, columns);
Console.Write(PrintMatrix(matrix)) ;
Console.WriteLine(ArithmeticMeanColumns(matrix));