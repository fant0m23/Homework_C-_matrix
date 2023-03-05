// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

byte GetValidValueFromUser(string message)
{
   Console.Write(message);
   string value = Console.ReadLine()!;
   bool valid = byte.TryParse(value, out byte f);
   if (valid == true) return Convert.ToByte(value);
   else return GetValidValueFromUser(message);
}
double[,] CreateMatrix(int size0, int size1, int range)
{
   double[,] newArray = new double[size0, size1];
   for (int i = 0; i < size0; i++)
   {
      for (int j = 0; j < size1; j++)
      {
         newArray[i, j] = Math.Round((new Random().Next(range * -1, range) * new Random().NextDouble()), 1);
      }
   }
   return newArray;
}
void PrintMatrix(double[,] matrix)
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

int lines = GetValidValueFromUser("Введите количество строк двумерного массива ");
int columns = GetValidValueFromUser("Введите количество столбцов двумерного массива ");
int rangeNumbers = GetValidValueFromUser("Заполним матрицу случайными вещественными значениями " +
                                          "из диапазона [-N ; N]. Введите N: ");
double[,] mass = CreateMatrix(lines, columns, rangeNumbers);
Console.WriteLine();
PrintMatrix(mass);


