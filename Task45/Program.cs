// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] GetArray(int size, int minV, int maxV)
{
    int[] res = new int[size];
    for (int i = 0; i < size; ++i)
    {
        res[i] = new Random().Next(minV, maxV + 1);
    }
    return res;
}

int[] arr = GetArray(10, 0, 10); // i
Console.WriteLine(string.Join(",", arr));
int[] arr2 = new int[arr.Length];

for (int i =0; i < arr.Length; i++)
{
    arr2[i] = arr[i];
}
//Console.WriteLine(string.Join(",", arr));
Console.WriteLine(string.Join(",", arr2));
