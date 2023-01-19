/* 

Напишите программу, которая на вход принимает два числа и выдает, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max 7
a = 2; b = 10 -> max 10
a = -9; b = -3 -> max -3

*/
Console.Write("Введите число a1: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число a2: ");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число a3: ");
int a3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b3: ");
int b3 = Convert.ToInt32(Console.ReadLine());

int max1 = a1; int min1;
int max2 = a2; int min2;
int max3 = a3; int min3;

if (b1 > max1) 
{
    max1 = b1; 
    min1 = a1;
}
else 
{
    min1 = b1;
    max1 = a1;
} 

if (b2 > max2) 
{
    max2 = b2; 
    min2 = a2;
}
else 
{
    min2 = b2;
    max2 = a2;
}

if (b3 > max3) 
{
    max3 = b3; 
    min3 = a3;
}
else 
{
    min3 = b3;
    max3 = a3;
}

Console.Write("max1 = ");
Console.WriteLine(max1);

Console.Write("min1 = ");
Console.WriteLine(min1);

Console.Write("max2 = ");
Console.WriteLine(max2);

Console.Write("min2 = ");
Console.WriteLine(min2);

Console.Write("max3 = ");
Console.WriteLine(max3);

Console.Write("min3 = ");
Console.WriteLine(min3);
