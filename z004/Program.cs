﻿//Задача 4
//Напишите программу, которая на вход принимает
//число (N), а на выходе показывает
//все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Write("Введите целое число ");
int a = Convert.ToInt32(Console.ReadLine());
int n = a - (a % 2);
int i = 0;
while (i < n)
{
  i +=2;
  Console.WriteLine(i);
}


