//Console.Write("Введите число: ");
//int num = int.Parse(Console.ReadLine());
//int even = 2;

//while (num >= even)
//{
    //Console.Write(even + " ");
    //even = even + 2;
//}
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int rem = 1;
while (rem <= num)
{
    if (rem % 2 == 0)
    {
        Console.Write(rem + " ");
    }
    rem++;
}
//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8