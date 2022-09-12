// Задача 62: Заполните спирально массив 4 на 4.

/*void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] mass = new int[4, 4];

int count = 0;
int i = 0;
int j = 0;

for (i = 0; i < mass.GetLength(0); i++)
{
    for (j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = count + 1;
        count++;
        if (j == mass.GetLength(1) - 1)
        {
            for (i = 1; i < mass.GetLength(0); i++)
            {
                mass[i, j] = count + 1;
                count++;
            }
        }
    }
}

Print(mass);*/


/*void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] mass = new int[4, 4];

int count = 0;
int i = 0;
int j = 0;

for (j = 0; j < mass.GetLength(1); j++)
{
    mass[i, j] = count + 1;
    count++;
}

j = mass.GetLength(1) - 1;

for (i = 1; i < mass.GetLength(0); i++)
{
    mass[i, j] = count + 1;
    count++;
}

i = mass.GetLength(0) - 1;

for (j = mass.GetLength(1) - 2; j >= 0; j--)
{
    mass[i, j] = count + 1;
    count++;
}

j = 0;

for (i = mass.GetLength(0) - 2; i > 0; i--)
{
    mass[i, j] = count + 1;
    count++;
}

i = 1;

for (j = 1; j < mass.GetLength(1) - 1; j++)
{
    mass[i, j] = count + 1;
    count++;
}

i = 2;

for (j = 2; j > 0; j--)
{
    mass[i, j] = count + 1;
    count++;
}

Print(mass);
*/
int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);


//  Функция заполнения массива по спирали начиная с 1
void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

//  Функция вывода двумерного массива в терминал
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}