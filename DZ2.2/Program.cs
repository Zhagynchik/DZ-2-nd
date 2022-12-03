/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine($"Введите число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if (number <= 99)
{
     Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number >=1000)
    {
    number = number / 10;
    }
    number = number % 10;
    Console.WriteLine(number);
}


