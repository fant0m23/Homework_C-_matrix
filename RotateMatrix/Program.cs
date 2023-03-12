// Задайте матрицу. Напишите прогу, кот заменяет строки на столбцы. Если это невозможно, должна
// вывести сообщение об этом.


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
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write($"{matrix[i, j]} ");
      }
      Console.WriteLine();
   }
}
int[,] RotateMatrix(int[,] matrix)
{
   int[,] newArray = new int[matrix.GetLength(1), matrix.GetLength(0)];
   for (int i = 0; i < newArray.GetLength(0); i++)
   {
      for (int j = 0; j < newArray.GetLength(1); j++)
      {
         newArray[i, j] = matrix[j, i];
      }
   }
   return newArray;
}
void PrintMatrixToFile(int[,] matrix)
{
   StreamWriter file = new StreamWriter("Матрица.csv");
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         if (j == matrix.GetLength(1) - 1) file.WriteLine($"{matrix[i, j]};");
         else file.Write($"{matrix[i, j]};");
      }
   }
   file.Close();
}


int lines = 3;
int columns = 3;

int[,] mass = CreateMatrix(lines, columns);
PrintMatrix(mass);
int[,] massNew = RotateMatrix(mass);
PrintMatrixToFile(massNew);


