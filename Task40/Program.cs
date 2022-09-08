﻿// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// ! Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите три числа: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());

if (A + B > C && A + C > B && B + C > A)
{
    Console.WriteLine("Треугольник со сторонами такой длины может существовать");
}
else Console.WriteLine("Треугольник со сторонами такой длины НЕ может существовать");