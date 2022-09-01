// Задача 38: Задайте массив вещественных чисел. 
///Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

/*void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArray(double[] array, int A, int B)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().Next(A, B) + new Random().NextDouble(), 2); 
    }
}

double Max(double[] array)
{
    int maxpos = 0;
    double max = array[maxpos];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[maxpos])
        {
            max = array[i];
            maxpos = i;
        }
    }
    return max;
}

double Min(double[] array)
{
    int minpos = 0;
    double min = array[minpos];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minpos])
        {
            min = array[i];
            minpos = i;
        }
    }
    return min;
}

double[] array = new double[5];
FillArray(array, 0, 100);
PrintArray(array);
Console.WriteLine($"Разница между максимальным элементом массива ({Max(array)}) и минимальным ({Min(array)}) равна {Max(array) - Min(array)}");
*/
double[] arrayRealNumbers = new double[5];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 100);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");