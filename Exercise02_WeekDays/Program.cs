﻿/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет
*/

Random rand = new Random();
int a = rand.Next();
Console.WriteLine(a);
int day = a % 7;

if (day < 6 && day > 0)
{
    Console.WriteLine("Это рабочий день. Иди работать, солнце ещё высоко.");
}
else
{
    Console.WriteLine("Это выходной. Но ты видел, сколько у тебя дел?");
}