using static Functions;

const int length = 30;
const int width = 20;
int m = GetByteValueFromUser("Введите количество торговых точек: ");
int n = GetByteValueFromUser("Нужно закрыть:");

// Console.WriteLine(ValidClose(m, n));

int[,] matrix = GetCoordinatPoints(m, length, width);
Console.WriteLine(PrintMatrix(matrix));

int[,] planeOLD = TransferToPlane(matrix, length, width);
PrintToTXT(planeOLD, "pointsOLD.txt");

int[,] DelNLines(int[,] matrix, int m, int n)
{
   int row = FindPointDel(matrix);
   int[,] newMatrix = DelLineMatrix(matrix, row);
   if (newMatrix.GetLength(0) == m - n)
   {
      return newMatrix;
   }
   else return DelNLines(newMatrix, m, n);
}

Console.WriteLine(PrintMatrix(
                  DelNLines(
                  matrix, m, n)));

int[,] mass = DelNLines(matrix, m, n);
int[,] planeNEW = TransferToPlane(mass, length, width);
PrintToTXT(planeNEW, "pointsNEW.txt");