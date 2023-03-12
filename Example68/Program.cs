// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int GetByteValueFromUser(string message)
{
   Console.Write(message);
   string userInput = Console.ReadLine()!;
   bool valid = byte.TryParse(userInput, out byte value);
   if (valid == true) return value;
   else return GetByteValueFromUser(message);
}



int number1 = GetByteValueFromUser("Введите значение M: ");
int number2 = GetByteValueFromUser("Введите значение N: ");

Console.WriteLine();
