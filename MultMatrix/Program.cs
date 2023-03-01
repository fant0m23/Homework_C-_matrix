// Нужно написать программу
// перемножения матриц
//
// генерация матрицы m x n

using static MyMethods;

int lines = GetValidValueFromUser("Введите кол-во строчек матрицы: ");
int columns = GetValidValueFromUser("Введите кол-во столбцов матрицы: ");
int from = GetValidValueFromUser("Начало диапазона случайных значений: ");
int to = GetValidValueFromUser("Конец диапазона случайных значений: ");
int [,] matrix1 = CreateMatrix(lines, columns, from, to);
int [,] matrix2 = CreateMatrix(lines, columns, from, to);

PrintMatrix(matrix1);
PrintMatrix(matrix2);

//  x  y     5  6       x5+y7   x6+y8
//  a  b     7  8       a5+b7   a6+b8
// По правилу перемножения матриц число столбцов первой матрицы должно быть равно
// числу строк второй матрицы, A (m n) · B (n k) = С (m k)

int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
   int [,] result = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
   for (int i = 0; i < matrix1.GetLength(0); i++)
   {
      
   }




















   //     for (int i = 0; i < matrix1.GetLength(0); i++)
   //     {
   //         for (int j = 0; j < matrix2.GetLength(1); j++)
   //         {
   //             for (int k = 0; k < matrix2.GetLength(0); k++)
   //             {
   //                 result[i, j] += matrix1[i, k] * matrix2[k, j];
   //             }
   //             Console.Write(result[i, j] + ", ");
   //         }
   //         Console.WriteLine();
   //     }

   return result;
}

int [,] resultMatrix = MultMatrix(matrix1, matrix2);
PrintMatrix(resultMatrix);