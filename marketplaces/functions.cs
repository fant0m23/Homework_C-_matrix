public class Functions
{
   public static int GetByteValueFromUser(string message)
   {
      Console.Write(message);
      string userInput = Console.ReadLine()!;
      bool valid = byte.TryParse(userInput, out byte value);
      if (valid == true && value != 0) return value;
      else return GetByteValueFromUser(message);
   }
   public static string ValidClose(int m, int n)
   {
      string mess = string.Empty;
      if (n > m) return "Нельзя закрыть больше чем есть всего";
      else if (n == m) return "Все точки закрыты!";
      else return mess;
   }
   public static int[,] GetCoordinatPoints(int m, int length, int width)
   {
      int[,] point = new int[m, 2];
      for (int i = 0; i < m; i++)
      {
         point[i, 0] = new Random().Next(0, length);
         point[i, 1] = new Random().Next(0, width);
      }
      return point;
   }
   public static double FindDistance(int x1, int y1, int x2, int y2)
   {
      return Math.Round(
             Math.Sqrt(
             Math.Pow(Math.Abs(x2 - x1), 2) + Math.Pow(Math.Abs(y2 - y1), 2)
             ),
            2);
   }
   public static int FindPointDel(int[,] mass, int length = 1000)
   {
      int lines = mass.GetLength(0);
      int columns = mass.GetLength(1);
      int nearestLineNumber = 0;
      double minDist = length;
      for (int i = 0; i < lines - 1; i++)
      {
         int x1 = mass[i, 0];
         int y1 = mass[i, 1];
         for (int j = i + 1; j < lines; j++)
         {
            int x2 = mass[j, 0];
            int y2 = mass[j, 1];
            double distance = FindDistance(x1, y1, x2, y2);
            // Console.WriteLine(distance);
            if (distance < minDist)
            {
               minDist = distance;
               nearestLineNumber = i;
            }
         }
      }
      return nearestLineNumber;
   }
   public static string PrintMatrix(int[,] matrix1)
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
   public static int[,] TransferToPlane(int[,] matrix, int length, int width)
   {
      int[,] mass = new int[length, width];
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
         mass[matrix[i, 0], matrix[i, 1]] = 7;
      }
      return mass;
   }
   public static void PrintToTXT(int[,] matrix, string filename)
   {
      StreamWriter sw = new StreamWriter(filename);
      sw.WriteLine("|------------------------------------------------------------|");
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
         sw.Write("|");
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
            if (matrix[i, j] > 0) sw.Write(" + ");
            else sw.Write($"   ");
         }
         sw.WriteLine($"|");
      }
      sw.Write("|------------------------------------------------------------|");
      sw.Close();
   }
   public static int[,] DelLineMatrix(int[,] martix, int line)
   {
      int rows = martix.GetLength(0);
      int cols = martix.GetLength(1);
      int k = 0;
      int[,] mass = new int[rows - 1, cols];
      for (int i = 0; i < rows; i++)
      {
         if (i == line) continue;
         else
         {
            for (int j = 0; j < cols; j++)
            {
               mass[k, j] = martix[i, j];
            }
         }
         k++;
      }
      return mass;
   }
}
