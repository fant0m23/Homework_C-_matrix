// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


long GetLongValueFromUser(string message)
{
   Console.Write(message);
   string userInput = Console.ReadLine()!;
   bool valid = long.TryParse(userInput, out long value);
   if (valid == true) return value;
   else return GetLongValueFromUser(message);
}
long Akkerman(long m, long n)
{
   if (m == 0) return n + 1;
   else if (m != 0 && n == 0) return Akkerman(m - 1, 1);
   else return Akkerman(m - 1, Akkerman(m, n - 1));
}

long number1 = GetLongValueFromUser("Введите значение M: ");
long number2 = GetLongValueFromUser("Введите значение N: ");

Console.WriteLine($"A({number1},{number2}) = {Akkerman(number1, number2)}");
