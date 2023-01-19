/* 

Напишите программу, которая на вход принимает число (N),
а на выходе показывает все четные числа от 1 до N.

*/

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 2;

while (i <= N)
{
    Console.Write("Четное число: ");
    Console.WriteLine(i);
    i = i + 2;
}
