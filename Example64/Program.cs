// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int GetByteValueFromUser(string message)
{
   Console.Write(message);
   string userInput = Console.ReadLine()!;
   bool valid = byte.TryParse(userInput, out byte value);
   if (valid == true && value != 0) return value;
   else return GetByteValueFromUser(message);
}
string FromNto1(int N)
{
   if (N == 1) return "1";
   else return $"{N}, {FromNto1(N-1)}";
}

int number = GetByteValueFromUser("Введите значение N: ");
Console.WriteLine(FromNto1(number));
