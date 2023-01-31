/* Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine()??"");
//int Number = Math.Abs(int.Parse(Console.ReadLine()??"")); //преобразуем тип данных в инт и делаем число положительным
if (Number >= 1)
for (int i = 1; i <= Number; i++)
{
    if (i%2 == 0) 
    {
    Console.Write($" {i}");
    }
}

else Console.WriteLine("Введите число больше 1");

