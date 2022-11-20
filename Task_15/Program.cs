// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введи цифру, обозначающую день недели и узнай является ли он выходным: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

{
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("да -> этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это не день недели");
  }
  else Console.WriteLine("нет -> этот день не выходной");
}
