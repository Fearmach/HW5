// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

int[] FillArrayWithRandomNumbers()
{
    Console.WriteLine("Введите размер массива:  ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}


int CheckNum (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0)
    count++;
    }
    Console.WriteLine($"из {array.Length} чисел, {count} четных");
    return count;
}

int[] mas = FillArrayWithRandomNumbers();
PrintArray(mas);
CheckNum(mas);

