/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */


Console.WriteLine($"Введите день недели соответствующей дню цифрой от 1 до 7: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if (number > 6) 
{
   Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будний день");
}



