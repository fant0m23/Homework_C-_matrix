// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int GetByteValueFromUser(string message)
{
   Console.Write(message);
   string value = Console.ReadLine()!;
   bool valid = byte.TryParse(value, out byte f);
   if (valid == true) return Convert.ToByte(value);
   else return GetByteValueFromUser(message);
}
int[,,] Create3xArray(int size0, int size1, int size2)
{
   int[,,] newArray = new int[size0, size1, size2];
   int beginValue = 10;
   int endValue = 99;
   int number = beginValue;
   const int primeValue = 7;
   for (int i = 0; i < size0; i++)
   {
      for (int j = 0; j < size1; j++)
      {
         for (int k = 0; k < size2; k++)
         {
            number += primeValue * new Random().Next(1, primeValue);
            if (number > endValue)
            {
               number = number % 100 + 10;
            }
            newArray[i, j, k] = number;
         }
      }
   }
   return newArray;
}
string Print3xArray(int[,,] matrix)
{
   int rows = matrix.GetLength(0);
   int columns = matrix.GetLength(1);
   int plane = matrix.GetLength(2);
   string result = String.Empty;
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
      {
         for (int k = 0; k < plane; k++)
         {
            result += $"{matrix[i, j, k]} ({i},{j},{k})   ";
         }
         result += "\n";
      }
   }
   return result;
}


int lines = GetByteValueFromUser("Введите количество строк трёхмерного массива: ");
int columns = GetByteValueFromUser("Введите количество столбцов трёхмерного массива: ");
int planes = GetByteValueFromUser("Введите размер трёхмерного массива в глубину: ");

int[,,] mass = Create3xArray(lines, columns, planes);

Console.WriteLine();
Console.WriteLine($"Массив размером {lines} x {columns} x {planes}");
Console.WriteLine(Print3xArray(mass));
