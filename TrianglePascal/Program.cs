// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.
// ** Сохранить треугольник в файл.


// int GetValidValueFromUser(string message)
// {
//    Console.Write(message);
//    string value = Console.ReadLine()!;
//    bool valid = byte.TryParse(value, out byte f);
//    if (valid == true) return Convert.ToByte(value);
//    else return GetValidValueFromUser(message);
// }
int GetValidValueFromUser(string message)
{
   Console.Write(message);
   string value = Console.ReadLine()!;
   bool valid = int.TryParse(value, out int f);
   if (valid == true) return Convert.ToInt32(value);
   else return GetValidValueFromUser(message);
}
int[,] CreateMatrix(int size)
{
   int[,] newArray = new int[size, size];
   for (int i = 0; i < size; i++)
   {
      for (int j = 0; j < size; j++)
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

int size = 1 + GetValidValueFromUser("Сколько строк треугольника Паскаля вывести? --> ");
Console.WriteLine();
int[,] mass = CreateMatrix(size);
PrintMatrix(mass);
Console.WriteLine();