/* Задача 18: Напишите программу, которая по заданному 
номеру четверти, показывает диапазон возможных координат
точек в этой четверти(x и y)
*/
void Diapazon(string coord)
{
    Console.WriteLine("Доступные координаты:" + coord);
}
Console.WriteLine("Введите номер четверти:");
int a = int.Parse(Console.ReadLine());
if (a == 1)
{
    Diapazon("x > 0 && y > 0");
}
if (a == 2)
{
    Diapazon("x < 0 && y > 0");
}
if (a == 3)
{
    Diapazon("x < 0 && y < 0");
}
if (a == 4)
{
    Diapazon("x > 0 && y < 0");
}