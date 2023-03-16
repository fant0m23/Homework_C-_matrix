// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int GetByteValueFromUser(string message)
{
   Console.Write(message);
   string userInput = Console.ReadLine()!;
   bool valid = byte.TryParse(userInput, out byte value);
   if (valid == true) return value;
   else return GetByteValueFromUser(message);
}
void CorrectionRange(ref int beginRange, ref int endRange)
{
   if (beginRange > endRange)
   {
      int temp = beginRange;
      beginRange = endRange;
      endRange = temp;
   }
}
int SummFromMtoN(int numberM, int numberN)
{
   if (numberM == numberN) return numberN;
   else if (numberN - numberM == 1) return numberM + numberN;
   else return numberM + SummFromMtoN(numberM + 1, numberN);
}

int number1 = GetByteValueFromUser("Введите значение M: ");
int number2 = GetByteValueFromUser("Введите значение N: ");
CorrectionRange(ref number1, ref number2);
Console.WriteLine("Сумма натуральных элементов в промежутке от M до N равна " +
                  $"{SummFromMtoN(number1, number2)}");
