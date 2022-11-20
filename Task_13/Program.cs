//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// System.Console.WriteLine("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// if (number / 100 > 0) System.Console.WriteLine($"Третьей цифрой числа {number} является цифра {number % 10};");
// else System.Console.WriteLine($"У числа {number} третьей цифры нет");

//  System.Console.WriteLine(); 


Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
  Console.WriteLine("Третьей цифрой числа является цифра - " + anyNumberText[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}