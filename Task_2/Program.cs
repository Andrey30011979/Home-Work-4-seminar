//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
// максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int Numbera = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int Numberb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int Numberc = Convert.ToInt32(Console.ReadLine());

if (Numbera > Numberb)
{
    if (Numbera > Numberc)
    {
        Console.WriteLine("Максимальное число: " + Numbera);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + Numberc);
    }
}
else if (Numberb > Numberc)
{
    Console.WriteLine("Максимальное число: " + Numberb);
}
else
{
    Console.WriteLine("Максимальное число: " + Numberc);
}
