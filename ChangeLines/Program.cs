// Задайте матрицу. Напишите прогу, кот поменяет местами 1-ю и последнюю строки матрицы.


int lines = 6;
int columns = 3;

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
void ChangeLines(int[,] matrix)
{
   int temp = 0;
   for (int i = 0; i < matrix.GetLength(1); i++)
   {
      temp = matrix[0, i];
      matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
      matrix[matrix.GetLength(0) - 1, i] = temp;
   }
}

int[,] mass = CreateMatrix(lines, columns);
PrintMatrix(mass);
ChangeLines(mass);
Console.WriteLine();
PrintMatrix(mass);
