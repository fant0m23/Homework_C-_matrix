// Нужно написать программу
// перемножения матриц
//
// генерация матрицы m x n

// using static MyMethods;

int GetByteValueFromUser(string message)
{
   Console.Write(message);
   string userInput = Console.ReadLine()!;
   bool valid = byte.TryParse(userInput, out byte value);
   if (valid == true) return value;
   else return GetByteValueFromUser(message);
}
int[,] CreateMatrix(int size0, int size1, int from, int to)
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
string PrintMatrix(int[,] matrix1)
{
   string result = String.Empty;
   for (int i = 0; i < matrix1.GetLength(0); i++)
   {
      for (int j = 0; j < matrix1.GetLength(1); j++)
      {
         result += $"{matrix1[i, j]}  ";
      }
      result += "\n";
   }
   return result;
}
int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
   int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

   for (int i = 0; i < matrix1.GetLength(0); i++)
   {
      for (int j = 0; j < matrix2.GetLength(1); j++)
      {
         for (int k = 0; k < matrix2.GetLength(0); k++)
         {
            result[i, j] += matrix1[i, k] * matrix2[k, j];
         }
      }
   }
   return result;
}

int lines = GetByteValueFromUser("Введите кол-во строчек матрицы: ");
int columns = GetByteValueFromUser("Введите кол-во столбцов матрицы: ");
int from = GetByteValueFromUser("Начало диапазона случайных значений: ");
int to = GetByteValueFromUser("Конец диапазона случайных значений: ");

int[,] matrix1 = CreateMatrix(lines, columns, from, to);
int[,] matrix2 = CreateMatrix(lines, columns, from, to);

Console.WriteLine(PrintMatrix(matrix1));
Console.WriteLine(PrintMatrix(matrix2));
int[,] resultMatrix = MultMatrix(matrix1, matrix2);
Console.WriteLine(PrintMatrix(resultMatrix));