// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите число А: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В: ");
int numberB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число C: ");
int numberC = int.Parse(Console.ReadLine()!);
int result;
if (numberA > numberB && numberA > numberC){
     result = numberA;
}if (numberB > numberA && numberB > numberC){
    result = numberB;
}else{
    result = numberC;
}Console.WriteLine("max = " + result);