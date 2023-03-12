// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int GetByteValueFromUser(string message)
{
   Console.Write(message);
   string userInput = Console.ReadLine()!;
   bool valid = byte.TryParse(userInput, out byte value);
   if (valid == true && value != 0) return value;
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
void SortMatrix(int[,] mass)
{
   int rows = mass.GetLength(0);
   int columns = mass.GetLength(1);
   int temp = 0;

   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns - 1; j++)
      {
         for (int next = j + 1; next < columns; next++)
         {
            if (mass[i, next] > mass[i, j])
            {
               temp = mass[i, j];
               mass[i, j] = mass[i, next];
               mass[i, next] = temp;
            }
         }
      }
   }
}

int lines = GetByteValueFromUser("Введите количество строк двумерного массива: ");
int columns = GetByteValueFromUser("Введите количество столбцов двумерного массива: ");
int[,] mass = CreateMatrix(lines, columns);
// DateTime begin = DateTime.Now;
Console.WriteLine(PrintMatrix(mass));
SortMatrix(mass);
Console.WriteLine(PrintMatrix(mass));
// Console.WriteLine((DateTime.Now - begin).TotalMicroseconds);
