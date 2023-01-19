/* 

Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
a = 2; b = 3, c = 7 -> max 7
a = 44; b = 5, c = 78 -> max 78
a = 22; b = 3, c = 9 -> max 22

*/ 

/*

int a1 = 2; int b1 = 3; int c1 = 7;
int a2 = 44; int b2 = 5; int c2 = 78;
int a3 = 22; int b3 = 3; int c3 = 9; 

*/

Console.Write("Введите число a1: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c1: ");
int c1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число a2: ");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c2: ");
int c2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число a3: ");
int a3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b3: ");
int b3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c3: ");
int c3 = Convert.ToInt32(Console.ReadLine());

int max1 = a1;
int max2 = a2;
int max3 = a3;

if (b1 > max1) max1 = b1;
if (c1 > max1) max1 = c1;

if (b2 > max2) max2 = b2;
if (c2 > max2) max2 = c2;

if (b3 > max3) max3 = b3;
if (c3 > max3) max3 = c3;

Console.Write("max1 = ");
Console.WriteLine(max1);

Console.Write("max2 = ");
Console.WriteLine(max2);

Console.Write("max3 = ");
Console.WriteLine(max3);

