﻿//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число А: ");
int numberA = int.Parse(Console.ReadLine()!);
int i = 1;
while (i < numberA){
    i += 2;
    Console.WriteLine(i - 1);
}